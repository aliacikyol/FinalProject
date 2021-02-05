using Business.Concrete;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new InMemoryProductDal());
            foreach (var product in productManager.GetAll())
            {
                Console.WriteLine(product.ProductName);
            }
            //Abstract-Soyut nesneleri,İnterface,Base classların olduğu dosya
            //Concrete-Somut nesnelerin olduğu dosya
        }
    }
}
