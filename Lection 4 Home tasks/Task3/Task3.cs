using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lection_4_Home_tasks.Task3;

internal class NegativeIncrement
{
    public static void Get()
    {
        int a = -20;
        int result = 0;
        do
        {
            result += a;
            Console.WriteLine(result);
        }
        while (result > -1000);
    }

}
