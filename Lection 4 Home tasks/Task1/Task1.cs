using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lection_4_Home_tasks.Task1;

public static class Months
{
    public static void GetMonths()
    {
        string[] months = new string[]
        {   "Jan",
            "Feb",
            "Mar",
            "Apr",
            "May",
            "Jun",
            "Jul",
            "Aug",
            "Sep",
            "Oct",
            "Nov",
            "Dec"
        };


        for (int i = 0; i < months.Length; i++)
        {
            Console.WriteLine(months[i]);
        }
    }  
}
