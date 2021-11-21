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
            defense.turret.sensor.getActiveStatus();
            defense.alert.getActiveStatus();
            defense.alert.alarm.getActiveStatus();
        }
    }
}
