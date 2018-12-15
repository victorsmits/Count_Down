using System;

namespace Count_Down
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            CountDown countdown = new CountDown(600);

            countdown.Start();
            Console.WriteLine(countdown.RemainingTime);
            System.Threading.Thread.Sleep(5000);
            Console.WriteLine(countdown.RemainingTime);
        }
    }
}
