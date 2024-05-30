namespace BTL_QL_BenhNhan
{
    partial class Form_Khoa
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
            this.label5 = new System.Windows.Forms.Label();
            this.txb_TenKhoa = new System.Windows.Forms.TextBox();
            this.txb_MaKhoa = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpk_NgayThanhLap = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_Them = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txb_Search = new System.Windows.Forms.TextBox();
            this.btn_TimKiem = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgv_DSKhoa = new System.Windows.Forms.DataGridView();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_DSKhoa)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(63)))), ((int)(((byte)(45)))));
            this.label5.Location = new System.Drawing.Point(572, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 48);
            this.label5.TabIndex = 28;
            this.label5.Text = "Khoa";
            // 
            // txb_TenKhoa
            // 
            this.txb_TenKhoa.Location = new System.Drawing.Point(210, 179);
            this.txb_TenKhoa.Name = "txb_TenKhoa";
            this.txb_TenKhoa.Size = new System.Drawing.Size(197, 32);
            this.txb_TenKhoa.TabIndex = 30;
            // 
            // txb_MaKhoa
            // 
            this.txb_MaKhoa.Location = new System.Drawing.Point(210, 97);
            this.txb_MaKhoa.Name = "txb_MaKhoa";
            this.txb_MaKhoa.Size = new System.Drawing.Size(197, 32);
            this.txb_MaKhoa.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(63)))), ((int)(((byte)(45)))));
            this.label3.Location = new System.Drawing.Point(40, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 24);
            this.label3.TabIndex = 28;
            this.label3.Text = "Mã khoa";
            // 
            // dtpk_NgayThanhLap
            // 
            this.dtpk_NgayThanhLap.CalendarMonthBackground = System.Drawing.Color.Gainsboro;
            this.dtpk_NgayThanhLap.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpk_NgayThanhLap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpk_NgayThanhLap.Location = new System.Drawing.Point(210, 268);
            this.dtpk_NgayThanhLap.Name = "dtpk_NgayThanhLap";
            this.dtpk_NgayThanhLap.Size = new System.Drawing.Size(197, 28);
            this.dtpk_NgayThanhLap.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(63)))), ((int)(((byte)(45)))));
            this.label4.Location = new System.Drawing.Point(40, 268);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ngày thành lập";
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.AutoSize = true;
            this.btn_Xoa.BackColor = System.Drawing.Color.Pink;
            this.btn_Xoa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Xoa.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa.Location = new System.Drawing.Point(323, 419);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(112, 38);
            this.btn_Xoa.TabIndex = 27;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = false;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(63)))), ((int)(((byte)(45)))));
            this.label2.Location = new System.Drawing.Point(40, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên khoa";
            // 
            // btn_Sua
            // 
            this.btn_Sua.AutoSize = true;
            this.btn_Sua.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.btn_Sua.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Sua.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sua.Location = new System.Drawing.Point(187, 419);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(112, 38);
            this.btn_Sua.TabIndex = 26;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = false;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click_1);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupBox2.Controls.Add(this.txb_TenKhoa);
            this.groupBox2.Controls.Add(this.txb_MaKhoa);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.dtpk_NgayThanhLap);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.btn_Xoa);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btn_Sua);
            this.groupBox2.Controls.Add(this.btn_Them);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(779, 127);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(441, 558);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin Khoa";
            // 
            // btn_Them
            // 
            this.btn_Them.AutoSize = true;
            this.btn_Them.BackColor = System.Drawing.Color.Thistle;
            this.btn_Them.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Them.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them.Location = new System.Drawing.Point(44, 419);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(112, 38);
            this.btn_Them.TabIndex = 25;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = false;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click_1);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(25, 44);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 21);
            this.label8.TabIndex = 21;
            this.label8.Text = "Tên khoa";
            // 
            // txb_Search
            // 
            this.txb_Search.Location = new System.Drawing.Point(178, 34);
            this.txb_Search.Multiline = true;
            this.txb_Search.Name = "txb_Search";
            this.txb_Search.Size = new System.Drawing.Size(234, 38);
            this.txb_Search.TabIndex = 22;
            // 
            // btn_TimKiem
            // 
            this.btn_TimKiem.AutoSize = true;
            this.btn_TimKiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(111)))), ((int)(((byte)(0)))));
            this.btn_TimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_TimKiem.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TimKiem.Location = new System.Drawing.Point(478, 34);
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.Size = new System.Drawing.Size(112, 38);
            this.btn_TimKiem.TabIndex = 21;
            this.btn_TimKiem.Text = "Tìm kiếm";
            this.btn_TimKiem.UseVisualStyleBackColor = false;
            this.btn_TimKiem.Click += new System.EventHandler(this.btn_TimKiem_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(206)))), ((int)(((byte)(142)))));
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txb_Search);
            this.groupBox1.Controls.Add(this.btn_TimKiem);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(45, 719);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(650, 87);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 26);
            this.label1.TabIndex = 25;
            this.label1.Text = "Danh sách khoa";
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.DataPropertyName = "ngayThanhLap";
            this.Column3.HeaderText = "Ngày thành lập";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "ten";
            this.Column2.HeaderText = "Tên khoa";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 175;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "ma";
            this.Column1.HeaderText = "Mã khoa";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // dtgv_DSKhoa
            // 
            this.dtgv_DSKhoa.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(216)))), ((int)(((byte)(207)))));
            this.dtgv_DSKhoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_DSKhoa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dtgv_DSKhoa.Location = new System.Drawing.Point(45, 127);
            this.dtgv_DSKhoa.Name = "dtgv_DSKhoa";
            this.dtgv_DSKhoa.RowHeadersWidth = 51;
            this.dtgv_DSKhoa.RowTemplate.Height = 24;
            this.dtgv_DSKhoa.Size = new System.Drawing.Size(638, 558);
            this.dtgv_DSKhoa.TabIndex = 24;
            this.dtgv_DSKhoa.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_DSKhoa_CellClick);
            this.dtgv_DSKhoa.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dtgv_DSKhoa_RowPrePaint);
            // 
            // Form_Khoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 833);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgv_DSKhoa);
            this.Name = "Form_Khoa";
            this.Text = "Khoa";
            this.Load += new System.EventHandler(this.Form_Khoa_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_DSKhoa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txb_TenKhoa;
        private System.Windows.Forms.TextBox txb_MaKhoa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpk_NgayThanhLap;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txb_Search;
        private System.Windows.Forms.Button btn_TimKiem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridView dtgv_DSKhoa;
    }
}