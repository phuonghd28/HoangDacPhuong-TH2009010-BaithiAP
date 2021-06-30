using System;

namespace BaiThi
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var manager = new ProductManager();
            while (true)
            {
                Console.WriteLine("1. Add product");
                Console.WriteLine("2. Display all product");
                Console.WriteLine("3. Delete product by id");
                Console.WriteLine("4. Exit");
                Console.WriteLine("Enter your choice (1 - 4)");
                var choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        manager.Create();
                        break;
                    case 2:
                        manager.Display();
                        break;
                    case 3:
                        manager.Delete();
                        break;
                }

                if (choice == 4)
                {
                    break;
                }
            }

        }
    }
}