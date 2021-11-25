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


        Thread alarmThread;

        public Main()
        {
            //Initialize Object Here
            defense = new Defense();

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
            //Add code here
        }
        private void initializeSPSModuleData()
        {
            //Add code here
        }
        private void initializeDNFModuleData()
        {
            //Add code here
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
            //Add Code Here
        }
        //--------------------SPS Module Code--------------------
        private void SPS_module_timer_Tick(object sender, EventArgs e)
        {
            //Add Code Here
        }
        //--------------------DNF Module Code--------------------
        private void DNF_module_timer_Tick(object sender, EventArgs e)
        {
            //Add Code Here
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
            Settings setting = new Settings(ref defense);

            setting.ShowDialog();
        }
        private void exitButton_Click(object sender, EventArgs e)//save settings here
        {
            defense.alert.alarm.toggleOff();
            defense.turret.saveDefenseConfig();
            Application.Exit();
        }

        /**     Cole's SPS Module Code within our windows Form1.cs  **/
        public Speaker speaker_object = new Speaker();
        public StrengthNullifier strength_object = new StrengthNullifier();
        public TelekinesisStick telekinesis_object = new TelekinesisStick();
        private void SPS_Container_Enter(object sender, EventArgs e)
        {

        }

        private void Module_Enabled_button_Clicked(object sender, EventArgs e)
        {

            //Update buttons
            Enabled_Button.Checked = true;
            Disabled_Button.Checked = false;
            //Enable all components
            foreach (Control c in SPS_module_box.Controls)
            {
                c.Enabled = true;
                if (c is GroupBox)
                {
                    foreach (Control c2 in c.Controls)
                    {
                        if (c2 is RadioButton) { }
                        else
                        {
                            c2.Enabled = false;
                        }
                    }
                }
            }


        }
        private void Module_Disabled_button_Clicked(object sender, EventArgs e)
        {
            //Update buttons
            Disabled_Button.Checked = true;
            Enabled_Button.Checked = false;

            //Disable all components
            foreach (Control c in SPS_module_box.Controls)
            {
                if (c is RadioButton) { } //extra if as to not disable radio buttons
                else
                {
                    c.Enabled = false;
                }
            }

            //uncheck sub-module buttons
            Speaker_Disabled_button.Checked = true;
            Strength_Disabled_Button.Checked = true;
            TK_Disabled_button.Checked = true;

        }
        private void Strength_Enabled_Button_Clicked(object sender, EventArgs e)    //Strength Section
        {
            //Update buttons
            Strength_Enabled_Button.Checked = true;
            Strength_Disabled_Button.Checked = false;
            foreach (Control c in strength_box.Controls)
            {
                c.Enabled = true;
            }
        }

        private void Strength_Disabled_Button_Clicked(object sender, EventArgs e)
        {
            //Update buttons
            Disabled_Button.Checked = true;
            Enabled_Button.Checked = false;
            foreach (Control c in strength_box.Controls)
            {
                if (c is RadioButton) { } //extra if as to not disable radio buttons
                else
                {
                    c.Enabled = false;
                }
            }
        }

        private void Speaker_Enabled_button_Clicked(object sender, EventArgs e) //Speaker Section
        {
            //Update buttons
            Speaker_Enabled_button.Checked = true;
            Speaker_Disabled_button.Checked = false;
            foreach (Control c in speaker_box.Controls)
            {
                c.Enabled = true;
            }

            Speaker speaker = new Speaker();
        }

        private void Speaker_Disabled_button_Clicked(object sender, EventArgs e)
        {
            //Update buttons
            Speaker_Disabled_button.Checked = true;
            Speaker_Enabled_button.Checked = false;
            foreach (Control c in speaker_box.Controls)
            {
                if (c is RadioButton) { }
                else
                {
                    c.Enabled = false;
                }
            }
        }
        private void Volume_button_Click(object sender, EventArgs e)
        {
            speaker_object.setVolume(volume_bar.Value);
            Volume_Amount_lbl.Text = volume_bar.Value.ToString();
        }

        private void volume_bar_ValueChanged(object sender, EventArgs e)
        {
            Volume_slider_lbl.Text = volume_bar.Value.ToString();
        }
        private void TK_Enabled_button_Clicked(object sender, EventArgs e)
        {
            //Update buttons
            TK_Enabled_button.Checked = true;
            TK_Disabled_button.Checked = false;
            foreach (Control c in telekinesis_box.Controls)
            {
                c.Enabled = true;
            }
        }

        private void TK_Disabled_button_Clicked(object sender, EventArgs e)
        {
            //Update buttons
            TK_Disabled_button.Checked = true;
            TK_Enabled_button.Checked = false;
            foreach (Control c in telekinesis_box.Controls)
            {
                if (c is RadioButton) { }
                else
                {
                    c.Enabled = false;
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        /**     SPS Module Form Code End        **/
    }
}
