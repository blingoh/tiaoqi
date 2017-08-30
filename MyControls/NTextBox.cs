using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace MyControls
{
    public partial class NTextBox :TextBox 
    {
        private Color backColor;
        public override Color BackColor
        {
            get { return base.BackColor; }
            set
            {
                backColor = value;
                base.BackColor = value;
            }
        }

        private Color foreColor;
        public override Color ForeColor
        {
            get { return base.ForeColor; }
            set
            {
                foreColor = value;
                base.ForeColor = value;
            }
        }

        private Color disableBackColor = Color.White;
        public Color DisableBackColor
        {
            get { return disableBackColor; }
            set { disableBackColor = value; }
        }

        private Color disableForeColor = Color.FromKnownColor(KnownColor.WindowText);
        public Color DisableForeColor
        {
            get { return disableForeColor; }
            set { disableForeColor = value; }
        }

        public new bool Enabled //這邊重寫Enabled屬性, 使用關鍵字new把原本的隱藏起來
        {
            get { return !ReadOnly; }
            set { ReadOnly = !value; }
        }

        protected override void OnReadOnlyChanged(EventArgs e)
        {
            base.OnReadOnlyChanged(e);

            if (ReadOnly)
            {
                base.BackColor = disableBackColor;
                base.ForeColor = disableForeColor;
            }
            else
            {
                base.BackColor = backColor;
                base.ForeColor = foreColor;
            }
        }

        public NTextBox()
        {
            InitializeComponent();
        }
    }
}
