using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitMergePractice
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i=0; i<10; i++)
            {
                Console.WriteLine("Kaitie is the boss times " + i);
                Console.WriteLine("So's Ali!" + i);
            }

            for (int i=10; i>0; i--)
            {
                Console.WriteLine("Countdown to self destruct: " + i);
                System.Threading.Thread.Sleep(1000);
            }
           
            Console.WriteLine("KABOOM");
            System.Threading.Thread.Sleep(3000);

            Console.WriteLine("Just kidding I'm not dead.");

            System.Threading.Thread.Sleep(3000);

            Console.WriteLine("....yet");
            Console.WriteLine("BOOM");

        }
    }
}
