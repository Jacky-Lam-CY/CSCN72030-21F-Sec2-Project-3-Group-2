using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Superhero_Containment_Main
{
    public partial class Settings : Form
    {
        //Add object here
        Defense defense;
        SPS sps;
        bool isChanged;
        public Settings(ref Defense def)//Pass reference of your object
        {
            defense = def;          
            InitializeComponent();           
        }

        //--------------------Load Module Settings(Object data)--------------------
        private void Settings_Load(object sender, EventArgs e)//Load Settings Data Here
        {
            loadDefenseModuleSettings();

            isChanged = false;
        }
        private void loadPhantomModuleSettings()
        {
            //Add Code Here
        }
        private void loadDNFModuleSettings()
        {
            //Add Code Here
        }
        private void loadSPSModuleSettings()
        {
            //Add Code Here
        }
        private void loadDefenseModuleSettings()
        {
            if (defense.getActiveStatus())
            {
                def_on.Checked = true;
            }
            else
            {
                def_off.Checked = true;
            }

            if (defense.turret.getActiveStatus())
            {
                def_tur_on.Checked = true;
            }
            else
            {
                def_tur_off.Checked = true;
            }

            if (defense.alert.getActiveStatus())
            {
                def_alert_on.Checked = true;
            }
            else
            {
                def_alert_off.Checked = true;
            }

            if (defense.alert.alarm.getActiveStatus())
            {
                def_alert_alarm_on.Checked = true;
            }
            else
            {
                def_alert_alarm_on.Checked = false;
            }

            int def_w1_dt = defense.turret.primary.getDurabilityThresholdValue();
            int def_w2_dt = defense.turret.secondary.getDurabilityThresholdValue();
            label_def_w1_dt.Text = def_w1_dt.ToString();
            trackBar_def_w1_dt.Value = def_w1_dt;
            label_def_w2_dt.Text = def_w2_dt.ToString();
            trackBar_def_w2_dt.Value = def_w2_dt;       
        }

        //--------------------Phantom Module Code--------------------

        //--------------------SPS Module Code--------------------
        /**     Cole's SPS Module Code within our windows Form1.cs  **/
        
        private void SPS_Container_Enter(object sender, EventArgs e)
        {

        }

        private void Module_Enabled_button_Clicked(object sender, EventArgs e)
        {

            //Update buttons
            SPS_Enabled_Button.Checked = true;
            SPS_Disabled_Button.Checked = false;
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
            SPS_Disabled_Button.Checked = true;
            SPS_Enabled_Button.Checked = false;

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
            SPS_Disabled_Button.Checked = true;
            SPS_Enabled_Button.Checked = false;
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
            sps.speaker_object.setVolume(volume_bar.Value);
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

        //--------------------DNF Module Code--------------------

        //--------------------Defense Module Code--------------------
        private void def_on_CheckedChanged(object sender, EventArgs e)
        {
            if (def_on.Checked == false)
            {
                def_tur_group.Enabled = false;
                def_alert_group.Enabled = false;
                applyButton.Enabled = true;
                isChanged = true;
            }
        }

        private void def_off_CheckedChanged(object sender, EventArgs e)
        {
            if (def_off.Checked == false)
            {
                def_tur_group.Enabled = true;
                def_alert_group.Enabled = true;
                applyButton.Enabled = true;
                isChanged = true;
            }
        }
        private void def_tur_on_CheckedChanged(object sender, EventArgs e)
        {
            if (def_tur_on.Checked == false)
            {
                def_w1_group.Enabled = false;
                def_w2_group.Enabled = false;
                applyButton.Enabled = true;
                isChanged = true;
            }
        }
        private void def_tur_off_CheckedChanged(object sender, EventArgs e)
        {
            if (def_tur_off.Checked == false)
            {
                def_w1_group.Enabled = true;
                def_w2_group.Enabled = true;
                applyButton.Enabled = true;
                isChanged = true;
            }
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void trackBar_def_w1_dt_Scroll(object sender, EventArgs e)
        {
            label_def_w1_dt.Text = trackBar_def_w1_dt.Value.ToString();
            applyButton.Enabled = true;
            isChanged = true;
        }
        private void trackBar_def_w2_dt_Scroll(object sender, EventArgs e)
        {
            label_def_w2_dt.Text = trackBar_def_w2_dt.Value.ToString();
            applyButton.Enabled = true;
            isChanged = true;
        }
        private void def_alert_on_CheckedChanged(object sender, EventArgs e)
        {
            if (def_alert_on.Checked == false)
            {
                def_alert_alarm_group.Enabled = false;
                applyButton.Enabled = true;
                isChanged = true;
            }
        }

        private void def_alert_off_CheckedChanged(object sender, EventArgs e)
        {
            if (def_alert_off.Checked == false)
            {
                def_alert_alarm_group.Enabled = true;
                applyButton.Enabled = true;
                isChanged = true;
            }
        }

        //--------------------Comfirm Settings Code--------------------
        private void okButton_Click(object sender, EventArgs e)
        {
            if (isChanged == true)
            {
                applyAppSettingsChanges();
            }
            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void applyButton_Click(object sender, EventArgs e)
        {
            applyAppSettingsChanges();
            isChanged = false;
            applyButton.Enabled = false;
        }
        private void applyAppSettingsChanges()
        {
            applyPhantomModuleSettingsChange();
            applySPSModuleSettingsChange();
            applyDNFModuleSettingsChange();
            applyDefenseModuleSettingsChange();
        }
        private void applyPhantomModuleSettingsChange()
        {
            //Add Code Here
        }
        private void applySPSModuleSettingsChange()
        {
            // Add Code Here
        }
        private void applyDNFModuleSettingsChange()
        {
            // Add Code Here
        }
        private void applyDefenseModuleSettingsChange()
        {
            if (def_on.Checked)
            {
                defense.toggleOn();
            }
            else
            {
                defense.toggleOff();
            }

            if (defense.getActiveStatus() && def_tur_on.Checked)
            {
                defense.turret.toggleOn();
            }
            else
            {
                defense.turret.toggleOff();
            }

            if (defense.getActiveStatus() && def_alert_on.Checked)
            {
                defense.alert.toggleOn();
            }
            else
            {
                defense.alert.toggleOff();
            }

            defense.turret.primary.setDurabilityThresholdValue(trackBar_def_w1_dt.Value);
            defense.turret.secondary.setDurabilityThresholdValue(trackBar_def_w2_dt.Value);
        }
        //--------------------End--------------------
        private void emptyFunction() { }      
    }
}
