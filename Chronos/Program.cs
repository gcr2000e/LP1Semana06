using System;
using System.Diagnostics;
using System.Threading;

namespace Chronos
{
    public class StopWatch
    {
        private static void Main(string[] args)
        {
            Stopwatch crono1 = new Stopwatch();
            Stopwatch crono2 = new Stopwatch();

            crono1.Start();
            Thread.Sleep(500);
            crono2.Start();
            Thread.Sleep(250);
            crono1.Stop();

            TimeSpan ts = crono1.Elapsed;
            TimeSpan ts2 = crono2.Elapsed;


            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
            ts.Hours, ts.Minutes, ts.Seconds,
            ts.Milliseconds / 10);

            string elapsedTime2 = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
            ts2.Hours, ts2.Minutes, ts2.Seconds,
            ts2.Milliseconds / 10);

            Console.WriteLine("Crono 1: " + elapsedTime);
            Console.WriteLine("Crono 2: " + elapsedTime2);
        }
    }
}
