using System;

namespace ReadWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string x = Console.ReadLine();
            
            while(x != "Stop")
            {             
                Console.WriteLine(x);                          
                x = Console.ReadLine();               
            }
        }
    }
}
