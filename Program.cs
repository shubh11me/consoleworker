using Microsoft.AspNetCore.Mvc;
using System;

namespace consoleworker
{
    class Program
    {

        static int fibrecursive(int no)
        {
            if (no <= 1)
                return no;
            return fibrecursive(no - 1) + fibrecursive(no - 2);
        }

        static void fibprint(int no)
        {

            for (int i = 0; i < no; i++)
            {
                if (i == 6)
                {
                    continue;
                }

                Console.WriteLine("index {0}: {1}", i==6?null:i, i == 6 ? null : fibrecursive(i));
            }

        }

        static void Main(string[] args)
        {

            string saaa = "I am <man> My name is <name> my fav color is <color>";
           var arr= saaa.Split(' ');
            //Console.WriteLine(new JsonResult(arr).Value );
            foreach(var m in arr)
            {
                Console.WriteLine(m);
            }
            Console.ReadKey();

            var name = "Shubham";
            var sname = "Todakr";

            Console.WriteLine("My name is {0} {1}", name,sname);
            Console.ReadKey();


            fibprint(10);
            Console.ReadKey();
            int[] absaaaaa= new int[5] { 0,0,0,0,0};
            int count = 0;
            foreach(var i in absaaaaa)
            {
                //Console.WriteLine(i);
                Console.Write($"Enter {count+1} number:-");
                absaaaaa[count] = Convert.ToInt32(Console.ReadLine());
                count++;
            }
            foreach(var innn in absaaaaa)
            {
                Console.WriteLine(innn);
            }
            //done







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
