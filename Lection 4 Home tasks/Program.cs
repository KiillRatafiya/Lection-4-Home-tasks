namespace Lection_4_Home_tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task 1----------------");
            Task1();
            Console.WriteLine("Task 2----------------");
            Task2();
            Console.WriteLine("Task 3----------------");
            Task3();
            Console.WriteLine("Task 4----------------");
            Task4();
            Console.WriteLine("Task 6----------------");
            Task6();
        }

        //Task 1
        public static void Task1()
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
                "Dec"};


            for (int i = 0; i < months.Length; i++)
            {
                Console.WriteLine(months[i]);
            }
        }

        //Task 2
        public static void Task2()
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

        //Task 3
        public static void Task3()
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

        //Task 4
        public static void Task4()
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

        //Task 6

            public static void Task6()
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
}