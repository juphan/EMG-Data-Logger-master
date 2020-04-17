﻿namespace EMG_Logger
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PredictionBox = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.StartButton = new System.Windows.Forms.Button();
            this.Pdata = new System.Windows.Forms.TextBox();
            this.serialPort2 = new System.IO.Ports.SerialPort(this.components);
            this.label14 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.Arduino = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.PredictionBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox4);
            this.groupBox1.Controls.Add(this.comboBox3);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox1.Location = new System.Drawing.Point(35, 32);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(1);
            this.groupBox1.Size = new System.Drawing.Size(848, 193);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Connect to Tiva Board";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 131);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Output File Name";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(6, 153);
            this.textBox2.Margin = new System.Windows.Forms.Padding(1);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(351, 26);
            this.textBox2.TabIndex = 6;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(497, 117);
            this.button4.Margin = new System.Windows.Forms.Padding(1);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(304, 49);
            this.button4.TabIndex = 5;
            this.button4.Text = "Stop Logging";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(497, 117);
            this.button3.Margin = new System.Windows.Forms.Padding(1);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(304, 49);
            this.button3.TabIndex = 4;
            this.button3.Text = "Start Logging";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "9600",
            "115200"});
            this.comboBox2.Location = new System.Drawing.Point(232, 39);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(1);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(137, 28);
            this.comboBox2.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(664, 39);
            this.button2.Margin = new System.Windows.Forms.Padding(1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(137, 57);
            this.button2.TabIndex = 2;
            this.button2.Text = "Disconnect";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(497, 39);
            this.button1.Margin = new System.Windows.Forms.Padding(1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 57);
            this.button1.TabIndex = 1;
            this.button1.Text = "Connect";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(19, 42);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(1);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(152, 28);
            this.comboBox1.TabIndex = 0;
            // 
            // serialPort1
            // 
            this.serialPort1.BaudRate = 115200;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(35, 236);
            this.textBox1.Margin = new System.Windows.Forms.Padding(1);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(848, 46);
            this.textBox1.TabIndex = 2;
            // 
            // timer1
            // 
            this.timer1.Interval = 220;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(35, 296);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(852, 146);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Timer";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(503, 47);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 58);
            this.label6.TabIndex = 4;
            this.label6.Text = ":";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(345, 47);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 58);
            this.label5.TabIndex = 3;
            this.label5.Text = ":";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(544, 37);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 76);
            this.label4.TabIndex = 2;
            this.label4.Text = "00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(387, 37);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 76);
            this.label3.TabIndex = 1;
            this.label3.Text = "00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(229, 37);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 76);
            this.label2.TabIndex = 0;
            this.label2.Text = "00";
            // 
            // PredictionBox
            // 
            this.PredictionBox.Controls.Add(this.label13);
            this.PredictionBox.Controls.Add(this.label12);
            this.PredictionBox.Controls.Add(this.label11);
            this.PredictionBox.Controls.Add(this.label10);
            this.PredictionBox.Controls.Add(this.label9);
            this.PredictionBox.Controls.Add(this.label8);
            this.PredictionBox.Controls.Add(this.label7);
            this.PredictionBox.Controls.Add(this.StartButton);
            this.PredictionBox.Controls.Add(this.Pdata);
            this.PredictionBox.Location = new System.Drawing.Point(35, 449);
            this.PredictionBox.Name = "PredictionBox";
            this.PredictionBox.Size = new System.Drawing.Size(594, 285);
            this.PredictionBox.TabIndex = 5;
            this.PredictionBox.TabStop = false;
            this.PredictionBox.Text = "Prediction";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label13.Location = new System.Drawing.Point(375, 212);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(76, 20);
            this.label13.TabIndex = 8;
            this.label13.Text = "7 = Okay";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label12.Location = new System.Drawing.Point(375, 192);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(76, 20);
            this.label12.TabIndex = 7;
            this.label12.Text = "6 = Point";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label11.Location = new System.Drawing.Point(375, 175);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(112, 20);
            this.label11.TabIndex = 6;
            this.label11.Text = "5 = Wave Out";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label10.Location = new System.Drawing.Point(375, 158);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(98, 20);
            this.label10.TabIndex = 5;
            this.label10.Text = "4 = Wave In";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label9.Location = new System.Drawing.Point(375, 136);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(119, 20);
            this.label9.TabIndex = 4;
            this.label9.Text = "3 = Open hand";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label8.Location = new System.Drawing.Point(374, 116);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 20);
            this.label8.TabIndex = 3;
            this.label8.Text = "2 = Rest";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.Location = new System.Drawing.Point(374, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 20);
            this.label7.TabIndex = 2;
            this.label7.Text = "1 = Fist";
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(378, 31);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(116, 50);
            this.StartButton.TabIndex = 1;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // Pdata
            // 
            this.Pdata.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.Pdata.Location = new System.Drawing.Point(6, 31);
            this.Pdata.Multiline = true;
            this.Pdata.Name = "Pdata";
            this.Pdata.Size = new System.Drawing.Size(347, 212);
            this.Pdata.TabIndex = 0;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(15, 76);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(152, 20);
            this.label14.TabIndex = 8;
            this.label14.Text = "Connect to Arduino";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(19, 99);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(152, 28);
            this.comboBox3.TabIndex = 9;
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "9600"});
            this.comboBox4.Location = new System.Drawing.Point(232, 99);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(152, 28);
            this.comboBox4.TabIndex = 10;
            // 
            // Arduino
            // 
            this.Arduino.Location = new System.Drawing.Point(651, 466);
            this.Arduino.Multiline = true;
            this.Arduino.Name = "Arduino";
            this.Arduino.Size = new System.Drawing.Size(311, 257);
            this.Arduino.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 772);
            this.Controls.Add(this.Arduino);
            this.Controls.Add(this.PredictionBox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "Form1";
            this.Text = "TIVA EMG Logger";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.PredictionBox.ResumeLayout(false);
            this.PredictionBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox PredictionBox;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.TextBox Pdata;
        private System.IO.Ports.SerialPort serialPort2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.TextBox Arduino;
    }
}

