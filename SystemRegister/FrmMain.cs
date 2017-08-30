using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemRegister
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnGeneration_Click(object sender, EventArgs e)
        {
            string sCustomerInfo = "";
            sCustomerInfo = this.txtPCCode.Text;
            Guid.NewGuid();
            sCustomerInfo = clsComputerInfo.Encrypt(sCustomerInfo, "F");
            if(sCustomerInfo.Length!=16)
            {
                MessageBox.Show("出现异常错误!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                lblRegisterCode.Text = sCustomerInfo.Substring(0, 4) + "-" + sCustomerInfo.Substring(4, 4) + "-" + sCustomerInfo.Substring(8, 4) + "-" + sCustomerInfo.Substring(12, 4);
            }
        }
    }
}
