using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lection_4_Home_tasks.Task4;

internal class ActiveButtons
{
    public static void Click()
    {
        Console.WriteLine("Please enter a letter: W, S, A or D");
        ConsoleKeyInfo input = Console.ReadKey(true);

        switch (input.Key)
        {
            case ConsoleKey.W:
                Console.WriteLine("Move up");
                break;
            case ConsoleKey.S:
                Console.WriteLine("Move down");
                break;
            case ConsoleKey.A:
                Console.WriteLine("Move left");
                break;
            case ConsoleKey.D:
                Console.WriteLine("Move right");
                break;
            default:
                Console.WriteLine("Wrong character");
                break;
        }

    }

}
