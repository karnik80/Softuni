using System;

namespace Favorite_Movie
{
    class Program
    {
        static void Main(string[] args)
        {
            int points = 0;
            string topMovie = string.Empty;
            int count = 0;

            while (true)
            {
                string movie = Console.ReadLine();
                if(movie == "STOP")
                {
                    Console.WriteLine($"The best movie for you is {topMovie} with {points} ASCII sum.");
                    break;
                }

                int lenght = movie.Length;
                int tempPoints = 0;

                for (int i = 0; i < lenght; i++)
                {
                    int ascii = (int)movie[i];
                    if(ascii >= 65 && ascii <= 90) // big letter
                    {
                        tempPoints += ascii - lenght;
                    }
                    else if(ascii >= 97 && ascii <= 122) // small letter
                    {
                        tempPoints += ascii - (lenght * 2);
                    }
                    else
                    {
                        tempPoints += ascii;
                    }

                    if(tempPoints > points)
                    {
                        points = tempPoints;
                        topMovie = movie;
                    }
                }
                count++;
                if (count >= 7)
                {
                    Console.WriteLine($"The limit is reached.");
                    Console.WriteLine($"The best movie for you is {topMovie} with {points} ASCII sum.");
                    break;
                }
            }
        }
    }
}
