using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4ExerciseSectionG
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] Sales = new double[12] {1,2,3,4,5,6,7,8,9,10,11,12.0};
            double max=0, min=Sales[0];
            double sum = 0;

            for(int i=0; i < 12; i++)
            {
                if (max < Sales[i])
                    max = Sales[i];
            }

            for (int i = 0; i < 12; i++)
            {
                if (max == Sales[i])
                    Console.WriteLine("Maximum sales is recorded on {0}", i);
            }

            for (int i = 0; i < 12; i++)
            {
                if (min > Sales[i])
                    min = Sales[i];
            }

            for (int i = 0; i < 12; i++)
            {
                if (min == Sales[i])
                    Console.WriteLine("Minimum sales is recorded on {0}", i);
            }

            for(int i = 0; i < 12; i++)
            {
                sum += Sales[i];
            }

            Console.WriteLine("The average monthly sales is {0}", sum / 12);
        }
    }
}
