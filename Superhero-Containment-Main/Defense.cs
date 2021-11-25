using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Media;

namespace Superhero_Containment_Main
{
    public abstract class Controller//Base Class
    {
        protected bool isActive;
        protected bool isError;

        public Controller()
        {
            Console.WriteLine("Controller Object Created!");
            isActive = true;
            isError = false;
        }
        public virtual void toggleOn()
        {
            isActive = true;
        }
        public virtual void toggleOff()
        {
            isActive = false;
        }
        public bool checkErrorState()
        {
            return isError;
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
            turret = new Turret();
            alert = new AlertSystem();
        }
        public void operate()
        {
            turret.operate();
            alert.operate();
        }

        public class Turret : Controller
        {
            public Weapon primary;
            public Weapon secondary;

            string configFilePath;
            public Turret()
            {
                Console.WriteLine("Turret Object Created!");
                primary = new Weapon(1);
                secondary = new Weapon(2);
                configFilePath = @"..\..\data\defenseConfig.txt";
                loadDefenseConfig();
            }
            public override bool getActiveStatus()
            {
                Console.WriteLine("Turret Status");
                return this.isActive;
            }
            public void saveDefenseConfig()
            {
                StreamWriter sw = File.CreateText(configFilePath);
                sw.WriteLine(primary.getDurabilityThresholdValue());
                sw.WriteLine(secondary.getDurabilityThresholdValue());
                sw.Close();
            }
            public bool loadDefenseConfig()
            {
                if (!File.Exists(configFilePath))//If data file does not exist, return
                {
                    return false;
                }
                else
                {
                    StreamReader sr = File.OpenText(configFilePath);
                    primary.setDurabilityThresholdValue(Int32.Parse(sr.ReadLine()));
                    secondary.setDurabilityThresholdValue(Int32.Parse(sr.ReadLine()));
                    sr.Close();
                    return true;
                }
            }
            public void operate()
            {
                primary.operate();
                secondary.operate();
            }
            public class Weapon: Controller
            {
                int durabilityValue;
                int durabilityThresholdValue;
                public DurabilitySensor sensor;
                
                public Weapon(int weaponID)
                {
                    Console.WriteLine("Weapon Object Created!");
                    DateTime rndSeed = DateTime.Now;
                    Random rnd = new Random(rndSeed.Millisecond * rndSeed.Millisecond);
                    durabilityValue = rnd.Next(50, 101);
                    durabilityThresholdValue = 30;
                    sensor = new DurabilitySensor(weaponID);
                }
                public override void toggleOn()
                {
                    base.toggleOn();
                    sensor.toggleOn();
                }
                public override void toggleOff()
                {
                    base.toggleOff();
                    sensor.toggleOff();
                }
                public override bool getActiveStatus()//remove after integration
                {
                    Console.WriteLine("Weapon Status");
                    return this.isActive;
                }
                public int readSensor()
                {
                    return durabilityValue;
                }
                public int getDurabilityThresholdValue()
                {
                    return durabilityThresholdValue;
                }
                public void setDurabilityThresholdValue(int value)
                {
                    if (value >= 0 && value <= 100)
                    {
                        durabilityThresholdValue = value;
                    }
                    else
                    {
                        throw new ArgumentOutOfRangeException();
                    }
                }
                public void operate()
                {
                    if (this.isActive) {
                        if (durabilityValue < durabilityThresholdValue)//turns off when reach or below threshold
                        {
                            this.toggleOff();
                            return;
                        }

                        if (durabilityValue > 0 && sensor.detectDurabilityDegradeFromFile())//detects degrade
                        {
                            durabilityValue--;
                        }
                    }
                    else
                    {
                        if (durabilityValue > durabilityThresholdValue)//turns on when threshold is set to below current durability value
                        {
                            this.toggleOn();
                        }
                    }
                }
                public class DurabilitySensor : Controller//detects degrade
                {                   
                    string sensorFilePath;
                    StreamReader sr;
                    public DurabilitySensor(int sensorID)
                    {
                        Console.WriteLine("DurabilitySensor Object Created!");
                        sensorFilePath = @"..\..\data\Sensor" + sensorID.ToString() + ".txt";
                        if (!File.Exists(sensorFilePath))//If data file does not exist, create one
                        {
                            createDataFile();
                        }
                        sr = File.OpenText(sensorFilePath);
                    }
                    public override bool getActiveStatus()//remove after integration
                    {
                        Console.WriteLine("DurabilitySensor Status");
                        return this.isActive;
                    }
                    public bool detectDurabilityDegradeFromFile()
                    {
                        if (getActiveStatus())
                        {
                            if (!File.Exists(sensorFilePath))//If data file does not exist, create one
                            {
                                createDataFile();
                                sr = File.OpenText(sensorFilePath);
                            }
                            if (sr.Peek() == -1)
                            {
                                sr.BaseStream.Seek(0, SeekOrigin.Begin);
                            }
                            int value = Int32.Parse(sr.ReadLine());
                            Console.WriteLine(value);//Log
                            return (value > 75);
                        }
                        return false;
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
        }
        public class AlertSystem : Controller
        {
            string sensorFilePath;
            StreamReader sr;

