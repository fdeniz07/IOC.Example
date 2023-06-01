namespace IOC.Example
{
    public class MsDAL : IDAL //implemantation for DI
    {
        public List<Product> GetProducts()
        {
            return new List<Product>() {
            new Product { Id = 1, Name = "Pencil", Price = 5, Stock = 200 },
            new Product { Id = 2, Name = "Book", Price = 25, Stock = 20 },
            new Product { Id = 3, Name = "Eraser", Price = 5, Stock = 40 },
            new Product { Id = 4, Name = "Notebook", Price = 10, Stock = 100 }
            };
        }

        public int Calculate()
        {
            return 100;
        }
    }
}
