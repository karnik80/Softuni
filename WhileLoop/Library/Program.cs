using System;

namespace Library
{
    class Program
    {
        static void Main(string[] args)
        {
            string myBook = Console.ReadLine();
            int count = 0;

            while (true)
            {
                string input = Console.ReadLine();

                if(input == "No More Books")
                {
                    Console.WriteLine("The book you search is not here!");
                    Console.WriteLine($"You checked {count} books.");
                    break;
                }

                if (myBook == input)
                {
                    Console.WriteLine($"You checked {count} books and found it.");
                    break;
                }
                else
                {
                    count++;
                }
            }
        }
    }
}
