using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Superhero_Containment
{
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
            public Weapon weapon1;
            public Weapon weapon2;
            public Turret()
            {
                Console.WriteLine("Turret Object Created!");
                weapon1 = new(1);
                weapon2 = new(2);
            }
            public override bool getActiveStatus()
            {
                Console.WriteLine("Turret Status");
                return this.isActive;
            }
            public void routineOperation()
            {
                
            }
            public class Weapon: Controller
            {
                bool enable { get; }
                public DurabilitySensor sensor;
                
                public Weapon(int weaponID)
                {
                    Console.WriteLine("Weapon Object Created!");
                    sensor = new(weaponID);
                }
                public override bool getActiveStatus()
                {
                    Console.WriteLine("Weapon Status");
                    return this.isActive;
                }
            }
            public class DurabilitySensor : Controller
            {
                int durabilityValue;
                string sensorFilePath;
                StreamReader sr;
                public DurabilitySensor(int sensorID)
                {
                    Console.WriteLine("DurabilitySensor Object Created!");
                    Random rnd = new Random();
                    durabilityValue = rnd.Next(50,101);
                    sensorFilePath = @"..\..\..\Sensor" + sensorID.ToString() + ".txt";
                    if (!File.Exists(sensorFilePath))//If data file does not exist, create one
                    {
                        createDataFile();
                    }
                    sr = File.OpenText(sensorFilePath);
                }
                public override bool getActiveStatus()
                {
                    Console.WriteLine("DurabilitySensor Status");                    
                    return this.isActive;
                }
                public void detectDurabilityFromFile()
                {
                    if (getActiveStatus())
                    {
                        if (!File.Exists(sensorFilePath))//If data file does not exist, create one
                        {
                            createDataFile();
                        }
                        else
                        {
                            if(sr.Peek() == -1)
                            {
                                sr.BaseStream.Seek(0, SeekOrigin.Begin);
                            }                                                       
                            for (int i = 0; i < 100; i++)
                            {
                                
                                durabilityValue = Int32.Parse(sr.ReadLine());
                                Console.WriteLine(durabilityValue);//Log
                            }
                        }
                    }
                }
                public void createDataFile()
                {
                    int[] value = new int[100];
                    Random rnd = new Random();
                    for (int i = 0; i < value.Length; i++)
                    {
                        value[i] = rnd.Next(0, 101);
                    }
                    StreamWriter sw = File.CreateText(sensorFilePath);
                    foreach (int i in value)
                    {
                        sw.WriteLine(i);
                    }
                    sw.Close();
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

