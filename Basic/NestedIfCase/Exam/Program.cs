using System;

namespace Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            int startExamHour = int.Parse(Console.ReadLine());
            int startExamMin = int.Parse(Console.ReadLine());
            int arriveExamHour = int.Parse(Console.ReadLine());
            int arriveExamMin = int.Parse(Console.ReadLine());

            int startMinutes = (startExamHour * 60) + startExamMin;
            int arriveMinutes = (arriveExamHour * 60) + arriveExamMin;
            int diffMinutes = startMinutes - arriveMinutes;

            if (diffMinutes < 0)
            {
                Console.WriteLine("Late");
                int lateMinutes = Math.Abs(diffMinutes);
                if(lateMinutes > 60)
                {
                    int late_Hours = lateMinutes / 60;
                    int late_Min = lateMinutes % 60;
                    if(late_Min < 10)
                    {
                        Console.WriteLine($"{late_Hours}:0{late_Min} hours after the start");
                    }
                    else
                    {
                        Console.WriteLine($"{late_Hours}:{late_Min} hours after the start");
                    }                  
                }
                else
                {
                    Console.WriteLine($"{lateMinutes} minutes after the start");
                }
            }
            else if(diffMinutes <= 30)
            {               
                if(diffMinutes == 0)
                {
                    Console.WriteLine("On time");
                }
                else
                {
                    Console.WriteLine("On time");
                    Console.WriteLine($"{diffMinutes} minutes before the start");
                }               
            }
            else if(diffMinutes > 30)
            {
                Console.WriteLine("Early");
                if(diffMinutes >= 60)
                {
                    int early_Hours = diffMinutes / 60;
                    int early_Min = diffMinutes % 60;
                    if(early_Min < 10)
                    {
                        Console.WriteLine($"{early_Hours}:0{early_Min} hours before the start");
                    }
                    else
                    {
                        Console.WriteLine($"{early_Hours}:{early_Min} hours before the start");
                    }
                    
                }
                else
                {
                    Console.WriteLine($"{diffMinutes} minutes before the start");
                }
                               
            }
        }
    }
}
