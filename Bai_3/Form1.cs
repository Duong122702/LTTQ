using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai_3
{
    public partial class Form1 : Form
    {
        List <KhachHang> ds = new List <KhachHang>();
        public Form1()
        {
            InitializeComponent();
        }

       

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void btThoat_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] sanpham = { "Coca cola", "Pepsi", "Seven up" };
            this.cmbChon.Items.AddRange(sanpham);
            for (int i = 1; i <= 10; i++)
            {
                this.cmbSoluong.Items.Add(i.ToString());
            }
            this.txtGia.ReadOnly = true;
            this.txtTien.ReadOnly = true;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.H && e.Modifiers == Keys.Alt)
            {

                if (MessageBox.Show("Bạn có muốn thoát không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Application.Exit();
                }
            }
            if(e.KeyCode == Keys.M && e.Modifiers == Keys.Alt)
            {
                this.txtTen.Text = "";
                this.txtGia.Text = "";
                this.txtTien.Text = "";
                this.txtTen.Focus();
                this.rdbNgay.Checked = false;
                this.rdbNuangay.Checked = false;
                this.cmbChon.Items.Clear();
                this.cmbSoluong.Items.Clear();
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.txtTen.Text = "";
            this.txtGia.Text = "";
            this.txtTien.Text = "";
            this.txtTen.Focus();
            this.rdbNgay.Checked = false;
            this.rdbNuangay.Checked = false;
            this.cmbChon.Items.Clear();
            this.cmbSoluong.Items.Clear();
        }

        private void cmbChon_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = cmbChon.SelectedIndex;
            
            if(selectedIndex == 0)
            {
                txtTien.Text = ((cmbSoluong.SelectedIndex + 1) * 0.5).ToString();
            }
            else if(selectedIndex == 1)
            {
                txtTien.Text = ((cmbSoluong.SelectedIndex + 1) * 0.8).ToString();
            }
            else if(selectedIndex == 2)
            {
                txtTien.Text = ((cmbSoluong.SelectedIndex + 1) * 1).ToString();
            }
            
        }

        private void rdbNgay_CheckedChanged(object sender, EventArgs e)
        {
            if(rdbNgay.Checked == true)
            {
                txtGia.Text = "200";
            }
        }

        private void rdbNuangay_CheckedChanged(object sender, EventArgs e)
        {
            if(rdbNuangay.Checked == true)
            {
                txtGia.Text = "100";
            }
        }

        private void cmbChon_SelectedValueChanged(object sender, EventArgs e)
        {
           
        }

        private void cmbSoluong_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = cmbChon.SelectedIndex;

            if (selectedIndex == 0)
            {
                txtTien.Text = ((cmbSoluong.SelectedIndex + 1) * 0.5).ToString();
            }
            else if (selectedIndex == 1)
            {
                txtTien.Text = ((cmbSoluong.SelectedIndex + 1) * 0.8).ToString();
            }
            else if (selectedIndex == 2)
            {
                txtTien.Text = ((cmbSoluong.SelectedIndex + 1) * 1).ToString();
            }
        }
    }
       
 }

