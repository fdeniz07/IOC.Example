using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOC.Example
{
    public class OracleDAL : IDAL
    {
        public List<Product> GetProducts()
        {
            //Oracle'den aldik

            return new List<Product>() {
            new Product { Id = 1, Name = "Oracle Pencil", Price = 5, Stock = 200 },
            new Product { Id = 2, Name = "Oracle Book", Price = 25, Stock = 20 },
            new Product { Id = 3, Name = "Oracle Eraser", Price = 5, Stock = 40 },
            new Product { Id = 4, Name = "Oracle Notebook", Price = 10, Stock = 100 }
            };
        }
    }
}
