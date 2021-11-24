using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;


namespace SuperpowerSuppression
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            
            InitializeComponent();
            
            
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
            foreach(Control c in SPS_module_box.Controls)
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

        /**     SPS Module Form Code End        **/
    }
}
