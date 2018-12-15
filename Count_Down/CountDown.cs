using System;
using System.Timers;

namespace Count_Down
{
    public class CountDown
    {
        private int seconde;

        public CountDown(int sec)
        {
            this.seconde = sec;
        }

        public int RemainingTime
        {
            get
            {
                return seconde;
            }
        }

        public void Start()
        {
            Timer aTimer = new Timer(1000);
            aTimer.Elapsed += OnTimedEvent;
            aTimer.AutoReset = true;
            aTimer.Enabled = true;
        }
        private void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            seconde--;
            Console.WriteLine(RemainingTime);
        }
    }
}
