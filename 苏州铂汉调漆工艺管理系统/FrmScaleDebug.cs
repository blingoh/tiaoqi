using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace 调漆工艺管理系统
{
    public partial class FrmScaleDebug : Form
    {
        private SerialPort spPort = new SerialPort();
        private long received_count = 0;//接收计数
        private StringBuilder builder = new StringBuilder();//避免在事件处理方法中反复的创建，定义到外面。
        public string sResult = "";

        public FrmScaleDebug()
        {
            InitializeComponent();
        }


        public bool ComINIT(ref string sErrorMessage)
        {
            try
            {
                if (spMain.IsOpen)
                {
                    spMain.Close();
                }

                spMain.PortName = "COM" + this.comScaleMain.Value.ToString();
                spMain.BaudRate = int.Parse(this.badrateScaleMain.Text);
                spMain.DataBits = int.Parse(this.databitScaleMain.Text);

                switch (this.parityScaleMain.Text.ToUpper())
                {
                    case "NONE":
                        spMain.Parity = System.IO.Ports.Parity.None;
                        break;
                    case "EVEN":
                        spMain.Parity = System.IO.Ports.Parity.Even;
                        break;
                    case "ODD":
                        spMain.Parity = System.IO.Ports.Parity.Odd;
                        break;
                    case "MARK":
                        spMain.Parity = System.IO.Ports.Parity.Mark;
                        break;
                    case "SPACE":
                        spMain.Parity = System.IO.Ports.Parity.Space;
                        break;
                    default:
                        break;
                }

                switch (int.Parse(stopbitScaleMain.Text))
                {
                    case 1:
                        spMain.StopBits = System.IO.Ports.StopBits.One;
                        break;
                    case 2:
                        spMain.StopBits = System.IO.Ports.StopBits.Two;
                        break;
                    default:
                        break;
                }

                sErrorMessage = "";
                return true;
            }
            catch (Exception ex)
            {
                sErrorMessage = ex.Message.ToString();
                return false;
            }
        }

        public bool ComOpen(ref string sErrorMessage)
        {
            if (spMain.IsOpen)
            {
                return true;
            }

            try
            {
                spMain.Open();
                return true;
            }
            catch (System.Exception ex)
            {
                sErrorMessage = ex.Message.ToString();
                return false;
            }
        }

        void SplitScaleResult()
        {

        }

        void Command_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            int n = spPort.BytesToRead;//先记录下来，避免某种原因，人为的原因，操作几次之间时间长，缓存不一致
            byte[] buf = new byte[n];//声明一个临时数组存储当前来的串口数据
            received_count += n;//增加接收计数
            spPort.Read(buf, 0, n);//读取缓冲数据
            builder.Remove(0, builder.Length);//清除字符串构造器的内容
           
            string[] xxx;
            //因为要访问ui资源，所以需要使用invoke方式同步ui。
            this.Invoke((EventHandler)(delegate
            {
                sResult =sResult + System.Text.Encoding.ASCII.GetString(buf);

                if (sResult.Length>=50)
                {
                    xxx = sResult.Split('\n');
                    if(lblResult.Text !=xxx[xxx.Length-2].Substring(7, 7).Trim())
                    { 
                        lblResult.Text = xxx[xxx.Length-2].Substring(7, 7).Trim(); 
                    }
                    if(lblUnit.Text != xxx[xxx.Length-2].Substring(14,2))
                    { 
                        lblUnit.Text = xxx[xxx.Length-2].Substring(14,2);
                    }
                    sResult = "";
                    Application.DoEvents();
                }
                richTextBox1.Text = richTextBox1.Text + System.Text.Encoding.ASCII.GetString(buf);
            }));
        }

        public bool ComClose(ref string sErrorMessage)
        {
            if (spMain.IsOpen == true)
            {
                try
                {
                    //spMain.DiscardInBuffer();
                    spMain.Close();
                    return true;
                }
                catch (System.Exception ex)
                {
                    sErrorMessage = ex.Message.ToString();
                    return false;
                }
            }
            else
            {
                return true;
            }
        }

        private void btnMainPartStart_Click(object sender, EventArgs e)
        {
            string sErrorMessage="";

            //Open Serial Port
            ComClose(ref sErrorMessage);
            if(ComINIT(ref sErrorMessage)==false)
            {
                MessageBox.Show(sErrorMessage, "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (ComOpen(ref sErrorMessage) == false)
            {
                MessageBox.Show(sErrorMessage, "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void btnMainPartStop_Click(object sender, EventArgs e)
        {
            string sErrorMessage = "";
            ComClose(ref sErrorMessage);

        }

        private void spMain_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            int n = spMain.BytesToRead;//先记录下来，避免某种原因，人为的原因，操作几次之间时间长，缓存不一致
            byte[] buf = new byte[n];//声明一个临时数组存储当前来的串口数据
            received_count += n;//增加接收计数
            spMain.Read(buf, 0, n);//读取缓冲数据
            builder.Remove(0, builder.Length);//清除字符串构造器的内容
            
            string[] xxx;
            //因为要访问ui资源，所以需要使用invoke方式同步ui。
            this.Invoke((EventHandler)(delegate
            {
                sResult = sResult + System.Text.Encoding.ASCII.GetString(buf);

                if (sResult.Length >= 50)
                {
                    xxx = sResult.Split('\n');
                    if (lblResult.Text != xxx[xxx.Length - 2].Substring(7, 7).Trim())
                    {
                        lblResult.Text = xxx[xxx.Length - 2].Substring(7, 7).Trim();
                    }
                    if (lblUnit.Text != xxx[xxx.Length - 2].Substring(14, 2))
                    {
                        lblUnit.Text = xxx[xxx.Length - 2].Substring(14, 2);
                    }
                    sResult = "";
                    Application.DoEvents();
                }
                richTextBox1.Text = richTextBox1.Text + System.Text.Encoding.ASCII.GetString(buf);
            }));
        }

        private void FrmScaleDebug_Load(object sender, EventArgs e)
        {

        }
    }
}
