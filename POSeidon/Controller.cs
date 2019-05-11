using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSeidon
{
    public static class Controller
    {
        public static IList<Product> Products { get; set; }

        static Controller()
        {
            Products = DBUtils.GetAllProducts().ToList();
        }
    }
}
