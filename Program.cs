using System;
using System.Threading;

namespace Stopwatch
{
    class Program
    {
        static void Main(string[] args)
        {
            var stopwatch = new Stopwatch();
            var cont = true;

            while (cont == true)
            {
                Console.WriteLine("Welcome to Stopwatch! Press Start to Start, Press Stop to Stop, or Exit to exit");
                var entry = Console.ReadLine();
                switch (entry)
                {
                    case "Start":
                        stopwatch.Start();
                        break;
                    case "Stop":
                        stopwatch.Stop();
                        Console.WriteLine(stopwatch.Report());
                        break;
                    case "Exit":
                        cont = false;
                        break;
                    default:
                        Console.WriteLine("Invalid entry try again.");
                        break;
                }
            }

        }

    }
}
