using Lection_4_Home_tasks.Task1;
using Lection_4_Home_tasks.Task2;
using Lection_4_Home_tasks.Task3;
using Lection_4_Home_tasks.Task4;
using Lection_4_Home_tasks.Task6;

namespace Lection_4_Home_tasks;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Task 1----------------");
        Months.GetMonths();
        Console.WriteLine("Task 2----------------");
        EvenNumbers.Get();
        Console.WriteLine("Task 3----------------");
        NegativeIncrement.Get();
        Console.WriteLine("Task 4----------------");
        ActiveButtons.Click();
        Console.WriteLine("Task 6----------------");
        MyRange.Get();
    }
}