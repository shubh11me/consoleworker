using System;

namespace consoleworker
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Myyyyy");


            Console.WriteLine("Enter Your Name :- ");
            var s = Console.ReadLine();
            Console.WriteLine("Hey " +s);
            for (var i = 0; i < 5; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
                else
                {
                    Console.WriteLine("Opppppp");
                }

            }
            Console.Write("Enter the no.");
            int day = Int32.Parse(Console.ReadLine());
            switch (day)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
            }

        }
    }
}
