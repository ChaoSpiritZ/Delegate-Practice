using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatePractice
{
    class VehicleControl
    {
        public Vehicle _vehicle;

        public VehicleControl()
        {
            _vehicle = new Vehicle();
            _vehicle.OnOnStop += StopMessage;
            _vehicle.OnOnTooFast += TooFastMessage;
            _vehicle.OnOnNormal += NormalMessage;
        }

        public void DoStuff()
        {
            _vehicle.Go(10);
            _vehicle.Stop();
            _vehicle.Go(100);
            _vehicle.Go(0);
            _vehicle.Go(120);
            _vehicle.Go(170);
            _vehicle.Stop();
        }

        public void StopMessage()
        {
            Console.WriteLine("The vehicle stopped!");
        }

        public void TooFastMessage(int speed)
        {
            Console.WriteLine("You are going at mach speed!!! ({0})", speed);
        }

        public void NormalMessage(int speed)
        {
            Console.WriteLine("You are going at {0} speed!", speed);
        }
    }
}
