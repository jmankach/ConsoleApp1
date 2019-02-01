using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        public delegate void Loghandler(string message);

        static void loger(string message)
        {
            Console.WriteLine(message);
        }
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter a No. to reverse");
            //int Number = int.Parse(Console.ReadLine());
            //int Reverse = 0;
            //while (Number > 0)
            //{
            //    int remainder = Number % 10;
            //    Reverse = (Reverse * 10) + remainder;
            //    Number = Number / 10;
            //}
            //Console.WriteLine("Reverse No. is {0}", Reverse);

            //string fff = findelement("sam");

            // Instantiation


            // Invocation

            Loghandler log = new Loghandler(loger);

            Process(log);


            Console.ReadLine();
        }

        static string findelement(string recherche)
        {
           List<string> myList = new List<string>(){ "jalal", "sam", "mankach" };

            var myItem = myList.Find(item => item.ToString() == recherche);
            return myItem;
        }
        public static void MyFunc()
        {
            Console.WriteLine("I was called by delegate ...");
        }

        static void Process(Loghandler loghandler)
        {
            if (loghandler != null)
            {
                loghandler("Process() begin");
            }
            if (loghandler != null)
            {
                loghandler("Process() end");
            }
        }
    }



 
}
