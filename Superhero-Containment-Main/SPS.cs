using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Superhero_Containment_Main
{
    public class SPS
    {
        private Boolean enabled = false;
        public void setEnabled(Boolean value)
        {
            enabled = value;
        }
        public Boolean getEnabled()
        {
            return enabled;
        }
        public Speaker speaker_object = new Speaker();
        public StrengthNullifier strength_object = new StrengthNullifier();
        public TelekinesisStick telekinesis_object = new TelekinesisStick();
    }
    public class Speaker
    {
        private int volume;
        private Boolean enabled = false;
        public void setEnabled(Boolean value)
        {
            enabled = value;

        }
        public Boolean getEnabled()
        {
            return enabled;
        }

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
        private int textFileIndex = 0;
        public void setSelectedCell(int cell)
        {
            this.selectedCell = cell;
        }
        public int getSelectedCell()
        {
            return this.selectedCell;
        }
        private Boolean enabled = false;
        public void setEnabled(Boolean value)
        {
            enabled = value;
        }
        public Boolean getEnabled()
        {
            return enabled;
        }
        public void readTelekinesisData()
        {
            string path = @"..\..\data\telekinesis_data.txt";
            string[] lines = System.IO.File.ReadAllLines(path);
            this.selectedCell = Convert.ToInt32(lines[this.textFileIndex]);
            this.textFileIndex++;
            if (this.textFileIndex == lines.Length - 1)
            {
                this.textFileIndex = 0;
            }

        }
    }
    public class StrengthNullifier
    {
        private int totalStrength;
        private int currentPower;
        private int textFileIndex = 0;
        private Boolean enabled = false;
        public void setEnabled(Boolean value)
        {
            enabled = value;
        }
        public Boolean getEnabled()
        {
            return enabled;
        }
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
            string path = @"..\..\data\strength_data.txt";
            string[] lines = System.IO.File.ReadAllLines(path);
            this.totalStrength = Convert.ToInt32(lines[this.textFileIndex]);
            this.textFileIndex++;

            if (this.textFileIndex == lines.Length - 1)
            {
                this.textFileIndex = 0;
            }




        }
    }

}
