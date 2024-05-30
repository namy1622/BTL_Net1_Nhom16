namespace BTL_QL_BenhNhan
{
    partial class Form_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Login));
            this.lb_Main = new System.Windows.Forms.Label();
            this.btn_DK_DN = new System.Windows.Forms.Button();
            this.btn_QuenMK = new System.Windows.Forms.Button();
            this.gb_QuenMK = new System.Windows.Forms.GroupBox();
            this.btn_LayMK = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txb_NhapMa = new System.Windows.Forms.TextBox();
            this.btn_GuiMa = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txb_NhapEmail = new System.Windows.Forms.TextBox();
            this.pn_TK_MK = new System.Windows.Forms.Panel();
            this.gb_SDT = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txb_SDT = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txb_MatKhau = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txb_TaiKhoan = new System.Windows.Forms.TextBox();
            this.gb_ReMK = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txb_ReMK = new System.Windows.Forms.TextBox();
            this.cb_ShowMK = new System.Windows.Forms.CheckBox();
            this.btn_LogIn_Out = new System.Windows.Forms.Button();
            this.gb_QuenMK.SuspendLayout();
            this.pn_TK_MK.SuspendLayout();
            this.gb_SDT.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.gb_ReMK.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_Main
            // 
            this.lb_Main.AutoSize = true;
            this.lb_Main.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Main.Location = new System.Drawing.Point(636, 53);
            this.lb_Main.Name = "lb_Main";
            this.lb_Main.Size = new System.Drawing.Size(239, 48);
            this.lb_Main.TabIndex = 0;
            this.lb_Main.Text = "Đăng nhập";
            // 
            // btn_DK_DN
            // 
            this.btn_DK_DN.AutoSize = true;
            this.btn_DK_DN.BackgroundImage = global::BTL_QL_BenhNhan.Properties.Resources.img_button1;
            this.btn_DK_DN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_DK_DN.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DK_DN.ForeColor = System.Drawing.Color.Black;
            this.btn_DK_DN.Location = new System.Drawing.Point(684, 562);
            this.btn_DK_DN.Name = "btn_DK_DN";
            this.btn_DK_DN.Size = new System.Drawing.Size(117, 35);
            this.btn_DK_DN.TabIndex = 14;
            this.btn_DK_DN.Text = "Đăng kí";
            this.btn_DK_DN.UseVisualStyleBackColor = true;
            this.btn_DK_DN.Click += new System.EventHandler(this.btn_DK_DN_Click);
            // 
            // btn_QuenMK
            // 
            this.btn_QuenMK.AutoSize = true;
            this.btn_QuenMK.BackgroundImage = global::BTL_QL_BenhNhan.Properties.Resources.img_button1;
            this.btn_QuenMK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_QuenMK.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_QuenMK.ForeColor = System.Drawing.Color.Black;
            this.btn_QuenMK.Location = new System.Drawing.Point(807, 562);
            this.btn_QuenMK.Name = "btn_QuenMK";
            this.btn_QuenMK.Size = new System.Drawing.Size(117, 35);
            this.btn_QuenMK.TabIndex = 15;
            this.btn_QuenMK.Text = "Quên mật khẩu";
            this.btn_QuenMK.UseVisualStyleBackColor = true;
            this.btn_QuenMK.Click += new System.EventHandler(this.btn_QuenMK_Click);
            // 
            // gb_QuenMK
            // 
            this.gb_QuenMK.Controls.Add(this.btn_LayMK);
            this.gb_QuenMK.Controls.Add(this.label5);
            this.gb_QuenMK.Controls.Add(this.txb_NhapMa);
            this.gb_QuenMK.Controls.Add(this.btn_GuiMa);
            this.gb_QuenMK.Controls.Add(this.label4);
            this.gb_QuenMK.Controls.Add(this.txb_NhapEmail);
            this.gb_QuenMK.Location = new System.Drawing.Point(556, 184);
            this.gb_QuenMK.Name = "gb_QuenMK";
            this.gb_QuenMK.Size = new System.Drawing.Size(378, 247);
            this.gb_QuenMK.TabIndex = 23;
            this.gb_QuenMK.TabStop = false;
            // 
            // btn_LayMK
            // 
            this.btn_LayMK.AutoSize = true;
            this.btn_LayMK.BackgroundImage = global::BTL_QL_BenhNhan.Properties.Resources.img_button1;
            this.btn_LayMK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_LayMK.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LayMK.ForeColor = System.Drawing.Color.Black;
            this.btn_LayMK.Location = new System.Drawing.Point(96, 203);
            this.btn_LayMK.Name = "btn_LayMK";
            this.btn_LayMK.Size = new System.Drawing.Size(159, 38);
            this.btn_LayMK.TabIndex = 29;
            this.btn_LayMK.Text = "Lấy lại Mật khẩu";
            this.btn_LayMK.UseVisualStyleBackColor = true;
            this.btn_LayMK.Click += new System.EventHandler(this.btn_LayMK_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Image = global::BTL_QL_BenhNhan.Properties.Resources.img_button1;
            this.label5.Location = new System.Drawing.Point(0, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 26);
            this.label5.TabIndex = 28;
            this.label5.Text = "Nhập mã XN";
            // 
            // txb_NhapMa
            // 
            this.txb_NhapMa.BackColor = System.Drawing.Color.Azure;
            this.txb_NhapMa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_NhapMa.Location = new System.Drawing.Point(149, 147);
            this.txb_NhapMa.Multiline = true;
            this.txb_NhapMa.Name = "txb_NhapMa";
            this.txb_NhapMa.Size = new System.Drawing.Size(229, 35);
            this.txb_NhapMa.TabIndex = 27;
            // 
            // btn_GuiMa
            // 
            this.btn_GuiMa.AutoSize = true;
            this.btn_GuiMa.BackgroundImage = global::BTL_QL_BenhNhan.Properties.Resources.img_button1;
            this.btn_GuiMa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_GuiMa.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_GuiMa.ForeColor = System.Drawing.Color.Black;
            this.btn_GuiMa.Location = new System.Drawing.Point(96, 72);
            this.btn_GuiMa.Name = "btn_GuiMa";
            this.btn_GuiMa.Size = new System.Drawing.Size(149, 38);
            this.btn_GuiMa.TabIndex = 26;
            this.btn_GuiMa.Text = "Gửi mã";
            this.btn_GuiMa.UseVisualStyleBackColor = true;
            this.btn_GuiMa.Click += new System.EventHandler(this.btn_GuiMa_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Image = global::BTL_QL_BenhNhan.Properties.Resources.img_button1;
            this.label4.Location = new System.Drawing.Point(0, 2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(238, 26);
            this.label4.TabIndex = 25;
            this.label4.Text = "Nhập Email đã đăng kí";
            // 
            // txb_NhapEmail
            // 
            this.txb_NhapEmail.BackColor = System.Drawing.Color.Azure;
            this.txb_NhapEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_NhapEmail.Location = new System.Drawing.Point(0, 31);
            this.txb_NhapEmail.Multiline = true;
            this.txb_NhapEmail.Name = "txb_NhapEmail";
            this.txb_NhapEmail.Size = new System.Drawing.Size(378, 35);
            this.txb_NhapEmail.TabIndex = 20;
            // 
            // pn_TK_MK
            // 
            this.pn_TK_MK.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pn_TK_MK.Controls.Add(this.gb_SDT);
            this.pn_TK_MK.Controls.Add(this.groupBox4);
            this.pn_TK_MK.Controls.Add(this.groupBox5);
            this.pn_TK_MK.Controls.Add(this.gb_ReMK);
            this.pn_TK_MK.Controls.Add(this.cb_ShowMK);
            this.pn_TK_MK.Controls.Add(this.btn_LogIn_Out);
            this.pn_TK_MK.Location = new System.Drawing.Point(556, 164);
            this.pn_TK_MK.Name = "pn_TK_MK";
            this.pn_TK_MK.Size = new System.Drawing.Size(389, 392);
            this.pn_TK_MK.TabIndex = 24;
            // 
            // gb_SDT
            // 
            this.gb_SDT.Controls.Add(this.label1);
            this.gb_SDT.Controls.Add(this.txb_SDT);
            this.gb_SDT.Location = new System.Drawing.Point(3, 223);
            this.gb_SDT.Name = "gb_SDT";
            this.gb_SDT.Size = new System.Drawing.Size(378, 37);
            this.gb_SDT.TabIndex = 23;
            this.gb_SDT.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Image = global::BTL_QL_BenhNhan.Properties.Resources.img_button1;
            this.label1.Location = new System.Drawing.Point(0, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 26);
            this.label1.TabIndex = 25;
            this.label1.Text = "Số điện thoại";
            // 
            // txb_SDT
            // 
            this.txb_SDT.BackColor = System.Drawing.Color.Azure;
            this.txb_SDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_SDT.Location = new System.Drawing.Point(163, 2);
            this.txb_SDT.Multiline = true;
            this.txb_SDT.Name = "txb_SDT";
            this.txb_SDT.Size = new System.Drawing.Size(215, 35);
            this.txb_SDT.TabIndex = 20;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.txb_MatKhau);
            this.groupBox4.Location = new System.Drawing.Point(0, 105);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(378, 39);
            this.groupBox4.TabIndex = 22;
            this.groupBox4.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Image = global::BTL_QL_BenhNhan.Properties.Resources.img_button1;
            this.label6.Location = new System.Drawing.Point(6, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 26);
            this.label6.TabIndex = 24;
            this.label6.Text = "Mật khẩu";
            // 
            // txb_MatKhau
            // 
            this.txb_MatKhau.BackColor = System.Drawing.Color.Azure;
            this.txb_MatKhau.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txb_MatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_MatKhau.Location = new System.Drawing.Point(134, 0);
            this.txb_MatKhau.Multiline = true;
            this.txb_MatKhau.Name = "txb_MatKhau";
            this.txb_MatKhau.PasswordChar = '*';
            this.txb_MatKhau.Size = new System.Drawing.Size(250, 35);
            this.txb_MatKhau.TabIndex = 17;
            this.txb_MatKhau.Enter += new System.EventHandler(this.txb_MatKhau_Enter);
            this.txb_MatKhau.Leave += new System.EventHandler(this.txb_MatKhau_Leave);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.txb_TaiKhoan);
            this.groupBox5.Location = new System.Drawing.Point(0, 28);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(378, 37);
            this.groupBox5.TabIndex = 21;
            this.groupBox5.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Image = global::BTL_QL_BenhNhan.Properties.Resources.img_button1;
            this.label7.Location = new System.Drawing.Point(6, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 26);
            this.label7.TabIndex = 23;
            this.label7.Text = "Tài khoản";
            // 
            // txb_TaiKhoan
            // 
            this.txb_TaiKhoan.BackColor = System.Drawing.Color.Azure;
            this.txb_TaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_TaiKhoan.Location = new System.Drawing.Point(134, 0);
            this.txb_TaiKhoan.Multiline = true;
            this.txb_TaiKhoan.Name = "txb_TaiKhoan";
            this.txb_TaiKhoan.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txb_TaiKhoan.Size = new System.Drawing.Size(250, 35);
            this.txb_TaiKhoan.TabIndex = 6;
            this.txb_TaiKhoan.Enter += new System.EventHandler(this.txb_TaiKhoan_Enter);
            this.txb_TaiKhoan.Leave += new System.EventHandler(this.txb_TaiKhoan_Leave);
            // 
            // gb_ReMK
            // 
            this.gb_ReMK.Controls.Add(this.label8);
            this.gb_ReMK.Controls.Add(this.txb_ReMK);
            this.gb_ReMK.Location = new System.Drawing.Point(0, 164);
            this.gb_ReMK.Name = "gb_ReMK";
            this.gb_ReMK.Size = new System.Drawing.Size(378, 37);
            this.gb_ReMK.TabIndex = 19;
            this.gb_ReMK.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Image = global::BTL_QL_BenhNhan.Properties.Resources.img_button1;
            this.label8.Location = new System.Drawing.Point(6, 8);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(133, 26);
            this.label8.TabIndex = 25;
            this.label8.Text = "Nhập lại MK";
            // 
            // txb_ReMK
            // 
            this.txb_ReMK.BackColor = System.Drawing.Color.Azure;
            this.txb_ReMK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_ReMK.Location = new System.Drawing.Point(157, 2);
            this.txb_ReMK.Multiline = true;
            this.txb_ReMK.Name = "txb_ReMK";
            this.txb_ReMK.PasswordChar = '*';
            this.txb_ReMK.Size = new System.Drawing.Size(221, 35);
            this.txb_ReMK.TabIndex = 20;
            this.txb_ReMK.Enter += new System.EventHandler(this.txb_ReMK_Enter);
            this.txb_ReMK.Leave += new System.EventHandler(this.txb_ReMK_Leave);
            // 
            // cb_ShowMK
            // 
            this.cb_ShowMK.AutoSize = true;
            this.cb_ShowMK.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_ShowMK.Location = new System.Drawing.Point(127, 272);
            this.cb_ShowMK.Name = "cb_ShowMK";
            this.cb_ShowMK.Size = new System.Drawing.Size(139, 25);
            this.cb_ShowMK.TabIndex = 8;
            this.cb_ShowMK.Text = "Hiện mật khẩu";
            this.cb_ShowMK.UseVisualStyleBackColor = true;
            this.cb_ShowMK.CheckedChanged += new System.EventHandler(this.cb_ShowMK_CheckedChanged);
            // 
            // btn_LogIn_Out
            // 
            this.btn_LogIn_Out.AutoSize = true;
            this.btn_LogIn_Out.BackgroundImage = global::BTL_QL_BenhNhan.Properties.Resources.img_button1;
            this.btn_LogIn_Out.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_LogIn_Out.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LogIn_Out.ForeColor = System.Drawing.Color.Black;
            this.btn_LogIn_Out.Location = new System.Drawing.Point(32, 322);
            this.btn_LogIn_Out.Name = "btn_LogIn_Out";
            this.btn_LogIn_Out.Size = new System.Drawing.Size(320, 48);
            this.btn_LogIn_Out.TabIndex = 13;
            this.btn_LogIn_Out.Text = "Đăng nhập";
            this.btn_LogIn_Out.UseVisualStyleBackColor = true;
            this.btn_LogIn_Out.Click += new System.EventHandler(this.btn_LogIn_Out_Click_1);
            // 
            // Form_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BackgroundImage = global::BTL_QL_BenhNhan.Properties.Resources.login12;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(982, 612);
            this.Controls.Add(this.pn_TK_MK);
            this.Controls.Add(this.gb_QuenMK);
            this.Controls.Add(this.btn_QuenMK);
            this.Controls.Add(this.btn_DK_DN);
            this.Controls.Add(this.lb_Main);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1004, 663);
            this.MinimumSize = new System.Drawing.Size(1004, 663);
            this.Name = "Form_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TrangChu_FormClosed);
            this.Load += new System.EventHandler(this.Form_Login_Load);
            this.gb_QuenMK.ResumeLayout(false);
            this.gb_QuenMK.PerformLayout();
            this.pn_TK_MK.ResumeLayout(false);
            this.pn_TK_MK.PerformLayout();
            this.gb_SDT.ResumeLayout(false);
            this.gb_SDT.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.gb_ReMK.ResumeLayout(false);
            this.gb_ReMK.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_Main;
        private System.Windows.Forms.Button btn_DK_DN;
        private System.Windows.Forms.Button btn_QuenMK;
        private System.Windows.Forms.GroupBox gb_QuenMK;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txb_NhapEmail;
        private System.Windows.Forms.Button btn_GuiMa;
        private System.Windows.Forms.Button btn_LayMK;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txb_NhapMa;
        private System.Windows.Forms.Panel pn_TK_MK;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txb_MatKhau;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txb_TaiKhoan;
        private System.Windows.Forms.GroupBox gb_ReMK;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txb_ReMK;
        private System.Windows.Forms.CheckBox cb_ShowMK;
        private System.Windows.Forms.Button btn_LogIn_Out;
        private System.Windows.Forms.GroupBox gb_SDT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txb_SDT;
    }
}

