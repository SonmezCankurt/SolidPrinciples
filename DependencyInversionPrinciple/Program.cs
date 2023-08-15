using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversion
{
    class Program
    {
        static void Main(string[] args)
        {

            Switch sw1 = new Switch(new LightBulb());
            sw1.Operate();
            sw1.Operate();
            sw1.Operate();

            Switch sw2 = new Switch(new Door());
            sw2.Operate();
            sw2.Operate();
            sw2.Operate();

            Console.ReadLine();

        }
    }



    // Good Design (Loose Coupling)

    interface ISwitchable
    {
        bool IsActivated { get;}
        void Activate();
        void Deactivate();
    }

    class LightBulb : ISwitchable
    {
        private bool isActivated;
        public bool IsActivated { get => isActivated; }

        public void Activate()
        {
            isActivated = true;
            Console.WriteLine("LightBulb is On");
        }

        public void Deactivate()
        {
            isActivated = false;
            Console.WriteLine("LightBulb is Off");
        }
    }

    class Door : ISwitchable
    {
        private bool isActivated;
        public bool IsActivated
        {
            get
            {
                return isActivated;
            }
        }
        public void Activate()
        {
            isActivated = true;
            Console.WriteLine("Door is Open");
        }

        public void Deactivate()
        {
            isActivated = false;
            Console.WriteLine("Door is Close");
        }
    }

    class Switch
    {
        private ISwitchable device;

        public Switch(ISwitchable device)
        {
            this.device = device;
        }

        public void Operate()
        {
            if (device.IsActivated)
                device.Deactivate();
            else
                device.Activate();
        }
    }


    // Bad Design (Tight Coupling)

    /*
    class LightBulb
    {
        public void TurnOn()
        {
            Console.WriteLine("LightBulb is ON");
        }
    }

    class Switch
    {
        private LightBulb bulb;

        public Switch()
        {
            bulb = new LightBulb();
        }

        public void Operate()
        {
            bulb.TurnOn();
        }
    }
    */
}
