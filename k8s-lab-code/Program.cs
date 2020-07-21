using System;
using System.Threading;

namespace k8s_lab_code
{
    class Program
    {
        static void Main(string[] args)
        {
            Timer t = new Timer(TimerCallback, null, 0, 2000);
            Console.ReadKey();
        }

        public static void TimerCallback(object obj)
        {
            Console.WriteLine("show mes: " + DateTime.Now);
            GC.Collect();
        }
    }
}
