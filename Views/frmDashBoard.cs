using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TieuLuanLapTrinhCSDL.Views
{
    public partial class frmDashBoard : Form
    {
        public frmDashBoard()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnRevenueUC_Click(object sender, EventArgs e)
        {
            frmRevenueUC frm = new frmRevenueUC();
            frm.ShowDialog();
        }

        private void btnStaffUC_Click(object sender, EventArgs e)
        {
            frmStaffUC frm = new frmStaffUC();
            frm.ShowDialog();
        }

        private void btnCustomerUC_Click(object sender, EventArgs e)
        {
            frmCustomerUC frm = new frmCustomerUC();
            frm.ShowDialog();
        }

        private void btnAccountUC_Click(object sender, EventArgs e)
        {
            frmAccountUC frm = new frmAccountUC();
            frm.ShowDialog();
        }
    }
}
