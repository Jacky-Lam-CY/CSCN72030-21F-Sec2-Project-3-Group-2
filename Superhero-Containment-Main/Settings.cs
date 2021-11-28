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
        Phantom p = new Phantom();
        HeartOfPhantom HOP = new HeartOfPhantom();
        EyeOfPhantom EOP = new EyeOfPhantom();
        SoulOfPhantom SOP = new SoulOfPhantom();
        
        bool isChanged;
        public Settings(ref Defense def, ref SPS s)//Pass reference of your object
        {
            defense = def;
            sps = s;
            InitializeComponent();           
        }

        //--------------------Load Module Settings(Object data)--------------------
        private void Settings_Load(object sender, EventArgs e)//Load Settings Data Here
        {
            loadDefenseModuleSettings();
            loadPhantomModuleSettings();
            loadSPSModuleSettings();
            isChanged = false;
            applyButton.Enabled = false;
        }
        private void loadPhantomModuleSettings()
        {
            p.readPdata();
            HOP.readHOPdata();
            EOP.readEOPdata();
            SOP.readSOPdata();
            if (p.phantomStatus == 1)
            {
                radioButton6.Checked = true;
            }
            else 
            {
                radioButton5.Checked = true;
            }
            if (HOP.HOPstatus == 1)
            {
                radioButton2.Checked = true;
            }
            else
            {
                radioButton1.Checked = true;
            }
            if (EOP.EOPstatus == 1)
            {
                radioButton4.Checked = true;
            }
            else
            {
                radioButton3.Checked = true;
            }
            if (SOP.SOPstatus == 1)
            {
                radioButton8.Checked = true;
            }
            else
            {
                radioButton7.Checked = true;
            }
            trackBar1.Value = HOP.HOPsensitivity;
            trackBar2.Value = EOP.EOPbrightness;
            trackBar4.Value = EOP.EOPviewingAngle;
            trackBar5.Value = EOP.EOPlight;
            trackBar3.Value = SOP.SOPcoveredArea;
        }

        private void loadDNFModuleSettings()
        {
            //Add Code Here
        }
        private void loadSPSModuleSettings()
        {
            //Add Code Here
            if (sps.getEnabled())
            {
                SPS_Enabled_Button.Checked = true;
                SPS_Disabled_Button.Checked = false;

                if (sps.speaker_object.getEnabled())
                {
                    Speaker_Enabled_button.Checked = true;
                    Speaker_Disabled_button.Checked = false;
                    speaker_box.Enabled = true;
                    volume_bar.Value = sps.speaker_object.getVolume();
                    Volume_slider_lbl.Text = sps.speaker_object.getVolume().ToString() + "%";
                    Volume_Amount_lbl.Text = sps.speaker_object.getVolume().ToString() + "%";
                }
                if (sps.telekinesis_object.getEnabled())
                {
                    TK_Enabled_button.Checked = true;
                    TK_Disabled_button.Checked = false;
                    telekinesis_box.Enabled = true;
                }
                if (sps.strength_object.getEnabled())
                {
                    Strength_Enabled_Button.Checked = true;
                    Strength_Disabled_Button.Checked = false;
                    strength_box.Enabled = true;
                    Strength_bar.Value = sps.strength_object.getCurrentPower();
                    str_percent_lbl.Text = sps.strength_object.getCurrentPower().ToString().ToString() + "%";
                    this.str_live_lbl.Text = sps.strength_object.getTotalStrength().ToString() + " kJ";
                }
            }
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
        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            p.phantomStatus = 1;
            applyButton.Enabled = true;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            p.phantomStatus = 0;
            applyButton.Enabled = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            HOP.HOPstatus = 1;
            applyButton.Enabled = true;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            HOP.HOPstatus = 0;
            applyButton.Enabled = true;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            EOP.EOPstatus = 1;
            applyButton.Enabled = true;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            EOP.EOPstatus = 0;
            applyButton.Enabled = true;
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            SOP.SOPstatus = 1;
            applyButton.Enabled = true;
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            SOP.SOPstatus = 0;
            applyButton.Enabled = true;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            HOP.HOPsensitivity = trackBar1.Value;
            applyButton.Enabled = true;
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            EOP.EOPbrightness = trackBar2.Value;
            applyButton.Enabled = true;
        }

        private void trackBar4_Scroll(object sender, EventArgs e)
        {
            EOP.EOPviewingAngle = trackBar4.Value;
            applyButton.Enabled = true;
        }

        private void trackBar5_Scroll(object sender, EventArgs e)
        {
            EOP.EOPlight = trackBar5.Value;
            applyButton.Enabled = true;
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            SOP.SOPcoveredArea = trackBar3.Value;
            applyButton.Enabled = true;
        }

        //--------------------SPS Module Code--------------------
        /**     Cole's SPS Module Code within our windows Form1.cs  **/
        private void Module_Enabled_button_Clicked(object sender, EventArgs e)
        {
            applyButton.Enabled = true;
            isChanged = true;
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
            applyButton.Enabled = true;
            isChanged = true;
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
            Strength_Enabled_Button.Checked = true;
            Strength_Disabled_Button.Checked = false;
            foreach (Control c in strength_box.Controls)
            {
                c.Enabled = true;
            }
            applyButton.Enabled = true;
            isChanged = true;

        }
        private void Str_Bar_Value_Changed(object sender, EventArgs e)
        {
            isChanged = true;
            applyButton.Enabled = true;
        }
        private void Strength_Disabled_Button_Clicked(object sender, EventArgs e)
        {
            applyButton.Enabled = true;
            isChanged = true;
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
        private void Auto_Set_Button_Clicked(object sender, EventArgs e)
        {
            Strength_bar.Value = Convert.ToInt32((sps.strength_object.getTotalStrength() / 3000.00) * 100);
            str_percent_lbl.Text = Strength_bar.Value.ToString() + "%";
            isChanged = true;
            applyButton.Enabled = true;
        }
       
        private void Speaker_Enabled_button_Clicked(object sender, EventArgs e) //Speaker Section
        {
            Speaker_Enabled_button.Checked = true;
            Speaker_Disabled_button.Checked = false;
            applyButton.Enabled = true;
            isChanged = true;
            foreach (Control c in speaker_box.Controls)
            {
                c.Enabled = true;
            }
        }

        private void Speaker_Disabled_button_Clicked(object sender, EventArgs e)
        {
            Speaker_Disabled_button.Checked = true;
            Speaker_Enabled_button.Checked = false;
            applyButton.Enabled = true;
            isChanged = true;
            foreach (Control c in speaker_box.Controls)
            {
                if (c is RadioButton) { }
                else
                {
                    c.Enabled = false;
                }
            }

        }

        private void volume_bar_ValueChanged(object sender, EventArgs e)
        {
            Volume_slider_lbl.Text = volume_bar.Value.ToString();
            applyButton.Enabled = true;
            isChanged = true;

        }
        private void TK_Enabled_button_Clicked(object sender, EventArgs e)
        {
            TK_Enabled_button.Checked = true;
            TK_Disabled_button.Checked = false;
            applyButton.Enabled = true;
            isChanged = true;
            foreach (Control c in telekinesis_box.Controls)
            {
                c.Enabled = true;
            }
        }
        private void TK_Disabled_button_Clicked(object sender, EventArgs e)
        {
            if (TK_Enabled_button.Checked)
            {
                TK_Disabled_button.Checked = true;
                TK_Enabled_button.Checked = false;
                applyButton.Enabled = true;
                isChanged = true;
                foreach (Control c in telekinesis_box.Controls)
                {
                    if (c is RadioButton) { }
                    else
                    {
                        c.Enabled = false;
                    }
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
            p.printPdata();
            HOP.printHOPdata();
            EOP.printEOPdata();
            SOP.printSOPdata();
        }
        private void applySPSModuleSettingsChange()
        {
            if (SPS_Enabled_Button.Checked)
            {
                sps.setEnabled(true);
                if (Speaker_Enabled_button.Checked)
                {
                    sps.speaker_object.setEnabled(true);
                    sps.speaker_object.setVolume(volume_bar.Value);
                    Volume_Amount_lbl.Text = volume_bar.Value.ToString();

                }
                else { sps.speaker_object.setEnabled(false); }

                if (Strength_Enabled_Button.Checked)
                {
                    sps.strength_object.setEnabled(true);
                    sps.strength_object.setCurrentPower(Strength_bar.Value);

                }
                else { sps.strength_object.setEnabled(false); }
                if (TK_Enabled_button.Checked)
                {
                    sps.telekinesis_object.setEnabled(true);
                }
                else { sps.telekinesis_object.setEnabled(false); }
            }
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
    }
}