            const int numOfEvents = 5;
            int[] alertEvents;
            string[] alertEventNames = {"Module 1",
                                        "Module 2",
                                        "Module 3",
                                        "Module 4",
                                        "Module 5"};
            bool[] isTriggered;

            public Alarm alarm;
            public AlertSystem()
            {
                Console.WriteLine("AlertSystem Object Created!");
                sensorFilePath = @"..\..\data\AlertSensor.txt";

                if (!File.Exists(sensorFilePath))//If data file does not exist, create one
                {
                    createDataFile();
                }
                sr = File.OpenText(sensorFilePath);

                alertEvents = new int[numOfEvents];
                foreach (int i in alertEvents)
                {
                    alertEvents[i] = 0;
                }
                isTriggered = new bool[5];
                for (int i = 0; i < isTriggered.Length; i++)
                {
                    isTriggered[i] = false;
                }
                
                alarm = new Alarm();
            }
            public override bool getActiveStatus()
            {
                Console.WriteLine("AlertSystem Status");
                return this.isActive;
            }
            public int[] getEventsList()
            {
                return alertEvents;
            }
            public string[] getEventNamesList()
            {
                return alertEventNames;
            }
            public int detectAlertEventFromFile()
            {
                if (getActiveStatus())
                {
                    if (!File.Exists(sensorFilePath))//If data file does not exist, create one
                    {
                        createDataFile();
                        sr = File.OpenText(sensorFilePath);
                    }
                    if (sr.Peek() == -1)
                    {
                        sr.BaseStream.Seek(0, SeekOrigin.Begin);
                    }
                    int value = Int32.Parse(sr.ReadLine());
                    Console.WriteLine(value);//Log
                    if (value > -1 && value < 5)
                    {
                        return value;
                    }
                }
                return -1;
            }
            public void createDataFile()
            {
                int[] value = new int[100];
                Random rnd = new Random();
                for (int i = 0; i < value.Length; i++)
                {
                    value[i] = rnd.Next(0, 20);
                }
                StreamWriter sw = File.CreateText(sensorFilePath);
                foreach (int i in value)
                {
                    sw.WriteLine(i);
                }
                sw.Close();
            }
            public void operate()
            {
                if (this.isActive)
                {
                    for (int i = 0; i < alertEvents.Length; i++)
                    {
                        if (alertEvents[i] == 3)
                        {
                            alertEvents[i] = 0;
                            isTriggered[i] = false;
                        }
                        if (alertEvents[i] == 2 && !isTriggered[i])
                        {
                            alarm.triggerAlarm();
                            isTriggered[i] = true;
                        }

                        Console.WriteLine($"AlertSystem Detects Event {alertEvents[i]}");
                    }
                    int events = detectAlertEventFromFile();
                    if (events > -1)
                    {
                        alertEvents[events] += 1;
                    }
                }
            }
            public class Alarm : Controller
            {
                string soundFilePath;
                SoundPlayer soundPlayer;                

                bool alertSingle;
                public Alarm()
                {
                    Console.WriteLine("Alarm Object Created!");
                    soundFilePath = @"..\..\data\testing.wav";
                    if (!File.Exists(soundFilePath))//If data file does not exist, object is in error state
                    {
                        this.isError = true;
                    }
                    else
                    {
                        soundPlayer = new SoundPlayer(soundFilePath);
                        alertSingle = false;
                    }
                }
                public override bool getActiveStatus()
                {
                    Console.WriteLine("Alarm Status");
                    return this.isActive;
                }
                public void playSystemAlarm()
                {
                    if (this.isError)
                    {
                        return;
                    }
                    while (isActive)
                    {
                        while (alertSingle)
                        {
                            soundPlayer.Play();
                            alertSingle = false;
                        }
                        Thread.Sleep(100);
                    }
                }
                public void stopAlarm()
                {
                    soundPlayer.Stop();
                }
                public void triggerAlarm()
                {
                    alertSingle = true;
                }
            }
        }
    }
}

