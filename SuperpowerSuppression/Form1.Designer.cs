namespace SuperpowerSuppression
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
            this.SPS_module_box = new System.Windows.Forms.GroupBox();
            this.Disabled_Button = new System.Windows.Forms.RadioButton();
            this.Enabled_Button = new System.Windows.Forms.RadioButton();
            this.speaker_box = new System.Windows.Forms.GroupBox();
            this.Speaker_Disabled_button = new System.Windows.Forms.RadioButton();
            this.Speaker_Enabled_button = new System.Windows.Forms.RadioButton();
            this.Current_Volume_text = new System.Windows.Forms.Label();
            this.volume_bar = new System.Windows.Forms.TrackBar();
            this.telekinesis_box = new System.Windows.Forms.GroupBox();
            this.TK_Disabled_button = new System.Windows.Forms.RadioButton();
            this.TK_Enabled_button = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.strength_box = new System.Windows.Forms.GroupBox();
            this.Strength_Disabled_Button = new System.Windows.Forms.RadioButton();
            this.Strength_Enabled_Button = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Strength_bar = new System.Windows.Forms.TrackBar();
            this.Volume_Amount_lbl = new System.Windows.Forms.Label();
            this.Volume_button = new System.Windows.Forms.Button();
            this.Volume_slider_lbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SPS_module_box.SuspendLayout();
            this.speaker_box.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.volume_bar)).BeginInit();
            this.telekinesis_box.SuspendLayout();
            this.strength_box.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Strength_bar)).BeginInit();
            this.SuspendLayout();
            // 
            // SPS_module_box
            // 
            this.SPS_module_box.BackColor = System.Drawing.SystemColors.ControlDark;
            this.SPS_module_box.Controls.Add(this.Disabled_Button);
            this.SPS_module_box.Controls.Add(this.Enabled_Button);
            this.SPS_module_box.Controls.Add(this.speaker_box);
            this.SPS_module_box.Controls.Add(this.telekinesis_box);
            this.SPS_module_box.Controls.Add(this.strength_box);
            this.SPS_module_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.SPS_module_box.Location = new System.Drawing.Point(12, 12);
            this.SPS_module_box.Name = "SPS_module_box";
            this.SPS_module_box.Size = new System.Drawing.Size(776, 224);
            this.SPS_module_box.TabIndex = 0;
            this.SPS_module_box.TabStop = false;
            this.SPS_module_box.Text = "Superpower Suppression Module";
            this.SPS_module_box.Enter += new System.EventHandler(this.SPS_Container_Enter);
            // 
            // Disabled_Button
            // 
            this.Disabled_Button.AutoSize = true;
            this.Disabled_Button.Checked = true;
            this.Disabled_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.Disabled_Button.Location = new System.Drawing.Point(6, 49);
            this.Disabled_Button.Name = "Disabled_Button";
            this.Disabled_Button.Size = new System.Drawing.Size(74, 19);
            this.Disabled_Button.TabIndex = 1;
            this.Disabled_Button.TabStop = true;
            this.Disabled_Button.Text = "Disabled";
            this.Disabled_Button.UseVisualStyleBackColor = true;
            this.Disabled_Button.Click += new System.EventHandler(this.Module_Disabled_button_Clicked);
            // 
            // Enabled_Button
            // 
            this.Enabled_Button.AutoSize = true;
            this.Enabled_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.Enabled_Button.Location = new System.Drawing.Point(6, 22);
            this.Enabled_Button.Name = "Enabled_Button";
            this.Enabled_Button.Size = new System.Drawing.Size(71, 19);
            this.Enabled_Button.TabIndex = 0;
            this.Enabled_Button.Text = "Enabled";
            this.Enabled_Button.UseVisualStyleBackColor = true;
            this.Enabled_Button.Click += new System.EventHandler(this.Module_Enabled_button_Clicked);
            // 
            // speaker_box
            // 
            this.speaker_box.Controls.Add(this.Volume_slider_lbl);
            this.speaker_box.Controls.Add(this.Volume_button);
            this.speaker_box.Controls.Add(this.Volume_Amount_lbl);
            this.speaker_box.Controls.Add(this.Speaker_Disabled_button);
            this.speaker_box.Controls.Add(this.Speaker_Enabled_button);
            this.speaker_box.Controls.Add(this.Current_Volume_text);
            this.speaker_box.Controls.Add(this.volume_bar);
            this.speaker_box.Location = new System.Drawing.Point(6, 77);
            this.speaker_box.Name = "speaker_box";
            this.speaker_box.Size = new System.Drawing.Size(243, 141);
            this.speaker_box.TabIndex = 10;
            this.speaker_box.TabStop = false;
            this.speaker_box.Text = "Speaker";
            // 
            // Speaker_Disabled_button
            // 
            this.Speaker_Disabled_button.AutoSize = true;
            this.Speaker_Disabled_button.Checked = true;
            this.Speaker_Disabled_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.Speaker_Disabled_button.Location = new System.Drawing.Point(83, 22);
            this.Speaker_Disabled_button.Name = "Speaker_Disabled_button";
            this.Speaker_Disabled_button.Size = new System.Drawing.Size(74, 19);
            this.Speaker_Disabled_button.TabIndex = 7;
            this.Speaker_Disabled_button.TabStop = true;
            this.Speaker_Disabled_button.Text = "Disabled";
            this.Speaker_Disabled_button.UseVisualStyleBackColor = true;
            this.Speaker_Disabled_button.Click += new System.EventHandler(this.Speaker_Disabled_button_Clicked);
            // 
            // Speaker_Enabled_button
            // 
            this.Speaker_Enabled_button.AutoSize = true;
            this.Speaker_Enabled_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.Speaker_Enabled_button.Location = new System.Drawing.Point(6, 22);
            this.Speaker_Enabled_button.Name = "Speaker_Enabled_button";
            this.Speaker_Enabled_button.Size = new System.Drawing.Size(71, 19);
            this.Speaker_Enabled_button.TabIndex = 6;
            this.Speaker_Enabled_button.Text = "Enabled";
            this.Speaker_Enabled_button.UseVisualStyleBackColor = true;
            this.Speaker_Enabled_button.Click += new System.EventHandler(this.Speaker_Enabled_button_Clicked);
            // 
            // Current_Volume_text
            // 
            this.Current_Volume_text.AutoSize = true;
            this.Current_Volume_text.Location = new System.Drawing.Point(6, 65);
            this.Current_Volume_text.Name = "Current_Volume_text";
            this.Current_Volume_text.Size = new System.Drawing.Size(120, 17);
            this.Current_Volume_text.TabIndex = 5;
            this.Current_Volume_text.Text = "Current Volume";
            // 
            // volume_bar
            // 
            this.volume_bar.LargeChange = 20;
            this.volume_bar.Location = new System.Drawing.Point(6, 90);
            this.volume_bar.Maximum = 100;
            this.volume_bar.Name = "volume_bar";
            this.volume_bar.Size = new System.Drawing.Size(176, 45);
            this.volume_bar.SmallChange = 5;
            this.volume_bar.TabIndex = 2;
            this.volume_bar.TickFrequency = 5;
            this.volume_bar.ValueChanged += new System.EventHandler(this.volume_bar_ValueChanged);
            // 
            // telekinesis_box
            // 
            this.telekinesis_box.Controls.Add(this.TK_Disabled_button);
            this.telekinesis_box.Controls.Add(this.TK_Enabled_button);
            this.telekinesis_box.Controls.Add(this.label5);
            this.telekinesis_box.Controls.Add(this.label4);
            this.telekinesis_box.Controls.Add(this.button1);
            this.telekinesis_box.Controls.Add(this.comboBox1);
            this.telekinesis_box.Location = new System.Drawing.Point(506, 18);
            this.telekinesis_box.Name = "telekinesis_box";
            this.telekinesis_box.Size = new System.Drawing.Size(264, 200);
            this.telekinesis_box.TabIndex = 12;
            this.telekinesis_box.TabStop = false;
            this.telekinesis_box.Text = "Telekinesis Stick";
            // 
            // TK_Disabled_button
            // 
            this.TK_Disabled_button.AutoSize = true;
            this.TK_Disabled_button.Checked = true;
            this.TK_Disabled_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.TK_Disabled_button.Location = new System.Drawing.Point(6, 51);
            this.TK_Disabled_button.Name = "TK_Disabled_button";
            this.TK_Disabled_button.Size = new System.Drawing.Size(74, 19);
            this.TK_Disabled_button.TabIndex = 11;
            this.TK_Disabled_button.TabStop = true;
            this.TK_Disabled_button.Text = "Disabled";
            this.TK_Disabled_button.UseVisualStyleBackColor = true;
            this.TK_Disabled_button.Click += new System.EventHandler(this.TK_Disabled_button_Clicked);
            // 
            // TK_Enabled_button
            // 
            this.TK_Enabled_button.AutoSize = true;
            this.TK_Enabled_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.TK_Enabled_button.Location = new System.Drawing.Point(6, 23);
            this.TK_Enabled_button.Name = "TK_Enabled_button";
            this.TK_Enabled_button.Size = new System.Drawing.Size(71, 19);
            this.TK_Enabled_button.TabIndex = 10;
            this.TK_Enabled_button.Text = "Enabled";
            this.TK_Enabled_button.UseVisualStyleBackColor = true;
            this.TK_Enabled_button.Click += new System.EventHandler(this.TK_Enabled_button_Clicked);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "label5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(122, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "label4";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(99, 59);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.comboBox1.Location = new System.Drawing.Point(198, 31);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(41, 24);
            this.comboBox1.TabIndex = 6;
            // 
            // strength_box
            // 
            this.strength_box.Controls.Add(this.button3);
            this.strength_box.Controls.Add(this.button2);
            this.strength_box.Controls.Add(this.label7);
            this.strength_box.Controls.Add(this.label6);
            this.strength_box.Controls.Add(this.label1);
            this.strength_box.Controls.Add(this.Strength_Disabled_Button);
            this.strength_box.Controls.Add(this.Strength_Enabled_Button);
            this.strength_box.Controls.Add(this.label3);
            this.strength_box.Controls.Add(this.label2);
            this.strength_box.Controls.Add(this.Strength_bar);
            this.strength_box.Location = new System.Drawing.Point(255, 18);
            this.strength_box.Name = "strength_box";
            this.strength_box.Size = new System.Drawing.Size(245, 200);
            this.strength_box.TabIndex = 11;
            this.strength_box.TabStop = false;
            this.strength_box.Text = "Super-Strength Nullifier";
            // 
            // Strength_Disabled_Button
            // 
            this.Strength_Disabled_Button.AutoSize = true;
            this.Strength_Disabled_Button.Checked = true;
            this.Strength_Disabled_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.Strength_Disabled_Button.Location = new System.Drawing.Point(7, 51);
            this.Strength_Disabled_Button.Name = "Strength_Disabled_Button";
            this.Strength_Disabled_Button.Size = new System.Drawing.Size(74, 19);
            this.Strength_Disabled_Button.TabIndex = 5;
            this.Strength_Disabled_Button.TabStop = true;
            this.Strength_Disabled_Button.Text = "Disabled";
            this.Strength_Disabled_Button.UseVisualStyleBackColor = true;
            this.Strength_Disabled_Button.Click += new System.EventHandler(this.Strength_Disabled_Button_Clicked);
            // 
            // Strength_Enabled_Button
            // 
            this.Strength_Enabled_Button.AutoSize = true;
            this.Strength_Enabled_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.Strength_Enabled_Button.Location = new System.Drawing.Point(7, 23);
            this.Strength_Enabled_Button.Name = "Strength_Enabled_Button";
            this.Strength_Enabled_Button.Size = new System.Drawing.Size(71, 19);
            this.Strength_Enabled_Button.TabIndex = 4;
            this.Strength_Enabled_Button.Text = "Enabled";
            this.Strength_Enabled_Button.UseVisualStyleBackColor = true;
            this.Strength_Enabled_Button.Click += new System.EventHandler(this.Strength_Enabled_Button_Clicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(113, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "label2";
            // 
            // Strength_bar
            // 
            this.Strength_bar.LargeChange = 50;
            this.Strength_bar.Location = new System.Drawing.Point(6, 103);
            this.Strength_bar.Maximum = 10000;
            this.Strength_bar.Name = "Strength_bar";
            this.Strength_bar.Size = new System.Drawing.Size(233, 45);
            this.Strength_bar.SmallChange = 5;
            this.Strength_bar.TabIndex = 1;
            this.Strength_bar.TickFrequency = 250;
            // 
            // Volume_Amount_lbl
            // 
            this.Volume_Amount_lbl.AutoSize = true;
            this.Volume_Amount_lbl.Location = new System.Drawing.Point(132, 65);
            this.Volume_Amount_lbl.Name = "Volume_Amount_lbl";
            this.Volume_Amount_lbl.Size = new System.Drawing.Size(17, 17);
            this.Volume_Amount_lbl.TabIndex = 8;
            this.Volume_Amount_lbl.Text = "0";
            // 
            // Volume_button
            // 
            this.Volume_button.Location = new System.Drawing.Point(180, 61);
            this.Volume_button.Name = "Volume_button";
            this.Volume_button.Size = new System.Drawing.Size(57, 23);
            this.Volume_button.TabIndex = 9;
            this.Volume_button.Text = "Set";
            this.Volume_button.UseVisualStyleBackColor = true;
            this.Volume_button.Click += new System.EventHandler(this.Volume_button_Click);
            // 
            // Volume_slider_lbl
            // 
            this.Volume_slider_lbl.AutoSize = true;
            this.Volume_slider_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Volume_slider_lbl.Location = new System.Drawing.Point(185, 92);
            this.Volume_slider_lbl.Name = "Volume_slider_lbl";
            this.Volume_slider_lbl.Size = new System.Drawing.Size(14, 15);
            this.Volume_slider_lbl.TabIndex = 10;
            this.Volume_slider_lbl.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(113, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "label1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "0 GW";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(177, 135);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "10,000 GW";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(9, 161);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(164, 161);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 10;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SPS_module_box);
            this.Name = "Form1";
            this.Text = "Form1";
            this.SPS_module_box.ResumeLayout(false);
            this.SPS_module_box.PerformLayout();
            this.speaker_box.ResumeLayout(false);
            this.speaker_box.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.volume_bar)).EndInit();
            this.telekinesis_box.ResumeLayout(false);
            this.telekinesis_box.PerformLayout();
            this.strength_box.ResumeLayout(false);
            this.strength_box.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Strength_bar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox SPS_module_box;
        private System.Windows.Forms.RadioButton Enabled_Button;
        private System.Windows.Forms.RadioButton Disabled_Button;
        private System.Windows.Forms.TrackBar volume_bar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox telekinesis_box;
        private System.Windows.Forms.GroupBox speaker_box;
        private System.Windows.Forms.Label Current_Volume_text;
        private System.Windows.Forms.GroupBox strength_box;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar Strength_bar;
        private System.Windows.Forms.RadioButton Strength_Disabled_Button;
        private System.Windows.Forms.RadioButton Strength_Enabled_Button;
        private System.Windows.Forms.RadioButton Speaker_Disabled_button;
        private System.Windows.Forms.RadioButton Speaker_Enabled_button;
        private System.Windows.Forms.RadioButton TK_Disabled_button;
        private System.Windows.Forms.RadioButton TK_Enabled_button;
        private System.Windows.Forms.Button Volume_button;
        private System.Windows.Forms.Label Volume_Amount_lbl;
        private System.Windows.Forms.Label Volume_slider_lbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
    }
}

