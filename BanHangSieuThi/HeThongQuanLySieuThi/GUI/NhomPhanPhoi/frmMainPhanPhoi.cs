using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeThongQuanLySieuThi.GUI.NhomPhanPhoi
{
    public partial class frmMainPhanPhoi : Form
    {
        public frmMainPhanPhoi()
        {
            InitializeComponent();
        }
        internal static List<byte> typePages = new List<byte>();

        public void themTabPages(UserControl uct, TabControl tbc, byte typeControl, string tenTab)
        {
            //kiem tra trang nay ton tai chua
            for (int i = 0; i < tbc.TabPages.Count; i++)
            {
                if (tbcPhanPhoi.TabPages[i].Text == tenTab)
                {
                    tbcPhanPhoi.SelectedTab = tbcPhanPhoi.TabPages[i];
                    return;
                }
            }
            // Khởi tạo tabpage
            TabPage tab = new TabPage();

            // Add UserControl vào tabpage
            tab.Controls.Add(uct);
            tab.Text = tenTab;
            tab.Size = tbc.Size;

            uct.Dock = DockStyle.Fill;
            tab.Contains(uct);
            uct.Focus();
            // Thêm tabpage vừa tạo vào tabControl mình muốn
            tbc.TabPages.Add(tab);
            tbc.SelectedTab = tab;
        }
        //thoat tab hien tai
        public void dongTabHienTai(TabControl tbc)
        {
            tbc.TabPages.Remove(tbc.SelectedTab);
        }
        //thoat tat ca ca tab
        public void dongTatCaCacTab(TabControl tbc)
        {
            while (tbc.TabPages.Count > 0)
            {
                dongTabHienTai(tbc);
            }
        }
        //contextMenuStripTab
        private void đóngTabHiệnTạiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dongTabHienTai(tbcPhanPhoi);
        }

        private void đóngTấtCảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dongTatCaCacTab(tbcPhanPhoi);
        }
        //menuStripChucNang
        private void phânPhốiTạiQuầyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            uctPhanPhoiQuay uct = new uctPhanPhoiQuay();
            themTabPages(uct, tbcPhanPhoi, 4, "Phân phối hàng trên quầy");
        }

        private void phânPhốiHàngTrongKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            uctPhanPhoiKho uct = new uctPhanPhoiKho();
            themTabPages(uct, tbcPhanPhoi, 4, "Phân phối hàng trong kho");
        }

        private void thôngTinNgườiDùngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //
        }
    }
}
