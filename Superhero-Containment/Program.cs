using System;

namespace Superhero_Containment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            Defense defense = new();
            defense.getActiveStatus();
            defense.turret.getActiveStatus();
            defense.turret.weapon1.getActiveStatus();
            defense.turret.weapon1.sensor.getActiveStatus();
            defense.turret.weapon2.getActiveStatus();
            defense.turret.weapon2.sensor.getActiveStatus();
            defense.alert.getActiveStatus();
            defense.alert.alarm.getActiveStatus();
            defense.turret.weapon2.sensor.detectDurabilityFromFile();
            defense.turret.weapon2.sensor.detectDurabilityFromFile();
        }
    }
}
