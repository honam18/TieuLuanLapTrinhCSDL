
namespace TieuLuanLapTrinhCSDL.Views
{
    partial class frmDashBoard
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hệThốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnExit = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnRevenueUC = new System.Windows.Forms.ToolStripMenuItem();
            this.btnStaffUC = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCustomerUC = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAccountUC = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hệThốngToolStripMenuItem,
            this.quảnLýToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(246, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hệThốngToolStripMenuItem
            // 
            this.hệThốngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnExit});
            this.hệThốngToolStripMenuItem.Image = global::TieuLuanLapTrinhCSDL.Properties.Resources.System;
            this.hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            this.hệThốngToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.hệThốngToolStripMenuItem.Text = "Hệ thống";
            // 
            // btnExit
            // 
            this.btnExit.Image = global::TieuLuanLapTrinhCSDL.Properties.Resources.turn_off;
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(104, 22);
            this.btnExit.Text = "Thoát";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // quảnLýToolStripMenuItem
            // 
            this.quảnLýToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnRevenueUC,
            this.btnStaffUC,
            this.btnCustomerUC,
            this.btnAccountUC});
            this.quảnLýToolStripMenuItem.Image = global::TieuLuanLapTrinhCSDL.Properties.Resources.view;
            this.quảnLýToolStripMenuItem.Name = "quảnLýToolStripMenuItem";
            this.quảnLýToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.quảnLýToolStripMenuItem.Text = "Quản lý";
            // 
            // btnRevenueUC
            // 
            this.btnRevenueUC.Image = global::TieuLuanLapTrinhCSDL.Properties.Resources.dollar;
            this.btnRevenueUC.Name = "btnRevenueUC";
            this.btnRevenueUC.Size = new System.Drawing.Size(180, 22);
            this.btnRevenueUC.Text = "Doanh Thu";
            this.btnRevenueUC.Click += new System.EventHandler(this.btnRevenueUC_Click);
            // 
            // btnStaffUC
            // 
            this.btnStaffUC.Image = global::TieuLuanLapTrinhCSDL.Properties.Resources.male;
            this.btnStaffUC.Name = "btnStaffUC";
            this.btnStaffUC.Size = new System.Drawing.Size(180, 22);
            this.btnStaffUC.Text = "Nhân viên";
            this.btnStaffUC.Click += new System.EventHandler(this.btnStaffUC_Click);
            // 
            // btnCustomerUC
            // 
            this.btnCustomerUC.Image = global::TieuLuanLapTrinhCSDL.Properties.Resources.user_group2;
            this.btnCustomerUC.Name = "btnCustomerUC";
            this.btnCustomerUC.Size = new System.Drawing.Size(180, 22);
            this.btnCustomerUC.Text = "Khách hàng";
            this.btnCustomerUC.Click += new System.EventHandler(this.btnCustomerUC_Click);
            // 
            // btnAccountUC
            // 
            this.btnAccountUC.Image = global::TieuLuanLapTrinhCSDL.Properties.Resources.list;
            this.btnAccountUC.Name = "btnAccountUC";
            this.btnAccountUC.Size = new System.Drawing.Size(180, 22);
            this.btnAccountUC.Text = "Tài khoản";
            this.btnAccountUC.Click += new System.EventHandler(this.btnAccountUC_Click);
            // 
            // frmDashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(246, 65);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmDashBoard";
            this.Text = "Quản lý rạp phim";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hệThốngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnExit;
        private System.Windows.Forms.ToolStripMenuItem quảnLýToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnRevenueUC;
        private System.Windows.Forms.ToolStripMenuItem btnStaffUC;
        private System.Windows.Forms.ToolStripMenuItem btnCustomerUC;
        private System.Windows.Forms.ToolStripMenuItem btnAccountUC;
    }
}