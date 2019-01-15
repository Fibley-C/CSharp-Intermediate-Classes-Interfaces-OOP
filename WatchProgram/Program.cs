using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WatchProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            var watch = new StopWatch();
            int input;

            do
            {
                Console.WriteLine("1 - Start watch\n2 - Stop watch\n3 - Read watch\n0 - Quit\n");
                input = Convert.ToInt32(Console.ReadLine());
                switch (input)
                {
                    case 1: watch.Start(); break;
                    case 2: watch.Stop(); break;
                    case 3: Console.WriteLine(watch.ElaspedTime()); break;
                }

            } while (input != 0);
        }
    }
}
