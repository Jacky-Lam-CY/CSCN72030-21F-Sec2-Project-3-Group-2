using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace Superhero_Containment_Main
{
    public partial class Main : Form
    {
        //Add Object Here
        Defense defense;
        SPS sps;
        DoorsNFloors DNF;
        Thread alarmThread;

        Phantom p = new Phantom();
        HeartOfPhantom HOP = new HeartOfPhantom();
        EyeOfPhantom EOP = new EyeOfPhantom();
        SoulOfPhantom SOP = new SoulOfPhantom();

        public Main()
        {
            //Initialize Object Here
            defense = new Defense();
            sps = new SPS();
            DNF = new DoorsNFloors();

            alarmThread = new Thread(new ThreadStart(() => defense.alert.alarm.playSystemAlarm()));
            InitializeComponent();            
        }

        private void Main_Load(object sender, EventArgs e)
        {
            initializeProgramData();
        }

        private void initializeProgramData()
        {
            initializePhantomModuleData();
            initializeSPSModuleData();
            initializeDNFModuleData();
            initializeDefenseModuleData();
        }
        private void initializePhantomModuleData()
        {
            p.readPdata();
            HOP.readHOPdata();
            EOP.readEOPdata();
            SOP.readSOPdata();
            if (p.phantomStatus == 1)
            {
                panel2.BackColor = Color.Green;
            }
            else
            {
                panel2.BackColor = Color.IndianRed;
            }
            if (HOP.HOPstatus == 1)
            {
                panel3.BackColor = Color.Green;
                pictureBox2.Visible = true;
            }
            else
            {
                panel3.BackColor = Color.IndianRed;
                pictureBox2.Visible = false;
            }
            if (EOP.EOPstatus == 1)
            {
                panel4.BackColor = Color.Green;
            }
            else
            {
                panel4.BackColor = Color.IndianRed;
            }
            if (SOP.SOPstatus == 1)
            {
                panel5.BackColor = Color.Green;
            }
            else
            {
                panel5.BackColor = Color.IndianRed;
            }
        }
        private void initializeSPSModuleData()
        {
            //Add code here
        }
        private void initializeDNFModuleData()
        {

            //Add code here
            //Add Code Here
            DNF.isOpen = false;
            DNF.humidityVal = 50;
            DNF.flagVal = DNF.flagAverage;
            DNF.weightVal = DNF.averageWeight;
        }
        private void initializeDefenseModuleData()
        {
            string[] alertEventNames = defense.alert.getEventNamesList();
            def_alert_label1.Text = alertEventNames[0];
            def_alert_label2.Text = alertEventNames[1];
            def_alert_label3.Text = alertEventNames[2];
            def_alert_label4.Text = alertEventNames[3];
            def_alert_label5.Text = alertEventNames[4];
            alarmThread.Start();
        }

        private void date_time_timer_Tick(object sender, EventArgs e)
        {
            date_time_label.Text = System.DateTime.Now.DayOfWeek.ToString() + System.DateTime.Now.ToString();         
        }
        //--------------------Phantom Module Code--------------------
        private void phantom_module_timer_Tick(object sender, EventArgs e)
        {
            p.readPdata();
            HOP.readHOPdata();
            EOP.readEOPdata();
            SOP.readSOPdata();
            if (p.phantomStatus == 1)
            {
                panel2.BackColor = Color.Green;
            }
            else
            {
                panel2.BackColor = Color.IndianRed;
            }
            if (HOP.HOPstatus == 1)
            {
                panel3.BackColor = Color.Green;
                pictureBox2.Visible = true;
            }
            else
            {
                panel3.BackColor = Color.IndianRed;
                pictureBox2.Visible = false;
            }
            if (EOP.EOPstatus == 1)
            {
                panel4.BackColor = Color.Green;
            }
            else
            {
                panel4.BackColor = Color.IndianRed;
            }
            if (SOP.SOPstatus == 1)
            {
                panel5.BackColor = Color.Green;
            }
            else
            {
                panel5.BackColor = Color.IndianRed;
            }
        }
        //--------------------SPS Module Code--------------------
        private void SPS_module_timer_Tick(object sender, EventArgs e)
        {
            if (sps.getEnabled())
            {
                sps_module_status.BackColor = Color.Lime;
                if (sps.telekinesis_object.getEnabled())
                {
                    sps.telekinesis_object.readTelekinesisData();
                    tk_status.BackColor = Color.Lime;
                }
                if (sps.strength_object.getEnabled())
                {
                    sps.strength_object.readStrengthData();
                    str_status.BackColor = Color.Lime;
                    this.strength_value_lbl.Text = sps.strength_object.getTotalStrength().ToString() + " kJ";
                    this.lbl_str_percent_main.Text = sps.strength_object.getCurrentPower().ToString() + "%";
                }
                if (sps.speaker_object.getEnabled())
                {
                    speaker_status.BackColor = Color.Lime;
                    this.lbl_volume_main.Text = sps.speaker_object.getVolume().ToString() + "%";

                }
            }
            else
            {
                sps_module_status.BackColor = Color.Gray;
                speaker_status.BackColor = Color.Gray;
                str_status.BackColor = Color.Gray;
                tk_status.BackColor = Color.Gray;
            }

        }
        
        //--------------------DNF Module Code--------------------
        private void DNF_module_timer_Tick(object sender, EventArgs e)
        {
            //Add Code Here

            if(DNF.isOpen == true)
            {
                label13.Text = "Door is Open";
            }
            else
            {
                label13.Text = "Door is Closed";
            }

           if(DNF.weightVal == DNF.averageWeight)
            {
                label15.Text = "Average";
            }
           else if(DNF.weightVal == DNF.lightWeight)
            {
                label15.Text = "Light";
            }
           else if(DNF.weightVal == DNF.heavyWeight)
            {
                label15.Text = "Heavy";
            }

            label26.Text = DNF.humidityVal.ToString() + "%";
        }
        //--------------------Defense Module Code--------------------
        private void defense_module_timer_Tick(object sender, EventArgs e)//Monitor and Display of data
        {
            defense_module_timer.Interval = 100;
            defense.operate();

            def_StatusLight.BackColor = changeActiveStatusLight(defense.getActiveStatus());
            def_tur_StatusLight.BackColor = changeActiveStatusLight(defense.turret.getActiveStatus());
            def_alert_StatusLight.BackColor = changeActiveStatusLight(defense.alert.getActiveStatus());

            int primaryValue = defense.turret.primary.readSensor();
            int secondaryValue = defense.turret.secondary.readSensor();
            changeVerticalBarValue(ref def_tur_w1_verBarFront, defense.turret.primary.getActiveStatus() ? primaryValue : 0);
            def_tur_w1_label.Text = primaryValue.ToString();
            changeVerticalBarValue(ref def_tur_w2_verBarFront, defense.turret.secondary.getActiveStatus() ? secondaryValue : 0);            
            def_tur_w2_label.Text = secondaryValue.ToString();


            int[] alertEvents = defense.alert.getEventsList();          

            def_alert_eventStatusLight1.BackColor = changeAlertEventStatusLight(alertEvents[0]);
            def_alert_eventStatusLight2.BackColor = changeAlertEventStatusLight(alertEvents[1]);
            def_alert_eventStatusLight3.BackColor = changeAlertEventStatusLight(alertEvents[2]);
            def_alert_eventStatusLight4.BackColor = changeAlertEventStatusLight(alertEvents[3]);
            def_alert_eventStatusLight5.BackColor = changeAlertEventStatusLight(alertEvents[4]);
        }
        private Color changeActiveStatusLight(bool activeState)
        {
            if (activeState)
            {
                return Color.FromName("Green");
            }
            else
            {
                return Color.FromName("Gray");
            }
        }
        private Color changeAlertEventStatusLight(int num)
        {
            switch (num)
            {
                case 0:
                    return Color.FromName("LightGreen");
                case 1:
                    return Color.FromArgb(255,227,2);
                case 2:
                    return Color.FromName("DarkRed");
                case 3:
                    return Color.FromName("DarkRed");
                default:
                    return Color.FromName("Gray");
            }

        }
        private void changeVerticalBarValue(ref Panel p, int value)
        {
            p.Location = new Point(p.Location.X, 2+Math.Abs(value-100));
        }

        //--------------------Control Button Code--------------------
        private void configButton_Click(object sender, EventArgs e)
        {
            Settings setting = new Settings(ref defense, ref sps, ref DNF);

            setting.ShowDialog();
        }
        private void exitButton_Click(object sender, EventArgs e)//save settings here
        {
            defense.alert.alarm.toggleOff();
            defense.turret.saveDefenseConfig();
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string getValue = "";
          

            DNF.runFloors(ref getValue);

            label17.Text = getValue;
        }
    }
}
