using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatePractice
{
    class Vehicle
    {
        private int _speed;
        public int Speed
        {
            get
            {
                return _speed;
            }
            set
            {
                //no error checking this time, sorry!
                _speed = value;
                if(_speed == 0 && OnOnStop != null)
                {
                    OnOnStop();
                }
                else if(_speed > 120 && OnOnTooFast != null)
                {
                    OnOnTooFast(_speed);
                }
                else if(OnOnNormal != null)
                {
                    OnOnNormal(_speed);
                }
            }
        }
        public delegate void OnStop();
        public delegate void OnTooFast(int speed);
        public delegate void OnNormal(int speed);

        public event OnStop OnOnStop;
        public event OnTooFast OnOnTooFast;
        public event OnNormal OnOnNormal;

        public Vehicle()
        {
            Speed = 0;
        }

        public void Go(int speed)
        {
            Speed = speed;
        }

        public void Stop()
        {
            Speed = 0;
        }

    }
}
