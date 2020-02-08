using System;

namespace OperacoesDateTime {
    class Program {
        static void Main(string[] args) {

            DateTime d = new DateTime(2001, 8, 15, 13, 45, 58, 275);

            Console.WriteLine(d);
            Console.WriteLine("1) Date: " + d.Date);
            Console.WriteLine("2) Day:" + d.Day );
            Console.WriteLine("3) Day:" + d.DayOfWeek);
            Console.WriteLine("4) Day:" + d.DayOfYear);
            Console.WriteLine("5) Day:" + d.Hour);
            Console.WriteLine("6) Day:" + d.Kind);
            Console.WriteLine("7) Day:" + d.Millisecond);
            Console.WriteLine("8) Day:" + d.Minute); 
            Console.WriteLine("9) Day:" + d.Month);
            Console.WriteLine("10) Day:" + d.Second);
            Console.WriteLine("11) Day:" + d.Ticks);
            Console.WriteLine("12) Day:" + d.TimeOfDay);
            Console.WriteLine("13) Day:" + d.Year);

            Console.WriteLine("--------------------" );

            DateTime r = new DateTime(2001, 8, 15, 13, 45, 58, 275);
         

            string r1 = r.ToLongDateString();
            string r2 = r.ToShortTimeString();
            string r3 = r.ToShortDateString();
            string r4 = r.ToShortTimeString(); 

            string r5 = r.ToString();

            string r6 = r.ToString("yyyy-MM-dd HH:mm:ss"); 

            Console.WriteLine(r1);
            Console.WriteLine(r2);
            Console.WriteLine(r3);
            Console.WriteLine(r4);
            Console.WriteLine(r5);
            Console.WriteLine(r6);

            Console.WriteLine("------------------------" );

            DateTime  c = new DateTime(2001, 8, 15, 13, 45, 58);

            DateTime c2 = c.AddHours(2);
            DateTime c3 = c.AddMinutes(3);


            Console.WriteLine(c);
            Console.WriteLine(c2);
            Console.WriteLine(c3);
            Console.WriteLine("--------------------------");

     
            DateTime h = new DateTime(2001, 10, 15);
            DateTime h2 = new DateTime(2000, 10, 18);

           TimeSpan t = h2.Subtract(h2); 
            Console.WriteLine(t);
         




        }
    }
}
