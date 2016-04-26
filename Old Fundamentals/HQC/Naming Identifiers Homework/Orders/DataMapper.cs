using System.Collections.Generic;
using System.Linq;
using Orders.Models;
using System.IO;

namespace Orders
{
    public class DataMapper
    {
        private string categoriesFile;
        private string productsFile;
        private string ordersFile;

        private const string categoriesFileName = "../../Data/categories.txt";
        private const string productsFileName = "../../Data/products.txt";
        private const string orderFileName = "../../Data/orders.txt";



        public string CategoriesFile
        {
            get { return this.categoriesFile; }
            set { this.categoriesFile = value; }
        }

        public string ProductsFile
        {
            get { return this.productsFile; }
            set { this.productsFile = value; }
        }

        public string OrdersFile
        {
            get { return this.ordersFile; }
            set { this.ordersFile = value; }
        }


        public DataMapper(string categoriesFile, string productsFile, string ordersFile)
        {
            this.CategoriesFile = categoriesFile;
            this.productsFile = productsFile;
            this.OrdersFile = ordersFile;
        }

       public DataMapper()
            : this(categoriesFileName, productsFileName, orderFileName)
        {
        }

        public IEnumerable<Category> GetCategories()
        {
            List<string>  categories= ReadFileLines(this.categoriesFile);
            return categories
                .Select(c => c.Split(','))
                .Select(c => new Category
                {
                    CategoryID = int.Parse(c[0]),
                    CategoryName = c[1],
                    CategoryDescription = c[2]
                });
        }

        public IEnumerable<Product> GetProducts()
        {
            List < string > products = ReadFileLines(this.productsFile);
            return products
                .Select(p => p.Split(','))
                .Select(p => new Product
                {
                    ProductID = int.Parse(p[0]),
                    ProductName = p[1],
                    ProductCategory = int.Parse(p[2]),
                    UnitPrice = decimal.Parse(p[3]),
                    UnitsInStock = int.Parse(p[4]),
                });
        }

        public IEnumerable<Order> GetOrders()
        {
            List < string > orders = ReadFileLines(this.ordersFile);
            return orders
                .Select(p => p.Split(','))
                .Select(p => new Order
                {
                    OrderID = int.Parse(p[0]),
                    OrderProductID = int.Parse(p[1]),
                    Quantity = int.Parse(p[2]),
                    Discount = decimal.Parse(p[3]),
                });
        }

        private List<string> ReadFileLines(string filename)
        {
            List<string> bufferedLine = new List<string>();
            StreamReader reader = new StreamReader(filename);
            string currentLine = reader.ReadLine();
            while ((currentLine = reader.ReadLine()) != null)
             {
               bufferedLine.Add(currentLine);
             }
           return bufferedLine;
        }
    }
}
