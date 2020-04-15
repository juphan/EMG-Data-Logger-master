﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;
using System.Timers;

namespace EMG_Logger
{
    public partial class Form1 : Form
    {
        string path = System.Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\\DataSync_JP\\DefaultNoNameOutputFile.csv";
        string FilePath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\\DataSync_JP\\";
        private DateTime datetime;

        StreamWriter sw;
        bool logging_data = false;
        string temp = null;
        string in_data;
        string outdata;
        
        

        int _hours = 0;
        int _minutes = 0;
        int _seconds = 0;

        public Form1()
        {
            InitializeComponent();
            getAvailablePorts();
            button1.Enabled = true;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Visible = false;
            StartButton.Enabled = false;
            ARConnect.Enabled = true;
            ARDisconnect.Enabled = false;
            serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(DataReceived);
            serialPort2.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(DataReceived);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        void getAvailablePorts()
        {
            // Get the available COM Ports and put them in the ComboBox1
            String[] ports = SerialPort.GetPortNames();
            comboBox1.Items.AddRange(ports);
            comboBox3.Items.AddRange(ports);

        }

        private void DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            if(logging_data)
            {
                try
                {
                    temp = serialPort1.ReadLine();
                    if(logging_data)
                        sw.WriteLine(temp);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("The last line of the CSV file may be missing.");
                }
            }
            else
            {
                in_data = serialPort1.ReadLine();
                this.Invoke(new EventHandler(display_event));
              
            }
        }

        private void display_event(object sender, EventArgs e)
        {
            datetime = DateTime.Now;
            string time = datetime.Hour + ":" + datetime.Minute + ":" + datetime.Second;
            // if(in_data == "6")
            // {
            //   Pdata.Text = time + "\t\t" + "Point" + "\n";
            // }
            // else if(in_data == "7")
            // {
            //   Pdata.Text = time + "\t\t" + "Okay" + "\n";
            // }
            Pdata.Text = time + "\t\t" + in_data + "\n";
            outdata = in_data;
        }




        //Connect to Tiva
        private void button1_Click(object sender, EventArgs e)
        {
            // Connect to COM Port
            try
            {
                if (comboBox1.Text == "" || comboBox2.Text == "")
                {
                    textBox1.Text = "Please select port settings.";
                }
                else
                {
                    // Setup settings for the serial port
                    serialPort1.PortName = comboBox1.Text;
                    serialPort1.BaudRate = Convert.ToInt32(comboBox2.Text);
                    serialPort1.Parity = Parity.None;
                    serialPort1.StopBits = StopBits.One;
                    serialPort1.DataBits = 8;
                    try
                    {
                        if (!serialPort1.IsOpen)
                            serialPort1.Open();
                    }
                    catch (Exception ex)
                    {
                        textBox1.Text = "Error";
                    }

                    // Setup timer
                    timer1.Interval = 275;
                    
                    // Change button access
                    button1.Enabled = false;
                    button2.Enabled = true;
                    button3.Enabled = true;
                    textBox1.Enabled = true;
                    StartButton.Enabled = false;
                }
            }
            catch(UnauthorizedAccessException)
            {
                textBox1.Text = "Unauthorized Access";
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Disconnect from COM Port
            logging_data = false;
            serialPort1.Close();
            button1.Enabled = true;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            try
            {
                sw.Close();
            }
            catch (Exception ex)
            {

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Send everything in the buffer to the Excel file every 275 ms
            timer1.Stop();
            timer1.Enabled = false;
            logging_data = !logging_data;

            if (!logging_data)
            {
                try
                {
                    sw.Close();
                }
                catch
                {
                    textBox1.Text = "Error";
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Start logging data to an Excel file
            try
            {
                if (!serialPort1.IsOpen)
                    serialPort1.Open();
            }
            catch (Exception ex)
            {
                textBox1.Text = "Serial Port Error";
            }

            try // Enable timer
            {
                timer1.Enabled = true;
                timer1.Start();
            }
            catch (Exception ex)
            {
                textBox1.Text = "Timer Error";
            }

            if (String.IsNullOrEmpty(textBox2.Text))   // Determine the name of the output file with the saved data
            {
                path = System.Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\\DataSync_JP\\DefaultNoNameOutputFile.csv";
            }else
            {
                path = FilePath + textBox2.Text + ".csv";
            }

            try  // Declare a new StreamWriter 
            {
                sw = new StreamWriter(path);
            }
            catch (Exception ex)
            {
                textBox1.Text = "Error";
            }

            timer2.Enabled = true;
            _hours = 0;
            _minutes = 0;
            _seconds = 0;

            ShowTime();

            button3.Visible = false;
            button4.Visible = true;
            button4.Enabled = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Stop logging data
            timer1.Enabled = true;
            timer1.Start();

            timer2.Enabled = false;

            button3.Visible = true;
            button4.Visible = false;

        }

        private void ShowTime()
        {
            label2.Text = _hours.ToString("00");
            label3.Text = _minutes.ToString("00");
            label4.Text = _seconds.ToString("00");
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            IncreaseSeconds();
            ShowTime();
        }

        private void IncreaseSeconds()
        {
            if(_seconds == 59)
            {
                _seconds = 0;
                IncreaseMinutes();
            }else
            {
                _seconds++;
            }
        }

        private void IncreaseMinutes()
        {
            if (_seconds == 59)
            {
                _minutes = 0;
                IncreaseHours();
            }
            else
            {
                _minutes++;
            }
        }

        private void IncreaseHours()
        {
            _hours++;
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            
            try
            {
                serialPort1.Open();
                serialPort2.Open();
                Pdata.Text = "";
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            

        }


        //Connecting to Arduino
        private void ARConnect_Click(object sender, EventArgs e)
        {

            try
            {
                if (comboBox3.Text == "" || comboBox4.Text == "")
                {
                    textBox1.Text = "Please select port settings.";
                }
                else
                {
                    // Setup settings for the serial port
                    serialPort2.PortName = comboBox1.Text;
                    serialPort2.BaudRate = Convert.ToInt32(comboBox4.Text);
                    serialPort2.Parity = Parity.None;
                    serialPort2.StopBits = StopBits.One;
                    serialPort2.DataBits = 8;
                    try
                    {
                        if (!serialPort2.IsOpen)
                            serialPort2.Open();
                    }
                    catch (Exception ex)
                    {
                        textBox1.Text = "Error";
                    }

                    // Setup timer
                    timer1.Interval = 275;

                    // Change button access
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    textBox1.Enabled = true;
                    StartButton.Enabled = false;
                    ARConnect.Enabled = false;
                    ARDisconnect.Enabled = true;
                }
            }
            catch (UnauthorizedAccessException)
            {
                textBox1.Text = "Unauthorized Access";
            }
        }

        private void ARDisconnect_Click(object sender, EventArgs e)
        {
            serialPort2.Close();
        }

    }
}
