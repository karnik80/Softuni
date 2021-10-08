using System;
using System.Collections.Generic;


namespace Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Product> myBasket = new Dictionary<string, Product>();

            string input = string.Empty;
            while((input = Console.ReadLine()) != "buy")
            {
                string[] tokens = input.Split();
                string name = tokens[0];
                double price = double.Parse(tokens[1]);
                int quantity = int.Parse(tokens[2]);

                if (myBasket.ContainsKey(name))
                {
                    myBasket[name].Price = price;
                    myBasket[name].Quantity += quantity;
                }
                else
                {
                    myBasket.Add(name, new Product(price, quantity));
                }
            }

            foreach (var item in myBasket)
            {
                Console.WriteLine($"{item.Key} -> {(item.Value.Price * item.Value.Quantity):F2}");
            }
        }
    }

    public class Product
    {
        public double Price { get; set; }
        public int Quantity { get; set; }

        public Product(double price, int quantity)
        {
            Price = price;
            Quantity = quantity;
        }
    }
}
