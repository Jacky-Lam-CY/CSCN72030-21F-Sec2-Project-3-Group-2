using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Superhero_Containment
{
    /*class DefenseA
    {
        bool isActive;
        public Turret turret;
        public AlertSystem alert;


        public DefenseA()
        {
            Console.WriteLine("Defense Object Created!");
            isActive = true;
            turret = new();
            alert = new();
        }
        public void toggleOn()
        {
            isActive = true;
        }
        public void toggleOff()
        {
            isActive = false;
        }
        public bool getActiveStatus()
        {
            return isActive;
        }


       
        public class Turret
        {
            bool isActive;

            public Turret()
            {
                isActive = true;
                Console.WriteLine("Turret Object Created!");
            }
            public void toggleOn()
            {
                isActive = true;
            }
            public void toggleOff()
            {
                isActive = false;
            }

            class DurabilitySensor
            {
                bool isActive = true;

                void toggleOn()
                {
                    isActive = true;
                }
                public void toggleOff()
                {
                    isActive = false;
                }
            }
        }

        internal class AlertSystem
        {
            bool isActive = true;

            class Alarm
            {
                bool isActive = true;
            }
        }
    }

    */
    public abstract class Controller//Base Class
    {
        protected bool isActive;

        public Controller()
        {
            Console.WriteLine("Controller Object Created!");
            isActive = true;
        }
        public void toggleOn()
        {
            isActive = true;
        }
        public void toggleOff()
        {
            isActive = false;
        }
        public virtual bool getActiveStatus()
        {
            Console.WriteLine("Controller Status");
            return isActive;
        }
    }

    public class Defense : Controller
    {
        public Turret turret;
        public AlertSystem alert;

        public Defense()
        {
            Console.WriteLine("Defense Object Created!");
            turret = new();
            alert = new();
        }

        public class Turret : Controller
        {
            public DurabilitySensor sensor;
            public Turret()
            {
                Console.WriteLine("Turret Object Created!");
                sensor = new();
            }
            public override bool getActiveStatus()
            {
                Console.WriteLine("Turret Status");
                return this.isActive;
            }


            public class DurabilitySensor : Controller
            {
                public DurabilitySensor()
                {
                    Console.WriteLine("DurabilitySensor Object Created!");
                }
                public override bool getActiveStatus()
                {
                    Console.WriteLine("DurabilitySensor Status");
                    return this.isActive;
                }
            }
        }
        public class AlertSystem : Controller
        {
            public Alarm alarm;
            public AlertSystem()
            {
                Console.WriteLine("AlertSystem Object Created!");
                alarm = new();
            }
            public override bool getActiveStatus()
            {
                Console.WriteLine("AlertSystem Status");
                return this.isActive;
            }



            public class Alarm : Controller
            {
                public Alarm()
                {
                    Console.WriteLine("Alarm Object Created!");
                }
                public override bool getActiveStatus()
                {
                    Console.WriteLine("Alarm Status");
                    return this.isActive;
                }
            }
        }
    }
}

