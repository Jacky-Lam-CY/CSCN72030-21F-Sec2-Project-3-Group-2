// Colin Smith
// CSCN72010 
// Group 2

// Super-hero Sontainment System
// Phantom Module

using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;

namespace SuperheroContainment
{
    class Phantom // **Create a function to read from 3 different txt files (One for each of the objects) and initalize each object to the data from the txt
    {
        public int phantomStatus { get; set; }
        public Phantom()
        {
            phantomStatus = 0;
        }

        public Phantom(int status)
        {
            this.phantomStatus = status;
        }
    }

    class HeartOfPhantom // Create a function to print object to a file
    {
        public int HOPStatus { get; set; }
        public int HOPsensitivity { get; set; }

        public HeartOfPhantom()
        {
            HOPStatus = 0;
            HOPsensitivity = 0;
        }

        public HeartOfPhantom(int status, int sensitivity)
        {
            this.HOPStatus = status;
            this.HOPsensitivity = sensitivity;
        }
    }
    class EyeOfPhantom // Create a function to print object to a file
    {
        public int EOPStatus { get; set; }
        public int EOPbrightness { get; set; }
        public int EOPviewingAngle { get; set; }
        public int EOPlight { get; set; }

        public EyeOfPhantom()
        {
            EOPStatus = 0;
            EOPbrightness = 0;
            EOPviewingAngle = 0;
            EOPlight = 0;
        }

        public EyeOfPhantom(int status, int brightness, int viewingAngle, int light)
        {
            this.EOPStatus = status;
            this.EOPbrightness = brightness;
            this.EOPviewingAngle = viewingAngle;
            this.EOPlight = light;
        }
    }

    class SoulOfPhantom // Create a function to print object to a file
    {
        public int SOPStatus { get; set; }
        public double SOPCoveredArea { get; set; }

        public SoulOfPhantom()
        {
            SOPStatus = 0;
            SOPCoveredArea = 0.0;
        }

        public SoulOfPhantom(int status, int coveredArea)
        {
            this.SOPStatus = status;
            this.SOPCoveredArea = coveredArea;
        }
    }
}
