using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4ExerciseSectionG
{
    class Program2
    {
        static void Main()
        {
            int[] ar = new int[6] { 3, 2, 1, 4, 0, 5 };
            
            for(int i=0; i<5; i++)
            {
                for(int j=i; j<5; j++)
                {
                    if (ar[i] < ar[j + 1])
                    {
                        int temp = ar[i];
                        ar[i] = ar[j + 1];
                        ar[j + 1] = temp;
                    }
                }

                Console.Write("Pass {0} is ", i+1);

                for(int z = 0; z < 6; z++)
                {
                    Console.Write("{0} ", ar[z]);
                }

                Console.WriteLine();
            }
        }
    }
}
