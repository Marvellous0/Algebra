using System;

namespace Assingment
{
    class Program
    {

        // public static void StopWatch()
        // { 
        private DateTime _startDate;
        private DateTime _endDate;
        private bool _Running;

        public void Start()
        {
            if (_Running)
            {
                throw new InvalidOperationException("Stopwatch is already running");
            }
            _startDate = DateTime.Now;
            _Running = true;
        }

        public void Stop()
        {
            if (!_Running)
            {
                throw new InvalidOperationException("Stopwatch is not running");
            }


            _endDate = DateTime.Now;
            _Running = false;
        }

        public TimeSpan GetDuration()
        {
            return _endDate - _startDate;
        }

    }

}
