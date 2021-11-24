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


namespace Superhero_Containment_UI
{
    public partial class Form1 : Form
    {
        Defense defense;
        Thread alarmThread;
        public Form1()
        {
            InitializeComponent();
            durabilitySensorTimer.Start();
            
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            defense = new Defense();
            alarmThread = new Thread(new ThreadStart(() => defense.alert.alarm.playAlarm()));
            alarmThread.Start();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (!defense.turret.primary.sensor.getActiveStatus())
            {
                defense.turret.primary.sensor.toggleOn();
                durabilityLabel.Visible = true;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (defense.turret.primary.sensor.getActiveStatus())
            {
                defense.turret.primary.sensor.toggleOff();
                durabilityLabel.Visible = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            durabilitySensorTimer.Interval = 1000;
            //defense.turret.operate();
            defense.alert.operate();
            int value = defense.turret.primary.readSensor();
            durabilityLabel.Text = value.ToString();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            defense.alert.alarm.toggleOff();
            Application.Exit();
            
        }

        private void groupBox8_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 config = new Form2();
            //this.Hide();
       

            config.ShowDialog();
        }
    }
}
