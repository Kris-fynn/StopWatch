using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;
using ComboBox = System.Windows.Forms.ComboBox;

namespace StopWatch
{
    public partial class Form1 : Form
    {
        int Timeleft = 0;//set timeleft as an integer
        int TimeRight = 0;//set timeright as an integer
       //int count = 0;
        string DataIn;

        public Form1()
        {
            InitializeComponent();
            dateTimePicker1.Value = new DateTime(1000, 01, 01, 0, 0, 0);//initialize the datetime picker to 00:00:00
            radioButton3D.Enabled = false;
            radioButtonSTD.Enabled = false;
            radioButtonTW.Enabled = false;
            FormBorderStyle = FormBorderStyle.None;
        }
        private void StopWatch_Load(object sender, EventArgs e)
        {

        }
        private void DownButton_Click(object sender, EventArgs e)
        {
            int timeInSec = 0;//for countup
            DateTime dateTime = dateTimePicker1.Value;//set the datetimepicker value to date/time format
            timeInSec += dateTime.Hour * 3600;//set max hours format
            timeInSec += dateTime.Minute * 60;//set max minute format
            timeInSec += dateTime.Second;//set seconds
            Timeleft = timeInSec;//put  the timeinsec value to the timeleft

            int timeInSec2 = 0;//for countdown
            timeInSec2 += dateTime.Hour * 3600;
            timeInSec2 += dateTime.Minute * 60;
            timeInSec2 += dateTime.Second;
            TimeRight = timeInSec2;//put  the timeinsec value to the timeright
        }
       
