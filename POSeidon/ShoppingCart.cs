using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSeidon
{
    public class ShoppingCart
    {
        public IList<ShoppingCartItem> Items { get; set; }
        public decimal TotalPrice { get; set; }

        public bool AddProduct(Product product, double amount=0)
        {
            if (product.StockAmount == 0 || amount > product.StockAmount)
            {
                return false;
            }
            ShoppingCartItem item = (from x in Items
                                     where x.Product.Id == product.Id
                                     select x).FirstOrDefault();
            if (item == null)
            {
                item = new ShoppingCartItem
                {
                    Product = product,
                    Amount = amount
                };
                AddItem(item);
            }
            else
            {
                item.Amount += amount;
                TotalPrice += item.Product.Price * (decimal) amount;
            }
            return true;
        }

        public void AddItem(ShoppingCartItem item)
        {
            Items.Add(item);
            TotalPrice += item.Product.Price;
        }

        public bool RemoveProduct(Product product)
        {
            var item = Items.FirstOrDefault(x => x.Product.Id == product.Id);
            if (item == null)
            {
                return false;
            }
            return RemoveItem(item);
        }

        public bool RemoveItem(ShoppingCartItem item)
        {
            if (Items.Remove(item))
            {
                TotalPrice -= item.Product.Price;
                return true;
            }
            return false;
        }

        public void Clear()
        {
            Items.Clear();
            TotalPrice = 0.0M;
        }

        public void Checkout(Customer customer=null)
        {
            DateTime date = DateTime.UtcNow;
            foreach (var item in Items)
            {
                if (DBUtils.DecreaseProductStockByAmount(item.Product, item.Amount))
                {
                    var log = new CustomerLog
                    {
                        Date = date,
                        ProductName = item.Product.Name,
                        ProductPrice = item.Product.Price,
                        ProductAmount = item.Amount,
                        ProductTotalPrice = (decimal) item.Amount * item.Product.Price
                    };
                    if (customer != null)
                    {
                        log.CustomerName = customer.FullName;
                        log.CustomerPhone = customer.Phone;
                        log.CustomerAddress = customer.Address;
                    }
                    DBUtils.CreateLog(log);
                }
                
            }
            Controller.Products.ResetBindings();
            Clear();
        }
    }
}
