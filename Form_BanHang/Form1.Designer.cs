namespace Form_BanHang
{
    partial class Form1
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
            this.lbTen = new System.Windows.Forms.Label();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lstDanhSachMatHang = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbTienMat = new System.Windows.Forms.RadioButton();
            this.rdbTheTinDung = new System.Windows.Forms.RadioButton();
            this.rdbSec = new System.Windows.Forms.RadioButton();
            this.lbDiaChi = new System.Windows.Forms.Label();
            this.txtDienThoai = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lstHangDatMua = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chbMail = new System.Windows.Forms.CheckBox();
            this.chbFax = new System.Windows.Forms.CheckBox();
            this.chbDienThoai = new System.Windows.Forms.CheckBox();
            this.btDongY = new System.Windows.Forms.Button();
            this.btThoat = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbTen
            // 
            this.lbTen.AutoSize = true;
            this.lbTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTen.Location = new System.Drawing.Point(41, 25);
            this.lbTen.Name = "lbTen";
            this.lbTen.Size = new System.Drawing.Size(52, 16);
            this.lbTen.TabIndex = 0;
            this.lbTen.Text = "Họ Tên";
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(108, 24);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(172, 20);
            this.txtTen.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Danh sách các mặt hàng";
            // 
            // lstDanhSachMatHang
            // 
            this.lstDanhSachMatHang.FormattingEnabled = true;
            this.lstDanhSachMatHang.Location = new System.Drawing.Point(44, 102);
            this.lstDanhSachMatHang.Name = "lstDanhSachMatHang";
            this.lstDanhSachMatHang.Size = new System.Drawing.Size(236, 147);
            this.lstDanhSachMatHang.TabIndex = 3;
            this.lstDanhSachMatHang.SelectedIndexChanged += new System.EventHandler(this.lstDanhSachMatHang_SelectedIndexChanged);
            this.lstDanhSachMatHang.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstDanhSachMatHang_MouseDoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbTienMat);
            this.groupBox1.Controls.Add(this.rdbTheTinDung);
            this.groupBox1.Controls.Add(this.rdbSec);
            this.groupBox1.Location = new System.Drawing.Point(44, 285);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(187, 113);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Phương thức thanh toán";
            // 
            // rdbTienMat
            // 
            this.rdbTienMat.AutoSize = true;
            this.rdbTienMat.Location = new System.Drawing.Point(35, 29);
            this.rdbTienMat.Name = "rdbTienMat";
            this.rdbTienMat.Size = new System.Drawing.Size(67, 17);
            this.rdbTienMat.TabIndex = 0;
            this.rdbTienMat.TabStop = true;
            this.rdbTienMat.Text = "Tiền Mặt";
            this.rdbTienMat.UseVisualStyleBackColor = true;
            // 
            // rdbTheTinDung
            // 
            this.rdbTheTinDung.AutoSize = true;
            this.rdbTheTinDung.Location = new System.Drawing.Point(35, 75);
            this.rdbTheTinDung.Name = "rdbTheTinDung";
            this.rdbTheTinDung.Size = new System.Drawing.Size(93, 17);
            this.rdbTheTinDung.TabIndex = 0;
            this.rdbTheTinDung.TabStop = true;
            this.rdbTheTinDung.Text = "Thẻ Tín Dụng";
            this.rdbTheTinDung.UseVisualStyleBackColor = true;
            this.rdbTheTinDung.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rdbSec
            // 
            this.rdbSec.AutoSize = true;
            this.rdbSec.Location = new System.Drawing.Point(35, 52);
            this.rdbSec.Name = "rdbSec";
            this.rdbSec.Size = new System.Drawing.Size(44, 17);
            this.rdbSec.TabIndex = 0;
            this.rdbSec.TabStop = true;
            this.rdbSec.Text = "Séc";
            this.rdbSec.UseVisualStyleBackColor = true;
            this.rdbSec.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // lbDiaChi
            // 
            this.lbDiaChi.AutoSize = true;
            this.lbDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDiaChi.Location = new System.Drawing.Point(379, 27);
            this.lbDiaChi.Name = "lbDiaChi";
            this.lbDiaChi.Size = new System.Drawing.Size(72, 16);
            this.lbDiaChi.TabIndex = 5;
            this.lbDiaChi.Text = "Điện Thoại";
            // 
            // txtDienThoai
            // 
            this.txtDienThoai.Location = new System.Drawing.Point(466, 25);
            this.txtDienThoai.Name = "txtDienThoai";
            this.txtDienThoai.Size = new System.Drawing.Size(169, 20);
            this.txtDienThoai.TabIndex = 6;
            this.txtDienThoai.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDienThoai_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(379, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Hàng đặt mua";
            // 
            // lstHangDatMua
            // 
            this.lstHangDatMua.FormattingEnabled = true;
            this.lstHangDatMua.Location = new System.Drawing.Point(382, 102);
            this.lstHangDatMua.Name = "lstHangDatMua";
            this.lstHangDatMua.Size = new System.Drawing.Size(253, 147);
            this.lstHangDatMua.TabIndex = 3;
            this.lstHangDatMua.SelectedIndexChanged += new System.EventHandler(this.lstHangDatMua_SelectedIndexChanged);
            this.lstHangDatMua.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstHangDatMua_MouseDoubleClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chbMail);
            this.groupBox2.Controls.Add(this.chbFax);
            this.groupBox2.Controls.Add(this.chbDienThoai);
            this.groupBox2.Location = new System.Drawing.Point(382, 285);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(187, 113);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hình thức liên lạc";
            // 
            // chbMail
            // 
            this.chbMail.AutoSize = true;
            this.chbMail.Location = new System.Drawing.Point(33, 75);
            this.chbMail.Name = "chbMail";
            this.chbMail.Size = new System.Drawing.Size(45, 17);
            this.chbMail.TabIndex = 0;
            this.chbMail.Text = "Mail";
            this.chbMail.UseVisualStyleBackColor = true;
            // 
            // chbFax
            // 
            this.chbFax.AutoSize = true;
            this.chbFax.Location = new System.Drawing.Point(33, 52);
            this.chbFax.Name = "chbFax";
            this.chbFax.Size = new System.Drawing.Size(43, 17);
            this.chbFax.TabIndex = 0;
            this.chbFax.Text = "Fax";
            this.chbFax.UseVisualStyleBackColor = true;
            // 
            // chbDienThoai
            // 
            this.chbDienThoai.AutoSize = true;
            this.chbDienThoai.Location = new System.Drawing.Point(33, 29);
            this.chbDienThoai.Name = "chbDienThoai";
            this.chbDienThoai.Size = new System.Drawing.Size(78, 17);
            this.chbDienThoai.TabIndex = 0;
            this.chbDienThoai.Text = "Điện Thoại";
            this.chbDienThoai.UseVisualStyleBackColor = true;
            // 
            // btDongY
            // 
            this.btDongY.Location = new System.Drawing.Point(128, 428);
            this.btDongY.Name = "btDongY";
            this.btDongY.Size = new System.Drawing.Size(84, 23);
            this.btDongY.TabIndex = 7;
            this.btDongY.Text = "Đồng ý";
            this.btDongY.UseVisualStyleBackColor = true;
            this.btDongY.Click += new System.EventHandler(this.btDongY_Click);
            // 
            // btThoat
            // 
            this.btThoat.Location = new System.Drawing.Point(427, 428);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(85, 23);
            this.btThoat.TabIndex = 7;
            this.btThoat.Text = "Thoát";
            this.btThoat.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 509);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.btDongY);
            this.Controls.Add(this.txtDienThoai);
            this.Controls.Add(this.lbDiaChi);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lstHangDatMua);
            this.Controls.Add(this.lstDanhSachMatHang);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.lbTen);
            this.Name = "Form1";
            this.Text = "Bán sách qua mạng";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTen;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstDanhSachMatHang;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbTienMat;
        private System.Windows.Forms.RadioButton rdbSec;
        private System.Windows.Forms.RadioButton rdbTheTinDung;
        private System.Windows.Forms.Label lbDiaChi;
        private System.Windows.Forms.TextBox txtDienThoai;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lstHangDatMua;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btDongY;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.CheckBox chbMail;
        private System.Windows.Forms.CheckBox chbFax;
        private System.Windows.Forms.CheckBox chbDienThoai;
    }
}