        private void label2_Click(object sender, EventArgs e)
        {

        }
        int TargetUp = 0;//target to count up 
        private void StartButton_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)//when countup is chosen
            {
                int timeInSec2 = 0;
                DateTime dateTime = dateTimePicker1.Value;//datetime will be equal to the value inserted at the datetimepicker 
               //format of the timein sec
                timeInSec2 += dateTime.Hour * 3600;
                timeInSec2 += dateTime.Minute * 60;
                timeInSec2 += dateTime.Second;
                if (timeInSec2 > 0)//for timer1 to countup 
                {
                    TargetUp = timeInSec2;//targetup will capture the value of timeinsec 
                }
                timer1.Start();//timer will start counting
            }
            else
            {
                int timeInSec = 0;
                DateTime dateTime = dateTimePicker1.Value;
                timeInSec += dateTime.Hour * 3600;
                timeInSec += dateTime.Minute * 60;
                timeInSec += dateTime.Second;
                if (Timeleft == 0)
                {
                    Timeleft = timeInSec;
                }               
                Timer2.Start();//timer will start
            }
            radioButton1.Enabled = false;//radio buttons and checkbuttons to be disabled because the measssages are currently being sent
            radioButton2.Enabled = false;
            redcheckBox.Enabled = false;
            greencheckBox2.Enabled = false;
            whitecheckBox3.Enabled = false;
            yellowcheckBox3.Enabled = false;
            radioButton3D.Enabled = false;
            radioButtonSTD.Enabled = false;
            radioButtonTW.Enabled = false;
        } 
        private void ResetButton_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                TimeRight = 0;
                TargetUp = 0;
                timer1.Stop();
            }else
            {
                Timeleft = 0;
                Timer2.Stop();
            }
            radioButton1.Enabled = true;//enable radio buttons and checkbuttons because no data is being sent
            radioButton2.Enabled = true;
            redcheckBox.Enabled = true;
            greencheckBox2.Enabled = true;
            whitecheckBox3.Enabled = true;
            yellowcheckBox3.Enabled = true;
            radioButton3D.Enabled = false;
            radioButtonSTD.Enabled = false;
            radioButtonTW.Enabled = false;
            //ReceiveButton.Enabled = true;
            StartButton.Enabled = true;
        }
        private void CountDownTimer_Tick(object sender, EventArgs e)
        {
            if (Timeleft > 0)
            {
                Timeleft = Timeleft - 1;//decrase by 1 second
                var TimeSpanVar = TimeSpan.FromSeconds(Timeleft);//take timeleft from seconds to hours and put it timespanvar variable
                label1.Text = TimeSpanVar.ToString();//display the value on the timespan variable on label1
            }
            else
            {
                Timer2.Stop();
                label1.Text = "TIME UP";//display alert to the user on label1 that the time has depleted
                radioButton1.Enabled = true;
                radioButton2.Enabled = true;
                redcheckBox.Enabled = true;
                greencheckBox2.Enabled = true;
                whitecheckBox3.Enabled = true;
                radioButton3D.Enabled = false;
                radioButtonSTD.Enabled = false;
                radioButtonTW.Enabled = false;
            }
            List<byte> PacketToSend = new List<byte>();//craete a list/packet to send to serialport
            PacketToSend.Add(0);//start of protocol to get the LED display micro ready to receive communtication
            PacketToSend.Add(83);//to indicate to the LED display micro on what static indicator is going to be comunicated
            PacketToSend.Add(1);//sign address that the communication is sent to 
            PacketToSend.Add(3);//end of header

            if (redcheckBox.Checked)
            {
                PacketToSend.Add(28);//get the LED display to modify the following information communicated
                PacketToSend.Add(82);//modify and display the communicated information in red  
                greencheckBox2.Checked = false;
                whitecheckBox3.Checked = false;
                yellowcheckBox3.Checked = false;
            }
            if (greencheckBox2.Checked)
            {
                PacketToSend.Add(28);
                PacketToSend.Add(71);//modify and display the communicated information in green  
                redcheckBox.Checked = false;
                whitecheckBox3.Checked = false;
                yellowcheckBox3.Checked = false;
            }
            if (whitecheckBox3.Checked)
            {
                PacketToSend.Add(28);
                PacketToSend.Add(87);//modify and display the communicated information in white  
                redcheckBox.Checked = false;
                greencheckBox2.Checked = false;
                yellowcheckBox3.Checked = false;
            }
            if (yellowcheckBox3.Checked)
            {
                PacketToSend.Add(28);
                PacketToSend.Add(89);//modify and display the communicated information in white  
                redcheckBox.Checked = false;
                greencheckBox2.Checked = false;
                whitecheckBox3.Checked = false;
            }
            if (Timeleft <= 10)
            {
                PacketToSend.Add(28);//get the LED display to modify the following information communicated
                PacketToSend.Add(70);//set toggle text flash on for countdown less than 10 seconds
            }
            string val1 = label1.Text;//take the information displayed on label1 and put in the string val1
            for (int i = 0; i < val1.Length; i++)
            {
                PacketToSend.Add((byte)(Char)val1[i]);//add the value on val1 to the list/packet that will be sent to the LED display
            }

            PacketToSend.Add(4);//end of text indiscation to the LED display

            byte crc = 0;
            for (int i = 0; i < PacketToSend.Count; i++)
            {
                crc ^= PacketToSend[i];
            }
            PacketToSend.Add(crc);
            String StringToSend = "";
            for (int i = 0; i < PacketToSend.Count; i++)
            {
                StringToSend += (Char)PacketToSend[i];
            }
            serialPort.Write(StringToSend);
        }
        private void timer1_Tick(object sender, EventArgs e)
        {

            if (TimeRight < 100)
            {
                TimeRight = TimeRight++;
                var TimeSpanVar2 = TimeSpan.FromSeconds(TimeRight);
                label1.Text = TimeSpanVar2.ToString();
            }
            else
            {
                timer1.Stop();
                label1.Text = "TIME UP!";
                radioButton1.Enabled = true;
                radioButton2.Enabled = true;
                redcheckBox.Enabled = true;
                greencheckBox2.Enabled = true;
                whitecheckBox3.Enabled = true;
                radioButton3D.Enabled = false;
                radioButtonSTD.Enabled = false;
                radioButtonTW.Enabled = false;
            }
            List<byte> PacketToSend = new List<byte>();
            PacketToSend.Add(0);
            PacketToSend.Add(83);
            PacketToSend.Add(1);
            PacketToSend.Add(3);
            if (redcheckBox.Checked)
            {
                PacketToSend.Add(28);
                PacketToSend.Add(82);
                greencheckBox2.Checked = false;
                whitecheckBox3.Checked = false;
                yellowcheckBox3.Checked = false;
            }
            if (greencheckBox2.Checked)
            {
                PacketToSend.Add(28);
                PacketToSend.Add(71);
                redcheckBox.Checked = false;
                whitecheckBox3.Checked = false;
                yellowcheckBox3.Checked = false;
            }
            if (whitecheckBox3.Checked)
            {
                PacketToSend.Add(28);
                PacketToSend.Add(87);
                redcheckBox.Checked = false;
                greencheckBox2.Checked = false;
                yellowcheckBox3.Checked = false;
            }
            if (yellowcheckBox3.Checked)
            {
                PacketToSend.Add(28);
                PacketToSend.Add(89);
                redcheckBox.Checked = false;
                greencheckBox2.Checked = false;
                whitecheckBox3.Checked = false;
            }

            string val1 = label1.Text;
            for (int i = 0; i < val1.Length; i++)
            {
                PacketToSend.Add((byte)(Char)val1[i]);
            }

            PacketToSend.Add(4);

            byte crc = 0;
            for (int i = 0; i < PacketToSend.Count; i++)
            {
                crc ^= PacketToSend[i];
            }

            PacketToSend.Add(crc);
            String StringToSend = "";
            for (int i = 0; i < PacketToSend.Count; i++)
            {
                StringToSend += (Char)PacketToSend[i];
            }
            if(serialPort.IsOpen)
            {
                serialPort.Write(StringToSend);

            }
            else
            {
                serialPort.Close();
            }
        }
        private void DownStartButton_Click(object sender, EventArgs e)
        {
            Timer2.Start();
        }
        private void DownPauseButton_Click(object sender, EventArgs e)
        {
            Timer2.Stop();
        }
        private void DownRSTButton_Click(object sender, EventArgs e)
        {

        }
        private void label2_Click_2(object sender, EventArgs e)
        {

        }
        private void label2_Click_1(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void PauseButton_Click(object sender, EventArgs e)
        {
            radioButton3D.Enabled = false;
            radioButtonSTD.Enabled = false;
            radioButtonTW.Enabled = false;
            if (timer1.Enabled)
            {
                timer1.Stop();
                redcheckBox.Enabled = true;
                greencheckBox2.Enabled = true;
                whitecheckBox3.Enabled = true;
                yellowcheckBox3.Enabled = true;
            }
            if (Timer2.Enabled)
            {
                Timer2.Stop();
                redcheckBox.Enabled = true;
                greencheckBox2.Enabled = true;
                whitecheckBox3.Enabled = true;
                yellowcheckBox3.Enabled = true;
            }
            return;
        }
        SerialPort serialPort;
        private void Sendbutton_Click(object sender, EventArgs e)
        {
     
        }
        private void Openbutton_Click(object sender, EventArgs e)
        {
            Int32 baudRate = Convert.ToInt32(comboBox2.Text.ToString());
            string comPort = comboBox1.Text;
            int address = Convert.ToInt32(numericUpDown1.Value);
            byte Address = (byte)address;
            if (Openbutton.Text == "Open")
            {
                serialPort = new SerialPort();
                serialPort.BaudRate = baudRate;
                serialPort.PortName = comPort;
                serialPort.Encoding = Encoding.GetEncoding("ISO-8859-1");
                //serialPort.DataReceived += SerialPort_DataReceived;
                serialPort.Open();
                Openbutton.Text = "Close";
                DataIn = serialPort.ReadExisting();
                this.Invoke(new EventHandler(ShowData));
                //serialPort.Close();
            }
            else
            {
                serialPort.Close();
                Openbutton.Text = "Open";
               
            }
        }
        * private void ShowData(object sender, EventArgs e)
     {
        ReceiveLabel.Text= DataIn.ToString();
     }
      private void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
      {
         DataIn = serialPort.ReadExisting();
         ShowData();
     }
      private void ShowData() 
      {
       //ReceiveLabel.Text = DataIn.ToString();
       DataIn = null; 
      }


        private void comboBox1_DropDown(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();//get the name of the port

            ComboBox cb = sender as ComboBox;// set COM on the ComboBox 

            cb.Items.Clear();
            foreach (string port in ports)
            {
                cb.Items.Add(port);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
           if (BoderEnable.Enabled)
            {
                radioButton3D.Enabled = true;
                radioButtonSTD.Enabled = true;
                radioButtonTW.Enabled = true;
            }
            else
            {
                FormBorderStyle = FormBorderStyle.None ;
            }
        }
        private void BorderChangebutton_Click(object sender, EventArgs e)
        {
            if (radioButton3D.Checked)
            {
                FormBorderStyle = FormBorderStyle.Fixed3D;
                radioButtonSTD.Checked = false;
                radioButtonTW.Checked = false;
            }
            if (radioButtonSTD.Checked)
            {
                FormBorderStyle = FormBorderStyle.None;
                radioButton3D.Checked = false;
                radioButtonTW.Checked = false;
            }
            if (radioButtonTW.Checked)
            {
                FormBorderStyle = FormBorderStyle.FixedToolWindow;
                radioButtonSTD.Checked = false;
                radioButton3D.Checked = false;
            }
        }

        private void ReceiveLabel_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click_3(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void redcheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
