
namespace Superhero_Containment_Main
{
    partial class Settings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.okButton = new System.Windows.Forms.Button();
            this.appControl = new System.Windows.Forms.TabControl();
            this.tabPage_phantom = new System.Windows.Forms.TabPage();
            this.tabPage_SPS = new System.Windows.Forms.TabPage();
            this.tabPage_DNF = new System.Windows.Forms.TabPage();
            this.tabPage_defense = new System.Windows.Forms.TabPage();
            this.groupBox_defense = new System.Windows.Forms.GroupBox();
            this.def_alert_group = new System.Windows.Forms.GroupBox();
            this.def_alert_alarm_group = new System.Windows.Forms.GroupBox();
            this.def_alert_alarm_on = new System.Windows.Forms.CheckBox();
            this.def_alert_off = new System.Windows.Forms.RadioButton();
            this.def_alert_on = new System.Windows.Forms.RadioButton();
            this.def_tur_group = new System.Windows.Forms.GroupBox();
            this.def_tur_off = new System.Windows.Forms.RadioButton();
            this.def_tur_on = new System.Windows.Forms.RadioButton();
            this.def_w2_group = new System.Windows.Forms.GroupBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.label_def_w2_dt = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.trackBar_def_w2_dt = new System.Windows.Forms.TrackBar();
            this.def_w1_group = new System.Windows.Forms.GroupBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.label_def_w1_dt = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.trackBar_def_w1_dt = new System.Windows.Forms.TrackBar();
            this.def_off = new System.Windows.Forms.RadioButton();
            this.def_on = new System.Windows.Forms.RadioButton();
            this.cancelButton = new System.Windows.Forms.Button();
            this.applyButton = new System.Windows.Forms.Button();
            this.appControl.SuspendLayout();
            this.tabPage_defense.SuspendLayout();
            this.groupBox_defense.SuspendLayout();
            this.def_alert_group.SuspendLayout();
            this.def_alert_alarm_group.SuspendLayout();
            this.def_tur_group.SuspendLayout();
            this.def_w2_group.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_def_w2_dt)).BeginInit();
            this.def_w1_group.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_def_w1_dt)).BeginInit();
            this.SuspendLayout();
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(259, 450);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 0;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // appControl
            // 
            this.appControl.Controls.Add(this.tabPage_phantom);
            this.appControl.Controls.Add(this.tabPage_SPS);
            this.appControl.Controls.Add(this.tabPage_DNF);
            this.appControl.Controls.Add(this.tabPage_defense);
            this.appControl.Location = new System.Drawing.Point(12, 12);
            this.appControl.Name = "appControl";
            this.appControl.SelectedIndex = 0;
            this.appControl.Size = new System.Drawing.Size(484, 432);
            this.appControl.TabIndex = 1;
            // 
            // tabPage_phantom
            // 
            this.tabPage_phantom.Location = new System.Drawing.Point(4, 22);
            this.tabPage_phantom.Name = "tabPage_phantom";
            this.tabPage_phantom.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_phantom.Size = new System.Drawing.Size(476, 406);
            this.tabPage_phantom.TabIndex = 0;
            this.tabPage_phantom.Text = "Phantom Module";
            this.tabPage_phantom.UseVisualStyleBackColor = true;
            // 
            // tabPage_SPS
            // 
            this.tabPage_SPS.Location = new System.Drawing.Point(4, 22);
            this.tabPage_SPS.Name = "tabPage_SPS";
            this.tabPage_SPS.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_SPS.Size = new System.Drawing.Size(476, 406);
            this.tabPage_SPS.TabIndex = 1;
            this.tabPage_SPS.Text = "Superpower Suppression Module";
            this.tabPage_SPS.UseVisualStyleBackColor = true;
            // 
            // tabPage_DNF
            // 
            this.tabPage_DNF.Location = new System.Drawing.Point(4, 22);
            this.tabPage_DNF.Name = "tabPage_DNF";
            this.tabPage_DNF.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_DNF.Size = new System.Drawing.Size(476, 406);
            this.tabPage_DNF.TabIndex = 2;
            this.tabPage_DNF.Text = "Doors and Floors Module";
            this.tabPage_DNF.UseVisualStyleBackColor = true;
            // 
            // tabPage_defense
            // 
            this.tabPage_defense.Controls.Add(this.groupBox_defense);
            this.tabPage_defense.Location = new System.Drawing.Point(4, 22);
            this.tabPage_defense.Name = "tabPage_defense";
            this.tabPage_defense.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_defense.Size = new System.Drawing.Size(476, 406);
            this.tabPage_defense.TabIndex = 3;
            this.tabPage_defense.Text = "Defense Module";
            this.tabPage_defense.UseVisualStyleBackColor = true;
            // 
            // groupBox_defense
            // 
            this.groupBox_defense.Controls.Add(this.def_alert_group);
            this.groupBox_defense.Controls.Add(this.def_tur_group);
            this.groupBox_defense.Controls.Add(this.def_off);
            this.groupBox_defense.Controls.Add(this.def_on);
            this.groupBox_defense.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_defense.Location = new System.Drawing.Point(6, 6);
            this.groupBox_defense.Name = "groupBox_defense";
            this.groupBox_defense.Size = new System.Drawing.Size(464, 394);
            this.groupBox_defense.TabIndex = 0;
            this.groupBox_defense.TabStop = false;
            this.groupBox_defense.Text = "Defense Module";
            // 
            // def_alert_group
            // 
            this.def_alert_group.Controls.Add(this.def_alert_alarm_group);
            this.def_alert_group.Controls.Add(this.def_alert_off);
            this.def_alert_group.Controls.Add(this.def_alert_on);
            this.def_alert_group.Location = new System.Drawing.Point(6, 321);
            this.def_alert_group.Name = "def_alert_group";
            this.def_alert_group.Size = new System.Drawing.Size(452, 67);
            this.def_alert_group.TabIndex = 3;
            this.def_alert_group.TabStop = false;
            this.def_alert_group.Text = "Alert System";
            // 
            // def_alert_alarm_group
            // 
            this.def_alert_alarm_group.Controls.Add(this.def_alert_alarm_on);
            this.def_alert_alarm_group.Location = new System.Drawing.Point(272, 19);
            this.def_alert_alarm_group.Name = "def_alert_alarm_group";
            this.def_alert_alarm_group.Size = new System.Drawing.Size(174, 42);
            this.def_alert_alarm_group.TabIndex = 3;
            this.def_alert_alarm_group.TabStop = false;
            this.def_alert_alarm_group.Text = "Alarm";
            // 
            // def_alert_alarm_on
            // 
            this.def_alert_alarm_on.AutoSize = true;
            this.def_alert_alarm_on.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.def_alert_alarm_on.Location = new System.Drawing.Point(6, 19);
            this.def_alert_alarm_on.Name = "def_alert_alarm_on";
            this.def_alert_alarm_on.Size = new System.Drawing.Size(88, 17);
            this.def_alert_alarm_on.TabIndex = 2;
            this.def_alert_alarm_on.Text = "Enable Alarm";
            this.def_alert_alarm_on.UseVisualStyleBackColor = true;
            this.def_alert_alarm_on.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // def_alert_off
            // 
            this.def_alert_off.AutoSize = true;
            this.def_alert_off.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.def_alert_off.Location = new System.Drawing.Point(76, 19);
            this.def_alert_off.Name = "def_alert_off";
            this.def_alert_off.Size = new System.Drawing.Size(66, 17);
            this.def_alert_off.TabIndex = 1;
            this.def_alert_off.TabStop = true;
            this.def_alert_off.Text = "Disabled";
            this.def_alert_off.UseVisualStyleBackColor = true;
            this.def_alert_off.CheckedChanged += new System.EventHandler(this.def_alert_off_CheckedChanged);
            // 
            // def_alert_on
            // 
            this.def_alert_on.AutoSize = true;
            this.def_alert_on.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.def_alert_on.Location = new System.Drawing.Point(6, 19);
            this.def_alert_on.Name = "def_alert_on";
            this.def_alert_on.Size = new System.Drawing.Size(64, 17);
            this.def_alert_on.TabIndex = 0;
            this.def_alert_on.TabStop = true;
            this.def_alert_on.Text = "Enabled";
            this.def_alert_on.UseVisualStyleBackColor = true;
            this.def_alert_on.CheckedChanged += new System.EventHandler(this.def_alert_on_CheckedChanged);
            // 
            // def_tur_group
            // 
            this.def_tur_group.Controls.Add(this.def_tur_off);
            this.def_tur_group.Controls.Add(this.def_tur_on);
            this.def_tur_group.Controls.Add(this.def_w2_group);
            this.def_tur_group.Controls.Add(this.def_w1_group);
            this.def_tur_group.Location = new System.Drawing.Point(6, 49);
            this.def_tur_group.Name = "def_tur_group";
            this.def_tur_group.Size = new System.Drawing.Size(452, 266);
            this.def_tur_group.TabIndex = 2;
            this.def_tur_group.TabStop = false;
            this.def_tur_group.Text = "Turret System";
            // 
            // def_tur_off
            // 
            this.def_tur_off.AutoSize = true;
            this.def_tur_off.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.def_tur_off.Location = new System.Drawing.Point(76, 19);
            this.def_tur_off.Name = "def_tur_off";
            this.def_tur_off.Size = new System.Drawing.Size(66, 17);
            this.def_tur_off.TabIndex = 3;
            this.def_tur_off.TabStop = true;
            this.def_tur_off.Text = "Disabled";
            this.def_tur_off.UseVisualStyleBackColor = true;
            this.def_tur_off.CheckedChanged += new System.EventHandler(this.def_tur_off_CheckedChanged);
            // 
            // def_tur_on
            // 
            this.def_tur_on.AutoSize = true;
            this.def_tur_on.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.def_tur_on.Location = new System.Drawing.Point(6, 19);
            this.def_tur_on.Name = "def_tur_on";
            this.def_tur_on.Size = new System.Drawing.Size(64, 17);
            this.def_tur_on.TabIndex = 2;
            this.def_tur_on.TabStop = true;
            this.def_tur_on.Text = "Enabled";
            this.def_tur_on.UseVisualStyleBackColor = true;
            this.def_tur_on.CheckedChanged += new System.EventHandler(this.def_tur_on_CheckedChanged);
            // 
            // def_w2_group
            // 
            this.def_w2_group.Controls.Add(this.checkBox2);
            this.def_w2_group.Controls.Add(this.label_def_w2_dt);
            this.def_w2_group.Controls.Add(this.label2);
            this.def_w2_group.Controls.Add(this.trackBar_def_w2_dt);
            this.def_w2_group.Location = new System.Drawing.Point(6, 154);
            this.def_w2_group.Name = "def_w2_group";
            this.def_w2_group.Size = new System.Drawing.Size(440, 106);
            this.def_w2_group.TabIndex = 1;
            this.def_w2_group.TabStop = false;
            this.def_w2_group.Text = "Weapon: Secondary";
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2.Location = new System.Drawing.Point(118, 19);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(141, 17);
            this.checkBox2.TabIndex = 3;
            this.checkBox2.Text = "Enable Durability Sensor";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // label_def_w2_dt
            // 
            this.label_def_w2_dt.AutoSize = true;
            this.label_def_w2_dt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_def_w2_dt.Location = new System.Drawing.Point(115, 39);
            this.label_def_w2_dt.Name = "label_def_w2_dt";
            this.label_def_w2_dt.Size = new System.Drawing.Size(35, 13);
            this.label_def_w2_dt.TabIndex = 2;
            this.label_def_w2_dt.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Durability Threshold:";
            // 
            // trackBar_def_w2_dt
            // 
            this.trackBar_def_w2_dt.Location = new System.Drawing.Point(118, 55);
            this.trackBar_def_w2_dt.Maximum = 100;
            this.trackBar_def_w2_dt.Name = "trackBar_def_w2_dt";
            this.trackBar_def_w2_dt.Size = new System.Drawing.Size(209, 45);
            this.trackBar_def_w2_dt.TabIndex = 0;
            this.trackBar_def_w2_dt.Scroll += new System.EventHandler(this.trackBar_def_w2_dt_Scroll);
            // 
            // def_w1_group
            // 
            this.def_w1_group.Controls.Add(this.checkBox3);
            this.def_w1_group.Controls.Add(this.label_def_w1_dt);
            this.def_w1_group.Controls.Add(this.label1);
            this.def_w1_group.Controls.Add(this.trackBar_def_w1_dt);
            this.def_w1_group.Location = new System.Drawing.Point(6, 42);
            this.def_w1_group.Name = "def_w1_group";
            this.def_w1_group.Size = new System.Drawing.Size(440, 106);
            this.def_w1_group.TabIndex = 0;
            this.def_w1_group.TabStop = false;
            this.def_w1_group.Text = "Weapon: Primary";
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox3.Location = new System.Drawing.Point(118, 83);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(141, 17);
            this.checkBox3.TabIndex = 3;
            this.checkBox3.Text = "Enable Durability Sensor";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // label_def_w1_dt
            // 
            this.label_def_w1_dt.AutoSize = true;
            this.label_def_w1_dt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_def_w1_dt.Location = new System.Drawing.Point(115, 16);
            this.label_def_w1_dt.Name = "label_def_w1_dt";
            this.label_def_w1_dt.Size = new System.Drawing.Size(35, 13);
            this.label_def_w1_dt.TabIndex = 2;
            this.label_def_w1_dt.Text = "label4";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Durability Threshold:";
            // 
            // trackBar_def_w1_dt
            // 
            this.trackBar_def_w1_dt.Location = new System.Drawing.Point(118, 32);
            this.trackBar_def_w1_dt.Maximum = 100;
            this.trackBar_def_w1_dt.Name = "trackBar_def_w1_dt";
            this.trackBar_def_w1_dt.Size = new System.Drawing.Size(209, 45);
            this.trackBar_def_w1_dt.TabIndex = 0;
            this.trackBar_def_w1_dt.Scroll += new System.EventHandler(this.trackBar_def_w1_dt_Scroll);
            // 
            // def_off
            // 
            this.def_off.AutoSize = true;
            this.def_off.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.def_off.Location = new System.Drawing.Point(76, 19);
            this.def_off.Name = "def_off";
            this.def_off.Size = new System.Drawing.Size(66, 17);
            this.def_off.TabIndex = 1;
            this.def_off.TabStop = true;
            this.def_off.Text = "Disabled";
            this.def_off.UseVisualStyleBackColor = true;
            this.def_off.CheckedChanged += new System.EventHandler(this.def_off_CheckedChanged);
            // 
            // def_on
            // 
            this.def_on.AutoSize = true;
            this.def_on.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.def_on.Location = new System.Drawing.Point(6, 19);
            this.def_on.Name = "def_on";
            this.def_on.Size = new System.Drawing.Size(64, 17);
            this.def_on.TabIndex = 0;
            this.def_on.TabStop = true;
            this.def_on.Text = "Enabled";
            this.def_on.UseVisualStyleBackColor = true;
            this.def_on.CheckedChanged += new System.EventHandler(this.def_on_CheckedChanged);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(340, 450);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 2;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // applyButton
            // 
            this.applyButton.Enabled = false;
            this.applyButton.Location = new System.Drawing.Point(421, 450);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(75, 23);
            this.applyButton.TabIndex = 3;
            this.applyButton.Text = "Apply";
            this.applyButton.UseVisualStyleBackColor = true;
            this.applyButton.Click += new System.EventHandler(this.applyButton_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 485);
            this.ControlBox = false;
            this.Controls.Add(this.applyButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.appControl);
            this.Controls.Add(this.okButton);
            this.MaximizeBox = false;
            this.Name = "Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.appControl.ResumeLayout(false);
            this.tabPage_defense.ResumeLayout(false);
            this.groupBox_defense.ResumeLayout(false);
            this.groupBox_defense.PerformLayout();
            this.def_alert_group.ResumeLayout(false);
            this.def_alert_group.PerformLayout();
            this.def_alert_alarm_group.ResumeLayout(false);
            this.def_alert_alarm_group.PerformLayout();
            this.def_tur_group.ResumeLayout(false);
            this.def_tur_group.PerformLayout();
            this.def_w2_group.ResumeLayout(false);
            this.def_w2_group.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_def_w2_dt)).EndInit();
            this.def_w1_group.ResumeLayout(false);
            this.def_w1_group.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_def_w1_dt)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.TabControl appControl;
        private System.Windows.Forms.TabPage tabPage_phantom;
        private System.Windows.Forms.TabPage tabPage_SPS;
        private System.Windows.Forms.TabPage tabPage_DNF;
        private System.Windows.Forms.TabPage tabPage_defense;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button applyButton;
        private System.Windows.Forms.GroupBox groupBox_defense;
        private System.Windows.Forms.RadioButton def_off;
        private System.Windows.Forms.RadioButton def_on;
        private System.Windows.Forms.GroupBox def_alert_group;
        private System.Windows.Forms.GroupBox def_tur_group;
        private System.Windows.Forms.GroupBox def_w2_group;
        private System.Windows.Forms.GroupBox def_w1_group;
        private System.Windows.Forms.CheckBox def_alert_alarm_on;
        private System.Windows.Forms.RadioButton def_alert_off;
        private System.Windows.Forms.RadioButton def_alert_on;
        private System.Windows.Forms.RadioButton def_tur_off;
        private System.Windows.Forms.RadioButton def_tur_on;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar trackBar_def_w2_dt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar trackBar_def_w1_dt;
        private System.Windows.Forms.GroupBox def_alert_alarm_group;
        private System.Windows.Forms.Label label_def_w2_dt;
        private System.Windows.Forms.Label label_def_w1_dt;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
    }
}