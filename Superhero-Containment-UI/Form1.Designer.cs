
namespace Superhero_Containment_UI
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.defenseON = new System.Windows.Forms.RadioButton();
            this.defenseOFF = new System.Windows.Forms.RadioButton();
            this.Defense_Module = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.defenseStatus = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.turretOFF = new System.Windows.Forms.RadioButton();
            this.turretON = new System.Windows.Forms.RadioButton();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.durabilityLabel = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.exitButton = new System.Windows.Forms.Button();
            this.durabilitySensorTimer = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.radioButton8 = new System.Windows.Forms.RadioButton();
            this.button2 = new System.Windows.Forms.Button();
            this.Defense_Module.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // defenseON
            // 
            this.defenseON.AutoSize = true;
            this.defenseON.Location = new System.Drawing.Point(627, 15);
            this.defenseON.Name = "defenseON";
            this.defenseON.Size = new System.Drawing.Size(41, 17);
            this.defenseON.TabIndex = 0;
            this.defenseON.TabStop = true;
            this.defenseON.Text = "ON";
            this.defenseON.UseVisualStyleBackColor = true;
            this.defenseON.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // defenseOFF
            // 
            this.defenseOFF.AutoSize = true;
            this.defenseOFF.Location = new System.Drawing.Point(674, 15);
            this.defenseOFF.Name = "defenseOFF";
            this.defenseOFF.Size = new System.Drawing.Size(45, 17);
            this.defenseOFF.TabIndex = 1;
            this.defenseOFF.TabStop = true;
            this.defenseOFF.Text = "OFF";
            this.defenseOFF.UseVisualStyleBackColor = true;
            this.defenseOFF.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // Defense_Module
            // 
            this.Defense_Module.Controls.Add(this.groupBox6);
            this.Defense_Module.Controls.Add(this.defenseStatus);
            this.Defense_Module.Controls.Add(this.groupBox3);
            this.Defense_Module.Controls.Add(this.defenseON);
            this.Defense_Module.Controls.Add(this.durabilityLabel);
            this.Defense_Module.Controls.Add(this.defenseOFF);
            this.Defense_Module.Location = new System.Drawing.Point(825, 465);
            this.Defense_Module.Name = "Defense_Module";
            this.Defense_Module.Size = new System.Drawing.Size(725, 385);
            this.Defense_Module.TabIndex = 2;
            this.Defense_Module.TabStop = false;
            this.Defense_Module.Text = "Defense Module";
            this.Defense_Module.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.groupBox9);
            this.groupBox6.Location = new System.Drawing.Point(365, 30);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(350, 345);
            this.groupBox6.TabIndex = 8;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Alert System";
            // 
            // groupBox9
            // 
            this.groupBox9.Location = new System.Drawing.Point(10, 185);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(330, 150);
            this.groupBox9.TabIndex = 0;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Alarm System";
            // 
            // defenseStatus
            // 
            this.defenseStatus.AutoSize = true;
            this.defenseStatus.Location = new System.Drawing.Point(349, 16);
            this.defenseStatus.Name = "defenseStatus";
            this.defenseStatus.Size = new System.Drawing.Size(37, 13);
            this.defenseStatus.TabIndex = 7;
            this.defenseStatus.Text = "Status";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox8);
            this.groupBox3.Controls.Add(this.turretOFF);
            this.groupBox3.Controls.Add(this.turretON);
            this.groupBox3.Controls.Add(this.groupBox7);
            this.groupBox3.Location = new System.Drawing.Point(10, 30);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(350, 345);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Turret System";
            // 
            // groupBox8
            // 
            this.groupBox8.Location = new System.Drawing.Point(10, 185);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(330, 150);
            this.groupBox8.TabIndex = 3;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Weapon: Secondary";
            this.groupBox8.Enter += new System.EventHandler(this.groupBox8_Enter);
            // 
            // turretOFF
            // 
            this.turretOFF.AutoSize = true;
            this.turretOFF.Location = new System.Drawing.Point(299, 19);
            this.turretOFF.Name = "turretOFF";
            this.turretOFF.Size = new System.Drawing.Size(45, 17);
            this.turretOFF.TabIndex = 2;
            this.turretOFF.TabStop = true;
            this.turretOFF.Text = "OFF";
            this.turretOFF.UseVisualStyleBackColor = true;
            // 
            // turretON
            // 
            this.turretON.AutoSize = true;
            this.turretON.Location = new System.Drawing.Point(252, 19);
            this.turretON.Name = "turretON";
            this.turretON.Size = new System.Drawing.Size(41, 17);
            this.turretON.TabIndex = 1;
            this.turretON.TabStop = true;
            this.turretON.Text = "ON";
            this.turretON.UseVisualStyleBackColor = true;
            // 
            // groupBox7
            // 
            this.groupBox7.Location = new System.Drawing.Point(10, 30);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(330, 150);
            this.groupBox7.TabIndex = 0;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Weapon: Primary";
            // 
            // durabilityLabel
            // 
            this.durabilityLabel.AutoSize = true;
            this.durabilityLabel.Location = new System.Drawing.Point(430, 16);
            this.durabilityLabel.Name = "durabilityLabel";
            this.durabilityLabel.Size = new System.Drawing.Size(35, 13);
            this.durabilityLabel.TabIndex = 5;
            this.durabilityLabel.Text = "label1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton4);
            this.groupBox2.Controls.Add(this.radioButton3);
            this.groupBox2.Location = new System.Drawing.Point(50, 50);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(725, 385);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Phantom Module";
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(67, 58);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(85, 17);
            this.radioButton4.TabIndex = 1;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "radioButton4";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(67, 35);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(85, 17);
            this.radioButton3.TabIndex = 0;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "radioButton3";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(1513, 865);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // durabilitySensorTimer
            // 
            this.durabilitySensorTimer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.radioButton5);
            this.groupBox1.Controls.Add(this.radioButton6);
            this.groupBox1.Location = new System.Drawing.Point(825, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(725, 385);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Superpower Suppression Module";
            // 
            // groupBox4
            // 
            this.groupBox4.Location = new System.Drawing.Point(223, 143);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 100);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "groupBox4";
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(53, 28);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(85, 17);
            this.radioButton5.TabIndex = 0;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "radioButton5";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(53, 51);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(85, 17);
            this.radioButton6.TabIndex = 1;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "radioButton6";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.radioButton7);
            this.groupBox5.Controls.Add(this.radioButton8);
            this.groupBox5.Location = new System.Drawing.Point(50, 465);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(725, 385);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "DoorNFloor Module";
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.Location = new System.Drawing.Point(67, 58);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(85, 17);
            this.radioButton7.TabIndex = 1;
            this.radioButton7.TabStop = true;
            this.radioButton7.Text = "radioButton7";
            this.radioButton7.UseVisualStyleBackColor = true;
            // 
            // radioButton8
            // 
            this.radioButton8.AutoSize = true;
            this.radioButton8.Location = new System.Drawing.Point(67, 35);
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.Size = new System.Drawing.Size(85, 17);
            this.radioButton8.TabIndex = 0;
            this.radioButton8.TabStop = true;
            this.radioButton8.Text = "radioButton8";
            this.radioButton8.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(746, 865);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Config";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1600, 900);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.Defense_Module);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Defense_Module.ResumeLayout(false);
            this.Defense_Module.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton defenseON;
        private System.Windows.Forms.RadioButton defenseOFF;
        private System.Windows.Forms.GroupBox Defense_Module;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Timer durabilitySensorTimer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton radioButton7;
        private System.Windows.Forms.RadioButton radioButton8;
        private System.Windows.Forms.Label defenseStatus;
        private System.Windows.Forms.Label durabilityLabel;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.RadioButton turretOFF;
        private System.Windows.Forms.RadioButton turretON;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Button button2;
    }
}

