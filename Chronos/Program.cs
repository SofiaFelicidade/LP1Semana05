using System;
using System.Diagnostics;
using System.Threading;

namespace Chronos
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch cron1, cron2;
            cron1 = Stopwatch.StartNew();
            Thread.Sleep(1000);
            cron2 = Stopwatch.StartNew();
            Thread.Sleep(1000);
            cron1.Stop();
            cron2.Stop();

                Console.WriteLine("Chrono 1 = " + cron1.ElapsedMilliseconds);
                Console.WriteLine("Chrono 2 = " + cron2.ElapsedMilliseconds);
        }
    }
}
