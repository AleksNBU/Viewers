using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Audience
{
    class Program
    {
        static void Main(string[] args)
        {
            Viewer[,] Cinema = new Viewer[5, 10];
            Random rnd1 = new Random();
            for (int i = 0; i < Cinema.GetLength(0); i++)
            {
                for (int j = 0; j < Cinema.GetLength(1); j++)
                {
                    int x = rnd1.Next(2);
                    if (x == 0)
                    {
                        Cinema[i, j] = null;
                    }
                    else Cinema[i, j] = new Viewer();
                }
            }
            int total = 0, totalAge = 0, totalMale = 0, totalFemal = 0, ageMale = 0, ageFemal = 0;

            for (int i = 0; i < Cinema.GetLength(0); i++)
            {
                for (int j = 0; j < Cinema.GetLength(1); j++)
                {
                    if (Cinema[i, j] != null)
                    {
                        total++;
                        totalAge += Cinema[i, j].Age;
                        if (Cinema[i, j].Gender.ToString() == "Male")
                        {
                            totalMale++;
                            ageMale += Cinema[i, j].Age;
                        }
                        else
                        {
                            totalFemal++;
                            ageFemal += Cinema[i, j].Age;
                        }
                    }
                }
            }
            Console.WriteLine($"In the cinema {total} viewers.");
            if (total != 0)
            {
                Console.WriteLine($"The average age of the viewer {totalAge / total} years.");
            }
            else Console.WriteLine($"In the cinema there are no the audience");
            Console.WriteLine($"The total number of men {totalMale}.");
            Console.WriteLine($"The total number of women {totalFemal}.");
            if (totalMale != 0)
            {
                Console.WriteLine($"The average age of the men {ageMale / totalMale} years.");
            }
            else Console.WriteLine($"In the cinema there are no men.");
            if (totalFemal != 0)
            {
                Console.WriteLine($"The average age of the men {ageFemal / totalFemal} years.");
            }
            else Console.WriteLine($"In the cinema there are no women.");
            Console.ReadLine();
        }
    }
}