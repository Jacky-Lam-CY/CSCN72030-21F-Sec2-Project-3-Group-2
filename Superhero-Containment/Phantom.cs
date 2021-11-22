// Colin Smith
// CSCN72010 
// Group 2

// Super-hero Sontainment System
// Phantom Module

using System;
using System.IO;

namespace SuperheroContainment
{
    class Phantom 
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
        public void printPdata()
        {
            StreamWriter sw = new StreamWriter(@"C:\Users\colin\OneDrive\Desktop\CSCN72030-21F-Sec2-Project-3-Group-2\P.txt");
            sw.WriteLine(this.phantomStatus);

            sw.Close();
        }
        public void readPdata()
        {
            string stat;
            StreamReader sr = new StreamReader(@"C:\Users\colin\OneDrive\Desktop\CSCN72030-21F-Sec2-Project-3-Group-2\P.txt");
            stat = sr.ReadLine();

            this.phantomStatus = Int32.Parse(stat);

            sr.Close();
        }
    }

    class HeartOfPhantom 
    {
        public int HOPstatus { get; set; }
        public int HOPsensitivity { get; set; }

        public HeartOfPhantom()
        {
            HOPstatus = 0;
            HOPsensitivity = 0;
        }

        public HeartOfPhantom(int status, int sensitivity)
        {
            this.HOPstatus = status;
            this.HOPsensitivity = sensitivity;
        }
        public void printHOPdata()
        {
            StreamWriter sw = new StreamWriter(@"C:\Users\colin\OneDrive\Desktop\CSCN72030-21F-Sec2-Project-3-Group-2\HOP.txt");
            sw.WriteLine(this.HOPstatus);
            sw.WriteLine(this.HOPsensitivity);

            sw.Close();
        }
        public void readHOPdata()
        {
            string stat, sens;
            StreamReader sr = new StreamReader(@"C:\Users\colin\OneDrive\Desktop\CSCN72030-21F-Sec2-Project-3-Group-2\HOP.txt");
            stat = sr.ReadLine();
            sens = sr.ReadLine();

            this.HOPstatus = Int32.Parse(stat);
            this.HOPsensitivity = Int32.Parse(sens);

            sr.Close();
        }
    }

    class EyeOfPhantom 
    {
        public int EOPstatus { get; set; }
        public int EOPbrightness { get; set; }
        public int EOPviewingAngle { get; set; }
        public int EOPlight { get; set; }

        public EyeOfPhantom()
        {
            EOPstatus = 0;
            EOPbrightness = 0;
            EOPviewingAngle = 0;
            EOPlight = 0;
        }

        public EyeOfPhantom(int status, int brightness, int viewingAngle, int light)
        {
            this.EOPstatus = status;
            this.EOPbrightness = brightness;
            this.EOPviewingAngle = viewingAngle;
            this.EOPlight = light;
        }
        public void printEOPdata()
        {
            StreamWriter sw = new StreamWriter(@"C:\Users\colin\OneDrive\Desktop\CSCN72030-21F-Sec2-Project-3-Group-2\EOP.txt");
            sw.WriteLine(this.EOPstatus);
            sw.WriteLine(this.EOPbrightness);
            sw.WriteLine(this.EOPviewingAngle);
            sw.WriteLine(this.EOPlight);

            sw.Close();
        }
        public void readEOPdata()
        {
            string stat, bright, view, light;
            StreamReader sr = new StreamReader(@"C:\Users\colin\OneDrive\Desktop\CSCN72030-21F-Sec2-Project-3-Group-2\EOP.txt");
            stat = sr.ReadLine();
            bright = sr.ReadLine();
            view = sr.ReadLine();
            light = sr.ReadLine();

            this.EOPstatus = Int32.Parse(stat);
            this.EOPbrightness = Int32.Parse(bright);
            this.EOPviewingAngle = Int32.Parse(view);
            this.EOPlight = Int32.Parse(light);

            sr.Close();
        }
    }

    class SoulOfPhantom 
    {
        public int SOPstatus { get; set; }
        public double SOPcoveredArea { get; set; }

        public SoulOfPhantom()
        {
            SOPstatus = 0;
            SOPcoveredArea = 0.0;
        }

        public SoulOfPhantom(int status, int coveredArea)
        {
            this.SOPstatus = status;
            this.SOPcoveredArea = coveredArea;
        }
        public void printSOPdata()
        {
            StreamWriter sw = new StreamWriter(@"C:\Users\colin\OneDrive\Desktop\CSCN72030-21F-Sec2-Project-3-Group-2\SOP.txt");
            sw.WriteLine(this.SOPstatus);
            sw.WriteLine(this.SOPcoveredArea);
       
            sw.Close();
        }
        public void readSOPdata()
        {
            string stat, area;
            StreamReader sr = new StreamReader(@"C:\Users\colin\OneDrive\Desktop\CSCN72030-21F-Sec2-Project-3-Group-2\SOP.txt");
            stat = sr.ReadLine();
            area = sr.ReadLine();

            this.SOPstatus = Int32.Parse(stat);
            this.SOPcoveredArea = Int32.Parse(area);
  
            sr.Close();
        }
    }
}