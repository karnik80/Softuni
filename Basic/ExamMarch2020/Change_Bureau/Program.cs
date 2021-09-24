using System;

namespace Change_Bureau
{
    class Program
    {
        static void Main(string[] args)
        {
            int bitCoin = int.Parse(Console.ReadLine());
            double chinesUan = double.Parse(Console.ReadLine());
            double commission = double.Parse(Console.ReadLine());

            double lv = 0.0; double euro = 0.0;

            lv = (bitCoin * 1168.00) + ((chinesUan * 0.15) * 1.76);
            lv = lv - (lv * (commission / 100));

            euro = lv / 1.95;
            
            //euro = Math.Round(euro, 2);
            Console.WriteLine("{0:f2}", euro);
        }
    }
}
