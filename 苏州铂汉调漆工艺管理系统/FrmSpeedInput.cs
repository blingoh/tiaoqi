using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 调漆工艺管理系统
{
    public partial class FrmSpeedInput : Form
    {
        public int nSeconds = 180;
        public Image img;

        public FrmSpeedInput()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            nSeconds = nSeconds - 1;
            this.lblTime.Text = nSeconds.ToString();
            if(nSeconds<=0)
            {
                img = Image.FromFile(System.IO.Directory.GetCurrentDirectory() + @"\Images\1.gif");
                this.pbTimeInfo.Image = img;
                lblTime.BackColor = Color.Green;
                timer1.Enabled = false;
            }
        }

        private void FrmSpeedInput_Load(object sender, EventArgs e)
        {
            img = Image.FromFile(System.IO.Directory.GetCurrentDirectory() + @"\Images\3.gif");
            lblTime.Text = "";
            this.pbTimeInfo.Image = img;
            lblTime.BackColor = Color.Red;
            timer1.Enabled = true;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string sErrorMessage = "";
            if(clsApp.IsDouble(this.txtSpeed.Text,ref sErrorMessage)==false)
            {
                MessageBox.Show("油漆的流速数据格式不正确!", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txtSpeed.SelectAll();
                this.txtSpeed.SelectionLength = this.txtSpeed.Text.Length;
                this.txtSpeed.Focus();
                return;
            }
            else
            {
                double dactres = double.Parse(this.txtSpeed.Text);
                if(dactres>=FrmMain.productiondata.OilSpeedL && dactres<=FrmMain.productiondata.OilSpeedU)
                { 
                    FrmMain.productiondata.ActualSpeed = double.Parse(this.txtSpeed.Text);
                    FrmMain.productiondata.ActualDelaySeconds = int.Parse(lblTime.Text);
                    DialogResult = DialogResult.Yes;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("油漆的流速数据超过设定规格!", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.txtSpeed.SelectAll();
                    this.txtSpeed.SelectionLength = this.txtSpeed.Text.Length;
                    this.txtSpeed.Focus();
                    return;
                }
            }
            
        }

        private void txtSpeed_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyValue==13)
            {
                string sErrorMessage = "";
                if (clsApp.IsDouble(this.txtSpeed.Text, ref sErrorMessage) == false)
                {
                    MessageBox.Show("油漆的流速数据格式不正确!", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.txtSpeed.SelectAll();
                    this.txtSpeed.SelectionLength = this.txtSpeed.Text.Length;
                    this.txtSpeed.Focus();
                    return;
                }
                else
                {
                    double dactres = double.Parse(this.txtSpeed.Text);
                    if (dactres >= FrmMain.productiondata.OilSpeedL && dactres <= FrmMain.productiondata.OilSpeedU)
                    {
                        FrmMain.productiondata.ActualSpeed = double.Parse(this.txtSpeed.Text);
                        FrmMain.productiondata.ActualDelaySeconds = int.Parse(lblTime.Text);
                        DialogResult = DialogResult.Yes;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("油漆的流速数据超过设定规格!", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        this.txtSpeed.SelectAll();
                        this.txtSpeed.SelectionLength = this.txtSpeed.Text.Length;
                        this.txtSpeed.Focus();
                        return;
                    }
                }
            
            }
        }
    }
}

