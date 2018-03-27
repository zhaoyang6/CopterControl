using System;
using System.Windows.Forms;
using System.IO.Ports;

namespace CopterControl
{
    public partial class Form1 : Form
    {
        //数据包 AA AB为帧头， EE FF 为帧尾
        byte[] Data_Protocol = { 0xAA, 0xAB, 0x00, 0x00, 0x00, 0x00, 0xEE, 0xFF };
        int temp; //临时存放数据框中读取的数据
        public Form1()
        {
            InitializeComponent();
        }
        //自动搜索串口
        private void SearchAndAddSerialComboBox(SerialPort Myport, ComboBox MyBox)
        {
            string[] Mystring = new string[20];
            string Buffer;
            MyBox.Items.Clear();
            for (int i = 1; i < 11; i++)
            {
                try
                {
                    Buffer = "COM" + i.ToString();
                    Myport.PortName = Buffer;
                    Myport.Open();
                    Mystring[i - 1] = Buffer;
                    MyBox.Items.Add(Buffer);
                    Myport.Close();
                }
                catch
                {
                }
            }
            MyBox.Text = Mystring[0];

        }
        //接收函数定义
        private void Port_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
        }
        //窗体初始化
        private void Form1_Load(object sender, EventArgs e)
        {
            COM_Baud.Text = "115200";
            SearchAndAddSerialComboBox(serialPort1, COM_NUM);  //搜索可用串口
            serialPort1.DataReceived += new SerialDataReceivedEventHandler(Port_DataReceived);   //接收事件
        }
        //串口的开闭
        private void COM_button_Click(object sender, EventArgs e)
        {
            if(serialPort1.IsOpen)
            {
                COM_button.Text = "打开串口";  //按钮显示变为关闭串口
                serialPort1.Close(); //关闭串口           
            }
            else //当串口为关闭串口时
            {
                COM_button.Text = "关闭串口";  //按钮显示变为关闭串口
                serialPort1.PortName = COM_NUM.Text;  //设置串口号
                serialPort1.BaudRate = Convert.ToInt32(COM_Baud.Text);  //设置串口波特率
                serialPort1.Open();  //打开串口
            }
        }
        //串口号的更新
        private void COM_Update_Click(object sender, EventArgs e)
        {
            SearchAndAddSerialComboBox(serialPort1, COM_NUM);
        }
        //发送ROLL
        private void Roll_Send_Click(object sender, EventArgs e)
        {
            Data_Protocol[2] = 0x01;
            try
            {
                temp = Convert.ToInt16(Roll_BOX.Text);
                if (temp < 0)
                {
                    Data_Protocol[3] = 0x00;
                    temp = 0 - temp;
                }
                else
                {
                    Data_Protocol[3] = 0x01;
                }
                Data_Protocol[5] = (byte)temp;                //低八位
                Data_Protocol[4] = (byte)(temp >> 8);     //高八位
                serialPort1.Write(Data_Protocol,0,8);
            }
            catch
            {
                MessageBox.Show("数据写入错误，请检查后重新写入！");
            }
        }
        //Pitch 数据发送
        private void Pitch_Send_Click(object sender, EventArgs e)
        {

            Data_Protocol[2] = 0x02;
            try
            {
                temp = Convert.ToInt16(Pitch_BOX.Text);
                if (temp < 0)
                {
                    Data_Protocol[3] = 0x00;
                    temp = 0 - temp;
                }
                else
                {
                    Data_Protocol[3] = 0x01;
                }
                Data_Protocol[5] = (byte)temp;                //低八位
                Data_Protocol[4] = (byte)(temp >> 8);     //高八位
                serialPort1.Write(Data_Protocol, 0, 8);
            }
            catch
            {
                MessageBox.Show("数据写入错误，请检查后重新写入！");
            }
        }
        //yaw 数据发送
        private void Yaw_Send_Click(object sender, EventArgs e)
        {

            Data_Protocol[2] = 0x03;
            try
            {
                temp = Convert.ToInt16(Yaw_BOX.Text);
                if (temp < 0)
                {
                    Data_Protocol[3] = 0x00;
                    temp = 0 - temp;
                }
                else
                {
                    Data_Protocol[3] = 0x01;
                }
                Data_Protocol[5] = (byte)temp;                //低八位
                Data_Protocol[4] = (byte)(temp >> 8);     //高八位
                serialPort1.Write(Data_Protocol, 0, 8);
            }
            catch
            {
                MessageBox.Show("数据写入错误，请检查后重新写入！");
            }
        }
        //油门数据发送
        private void Throttle_Send_Click(object sender, EventArgs e)
        {

            Data_Protocol[2] = 0x04;
            try
            {
                temp = Convert.ToInt16(Throttle_Box.Text);
                if (temp < 0)
                {
                    Data_Protocol[3] = 0x00;
                    temp = 0 - temp;
                }
                else
                {
                    Data_Protocol[3] = 0x01;
                }
                Data_Protocol[5] = (byte)temp;                //低八位
                Data_Protocol[4] = (byte)(temp >> 8);     //高八位
                serialPort1.Write(Data_Protocol, 0, 8);
            }
            catch
            {
                MessageBox.Show("数据写入错误，请检查后重新写入！");
            }
        }
        //模式发送设置
        private void Mode_Set_Click(object sender, EventArgs e)
        {
            Data_Protocol[2] = 0x05;
            try
            {
                if (Mode_Box.Text == "自稳")
                {
                    Data_Protocol[3] = 0x01;
                }
                else if (Mode_Box.Text == "定高")
                {
                    Data_Protocol[3] = 0x02;
                }
                else
                {
                    Data_Protocol[3] = 0x03;
                }
                serialPort1.Write(Data_Protocol, 0, 8);
            }
            catch
            {
                MessageBox.Show("模式设置出现错误，请检查！");
            }
        }
    }
}
