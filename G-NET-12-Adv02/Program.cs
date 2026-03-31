namespace G_NET_12_Adv02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Starter Code

            /*
            public class Product
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Category { get; set; }
            public double Price { get; set; }
            public int Stock { get; set; }
            }
          List<Product> catalog = new()
            {
         new Product { Id=1, Name="Laptop", Category="Electronics", Price=1200, Stock=10 },
         new Product { Id=2,Name="Phone", Category="Electronics", Price=800, Stock=25 },
         new Product { Id=3, Name="T-Shirt", Category="Clothing", Price=30, Stock=100 },
         new Product { Id=4, Name="Jeans", Category="Clothing", Price=60, Stock=50 },
         new Product { Id=5, Name="Chocolate", Category="Food", Price=5, Stock=200 },
         new Product { Id=6, Name="Coffee Beans", Category="Food", Price=15, Stock=80 },
         new Product { Id=7, Name="C# Book", Category="Books", Price=45, Stock=30 },
         new Product { Id=8, Name="Novel", Category="Books", Price=20, Stock=60 },
         new Product { Id=9,Name="Headphones", Category="Electronics", Price=150, Stock=40 },
         new Product { Id=10, Name="Jacket", Category="Clothing", Price=120, Stock=15 }
          };
            */
            #endregion

            #region Task 01
            /*
                // Method using Func delegate
                static List<Product> SearchProducts(List<Product> products, Func<Product, bool> filter)
                {
                    List<Product> result = new();

                    foreach (var product in products)
                    {
                        if (filter(product))
                            result.Add(product);
                    }

                    return result;
                }


                var electronics = SearchProducts(catalog, p => p.Category == "Electronics");

                var cheap = SearchProducts(catalog, p => p.Price < 50);

                var inStock = SearchProducts(catalog, p => p.Stock > 0);

                var clothing = SearchProducts(catalog, p => p.Category == "Clothing" && p.Price < 100);

            */

            #endregion

            #region Task 03.1

            // Method using Action delegate
            static void PrintReport(List<Product> products, Action<Product> action)
            {
                foreach (var product in products)
                {
                    action(product);
                }
            }



            PrintReport(catalog, p =>
            {
                Console.WriteLine($"{p.Name} - ${p.Price}");
            });


            PrintReport(catalog, p =>
            {
                Console.WriteLine($"[{p.Category}] {p.Name} | Price: ${p.Price} | Stock: {p.Stock}");
            });





            #endregion





        }
    }
}
