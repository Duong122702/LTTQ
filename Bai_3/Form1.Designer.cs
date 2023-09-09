namespace Bai_3
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbSoluong = new System.Windows.Forms.ComboBox();
            this.cmbChon = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btThem = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTien = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.lbGia = new System.Windows.Forms.Label();
            this.rdbNuangay = new System.Windows.Forms.RadioButton();
            this.rdbNgay = new System.Windows.Forms.RadioButton();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.lbTen = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.btThoat = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbSoluong);
            this.groupBox1.Controls.Add(this.cmbChon);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.btThem);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtTien);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtGia);
            this.groupBox1.Controls.Add(this.lbGia);
            this.groupBox1.Controls.Add(this.rdbNuangay);
            this.groupBox1.Controls.Add(this.rdbNgay);
            this.groupBox1.Controls.Add(this.txtTen);
            this.groupBox1.Controls.Add(this.lbTen);
            this.groupBox1.Location = new System.Drawing.Point(24, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(315, 273);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập thông tin khách đặt Tour";
            // 
            // cmbSoluong
            // 
            this.cmbSoluong.FormattingEnabled = true;
            this.cmbSoluong.Location = new System.Drawing.Point(128, 152);
            this.cmbSoluong.Name = "cmbSoluong";
            this.cmbSoluong.Size = new System.Drawing.Size(44, 21);
            this.cmbSoluong.TabIndex = 12;
            this.cmbSoluong.SelectedIndexChanged += new System.EventHandler(this.cmbSoluong_SelectedIndexChanged);
            // 
            // cmbChon
            // 
            this.cmbChon.FormattingEnabled = true;
            this.cmbChon.Location = new System.Drawing.Point(26, 153);
            this.cmbChon.Name = "cmbChon";
            this.cmbChon.Size = new System.Drawing.Size(87, 21);
            this.cmbChon.TabIndex = 11;
            this.cmbChon.SelectedIndexChanged += new System.EventHandler(this.cmbChon_SelectedIndexChanged);
            this.cmbChon.SelectedValueChanged += new System.EventHandler(this.cmbChon_SelectedValueChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(188, 207);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Thêm mới";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btThem
            // 
            this.btThem.Location = new System.Drawing.Point(26, 207);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(87, 23);
            this.btThem.TabIndex = 10;
            this.btThem.Text = "Thêm vào DS";
            this.btThem.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(259, 156);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "$";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // txtTien
            // 
            this.txtTien.Location = new System.Drawing.Point(197, 153);
            this.txtTien.Name = "txtTien";
            this.txtTien.Size = new System.Drawing.Size(56, 20);
            this.txtTien.TabIndex = 8;
            this.txtTien.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(125, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Số lượng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(194, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Tiền";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Chọn đồ uống";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(244, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "$";
            // 
            // txtGia
            // 
            this.txtGia.Location = new System.Drawing.Point(128, 97);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(110, 20);
            this.txtGia.TabIndex = 4;
            // 
            // lbGia
            // 
            this.lbGia.AutoSize = true;
            this.lbGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGia.Location = new System.Drawing.Point(23, 97);
            this.lbGia.Name = "lbGia";
            this.lbGia.Size = new System.Drawing.Size(88, 16);
            this.lbGia.TabIndex = 3;
            this.lbGia.Text = "Giá du thuyền";
            // 
            // rdbNuangay
            // 
            this.rdbNuangay.AutoSize = true;
            this.rdbNuangay.Location = new System.Drawing.Point(139, 58);
            this.rdbNuangay.Name = "rdbNuangay";
            this.rdbNuangay.Size = new System.Drawing.Size(71, 17);
            this.rdbNuangay.TabIndex = 2;
            this.rdbNuangay.TabStop = true;
            this.rdbNuangay.Text = "Nửa ngày";
            this.rdbNuangay.UseVisualStyleBackColor = true;
            this.rdbNuangay.CheckedChanged += new System.EventHandler(this.rdbNuangay_CheckedChanged);
            // 
            // rdbNgay
            // 
            this.rdbNgay.AutoSize = true;
            this.rdbNgay.Location = new System.Drawing.Point(26, 58);
            this.rdbNgay.Name = "rdbNgay";
            this.rdbNgay.Size = new System.Drawing.Size(64, 17);
            this.rdbNgay.TabIndex = 2;
            this.rdbNgay.TabStop = true;
            this.rdbNgay.Text = "Cả ngày";
            this.rdbNgay.UseVisualStyleBackColor = true;
            this.rdbNgay.CheckedChanged += new System.EventHandler(this.rdbNgay_CheckedChanged);
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(83, 25);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(155, 20);
            this.txtTen.TabIndex = 1;
            // 
            // lbTen
            // 
            this.lbTen.AutoSize = true;
            this.lbTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTen.Location = new System.Drawing.Point(23, 26);
            this.lbTen.Name = "lbTen";
            this.lbTen.Size = new System.Drawing.Size(46, 16);
            this.lbTen.TabIndex = 0;
            this.lbTen.Text = "Họ tên";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listBox3);
            this.groupBox2.Location = new System.Drawing.Point(345, 30);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(408, 213);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách khách hàng đặt Tour";
            // 
            // listBox3
            // 
            this.listBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox3.Location = new System.Drawing.Point(3, 16);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(402, 194);
            this.listBox3.TabIndex = 0;
            // 
            // btThoat
            // 
            this.btThoat.Location = new System.Drawing.Point(639, 260);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(100, 23);
            this.btThoat.TabIndex = 2;
            this.btThoat.Text = "Thoát";
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            this.btThoat.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btThoat_KeyDown);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 353);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Công ty du thuyền Hồ Tây";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.Label lbGia;
        private System.Windows.Forms.RadioButton rdbNuangay;
        private System.Windows.Forms.RadioButton rdbNgay;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Label lbTen;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTien;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.ComboBox cmbSoluong;
        private System.Windows.Forms.ComboBox cmbChon;
    }
}

