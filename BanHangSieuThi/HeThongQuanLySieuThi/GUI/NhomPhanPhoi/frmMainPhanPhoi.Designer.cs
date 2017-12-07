namespace HeThongQuanLySieuThi.GUI.NhomPhanPhoi
{
    partial class frmMainPhanPhoi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tbcPhanPhoi = new System.Windows.Forms.TabControl();
            this.contextMenuStripTab = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.đóngTabHiệnTạiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đóngTấtCảToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripChucNang = new System.Windows.Forms.MenuStrip();
            this.traCứuHàngHóaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phânPhốiTạiQuầyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phânPhốiHàngTrongKhoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinNgườiDùngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStripTab.SuspendLayout();
            this.menuStripChucNang.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbcPhanPhoi
            // 
            this.tbcPhanPhoi.ContextMenuStrip = this.contextMenuStripTab;
            this.tbcPhanPhoi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcPhanPhoi.Location = new System.Drawing.Point(0, 24);
            this.tbcPhanPhoi.Name = "tbcPhanPhoi";
            this.tbcPhanPhoi.SelectedIndex = 0;
            this.tbcPhanPhoi.Size = new System.Drawing.Size(1008, 637);
            this.tbcPhanPhoi.TabIndex = 6;
            // 
            // contextMenuStripTab
            // 
            this.contextMenuStripTab.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đóngTabHiệnTạiToolStripMenuItem,
            this.đóngTấtCảToolStripMenuItem});
            this.contextMenuStripTab.Name = "contextMenuStripTab";
            this.contextMenuStripTab.Size = new System.Drawing.Size(169, 48);
            // 
            // đóngTabHiệnTạiToolStripMenuItem
            // 
            this.đóngTabHiệnTạiToolStripMenuItem.Name = "đóngTabHiệnTạiToolStripMenuItem";
            this.đóngTabHiệnTạiToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.đóngTabHiệnTạiToolStripMenuItem.Text = "Đóng tab hiện tại ";
            this.đóngTabHiệnTạiToolStripMenuItem.Click += new System.EventHandler(this.đóngTabHiệnTạiToolStripMenuItem_Click);
            // 
            // đóngTấtCảToolStripMenuItem
            // 
            this.đóngTấtCảToolStripMenuItem.Name = "đóngTấtCảToolStripMenuItem";
            this.đóngTấtCảToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.đóngTấtCảToolStripMenuItem.Text = "Đóng tất cả";
            this.đóngTấtCảToolStripMenuItem.Click += new System.EventHandler(this.đóngTấtCảToolStripMenuItem_Click);
            // 
            // menuStripChucNang
            // 
            this.menuStripChucNang.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.traCứuHàngHóaToolStripMenuItem,
            this.thôngTinNgườiDùngToolStripMenuItem});
            this.menuStripChucNang.Location = new System.Drawing.Point(0, 0);
            this.menuStripChucNang.Name = "menuStripChucNang";
            this.menuStripChucNang.Size = new System.Drawing.Size(1008, 24);
            this.menuStripChucNang.TabIndex = 5;
            this.menuStripChucNang.Text = "menuStrip1";
            // 
            // traCứuHàngHóaToolStripMenuItem
            // 
            this.traCứuHàngHóaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.phânPhốiTạiQuầyToolStripMenuItem,
            this.phânPhốiHàngTrongKhoToolStripMenuItem});
            this.traCứuHàngHóaToolStripMenuItem.Name = "traCứuHàngHóaToolStripMenuItem";
            this.traCứuHàngHóaToolStripMenuItem.Size = new System.Drawing.Size(126, 20);
            this.traCứuHàngHóaToolStripMenuItem.Text = "Phân phối hàng hóa";
            // 
            // phânPhốiTạiQuầyToolStripMenuItem
            // 
            this.phânPhốiTạiQuầyToolStripMenuItem.Name = "phânPhốiTạiQuầyToolStripMenuItem";
            this.phânPhốiTạiQuầyToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.phânPhốiTạiQuầyToolStripMenuItem.Text = "Phân phối hàng trên quầy";
            this.phânPhốiTạiQuầyToolStripMenuItem.Click += new System.EventHandler(this.phânPhốiTạiQuầyToolStripMenuItem_Click);
            // 
            // phânPhốiHàngTrongKhoToolStripMenuItem
            // 
            this.phânPhốiHàngTrongKhoToolStripMenuItem.Name = "phânPhốiHàngTrongKhoToolStripMenuItem";
            this.phânPhốiHàngTrongKhoToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.phânPhốiHàngTrongKhoToolStripMenuItem.Text = "Phân phối hàng trong kho";
            this.phânPhốiHàngTrongKhoToolStripMenuItem.Click += new System.EventHandler(this.phânPhốiHàngTrongKhoToolStripMenuItem_Click);
            // 
            // thôngTinNgườiDùngToolStripMenuItem
            // 
            this.thôngTinNgườiDùngToolStripMenuItem.Name = "thôngTinNgườiDùngToolStripMenuItem";
            this.thôngTinNgườiDùngToolStripMenuItem.Size = new System.Drawing.Size(136, 20);
            this.thôngTinNgườiDùngToolStripMenuItem.Text = "Thông tin người dùng";
            this.thôngTinNgườiDùngToolStripMenuItem.Click += new System.EventHandler(this.thôngTinNgườiDùngToolStripMenuItem_Click);
            // 
            // frmMainPhanPhoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 661);
            this.Controls.Add(this.tbcPhanPhoi);
            this.Controls.Add(this.menuStripChucNang);
            this.Name = "frmMainPhanPhoi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMainPhanPhoi";
            this.contextMenuStripTab.ResumeLayout(false);
            this.menuStripChucNang.ResumeLayout(false);
            this.menuStripChucNang.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tbcPhanPhoi;
        private System.Windows.Forms.MenuStrip menuStripChucNang;
        private System.Windows.Forms.ToolStripMenuItem traCứuHàngHóaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phânPhốiTạiQuầyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phânPhốiHàngTrongKhoToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripTab;
        private System.Windows.Forms.ToolStripMenuItem đóngTabHiệnTạiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đóngTấtCảToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinNgườiDùngToolStripMenuItem;
    }
}