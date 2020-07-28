using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Channels;

namespace Stopwatch
{
    public class Stopwatch
    {
        private DateTime _startTime;
        private DateTime _endTime;
        private TimeSpan _duration;
        private bool _hasStarted;
        private bool _hasEnded;

        public void Start()
        {
            if (_hasStarted == false)
            {
                _startTime = DateTime.Now;
                _hasStarted = true;
            }
            else
            {
                throw new Exception("User has already started once, cannot start again");
            }
        }

        public void Stop()
        {
            if (_hasStarted == true)
            {
                _endTime = DateTime.Now;
                _hasEnded = true;
            }
            else
            {
                throw new Exception("User has pressed stop before a start event");
            }
            
        }

        public TimeSpan Report()
        {
            if (_hasEnded == true && _hasStarted == true)
            {
                _duration = _endTime - _startTime;
                _hasStarted = false;
                _hasEnded = false;
                return _duration;
            }
            else
            {
                throw new Exception("Invalid State has been reached");
            }


        }

    }

}
