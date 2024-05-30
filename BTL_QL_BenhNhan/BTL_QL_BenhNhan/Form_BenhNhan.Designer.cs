namespace BTL_QL_BenhNhan
{
    partial class Form_BenhNhan
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
            this.dtgv_DS_BenhNhan = new System.Windows.Forms.DataGridView();
            this.pb_AnhBN = new System.Windows.Forms.PictureBox();
            this.btn_TimKiem = new System.Windows.Forms.Button();
            this.txb_TimKiem = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.txb_CCCD = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbb_MaBS = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cbb_MaKhoa = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtpk_NgaySinh = new System.Windows.Forms.DateTimePicker();
            this.txb_TinhTrang = new System.Windows.Forms.TextBox();
            this.txb_CanNang = new System.Windows.Forms.TextBox();
            this.txb_BHYT = new System.Windows.Forms.TextBox();
            this.txb_DiaChi = new System.Windows.Forms.TextBox();
            this.txb_ChieuCao = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txb_GioiTinh = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txb_TenBN = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txb_MaBN = new System.Windows.Forms.TextBox();
            this.lb_MaBN = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_XuatExcel = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_DS_BenhNhan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_AnhBN)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgv_DS_BenhNhan
            // 
            this.dtgv_DS_BenhNhan.AllowUserToAddRows = false;
            this.dtgv_DS_BenhNhan.AllowUserToDeleteRows = false;
            this.dtgv_DS_BenhNhan.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgv_DS_BenhNhan.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dtgv_DS_BenhNhan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_DS_BenhNhan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11,
            this.Column13});
            this.dtgv_DS_BenhNhan.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dtgv_DS_BenhNhan.Location = new System.Drawing.Point(29, 76);
            this.dtgv_DS_BenhNhan.Name = "dtgv_DS_BenhNhan";
            this.dtgv_DS_BenhNhan.ReadOnly = true;
            this.dtgv_DS_BenhNhan.RowHeadersWidth = 51;
            this.dtgv_DS_BenhNhan.RowTemplate.Height = 24;
            this.dtgv_DS_BenhNhan.Size = new System.Drawing.Size(1057, 277);
            this.dtgv_DS_BenhNhan.TabIndex = 14;
            this.dtgv_DS_BenhNhan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_DS_BenhNhan_CellClick);
            this.dtgv_DS_BenhNhan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_DS_BenhNhan_CellContentClick);
            this.dtgv_DS_BenhNhan.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dtgv_DS_BenhNhan_RowPrePaint);
            // 
            // pb_AnhBN
            // 
            this.pb_AnhBN.BackColor = System.Drawing.Color.White;
            this.pb_AnhBN.BackgroundImage = global::BTL_QL_BenhNhan.Properties.Resources.user;
            this.pb_AnhBN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pb_AnhBN.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pb_AnhBN.Location = new System.Drawing.Point(20, 69);
            this.pb_AnhBN.Name = "pb_AnhBN";
            this.pb_AnhBN.Size = new System.Drawing.Size(142, 167);
            this.pb_AnhBN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_AnhBN.TabIndex = 63;
            this.pb_AnhBN.TabStop = false;
            this.pb_AnhBN.Click += new System.EventHandler(this.pb_AnhBN_Click);
            // 
            // btn_TimKiem
            // 
            this.btn_TimKiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_TimKiem.Location = new System.Drawing.Point(363, 24);
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.Size = new System.Drawing.Size(112, 29);
            this.btn_TimKiem.TabIndex = 62;
            this.btn_TimKiem.Text = "Tìm kiếm";
            this.btn_TimKiem.UseVisualStyleBackColor = false;
            this.btn_TimKiem.Click += new System.EventHandler(this.btn_TimKiem_Click_1);
            // 
            // txb_TimKiem
            // 
            this.txb_TimKiem.Location = new System.Drawing.Point(122, 24);
            this.txb_TimKiem.Name = "txb_TimKiem";
            this.txb_TimKiem.Size = new System.Drawing.Size(202, 28);
            this.txb_TimKiem.TabIndex = 61;
            this.txb_TimKiem.TextChanged += new System.EventHandler(this.txb_TimKiem_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(29, 28);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(87, 21);
            this.label14.TabIndex = 60;
            this.label14.Text = "Tim kiếm";
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.BackColor = System.Drawing.Color.Green;
            this.btn_Xoa.Location = new System.Drawing.Point(398, 402);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(105, 40);
            this.btn_Xoa.TabIndex = 59;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = false;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click_1);
            // 
            // btn_Sua
            // 
            this.btn_Sua.BackColor = System.Drawing.Color.Olive;
            this.btn_Sua.Location = new System.Drawing.Point(215, 400);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(120, 42);
            this.btn_Sua.TabIndex = 58;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = false;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click_1);
            // 
            // btn_Them
            // 
            this.btn_Them.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Them.Location = new System.Drawing.Point(42, 400);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(120, 42);
            this.btn_Them.TabIndex = 57;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = false;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click_1);
            // 
            // txb_CCCD
            // 
            this.txb_CCCD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(175)))), ((int)(((byte)(169)))));
            this.txb_CCCD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txb_CCCD.Location = new System.Drawing.Point(713, 141);
            this.txb_CCCD.Multiline = true;
            this.txb_CCCD.Name = "txb_CCCD";
            this.txb_CCCD.Size = new System.Drawing.Size(160, 25);
            this.txb_CCCD.TabIndex = 56;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(562, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 21);
            this.label5.TabIndex = 55;
            this.label5.Text = "CCCD";
            // 
            // cbb_MaBS
            // 
            this.cbb_MaBS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(175)))), ((int)(((byte)(169)))));
            this.cbb_MaBS.FormattingEnabled = true;
            this.cbb_MaBS.Location = new System.Drawing.Point(713, 330);
            this.cbb_MaBS.Name = "cbb_MaBS";
            this.cbb_MaBS.Size = new System.Drawing.Size(160, 29);
            this.cbb_MaBS.TabIndex = 53;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(63)))), ((int)(((byte)(45)))));
            this.label10.Location = new System.Drawing.Point(508, -6);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(237, 48);
            this.label10.TabIndex = 13;
            this.label10.Text = "Bệnh nhân";
            // 
            // cbb_MaKhoa
            // 
            this.cbb_MaKhoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(175)))), ((int)(((byte)(169)))));
            this.cbb_MaKhoa.FormattingEnabled = true;
            this.cbb_MaKhoa.Location = new System.Drawing.Point(1038, 333);
            this.cbb_MaKhoa.Name = "cbb_MaKhoa";
            this.cbb_MaKhoa.Size = new System.Drawing.Size(115, 29);
            this.cbb_MaKhoa.TabIndex = 54;
            this.cbb_MaKhoa.SelectedIndexChanged += new System.EventHandler(this.cbb_MaKhoa_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.pb_AnhBN);
            this.groupBox1.Controls.Add(this.btn_Xoa);
            this.groupBox1.Controls.Add(this.btn_Sua);
            this.groupBox1.Controls.Add(this.btn_Them);
            this.groupBox1.Controls.Add(this.txb_CCCD);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cbb_MaKhoa);
            this.groupBox1.Controls.Add(this.cbb_MaBS);
            this.groupBox1.Controls.Add(this.dtpk_NgaySinh);
            this.groupBox1.Controls.Add(this.txb_TinhTrang);
            this.groupBox1.Controls.Add(this.txb_CanNang);
            this.groupBox1.Controls.Add(this.txb_BHYT);
            this.groupBox1.Controls.Add(this.txb_DiaChi);
            this.groupBox1.Controls.Add(this.txb_ChieuCao);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txb_GioiTinh);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txb_TenBN);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txb_MaBN);
            this.groupBox1.Controls.Add(this.lb_MaBN);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(63)))), ((int)(((byte)(45)))));
            this.groupBox1.Location = new System.Drawing.Point(29, 369);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1207, 469);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chi tiết";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btn_TimKiem);
            this.panel1.Controls.Add(this.txb_TimKiem);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Location = new System.Drawing.Point(656, 389);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(506, 63);
            this.panel1.TabIndex = 64;
            // 
            // dtpk_NgaySinh
            // 
            this.dtpk_NgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpk_NgaySinh.Location = new System.Drawing.Point(343, 141);
            this.dtpk_NgaySinh.Name = "dtpk_NgaySinh";
            this.dtpk_NgaySinh.Size = new System.Drawing.Size(160, 28);
            this.dtpk_NgaySinh.TabIndex = 52;
            // 
            // txb_TinhTrang
            // 
            this.txb_TinhTrang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(175)))), ((int)(((byte)(169)))));
            this.txb_TinhTrang.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txb_TinhTrang.Location = new System.Drawing.Point(1038, 246);
            this.txb_TinhTrang.Multiline = true;
            this.txb_TinhTrang.Name = "txb_TinhTrang";
            this.txb_TinhTrang.Size = new System.Drawing.Size(115, 25);
            this.txb_TinhTrang.TabIndex = 50;
            // 
            // txb_CanNang
            // 
            this.txb_CanNang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(175)))), ((int)(((byte)(169)))));
            this.txb_CanNang.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txb_CanNang.Location = new System.Drawing.Point(1038, 147);
            this.txb_CanNang.Multiline = true;
            this.txb_CanNang.Name = "txb_CanNang";
            this.txb_CanNang.Size = new System.Drawing.Size(115, 25);
            this.txb_CanNang.TabIndex = 49;
            // 
            // txb_BHYT
            // 
            this.txb_BHYT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(175)))), ((int)(((byte)(169)))));
            this.txb_BHYT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txb_BHYT.Location = new System.Drawing.Point(713, 238);
            this.txb_BHYT.Multiline = true;
            this.txb_BHYT.Name = "txb_BHYT";
            this.txb_BHYT.Size = new System.Drawing.Size(160, 25);
            this.txb_BHYT.TabIndex = 47;
            // 
            // txb_DiaChi
            // 
            this.txb_DiaChi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(175)))), ((int)(((byte)(169)))));
            this.txb_DiaChi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txb_DiaChi.Location = new System.Drawing.Point(343, 326);
            this.txb_DiaChi.Multiline = true;
            this.txb_DiaChi.Name = "txb_DiaChi";
            this.txb_DiaChi.Size = new System.Drawing.Size(160, 25);
            this.txb_DiaChi.TabIndex = 45;
            // 
            // txb_ChieuCao
            // 
            this.txb_ChieuCao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(175)))), ((int)(((byte)(169)))));
            this.txb_ChieuCao.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txb_ChieuCao.Location = new System.Drawing.Point(343, 238);
            this.txb_ChieuCao.Multiline = true;
            this.txb_ChieuCao.Name = "txb_ChieuCao";
            this.txb_ChieuCao.Size = new System.Drawing.Size(160, 25);
            this.txb_ChieuCao.TabIndex = 44;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(908, 341);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(82, 21);
            this.label13.TabIndex = 42;
            this.label13.Text = "Mã khoa";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(562, 333);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(89, 21);
            this.label12.TabIndex = 41;
            this.label12.Text = "Mã bác sĩ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(182, 330);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 21);
            this.label11.TabIndex = 40;
            this.label11.Text = "Địa Chỉ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(908, 246);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 21);
            this.label9.TabIndex = 39;
            this.label9.Text = "Tình Trạng";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(562, 242);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 21);
            this.label8.TabIndex = 38;
            this.label8.Text = "BHYT";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(182, 238);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 21);
            this.label7.TabIndex = 37;
            this.label7.Text = "Chiều cao";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(908, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 21);
            this.label6.TabIndex = 36;
            this.label6.Text = "Cân nặng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(182, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 21);
            this.label4.TabIndex = 34;
            this.label4.Text = "Ngày Sinh";
            // 
            // txb_GioiTinh
            // 
            this.txb_GioiTinh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(175)))), ((int)(((byte)(169)))));
            this.txb_GioiTinh.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txb_GioiTinh.Location = new System.Drawing.Point(1038, 48);
            this.txb_GioiTinh.Multiline = true;
            this.txb_GioiTinh.Name = "txb_GioiTinh";
            this.txb_GioiTinh.Size = new System.Drawing.Size(115, 25);
            this.txb_GioiTinh.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(908, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 21);
            this.label3.TabIndex = 32;
            this.label3.Text = "Giới Tính";
            // 
            // txb_TenBN
            // 
            this.txb_TenBN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(175)))), ((int)(((byte)(169)))));
            this.txb_TenBN.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txb_TenBN.Location = new System.Drawing.Point(713, 48);
            this.txb_TenBN.Multiline = true;
            this.txb_TenBN.Name = "txb_TenBN";
            this.txb_TenBN.Size = new System.Drawing.Size(160, 25);
            this.txb_TenBN.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(551, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 21);
            this.label2.TabIndex = 30;
            this.label2.Text = "Tên bệnh nhân";
            // 
            // txb_MaBN
            // 
            this.txb_MaBN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(175)))), ((int)(((byte)(169)))));
            this.txb_MaBN.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txb_MaBN.Location = new System.Drawing.Point(343, 48);
            this.txb_MaBN.Multiline = true;
            this.txb_MaBN.Name = "txb_MaBN";
            this.txb_MaBN.Size = new System.Drawing.Size(160, 25);
            this.txb_MaBN.TabIndex = 29;
            // 
            // lb_MaBN
            // 
            this.lb_MaBN.AutoSize = true;
            this.lb_MaBN.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_MaBN.Location = new System.Drawing.Point(182, 52);
            this.lb_MaBN.Name = "lb_MaBN";
            this.lb_MaBN.Size = new System.Drawing.Size(131, 21);
            this.lb_MaBN.TabIndex = 1;
            this.lb_MaBN.Text = "Mã bệnh nhân";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 24);
            this.label1.TabIndex = 11;
            this.label1.Text = "Danh sách bệnh nhân";
            // 
            // btn_XuatExcel
            // 
            this.btn_XuatExcel.AutoSize = true;
            this.btn_XuatExcel.BackColor = System.Drawing.Color.Teal;
            this.btn_XuatExcel.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.btn_XuatExcel.FlatAppearance.BorderSize = 2;
            this.btn_XuatExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_XuatExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_XuatExcel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_XuatExcel.Image = global::BTL_QL_BenhNhan.Properties.Resources.excel;
            this.btn_XuatExcel.Location = new System.Drawing.Point(1092, 167);
            this.btn_XuatExcel.Name = "btn_XuatExcel";
            this.btn_XuatExcel.Size = new System.Drawing.Size(168, 54);
            this.btn_XuatExcel.TabIndex = 15;
            this.btn_XuatExcel.Text = " Xuất Excel";
            this.btn_XuatExcel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_XuatExcel.UseVisualStyleBackColor = false;
            this.btn_XuatExcel.Click += new System.EventHandler(this.btn_XuatExcel_Click);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "ma";
            this.Column1.HeaderText = "Mã";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "ten";
            this.Column2.HeaderText = "Tên";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "gioiTinh";
            this.Column3.HeaderText = "Giới Tính";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "ngaySinh";
            this.Column4.HeaderText = "Ngày Sinh";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "CCCD";
            this.Column5.HeaderText = "CCCD";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 125;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "canNang";
            this.Column6.HeaderText = "Cân Nặng";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 125;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "chieuCao";
            this.Column7.HeaderText = "Chiều Cao";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 125;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "BHYT";
            this.Column8.HeaderText = "BHYT";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 125;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "tinhTrang";
            this.Column9.HeaderText = "Tình Trạng";
            this.Column9.MinimumWidth = 6;
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Width = 125;
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "diaChi";
            this.Column10.HeaderText = "Địa Chỉ";
            this.Column10.MinimumWidth = 6;
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            this.Column10.Width = 125;
            // 
            // Column11
            // 
            this.Column11.DataPropertyName = "tenBacSi";
            this.Column11.HeaderText = "Bác Sĩ Điều Trị";
            this.Column11.MinimumWidth = 6;
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            this.Column11.Width = 125;
            // 
            // Column13
            // 
            this.Column13.DataPropertyName = "tenKhoa";
            this.Column13.HeaderText = "Tên Khoa Điều Trị";
            this.Column13.MinimumWidth = 6;
            this.Column13.Name = "Column13";
            this.Column13.ReadOnly = true;
            this.Column13.Width = 125;
            // 
            // Form_BenhNhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 833);
            this.Controls.Add(this.btn_XuatExcel);
            this.Controls.Add(this.dtgv_DS_BenhNhan);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form_BenhNhan";
            this.Text = "BenhNhan";
            this.Load += new System.EventHandler(this.Form_BenhNhan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_DS_BenhNhan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_AnhBN)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dtgv_DS_BenhNhan;
        private System.Windows.Forms.PictureBox pb_AnhBN;
        private System.Windows.Forms.Button btn_TimKiem;
        private System.Windows.Forms.TextBox txb_TimKiem;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.TextBox txb_CCCD;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbb_MaBS;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbb_MaKhoa;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpk_NgaySinh;
        private System.Windows.Forms.TextBox txb_TinhTrang;
        private System.Windows.Forms.TextBox txb_CanNang;
        private System.Windows.Forms.TextBox txb_BHYT;
        private System.Windows.Forms.TextBox txb_DiaChi;
        private System.Windows.Forms.TextBox txb_ChieuCao;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txb_GioiTinh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txb_TenBN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txb_MaBN;
        private System.Windows.Forms.Label lb_MaBN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_XuatExcel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
    }
}