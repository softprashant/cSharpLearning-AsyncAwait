using System;
using System.Threading;

namespace Demo
{
    public static class ThreadStaticExplained
    {
        [ThreadStatic]
        public static int Value = 0;

        public static void ThreadStaticAllowsToHaveIndivualCopyOfVairablesWithAreScopedGlobaly()
        {
            var t1 = new Thread(() =>
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine(Value++);
                }
            });
            t1.Start();

            var t2 = new Thread(() =>
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine(Value++);
                }
            });

            t2.Start();
        }
    }
}