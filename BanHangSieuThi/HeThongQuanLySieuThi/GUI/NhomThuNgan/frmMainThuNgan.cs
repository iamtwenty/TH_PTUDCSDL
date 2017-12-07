using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeThongQuanLySieuThi.GUI.NhomThuNgan
{
    public partial class frmMainThuNgan : Form
    {
        public frmMainThuNgan()
        {
            InitializeComponent();
        }

        public void themTabPages(UserControl uct, string tenTab)
        {
            //kiem tra trang nay ton tai chua
            for (int i = 0; i < tbcThuNgan.TabPages.Count; i++)
            {
                if (tbcThuNgan.TabPages[i].Text == tenTab)
                {
                    tbcThuNgan.SelectedTab = tbcThuNgan.TabPages[i];
                    return;
                }
            }
            //
            // Khởi tạo tabpage
            TabPage tab = new TabPage();

            // Add UserControl vào tabpage
            tab.Controls.Add(uct);
            tab.Text = tenTab;
            tab.Size = tbcThuNgan.Size;

            uct.Dock = DockStyle.Fill;
            tab.Contains(uct);
            uct.Focus();
            // Thêm tabpage vừa tạo vào tabControl mình muốn
            tbcThuNgan.TabPages.Add(tab);
            tbcThuNgan.SelectedTab = tab;
        }
        //thoat tab hien tai
        public void dongTabHienTai()
        {
            tbcThuNgan.TabPages.Remove(tbcThuNgan.SelectedTab);
        }
        //thoat tat ca ca tab
        public void dongTatCaCacTab()
        {
            while (tbcThuNgan.TabPages.Count > 0)
            {
                dongTabHienTai();
            }
        }
        //
        private void hoạtĐộngBánHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            uctBanHang uct = new uctBanHang();
            themTabPages(uct,"Hoạt động bán hàng");
        }

        private void thôngTinKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            uctKhachHang_ThuNgan uct = new uctKhachHang_ThuNgan();
            themTabPages(uct,"Thông tin khách hàng");
        }

        private void thôngTinMặtHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            uctMatHang_ThuNgan uct = new uctMatHang_ThuNgan();
            themTabPages(uct,"Thông tin mặt hàng");
        }

        private void thôngTinTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            uctThongTinTaiKhoan uct = new uctThongTinTaiKhoan();
            themTabPages(uct, "Thông tin tài khoản");
        }
        //
        private void đóngTabHiệnTạiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dongTabHienTai();
        }

        private void đóngTấtCảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dongTatCaCacTab();
        }
    }
}
