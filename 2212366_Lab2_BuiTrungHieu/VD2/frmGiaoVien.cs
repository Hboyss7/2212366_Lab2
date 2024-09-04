using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VD2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string lienHe = "https://cntt.dlu.edu.vn/";
            this.linklbLienHe.Links.Add(0, lienHe.Length, lienHe);
            this.cboMaSo.SelectedItem = this.cboMaSo.Items[0];
            //this.cboMaSo.SelectedIndex = this.cboMaSo.Items.Count - 1;

        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            // Chọn từng cái 
            //this.lbMonHocDay.Items.Add(lbDanhSachMH.SelectedItem);
            //this.lbDanhSachMH.Items.Remove(lbDanhSachMH.SelectedItem);

            // Chọn nhiều (ctrl) SelectedItems, nó trả về collection
            // Ta sẽ biết chọn được những gì vì nó lưu trong collection, nhưng ko biết có bao nhiêu
            //1. Đếm coi thử chọn bao nhiêu
            //int i = this.lbDanhSachMH.SelectedItems.Count;
            // vì count = index -1 
            int i =this.lbDanhSachMH.SelectedItems.Count - 1;
            while (i>=0)
            {
                this.lbMonHocDay.Items.Add(lbDanhSachMH.SelectedItems[i]);
                this.lbDanhSachMH.Items.Remove(lbDanhSachMH.SelectedItems[i]);
                i--;
            }
            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int i = this.lbMonHocDay.SelectedItems.Count - 1;
            while (i >= 0)
            {
                this.lbDanhSachMH.Items.Add(lbMonHocDay.SelectedItems[i]);
                this.lbMonHocDay.Items.Remove(lbMonHocDay.SelectedItems[i]);
                i--;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Reset();
        }

        public void Reset()
        {
            this.txtHoTen.Text = "";
            this.rdNam.Checked = true;
            this.cboMaSo.SelectedItem = cboMaSo.Items[0];
            this.txtMail.Text = "";
            this.mtxtSoDT.Text = "";
            this.dtpNgaySinh.Value = DateTime.Now;

            foreach (var item in lbMonHocDay.Items)
            {
                this.lbDanhSachMH.Items.Add(item);
            }
            this.lbMonHocDay.Items.Clear();

            for (int i = 0; i < chklbNgoaiNgu.Items.Count - 1; i++)
            {
                chklbNgoaiNgu.SetItemChecked(i, false);
            }
            
            
            



        }
    }
}
