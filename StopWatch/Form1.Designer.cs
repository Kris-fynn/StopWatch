namespace StopWatch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.StartButton = new System.Windows.Forms.Button();
            this.ResetButton = new System.Windows.Forms.Button();
            this.PauseButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Timer2 = new System.Windows.Forms.Timer(this.components);
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Openbutton = new System.Windows.Forms.Button();
            this.redcheckBox = new System.Windows.Forms.CheckBox();
            this.greencheckBox2 = new System.Windows.Forms.CheckBox();
            this.whitecheckBox3 = new System.Windows.Forms.CheckBox();
            this.ReceiveLabel = new System.Windows.Forms.Label();
            this.BoderEnable = new System.Windows.Forms.Button();
            this.radioButton3D = new System.Windows.Forms.RadioButton();
            this.radioButtonSTD = new System.Windows.Forms.RadioButton();
            this.radioButtonTW = new System.Windows.Forms.RadioButton();
            this.BorderChangebutton = new System.Windows.Forms.Button();
            this.yellowcheckBox3 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.SystemColors.Info;
            this.label1.Name = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // StartButton
            // 
            this.StartButton.BackColor = System.Drawing.Color.DarkTurquoise;
            resources.ApplyResources(this.StartButton, "StartButton");
            this.StartButton.ForeColor = System.Drawing.SystemColors.Info;
            this.StartButton.Name = "StartButton";
            this.StartButton.UseVisualStyleBackColor = false;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // ResetButton
            // 
            this.ResetButton.BackColor = System.Drawing.Color.DarkKhaki;
            resources.ApplyResources(this.ResetButton, "ResetButton");
            this.ResetButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.UseVisualStyleBackColor = false;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // PauseButton
            // 
            this.PauseButton.BackColor = System.Drawing.Color.Firebrick;
            this.PauseButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            resources.ApplyResources(this.PauseButton, "PauseButton");
            this.PauseButton.ForeColor = System.Drawing.SystemColors.Info;
            this.PauseButton.Name = "PauseButton";
            this.PauseButton.UseVisualStyleBackColor = false;
            this.PauseButton.Click += new System.EventHandler(this.PauseButton_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Timer2
            // 
            this.Timer2.Interval = 1000;
            this.Timer2.Tick += new System.EventHandler(this.CountDownTimer_Tick);
            // 
            // dateTimePicker1
            // 
            resources.ApplyResources(this.dateTimePicker1, "dateTimePicker1");
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.ShowUpDown = true;
            // 
            // radioButton1
            // 
            resources.ApplyResources(this.radioButton1, "radioButton1");
            this.radioButton1.Checked = true;
            this.radioButton1.ForeColor = System.Drawing.Color.White;
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.TabStop = true;
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            resources.ApplyResources(this.radioButton2, "radioButton2");
            this.radioButton2.ForeColor = System.Drawing.Color.White;
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            resources.ApplyResources(this.comboBox1, "comboBox1");
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.DropDown += new System.EventHandler(this.comboBox1_DropDown);
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // comboBox2
            // 
            resources.ApplyResources(this.comboBox2, "comboBox2");
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            resources.GetString("comboBox2.Items"),
            resources.GetString("comboBox2.Items1"),
            resources.GetString("comboBox2.Items2")});
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // numericUpDown1
            // 
            resources.ApplyResources(this.numericUpDown1, "numericUpDown1");
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Name = "label2";
            this.label2.Click += new System.EventHandler(this.label2_Click_3);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Name = "label4";
            // 
            // Openbutton
            // 
            this.Openbutton.BackColor = System.Drawing.Color.Teal;
            resources.ApplyResources(this.Openbutton, "Openbutton");
            this.Openbutton.FlatAppearance.BorderSize = 0;
            this.Openbutton.Name = "Openbutton";
            this.Openbutton.UseVisualStyleBackColor = false;
            this.Openbutton.Click += new System.EventHandler(this.Openbutton_Click);
            // 
            // redcheckBox
            // 
            resources.ApplyResources(this.redcheckBox, "redcheckBox");
            this.redcheckBox.ForeColor = System.Drawing.Color.DarkRed;
            this.redcheckBox.Name = "redcheckBox";
            this.redcheckBox.UseVisualStyleBackColor = true;
            this.redcheckBox.CheckedChanged += new System.EventHandler(this.redcheckBox_CheckedChanged);
            // 
            // greencheckBox2
            // 
            resources.ApplyResources(this.greencheckBox2, "greencheckBox2");
            this.greencheckBox2.ForeColor = System.Drawing.Color.DarkGreen;
            this.greencheckBox2.Name = "greencheckBox2";
            this.greencheckBox2.UseVisualStyleBackColor = true;
            // 
            // whitecheckBox3
            // 
            resources.ApplyResources(this.whitecheckBox3, "whitecheckBox3");
            this.whitecheckBox3.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.whitecheckBox3.Name = "whitecheckBox3";
            this.whitecheckBox3.UseVisualStyleBackColor = true;
            // 
            // ReceiveLabel
            // 
            resources.ApplyResources(this.ReceiveLabel, "ReceiveLabel");
            this.ReceiveLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.ReceiveLabel.Name = "ReceiveLabel";
            this.ReceiveLabel.Click += new System.EventHandler(this.ReceiveLabel_Click);
            // 
            // BoderEnable
            // 
            this.BoderEnable.BackColor = System.Drawing.Color.Gray;
            resources.ApplyResources(this.BoderEnable, "BoderEnable");
            this.BoderEnable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.BoderEnable.Name = "BoderEnable";
            this.BoderEnable.UseVisualStyleBackColor = false;
            this.BoderEnable.Click += new System.EventHandler(this.button1_Click);
            // 
            // radioButton3D
            // 
            resources.ApplyResources(this.radioButton3D, "radioButton3D");
            this.radioButton3D.ForeColor = System.Drawing.Color.SteelBlue;
            this.radioButton3D.Name = "radioButton3D";
            this.radioButton3D.TabStop = true;
            this.radioButton3D.UseVisualStyleBackColor = true;
            // 
            // radioButtonSTD
            // 
            resources.ApplyResources(this.radioButtonSTD, "radioButtonSTD");
            this.radioButtonSTD.ForeColor = System.Drawing.Color.SteelBlue;
            this.radioButtonSTD.Name = "radioButtonSTD";
            this.radioButtonSTD.TabStop = true;
            this.radioButtonSTD.UseVisualStyleBackColor = true;
            // 
            // radioButtonTW
            // 
            resources.ApplyResources(this.radioButtonTW, "radioButtonTW");
            this.radioButtonTW.ForeColor = System.Drawing.Color.SteelBlue;
            this.radioButtonTW.Name = "radioButtonTW";
            this.radioButtonTW.TabStop = true;
            this.radioButtonTW.UseVisualStyleBackColor = true;
            // 
            // BorderChangebutton
            // 
            resources.ApplyResources(this.BorderChangebutton, "BorderChangebutton");
            this.BorderChangebutton.Name = "BorderChangebutton";
            this.BorderChangebutton.UseVisualStyleBackColor = true;
            this.BorderChangebutton.Click += new System.EventHandler(this.BorderChangebutton_Click);
            // 
            // yellowcheckBox3
            // 
            resources.ApplyResources(this.yellowcheckBox3, "yellowcheckBox3");
            this.yellowcheckBox3.ForeColor = System.Drawing.Color.Yellow;
            this.yellowcheckBox3.Name = "yellowcheckBox3";
            this.yellowcheckBox3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.Controls.Add(this.yellowcheckBox3);
            this.Controls.Add(this.BorderChangebutton);
            this.Controls.Add(this.radioButtonTW);
            this.Controls.Add(this.radioButtonSTD);
            this.Controls.Add(this.radioButton3D);
            this.Controls.Add(this.BoderEnable);
            this.Controls.Add(this.ReceiveLabel);
            this.Controls.Add(this.whitecheckBox3);
            this.Controls.Add(this.greencheckBox2);
            this.Controls.Add(this.redcheckBox);
            this.Controls.Add(this.Openbutton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.PauseButton);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Button PauseButton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer Timer2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Openbutton;
        private System.Windows.Forms.CheckBox redcheckBox;
        private System.Windows.Forms.CheckBox greencheckBox2;
        private System.Windows.Forms.CheckBox whitecheckBox3;
        private System.Windows.Forms.Label ReceiveLabel;
        private System.Windows.Forms.Button BoderEnable;
        private System.Windows.Forms.RadioButton radioButton3D;
        private System.Windows.Forms.RadioButton radioButtonSTD;
        private System.Windows.Forms.RadioButton radioButtonTW;
        private System.Windows.Forms.Button BorderChangebutton;
        private System.Windows.Forms.CheckBox yellowcheckBox3;
    }
}

