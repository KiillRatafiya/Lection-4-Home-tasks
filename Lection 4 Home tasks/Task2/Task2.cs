using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lection_4_Home_tasks.Task2;

    public static class EvenNumbers
    {
        public static void Get()
        {

            for (int i = 0; i <= 99; i++)
            {
                if (i % 5 == 0)
                {
                    Console.Write("{0}, ", i);
                    Console.WriteLine();
                }
            }
        }


    }

