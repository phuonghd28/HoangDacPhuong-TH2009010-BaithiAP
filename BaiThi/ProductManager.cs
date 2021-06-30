using System;
using System.Collections.Generic;

namespace BaiThi
{
    public class ProductManager
    {
        private Dictionary<string, Product> _products = new Dictionary<string, Product>();

        public void Create()
        {
            Console.WriteLine("Enter id :");
            var id = Console.ReadLine();
            Console.WriteLine("Enter name :");
            var name = Console.ReadLine();
            Console.WriteLine("Enter price :");
            var price = double.Parse(Console.ReadLine());
            _products.Add(id,new Product()
            {
                Id = id,
                Name = name,
                Price = price
            });
            Console.WriteLine("Add product success");
        }

        public void Display()
        {
            if (_products.Count == 0)
            {
                Console.WriteLine("Product Have Not Found");
            }
            else
            {
                Console.WriteLine("Product ID    Product Name    Price");
                foreach (var list in _products)
                {
                    Console.WriteLine(list.Value.ToString());
                }
            }
            
        }

        public void Delete()
        {
            Console.WriteLine("Enter id :");
            var id = Console.ReadLine();
            if (_products.ContainsKey(id))
            {
                _products.Remove(id);
                Console.WriteLine("Delete Success");
            }
            else
            {
                Console.WriteLine($"Product with Id : ${id} not found");
            }
        }
    }
}