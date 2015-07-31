using System;

using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace ClientTest
{
    class Program
    {
        static AutoResetEvent re1 = new AutoResetEvent(true);
        static void Main(string[] args)
        {
           

            
            
            //AutoResetEvent re2 = new AutoResetEvent(true);
            //re12.WaitOne();
            ThreadPool.QueueUserWorkItem(new WaitCallback(Start),1);

            ThreadPool.QueueUserWorkItem(new WaitCallback(Start), 2);

            Thread.Sleep(1000000);
            
        }
        static void Start(object a)
        {
            re1.WaitOne();
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine("-" + a.ToString() + " " + i);
                System.Diagnostics.Debug.WriteLine("-" + a.ToString() + " " + i);
                Thread.Sleep(100);
            }
            re1.Set();
        }
    }
}
