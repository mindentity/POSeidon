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

        public void AddProduct(Product product, double amount)
        {
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
            }
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
    }
}
