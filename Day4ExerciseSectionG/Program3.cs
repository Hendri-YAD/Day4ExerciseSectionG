using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4ExerciseSectionG
{
    class Program3
    {
        static void Main()
        {
            double[,] Marks;
            Marks = new double[12,6] {{56, 84, 68,29,0,0},
                                      {94, 73, 31, 96,0,0},
                                      {41, 63, 36, 90,0,0},
                                      {99, 9, 18, 17,0,0},
                                      {62, 3, 65, 75,0,0},
                                      {40, 96, 53, 23,0,0},
                                      {81, 15, 27, 30,0,0},
                                      {21, 70, 100, 22,0,0},
                                      {88, 50, 13, 12,0,0},
                                      {48, 54, 52, 78,0,0},
                                      {64, 71, 67, 25,0,0},
                                      {16, 93, 46, 72,0,0}};

            for(int i = 0; i < 12; i++)
            {
                Marks[i, 4] = (Marks[i, 0] + Marks[i, 1] + Marks[i, 2] + Marks[i, 3]);
                Marks[i, 5] = Marks[i, 4] / 4;
            }

            for(int i = 0; i < 12; i++)
            {
                Console.WriteLine("Student {0} Total is {1}, Average is {2}", i + 1, Marks[i, 4], Marks[i, 5]);
            }

            Console.WriteLine();

            for(int j = 0; j < 4; j++)
            {
                double total = 0, avg =0, var =0, sumSqr=0;
                for (int i=0; i < 12; i++)
                {
                    total = total + Marks[i, j];
                }
                avg = total / 12;

                for (int i = 0; i < 12; i++)
                {
                    sumSqr = sumSqr + Math.Pow(Marks[i, j] - avg,2);
                }
                var = sumSqr / 12;
                
                Console.WriteLine("Average of Subject {0} is {1:0.#####}", j + 1, avg);
                Console.WriteLine("Variance of Subject {0} is {1:0.#####}\n", j + 1, var);
            }
        }
    }
}
