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
            defense.turret.primary.getActiveStatus();
            defense.turret.primary.sensor.getActiveStatus();
            defense.turret.secondary.getActiveStatus();
            defense.turret.secondary.sensor.getActiveStatus();
            defense.alert.getActiveStatus();
            defense.alert.alarm.getActiveStatus();
            defense.turret.secondary.sensor.detectDurabilityDegradeFromFile();
            defense.turret.secondary.sensor.detectDurabilityDegradeFromFile();
            
            defense.turret.saveDefenseConfig();
        }
    }
}
