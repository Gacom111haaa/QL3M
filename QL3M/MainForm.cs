using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QL3M
{
    public partial class MainForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void ribbonPageGroup1_CaptionButtonClick(object sender, DevExpress.XtraBars.Ribbon.RibbonPageGroupEventArgs e)
        {
            
        }

        private void CusList_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            QLKH khachHang = new QLKH();
            khachHang.Dock = DockStyle.Fill;
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(khachHang);
        }

        private void StoreList_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            QLKho kho = new QLKho();
            kho.Dock = DockStyle.Fill;
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(kho);
        }

        private void BuySellList_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            QLXuatNhap XN = new QLXuatNhap();
            XN.Dock = DockStyle.Fill;
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(XN);
        }
    }
}
