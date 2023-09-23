namespace Ktra
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
            this.gbInfo = new System.Windows.Forms.GroupBox();
            this.cmbTinhtrang = new System.Windows.Forms.ComboBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.gbHuong = new System.Windows.Forms.GroupBox();
            this.rdbTaybac = new System.Windows.Forms.RadioButton();
            this.rdbDongbac = new System.Windows.Forms.RadioButton();
            this.rdbBac = new System.Windows.Forms.RadioButton();
            this.rdbTay = new System.Windows.Forms.RadioButton();
            this.rdbTaynam = new System.Windows.Forms.RadioButton();
            this.rdbDongnam = new System.Windows.Forms.RadioButton();
            this.rdbNam = new System.Windows.Forms.RadioButton();
            this.rdbDong = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTrietkhau = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSonhavs = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSophong = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.lbDiaChi = new System.Windows.Forms.Label();
            this.btnTimkiem = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.lstvDS = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gbInfo.SuspendLayout();
            this.gbHuong.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbInfo
            // 
            this.gbInfo.Controls.Add(this.cmbTinhtrang);
            this.gbInfo.Controls.Add(this.btnXoa);
            this.gbInfo.Controls.Add(this.btnSua);
            this.gbInfo.Controls.Add(this.btnThem);
            this.gbInfo.Controls.Add(this.gbHuong);
            this.gbInfo.Controls.Add(this.label6);
            this.gbInfo.Controls.Add(this.txtGia);
            this.gbInfo.Controls.Add(this.label5);
            this.gbInfo.Controls.Add(this.txtTrietkhau);
            this.gbInfo.Controls.Add(this.label4);
            this.gbInfo.Controls.Add(this.txtSonhavs);
            this.gbInfo.Controls.Add(this.label3);
            this.gbInfo.Controls.Add(this.txtSophong);
            this.gbInfo.Controls.Add(this.label2);
            this.gbInfo.Controls.Add(this.txtDiaChi);
            this.gbInfo.Controls.Add(this.lbDiaChi);
            this.gbInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInfo.Location = new System.Drawing.Point(24, 13);
            this.gbInfo.Name = "gbInfo";
            this.gbInfo.Size = new System.Drawing.Size(319, 426);
            this.gbInfo.TabIndex = 0;
            this.gbInfo.TabStop = false;
            this.gbInfo.Text = "Nhập Thông Tin Phòng";
            // 
            // cmbTinhtrang
            // 
            this.cmbTinhtrang.FormattingEnabled = true;
            this.cmbTinhtrang.Location = new System.Drawing.Point(102, 209);
            this.cmbTinhtrang.Name = "cmbTinhtrang";
            this.cmbTinhtrang.Size = new System.Drawing.Size(121, 24);
            this.cmbTinhtrang.TabIndex = 4;
            this.cmbTinhtrang.SelectedIndexChanged += new System.EventHandler(this.cmbTinhtrang_SelectedIndexChanged);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(221, 381);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(114, 381);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 3;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(9, 381);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 3;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // gbHuong
            // 
            this.gbHuong.Controls.Add(this.rdbTaybac);
            this.gbHuong.Controls.Add(this.rdbDongbac);
            this.gbHuong.Controls.Add(this.rdbBac);
            this.gbHuong.Controls.Add(this.rdbTay);
            this.gbHuong.Controls.Add(this.rdbTaynam);
            this.gbHuong.Controls.Add(this.rdbDongnam);
            this.gbHuong.Controls.Add(this.rdbNam);
            this.gbHuong.Controls.Add(this.rdbDong);
            this.gbHuong.Location = new System.Drawing.Point(9, 248);
            this.gbHuong.Name = "gbHuong";
            this.gbHuong.Size = new System.Drawing.Size(287, 127);
            this.gbHuong.TabIndex = 2;
            this.gbHuong.TabStop = false;
            this.gbHuong.Text = "groupBox2";
            // 
            // rdbTaybac
            // 
            this.rdbTaybac.AutoSize = true;
            this.rdbTaybac.Location = new System.Drawing.Point(160, 98);
            this.rdbTaybac.Name = "rdbTaybac";
            this.rdbTaybac.Size = new System.Drawing.Size(76, 20);
            this.rdbTaybac.TabIndex = 0;
            this.rdbTaybac.TabStop = true;
            this.rdbTaybac.Text = "Tây Bắc";
            this.rdbTaybac.UseVisualStyleBackColor = true;
            this.rdbTaybac.CheckedChanged += new System.EventHandler(this.rdbTaybac_CheckedChanged);
            // 
            // rdbDongbac
            // 
            this.rdbDongbac.AutoSize = true;
            this.rdbDongbac.Location = new System.Drawing.Point(160, 73);
            this.rdbDongbac.Name = "rdbDongbac";
            this.rdbDongbac.Size = new System.Drawing.Size(84, 20);
            this.rdbDongbac.TabIndex = 0;
            this.rdbDongbac.TabStop = true;
            this.rdbDongbac.Text = "Đông Bắc";
            this.rdbDongbac.UseVisualStyleBackColor = true;
            this.rdbDongbac.CheckedChanged += new System.EventHandler(this.rdbDongbac_CheckedChanged);
            // 
            // rdbBac
            // 
            this.rdbBac.AutoSize = true;
            this.rdbBac.Location = new System.Drawing.Point(160, 47);
            this.rdbBac.Name = "rdbBac";
            this.rdbBac.Size = new System.Drawing.Size(49, 20);
            this.rdbBac.TabIndex = 0;
            this.rdbBac.TabStop = true;
            this.rdbBac.Text = "Bắc";
            this.rdbBac.UseVisualStyleBackColor = true;
            this.rdbBac.CheckedChanged += new System.EventHandler(this.rdbBac_CheckedChanged);
            // 
            // rdbTay
            // 
            this.rdbTay.AutoSize = true;
            this.rdbTay.Location = new System.Drawing.Point(160, 21);
            this.rdbTay.Name = "rdbTay";
            this.rdbTay.Size = new System.Drawing.Size(49, 20);
            this.rdbTay.TabIndex = 0;
            this.rdbTay.TabStop = true;
            this.rdbTay.Text = "Tây";
            this.rdbTay.UseVisualStyleBackColor = true;
            this.rdbTay.CheckedChanged += new System.EventHandler(this.rdbTay_CheckedChanged);
            // 
            // rdbTaynam
            // 
            this.rdbTaynam.AutoSize = true;
            this.rdbTaynam.Location = new System.Drawing.Point(23, 98);
            this.rdbTaynam.Name = "rdbTaynam";
            this.rdbTaynam.Size = new System.Drawing.Size(81, 20);
            this.rdbTaynam.TabIndex = 0;
            this.rdbTaynam.TabStop = true;
            this.rdbTaynam.Text = "Tây Nam";
            this.rdbTaynam.UseVisualStyleBackColor = true;
            this.rdbTaynam.CheckedChanged += new System.EventHandler(this.rdbTaynam_CheckedChanged);
            // 
            // rdbDongnam
            // 
            this.rdbDongnam.AutoSize = true;
            this.rdbDongnam.Location = new System.Drawing.Point(23, 73);
            this.rdbDongnam.Name = "rdbDongnam";
            this.rdbDongnam.Size = new System.Drawing.Size(89, 20);
            this.rdbDongnam.TabIndex = 0;
            this.rdbDongnam.TabStop = true;
            this.rdbDongnam.Text = "Đông Nam";
            this.rdbDongnam.UseVisualStyleBackColor = true;
            this.rdbDongnam.CheckedChanged += new System.EventHandler(this.rdbDongnam_CheckedChanged);
            // 
            // rdbNam
            // 
            this.rdbNam.AutoSize = true;
            this.rdbNam.Location = new System.Drawing.Point(23, 47);
            this.rdbNam.Name = "rdbNam";
            this.rdbNam.Size = new System.Drawing.Size(54, 20);
            this.rdbNam.TabIndex = 0;
            this.rdbNam.TabStop = true;
            this.rdbNam.Text = "Nam";
            this.rdbNam.UseVisualStyleBackColor = true;
            this.rdbNam.CheckedChanged += new System.EventHandler(this.rdbNam_CheckedChanged);
            // 
            // rdbDong
            // 
            this.rdbDong.AutoSize = true;
            this.rdbDong.Location = new System.Drawing.Point(23, 21);
            this.rdbDong.Name = "rdbDong";
            this.rdbDong.Size = new System.Drawing.Size(57, 20);
            this.rdbDong.TabIndex = 0;
            this.rdbDong.TabStop = true;
            this.rdbDong.Text = "Đông";
            this.rdbDong.UseVisualStyleBackColor = true;
            this.rdbDong.CheckedChanged += new System.EventHandler(this.rdbDong_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 215);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Tình Trạng";
            // 
            // txtGia
            // 
            this.txtGia.Location = new System.Drawing.Point(102, 171);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(194, 22);
            this.txtGia.TabIndex = 1;
            this.txtGia.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtGia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGia_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Giá";
            // 
            // txtTrietkhau
            // 
            this.txtTrietkhau.Location = new System.Drawing.Point(102, 131);
            this.txtTrietkhau.Name = "txtTrietkhau";
            this.txtTrietkhau.Size = new System.Drawing.Size(194, 22);
            this.txtTrietkhau.TabIndex = 1;
            this.txtTrietkhau.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Triết khấu";
            // 
            // txtSonhavs
            // 
            this.txtSonhavs.Location = new System.Drawing.Point(102, 92);
            this.txtSonhavs.Name = "txtSonhavs";
            this.txtSonhavs.Size = new System.Drawing.Size(194, 22);
            this.txtSonhavs.TabIndex = 1;
            this.txtSonhavs.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtSonhavs.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSonhavs_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Số nhà vệ sinh";
            // 
            // txtSophong
            // 
            this.txtSophong.Location = new System.Drawing.Point(102, 56);
            this.txtSophong.Name = "txtSophong";
            this.txtSophong.Size = new System.Drawing.Size(194, 22);
            this.txtSophong.TabIndex = 1;
            this.txtSophong.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtSophong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSophong_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Số phòng ngủ";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(102, 20);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(194, 22);
            this.txtDiaChi.TabIndex = 1;
            this.txtDiaChi.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lbDiaChi
            // 
            this.lbDiaChi.AutoSize = true;
            this.lbDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDiaChi.Location = new System.Drawing.Point(6, 24);
            this.lbDiaChi.Name = "lbDiaChi";
            this.lbDiaChi.Size = new System.Drawing.Size(49, 16);
            this.lbDiaChi.TabIndex = 0;
            this.lbDiaChi.Text = "Địa Chỉ";
            this.lbDiaChi.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.Location = new System.Drawing.Point(543, 394);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(80, 33);
            this.btnTimkiem.TabIndex = 3;
            this.btnTimkiem.Text = "Tìm Kiếm";
            this.btnTimkiem.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(880, 394);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(81, 33);
            this.btnThoat.TabIndex = 3;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // lstvDS
            // 
            this.lstvDS.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.lstvDS.FullRowSelect = true;
            this.lstvDS.GridLines = true;
            this.lstvDS.HideSelection = false;
            this.lstvDS.Location = new System.Drawing.Point(383, 24);
            this.lstvDS.Name = "lstvDS";
            this.lstvDS.Size = new System.Drawing.Size(712, 364);
            this.lstvDS.TabIndex = 4;
            this.lstvDS.UseCompatibleStateImageBehavior = false;
            this.lstvDS.View = System.Windows.Forms.View.Details;
            this.lstvDS.SelectedIndexChanged += new System.EventHandler(this.lstvDS_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Địa chỉ";
            this.columnHeader1.Width = 135;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Số phòng ngủ";
            this.columnHeader2.Width = 93;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Số nhà WC";
            this.columnHeader3.Width = 78;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Triết khấu";
            this.columnHeader4.Width = 95;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Giá";
            this.columnHeader5.Width = 105;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Hướng ban công";
            this.columnHeader6.Width = 109;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Tình Trạng";
            this.columnHeader7.Width = 89;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1160, 467);
            this.Controls.Add(this.lstvDS);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnTimkiem);
            this.Controls.Add(this.gbInfo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbInfo.ResumeLayout(false);
            this.gbInfo.PerformLayout();
            this.gbHuong.ResumeLayout(false);
            this.gbHuong.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbInfo;
        private System.Windows.Forms.Label lbDiaChi;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtSophong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbHuong;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTrietkhau;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSonhavs;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnTimkiem;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.RadioButton rdbTaybac;
        private System.Windows.Forms.RadioButton rdbDongbac;
        private System.Windows.Forms.RadioButton rdbBac;
        private System.Windows.Forms.RadioButton rdbTay;
        private System.Windows.Forms.RadioButton rdbTaynam;
        private System.Windows.Forms.RadioButton rdbDongnam;
        private System.Windows.Forms.RadioButton rdbNam;
        private System.Windows.Forms.RadioButton rdbDong;
        private System.Windows.Forms.ListView lstvDS;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ComboBox cmbTinhtrang;
    }
}

