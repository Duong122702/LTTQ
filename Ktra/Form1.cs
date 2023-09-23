using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Ktra
{
    public partial class Form1 : Form
    {
        List<Phong> phongs = new List<Phong>();
        public Form1()
        {
            InitializeComponent();
            txtTrietkhau.Enabled = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtSophong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) e.Handled = true;
        }

        private void txtSonhavs_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) e.Handled = true;
        }

        private void txtGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) e.Handled = true;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void rdbDong_CheckedChanged(object sender, EventArgs e)
        {
            txtTrietkhau.Text = "0%";
        }

        private void rdbTay_CheckedChanged(object sender, EventArgs e)
        {
            txtTrietkhau.Text = "-10%";
        }

        private void rdbNam_CheckedChanged(object sender, EventArgs e)
        {
            txtTrietkhau.Text = "0%";
        }

        private void rdbBac_CheckedChanged(object sender, EventArgs e)
        {
            txtTrietkhau.Text = "0%";
        }

        private void rdbDongnam_CheckedChanged(object sender, EventArgs e)
        {
            txtTrietkhau.Text = "1%";
        }

        private void rdbDongbac_CheckedChanged(object sender, EventArgs e)
        {
            txtTrietkhau.Text = "0%";
        }

        private void rdbTaynam_CheckedChanged(object sender, EventArgs e)
        {
            txtTrietkhau.Text = "-2%";
        }

        private void rdbTaybac_CheckedChanged(object sender, EventArgs e)
        {
            txtTrietkhau.Text = "-5%";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
             ListViewItem item = new ListViewItem();
             item.Text = txtDiaChi.Text;
             item.SubItems.Add(txtSophong.Text);
             item.SubItems.Add(txtSonhavs.Text);
             item.SubItems.Add(txtTrietkhau.Text);
             item.SubItems.Add(txtGia.Text);
             if(rdbBac.Checked == true) item.SubItems.Add("Bắc");

            if (cmbTinhtrang.SelectedIndex == 0) item.SubItems.Add("Trống");
            if (cmbTinhtrang.SelectedIndex == 1) item.SubItems.Add("Đã Thuê");

            lstvDS.Items.Add(item);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbTinhtrang.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTinhtrang.Items.Add("Trống");
            cmbTinhtrang.Items.Add("Đã thuê");

        }

        private void cmbTinhtrang_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if(lstvDS.SelectedItems.Count > 0 )
            {
                int i = lstvDS.SelectedItems[0].Index;
                lstvDS.Items[i].SubItems[0].Text = txtDiaChi.Text;

            } 
        }

        private void lstvDS_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListViewItem ls = new ListViewItem();
            if (lstvDS.SelectedItems.Count > 0)
            {
                ls = lstvDS.SelectedItems[0];
                txtDiaChi.Text = ls.Text;
            }
            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(lstvDS.SelectedItems.Count > 0)
            {
                if(DialogResult.OK == MessageBox.Show("ban co muon xoa", "thong bao", MessageBoxButtons.OKCancel))
                {
                    int i = lstvDS.SelectedItems[0].Index;
                    lstvDS.Items.RemoveAt(i);
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
