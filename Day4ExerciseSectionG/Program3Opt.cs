using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4ExerciseSectionG
{
    class Program3Opt
    {
        static void Main()
        {
            double[,] Marks;
            Console.Write("Please enter the number of subjects: ");
            int numSub = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please enter the number of students: ");
            int numStu = Convert.ToInt32(Console.ReadLine());

            Marks = new double[numStu, numSub+2];

            for(int i=0; i < numStu; i++)
            {
                for(int j=0; j < numSub; j++)
                {
                    Console.Write("Please enter Subject {0} score for student {1}: ", j+1,i+1);
                    Marks[i,j] = Convert.ToDouble(Console.ReadLine());
                }                
            }           

            for(int i = 0; i < numStu; i++)
            {
                Marks[i, numSub] = 0;

                for(int j = 0; j < numSub; j++)
                {
                    Marks[i, numSub] = Marks[i, numSub] + Marks[i, j];//finding total
                }
                
                Marks[i, numSub+1] = Marks[i, numSub] / numSub; //finding average
            }

            for(int i = 0; i < numStu; i++)
            {
                Console.WriteLine("Student {0} Total is {1}, Average is {2}", i + 1, Marks[i, numSub], Marks[i, numSub+1]);
            }

            Console.WriteLine();

            for(int j = 0; j < numSub; j++)
            {
                double total = 0, avg =0, var =0, sumSqr=0;
                for (int i=0; i < numStu; i++)
                {
                    total = total + Marks[i, j];
                }
                avg = total / numStu;

                for (int i = 0; i < numStu; i++)
                {
                    sumSqr = sumSqr + Math.Pow(Marks[i, j] - avg,2);
                }
                var = sumSqr / numStu;
                
                Console.WriteLine("Average of Subject {0} is {1:0.#####}", j + 1, avg);
                Console.WriteLine("Variance of Subject {0} is {1:0.#####}\n", j + 1, var);
            }
        }
    }
}
