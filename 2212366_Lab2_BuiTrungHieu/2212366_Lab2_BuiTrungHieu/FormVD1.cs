using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2212366_Lab2_BuiTrungHieu
{
    public partial class FormVD1 : Form
    {
        public FormVD1()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Reset();
        }
        private void Reset()
        {
            this.cboMaHV.Text = "";
            this.txtHoTenn.Text = "";
            this.dtpNgayDangKy.Value = DateTime.Now;
            this.rdNam.Checked = true;
            this.chkTiengAnhA.Checked = false;
            this.chkTiengAnhB.Checked = false;
            this.chkTinHocA.Checked = false;
            this.chkTinHocB.Checked = false;
            this.txtTongTien.Text = "";

        }

        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            int sum = 0;
            if (chkTiengAnhA.Checked)
            {
                sum += int.Parse(lblTienTAA.Text.Split('.')[0]);
            }
            if (chkTiengAnhB.Checked)
            {
                sum += int.Parse(lblTienTAB.Text.Split('.')[0]);
            }
            if (chkTinHocA.Checked)
            {
                sum += int.Parse(lblTienTHA.Text.Split('.')[0]);
            }
            if (chkTinHocB.Checked)
            {
                sum += int.Parse(lblTienTHB.Text.Split('.')[0]);
            }
            txtTongTien.Text = sum + ".000 đồng";
        }

    }
}
