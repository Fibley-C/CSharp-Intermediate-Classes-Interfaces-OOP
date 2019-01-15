using System;

namespace WatchProgram
{
    public class StopWatch
    {
        DateTime StartTime;
        Boolean IsRunning;
        DateTime FinishTime;

        public void Start()
        {
            if (IsRunning)
            {
                throw new InvalidOperationException("Stopwatch already running!");
            }
            StartTime = DateTime.Now;
            IsRunning = true;
        }

        public void Stop()
        {
            if (!IsRunning)
            {
                throw new InvalidOperationException("Cannot stop as watch isn't running!");
            }
            FinishTime = DateTime.Now;
            IsRunning = false;
        }

        public TimeSpan ElaspedTime()
        {
            if (IsRunning)
            {
                return DateTime.Now - StartTime;
            }
            else
            {
                return FinishTime - StartTime;
            }
        }
    }
}