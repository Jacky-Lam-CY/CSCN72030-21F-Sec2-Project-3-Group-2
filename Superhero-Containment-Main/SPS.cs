using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Superhero_Containment_Main
{
    public class SPS
    {
        const string TELEKINESIS_DATA_PATH = @"..\SPS_Files\telekinesis_data.txt";
        const string STRENGTH_DATA_PATH = @"..\SPS_Files\strength_data.txt";

    }
    public class Speaker
    {
        private int volume;

        public void setVolume(int volume)
        {
            this.volume = volume;
        }
        public int getVolume()
        {
            return this.volume;
        }

    }
    public class TelekinesisStick
    {
        private int selectedCell;
        public void setSelectedCell(int cell)
        {
            this.selectedCell = cell;
        }
        public int getSelectedCell()
        {
            return this.selectedCell;
        }
        public void readTelekinesisData()
        {
            string path = @"..\SPS_Files\telekinesis_data.txt";
            string[] lines = System.IO.File.ReadAllLines(path);
            foreach (string line in lines)
            {
                // Use a tab to indent each line of the file.
                Console.WriteLine("\t" + line);
            }

        }
    }
    public class StrengthNullifier
    {
        private int totalStrength;
        private int currentPower;

        public void setCurrentPower(int power)
        {
            this.currentPower = power;
        }
        public int getCurrentPower()
        {
            return this.currentPower;
        }
        public int getTotalStrength()
        {
            return this.totalStrength;
        }
        public void readStrengthData()
        {
            string path = @"..\SPS_Files\strength_data.txt";
            string[] lines = System.IO.File.ReadAllLines(path);
            foreach (string line in lines)
            {
                // Use a tab to indent each line of the file.
                Console.WriteLine("\t" + line);
            }

        }
    }

}
