using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lection_4_Home_tasks.Task6;

internal class MyRange
{
    public static void Get()
    {
        int a = 100;
        while (a >= 100 && a <= 800)
        {
            if (a % 17 == 0)
            {
                Console.WriteLine(a);
            }
            a++;
        }
    }
}
