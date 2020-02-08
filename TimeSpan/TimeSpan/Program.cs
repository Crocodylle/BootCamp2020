using System;

namespace TimeSpan1 {
    class Program {
        static void Main(string[] args) {

            TimeSpan t1 = new TimeSpan(0, 1, 30);
            TimeSpan t2 = new TimeSpan(9000000000L);
            TimeSpan t3 = new TimeSpan(2, 11, 21);
            TimeSpan t4 = new TimeSpan(1, 2, 11, 21);
            TimeSpan t5 = new TimeSpan(1, 2, 11, 21, 321);

            Console.WriteLine(t1);
            Console.WriteLine(t1.Seconds);
            Console.WriteLine(t2);
            Console.WriteLine(t3);
            Console.WriteLine(t4);
            Console.WriteLine(t5);


            Console.WriteLine("---------------------------");

            TimeSpan a1 = TimeSpan.FromDays(1.5);
            TimeSpan a2 = TimeSpan.FromHours(1.5);
            TimeSpan a3 = TimeSpan.FromMinutes(1.5);
            TimeSpan a4 = TimeSpan.FromSeconds(1.5);
            TimeSpan a5 = TimeSpan.FromMilliseconds(1.5);
            TimeSpan a6 = TimeSpan.FromTicks(9000000000L);


            Console.WriteLine(a1);
            Console.WriteLine(a2);
            Console.WriteLine(a3);
            Console.WriteLine(a4);
            Console.WriteLine(a5);
            Console.WriteLine(a6);
                                          
        }
    }
}
