using System;
using System.Threading;

namespace Øvelse1
{
    class Program
    {

        static Thread t1 = new Thread(SayEasy);
        static void Main(string[] args)
        {
            t1.Name = "Thread1";
            t1.Start();
            Console.Read();
        }

        static void SayEasy()
        {
            for (int i = 0; i < 5; i++)
                Console.WriteLine("[{0}] C# trådning er nemt", Thread.CurrentThread.Name);
        }

    }
}
