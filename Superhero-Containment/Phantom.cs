// Colin Smith
// CSCN72010 
// Group 2
// 
// Super-hero Sontainment System
// Phantom Module

using System;

namespace SuperheroContainment
{
    /*
    class Program
    {
        static void Main(string[] args)
        {

        }
    }
    */

    // ****CAN ONLY MAKE AN OBJECT WITH ALL OF THEIR ATTRIBUTES HOP(STATUS, SENSITIVITY) MAKE IT SO YOU CAN CONFIGURE INDIVIUALLY HOP(STATUS)
    public class Phantom
    {
        int phantomStatus { get; set; }
        public Phantom()
        {
            phantomStatus = 0;
        }

        public Phantom(int status)
        {
            this.phantomStatus = status;
        }
        public string OnOff()
        {
            if (this.phantomStatus == 0)
            {
                return "Off"; // Display button as off
            }
            else
                return "On"; // Display button as on
        }

        // Read from file and initialize the objects here 
    }

    public class HOP
    {
        int HOPStatus { get; set; }
        int HOPsensitivity { get; set; }

        public HOP()
        {
            HOPStatus = 0;
            HOPsensitivity = 0;
        }

        public HOP(int status, int sensitivity)
        {
            this.HOPStatus = status;
            this.HOPsensitivity = sensitivity;
        }

        public string OnOff()
        {
            if (this.HOPStatus == 0)
            {
                return "Off"; // Display button as off
            }
            else
                return "On"; // Display button as on
        }
        // Print to file
    }
    class EOP
    {
        int EOPStatus { get; set; }
        int EOPbrightness { get; set; }
        int EOPviewingAngle { get; set; }
        int EOPlight { get; set; }

        public EOP()
        {
            EOPStatus = 0;
            EOPbrightness = 0;
            EOPviewingAngle = 0;
            EOPlight = 0;
        }

        public EOP(int status, int brightness, int viewingAngle, int light)
        {
            this.EOPStatus = status;
            this.EOPbrightness = brightness;
            this.EOPviewingAngle = viewingAngle;
            this.EOPlight = light;
        }
        public string OnOff()
        {
            if (this.EOPStatus == 0)
            {
                return "Off"; // Display button as off
            }
            else
                return "On"; // Display button as on
        }
        // Print to file
    }

    class SOP
    {
        int SOPStatus { get; set; }
        double SOPCoveredArea { get; set; }

        public SOP()
        {
            SOPStatus = 0;
            SOPCoveredArea = 0.0;
        }

        public SOP(int status, int coveredArea)
        {
            this.SOPStatus = status;
            this.SOPCoveredArea = coveredArea;
        }
        public string OnOff()
        {
            if (this.SOPStatus == 0)
            {
                return "Off"; // Display button as off
            }
            else
                return "On"; // Display button as on
        }
        // Print to file
    }
}
