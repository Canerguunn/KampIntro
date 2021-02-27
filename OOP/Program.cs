using System;
using OOP1;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Product pr1 = new Product();
            pr1.CategoryId = 1;
            pr1.Id = 1;
            pr1.ProductName = "Sehpa";
            pr1.UnitPrice = 2;
            pr1.UnitsInStock = 3;

            ProductManager pm = new ProductManager();
            pm.Add(pr1);
        }
    }
}
