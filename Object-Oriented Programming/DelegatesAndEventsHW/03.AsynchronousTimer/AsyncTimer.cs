using System;
using System.Threading;

namespace AsynchronousTimer
{
    public class AsyncTimer
    {
        private int ticks;
        private int miliseconds;

        public AsyncTimer(Action<int> method, int ticks, int miliseconds)
        {
            this.MethodToExectue = method;
            this.Ticks = ticks;
            this.Miliseconds = miliseconds;
        }

        public Action<int> MethodToExectue { get; set; }

        public int Ticks
        {
            get
            {
                return this.ticks;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("ticks", "The method should be executed at least once.");
                }

                this.ticks = value;
            }
        }

        public int Miliseconds
        {
            get
            {
                return this.miliseconds;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("miliseconds", "The sleep time cannot be negative.");
                }

                this.miliseconds = value;
            }
        }

        public void Run()
        {
            Thread backgroundThread = new Thread(this.Counter);
            backgroundThread.Start();
        }

        private void Counter()
        {
            for (int i = 0; i < this.Ticks; i++)
            {
                Thread.Sleep(this.Miliseconds);
                Random rnd = new Random();

                if (this.MethodToExectue != null)
                {
                    MethodToExectue(rnd.Next(1, 100));
                }
            }
        }
    }
}