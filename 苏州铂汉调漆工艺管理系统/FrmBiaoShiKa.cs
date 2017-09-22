using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static 调漆工艺管理系统.FrmMain;

namespace 调漆工艺管理系统
{
    public partial class FrmBiaoShiKa : Form
    {
        public FrmBiaoShiKa()
        {
            InitializeComponent();
            
        }

        private void FrmBiaoShiKa_Load(object sender, EventArgs e)
        {
            ListViewItem item1 = new ListViewItem(FrmMain.productiondata.PartNumber, 0);
            item1.SubItems.Add(FrmMain.productiondata.Supplier);
            item1.SubItems.Add(FrmMain.productiondata.ShiftName);
            this.listView1.Items.AddRange(new ListViewItem[] { item1 });

            ListViewItem item2 = new ListViewItem("油漆编号");
            item2.SubItems.Add("固化剂编号");
            item2.SubItems.Add("稀释剂编号");
            this.listView1.Items.AddRange(new ListViewItem[] { item2 });

            ListViewItem item3 = new ListViewItem(FrmMain.productiondata.YouQiType=="原油"? FrmMain.productiondata.PartNumberMain : "");
            item3.SubItems.Add(FrmMain.productiondata.YouQiType == "固化剂" ? FrmMain.productiondata.PartNumberGuHua : "");
            item3.SubItems.Add(FrmMain.productiondata.YouQiType == "稀释剂" ? FrmMain.productiondata.PartNumberXiShi : "");
            this.listView1.Items.AddRange(new ListViewItem[] { item3 });

            ListViewItem item4 = new ListViewItem("油漆状态");
            item4.SubItems.Add("重量(KG)");
            item4.SubItems.Add("一次开桶日期");
            this.listView1.Items.AddRange(new ListViewItem[] { item4 });

            ListViewItem item5 = new ListViewItem(FrmMain.productiondata.YouQiType);
            //*****************************************
            item5.SubItems.Add("");
            //*****************************************
            item5.SubItems.Add(DateTime.Now.ToLocalTime().ToString());
            this.listView1.Items.AddRange(new ListViewItem[] { item5 });

            ListViewItem item6 = new ListViewItem("二次开桶日期");
            item6.SubItems.Add("三次开桶日期");
            item6.SubItems.Add("失效日期");
            this.listView1.Items.AddRange(new ListViewItem[] { item6 });

            ListViewItem item7 = new ListViewItem(FrmMain.productiondata.PartNumber);
            item7.SubItems.Add(FrmMain.productiondata.Supplier);
            item7.SubItems.Add(DateTime.Now.ToLocalTime().AddHours(FrmMain.productiondata.ValidHours).ToString());
            this.listView1.Items.AddRange(new ListViewItem[] { item7 });

            ListViewItem item8 = new ListViewItem("责任人");
            item8.SubItems.Add(userinfo.UserName);
            this.listView1.Items.AddRange(new ListViewItem[] { item8 });


        }

        
    }
}
