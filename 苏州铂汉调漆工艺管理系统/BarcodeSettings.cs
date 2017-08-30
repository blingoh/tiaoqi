using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 调漆工艺管理系统
{
    public partial class BarcodeSettings : Form
    {
        private string barcode;
        public string CodeRule
        {
            get;set;
        }
        public string BarCode
        {
            get { return barcode; }
            set
            {
                if (null != value)
                {
                    barcode = value.Trim();
                }
                var w = 13;
                var allChars = barcode.ToCharArray();
                pnlCode.Controls.Clear(); // 清空
                for (var i = 0; i < barcode.Length; i++)
                {
                    Label lbl = new Label();
                    lbl.Font = new Font(FontFamily.GenericMonospace, 12);
                    lbl.AutoSize = false;
                    lbl.Text = allChars[i].ToString();
                    lbl.Visible = true;
                    var location = new Point(w * i, 36);
                    lbl.Location = location;
                    lbl.Size = new Size(w, w + 4);

                    CheckBox chk = new CheckBox();
                    var chkLocation = new Point(w * i + 2, 36 + 15);
                    chk.Location = chkLocation;
                    chk.AutoSize = false;
                    chk.Size = new Size(w, w);
                    chk.Tag = 1000 + i;

                    pnlCode.Controls.Add(chk);
                    pnlCode.Controls.Add(lbl);
                }
            }
        }
        public BarcodeSettings()
        {
            InitializeComponent();
        }

        private void OnBtnOkClicked(object sender, EventArgs e)
        {
            var children = pnlCode.Controls;
            IList<int> checkedPos = new List<int>();
            foreach (var control in children)
            {
                if (control is CheckBox)
                {
                    var chk = control as CheckBox;
                    if (chk.Checked)
                    {
                        checkedPos.Add((int)chk.Tag - 1000);
                    }
                }
            }
            var arr = checkedPos.ToArray();
            Array.Sort(arr);
            StringBuilder builder = new StringBuilder();
            for (var i = 0; i < arr.Length; i++)
            {
                builder.Append(checkedPos[i] + "");
                if (i < arr.Length - 1)
                {
                    builder.Append(",");
                }
            }
            string codePos = builder.ToString();
            CodeRule = codePos;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void OnWinShown(object sender, EventArgs e)
        {
            if (null != CodeRule && 
                0 < CodeRule.Trim().Length)
            {
                var chs = CodeRule.Split(',');
                foreach(var control in pnlCode.Controls)
                {
                    if (control is CheckBox)
                    {
                        if (chs.Contains<string>(((int)(control as CheckBox).Tag - 1000) + ""))
                        {
                            (control as CheckBox).Checked = true;
                        }
                    }
                }
            }
        }
    }
}
