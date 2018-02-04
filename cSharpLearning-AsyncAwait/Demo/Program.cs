using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Main thread started");
            Thread thread = new Thread(Iteration);
            thread.Start();
            Console.WriteLine("Main Thread ends");
        }

        private static void Iteration()
        {
            for (var i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
                Thread.Sleep(1000);
            }
        }
    }
}
