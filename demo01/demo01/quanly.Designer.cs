namespace demo01
{
    partial class quanly
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(quanly));
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.labelGiaodiennhanvien = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.labelDangxuat = new System.Windows.Forms.Label();
            this.btnDong = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.btnThunho = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnThongke = new Guna.UI2.WinForms.Guna2GradientCircleButton();
            this.btnQlDichVu = new Guna.UI2.WinForms.Guna2GradientCircleButton();
            this.btnQlNhanVien = new Guna.UI2.WinForms.Guna2GradientCircleButton();
            this.btnQlkhach = new Guna.UI2.WinForms.Guna2GradientCircleButton();
            this.btnQlPhong = new Guna.UI2.WinForms.Guna2GradientCircleButton();
            this.uC_QuanLyNhanVien1 = new demo01.All_Use_Control.UC_QuanLyNhanVien();
            this.uC_DangKiKhach1 = new demo01.All_Use_Control.UC_DangKiKhach();
            this.uC_AddRoom2 = new demo01.All_Use_Control.UC_AddRoom();
            this.uC_AddRoom1 = new demo01.All_Use_Control.UC_AddRoom();
            this.uC_QuanLyDichVu1 = new demo01.All_Use_Control.UC_QuanLyDichVu();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 25;
            this.guna2Elipse1.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnThongke);
            this.panel1.Controls.Add(this.btnQlDichVu);
            this.panel1.Controls.Add(this.btnQlNhanVien);
            this.panel1.Controls.Add(this.btnQlkhach);
            this.panel1.Controls.Add(this.btnQlPhong);
            this.panel1.Location = new System.Drawing.Point(5, 123);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(101, 557);
            this.panel1.TabIndex = 19;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.uC_QuanLyDichVu1);
            this.panel2.Controls.Add(this.uC_QuanLyNhanVien1);
            this.panel2.Controls.Add(this.uC_DangKiKhach1);
            this.panel2.Controls.Add(this.uC_AddRoom2);
            this.panel2.Controls.Add(this.uC_AddRoom1);
            this.panel2.Location = new System.Drawing.Point(122, 64);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1120, 570);
            this.panel2.TabIndex = 20;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Monotype Corsiva", 25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(563, 16);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(221, 42);
            this.guna2HtmlLabel1.TabIndex = 21;
            this.guna2HtmlLabel1.Text = "May Plaza Hotel";
            // 
            // labelGiaodiennhanvien
            // 
            this.labelGiaodiennhanvien.AutoSize = true;
            this.labelGiaodiennhanvien.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelGiaodiennhanvien.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGiaodiennhanvien.Location = new System.Drawing.Point(999, 661);
            this.labelGiaodiennhanvien.Name = "labelGiaodiennhanvien";
            this.labelGiaodiennhanvien.Size = new System.Drawing.Size(142, 19);
            this.labelGiaodiennhanvien.TabIndex = 23;
            this.labelGiaodiennhanvien.Text = "Giao Diện Nhân Viên";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.labelDangxuat);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.labelGiaodiennhanvien);
            this.panel3.Controls.Add(this.btnDong);
            this.panel3.Controls.Add(this.guna2CirclePictureBox1);
            this.panel3.Controls.Add(this.guna2HtmlLabel1);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.btnThunho);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Location = new System.Drawing.Point(1, 7);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1267, 701);
            this.panel3.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 19);
            this.label2.TabIndex = 24;
            this.label2.Text = "Quản Lý";
            // 
            // labelDangxuat
            // 
            this.labelDangxuat.AutoSize = true;
            this.labelDangxuat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelDangxuat.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDangxuat.Location = new System.Drawing.Point(1167, 661);
            this.labelDangxuat.Name = "labelDangxuat";
            this.labelDangxuat.Size = new System.Drawing.Size(75, 19);
            this.labelDangxuat.TabIndex = 25;
            this.labelDangxuat.Text = "Đăng Xuất";
            this.labelDangxuat.Click += new System.EventHandler(this.labelDangxuat_Click);
            // 
            // btnDong
            // 
            this.btnDong.Animated = true;
            this.btnDong.AutoRoundedCorners = true;
            this.btnDong.BorderRadius = 14;
            this.btnDong.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDong.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDong.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDong.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDong.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDong.FillColor = System.Drawing.Color.Transparent;
            this.btnDong.FillColor2 = System.Drawing.Color.Silver;
            this.btnDong.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDong.ForeColor = System.Drawing.Color.White;
            this.btnDong.Image = global::demo01.Properties.Resources.close_FILL0_wght400_GRAD0_opsz24;
            this.btnDong.Location = new System.Drawing.Point(1237, 0);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(30, 30);
            this.btnDong.TabIndex = 12;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2CirclePictureBox1.Image")));
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(16, 1);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(75, 75);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2CirclePictureBox1.TabIndex = 22;
            this.guna2CirclePictureBox1.TabStop = false;
            // 
            // btnThunho
            // 
            this.btnThunho.Animated = true;
            this.btnThunho.AutoRoundedCorners = true;
            this.btnThunho.BorderRadius = 14;
            this.btnThunho.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThunho.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThunho.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThunho.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThunho.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThunho.FillColor = System.Drawing.Color.Transparent;
            this.btnThunho.FillColor2 = System.Drawing.Color.Silver;
            this.btnThunho.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnThunho.ForeColor = System.Drawing.Color.White;
            this.btnThunho.Image = global::demo01.Properties.Resources.minimize_FILL0_wght400_GRAD0_opsz24;
            this.btnThunho.Location = new System.Drawing.Point(1201, 0);
            this.btnThunho.Name = "btnThunho";
            this.btnThunho.Size = new System.Drawing.Size(30, 30);
            this.btnThunho.TabIndex = 11;
            this.btnThunho.Click += new System.EventHandler(this.btnThunho_Click);
            // 
            // btnThongke
            // 
            this.btnThongke.Animated = true;
            this.btnThongke.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThongke.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThongke.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThongke.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThongke.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThongke.FillColor = System.Drawing.Color.Silver;
            this.btnThongke.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnThongke.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold);
            this.btnThongke.ForeColor = System.Drawing.Color.White;
            this.btnThongke.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.btnThongke.Image = ((System.Drawing.Image)(resources.GetObject("btnThongke.Image")));
            this.btnThongke.Location = new System.Drawing.Point(11, 373);
            this.btnThongke.Name = "btnThongke";
            this.btnThongke.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnThongke.Size = new System.Drawing.Size(80, 80);
            this.btnThongke.TabIndex = 22;
            this.btnThongke.Text = "Thống Kê";
            // 
            // btnQlDichVu
            // 
            this.btnQlDichVu.Animated = true;
            this.btnQlDichVu.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnQlDichVu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnQlDichVu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnQlDichVu.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnQlDichVu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnQlDichVu.FillColor = System.Drawing.Color.Silver;
            this.btnQlDichVu.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnQlDichVu.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold);
            this.btnQlDichVu.ForeColor = System.Drawing.Color.White;
            this.btnQlDichVu.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.btnQlDichVu.Image = ((System.Drawing.Image)(resources.GetObject("btnQlDichVu.Image")));
            this.btnQlDichVu.Location = new System.Drawing.Point(11, 287);
            this.btnQlDichVu.Name = "btnQlDichVu";
            this.btnQlDichVu.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnQlDichVu.Size = new System.Drawing.Size(80, 80);
            this.btnQlDichVu.TabIndex = 21;
            this.btnQlDichVu.Text = "Quản Lý Dịch Vụ";
            this.btnQlDichVu.Click += new System.EventHandler(this.btnQlDichvu_Click);
            // 
            // btnQlNhanVien
            // 
            this.btnQlNhanVien.Animated = true;
            this.btnQlNhanVien.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnQlNhanVien.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnQlNhanVien.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnQlNhanVien.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnQlNhanVien.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnQlNhanVien.FillColor = System.Drawing.Color.Silver;
            this.btnQlNhanVien.FillColor2 = System.Drawing.Color.DimGray;
            this.btnQlNhanVien.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold);
            this.btnQlNhanVien.ForeColor = System.Drawing.Color.White;
            this.btnQlNhanVien.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.btnQlNhanVien.Image = ((System.Drawing.Image)(resources.GetObject("btnQlNhanVien.Image")));
            this.btnQlNhanVien.Location = new System.Drawing.Point(11, 201);
            this.btnQlNhanVien.Name = "btnQlNhanVien";
            this.btnQlNhanVien.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnQlNhanVien.Size = new System.Drawing.Size(80, 80);
            this.btnQlNhanVien.TabIndex = 20;
            this.btnQlNhanVien.Text = "Quản Lý Nhân Viên";
            this.btnQlNhanVien.Click += new System.EventHandler(this.tbnThanhtoan_Click);
            // 
            // btnQlkhach
            // 
            this.btnQlkhach.Animated = true;
            this.btnQlkhach.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnQlkhach.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnQlkhach.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnQlkhach.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnQlkhach.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnQlkhach.FillColor = System.Drawing.Color.Silver;
            this.btnQlkhach.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnQlkhach.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold);
            this.btnQlkhach.ForeColor = System.Drawing.Color.White;
            this.btnQlkhach.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.btnQlkhach.Image = ((System.Drawing.Image)(resources.GetObject("btnQlkhach.Image")));
            this.btnQlkhach.Location = new System.Drawing.Point(11, 115);
            this.btnQlkhach.Name = "btnQlkhach";
            this.btnQlkhach.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnQlkhach.Size = new System.Drawing.Size(80, 80);
            this.btnQlkhach.TabIndex = 18;
            this.btnQlkhach.Text = "Quản Lý Khách";
            this.btnQlkhach.Click += new System.EventHandler(this.btnQlkhach_Click);
            // 
            // btnQlPhong
            // 
            this.btnQlPhong.Animated = true;
            this.btnQlPhong.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnQlPhong.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnQlPhong.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnQlPhong.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnQlPhong.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnQlPhong.FillColor = System.Drawing.Color.Silver;
            this.btnQlPhong.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnQlPhong.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold);
            this.btnQlPhong.ForeColor = System.Drawing.Color.White;
            this.btnQlPhong.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.btnQlPhong.Image = ((System.Drawing.Image)(resources.GetObject("btnQlPhong.Image")));
            this.btnQlPhong.Location = new System.Drawing.Point(11, 29);
            this.btnQlPhong.Name = "btnQlPhong";
            this.btnQlPhong.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnQlPhong.Size = new System.Drawing.Size(80, 80);
            this.btnQlPhong.TabIndex = 17;
            this.btnQlPhong.Text = "Quản Lý Phòng";
            this.btnQlPhong.Click += new System.EventHandler(this.btnQlPhong_Click);
            // 
            // uC_QuanLyNhanVien1
            // 
            this.uC_QuanLyNhanVien1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.uC_QuanLyNhanVien1.Location = new System.Drawing.Point(0, 0);
            this.uC_QuanLyNhanVien1.Name = "uC_QuanLyNhanVien1";
            this.uC_QuanLyNhanVien1.Size = new System.Drawing.Size(1120, 570);
            this.uC_QuanLyNhanVien1.TabIndex = 3;
            // 
            // uC_DangKiKhach1
            // 
            this.uC_DangKiKhach1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.uC_DangKiKhach1.Location = new System.Drawing.Point(0, 0);
            this.uC_DangKiKhach1.Name = "uC_DangKiKhach1";
            this.uC_DangKiKhach1.Size = new System.Drawing.Size(1120, 570);
            this.uC_DangKiKhach1.TabIndex = 2;
            // 
            // uC_AddRoom2
            // 
            this.uC_AddRoom2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.uC_AddRoom2.Location = new System.Drawing.Point(19, 24);
            this.uC_AddRoom2.Name = "uC_AddRoom2";
            this.uC_AddRoom2.Size = new System.Drawing.Size(1120, 570);
            this.uC_AddRoom2.TabIndex = 1;
            // 
            // uC_AddRoom1
            // 
            this.uC_AddRoom1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.uC_AddRoom1.Location = new System.Drawing.Point(0, 0);
            this.uC_AddRoom1.Name = "uC_AddRoom1";
            this.uC_AddRoom1.Size = new System.Drawing.Size(1120, 570);
            this.uC_AddRoom1.TabIndex = 0;
            // 
            // uC_QuanLyDichVu1
            // 
            this.uC_QuanLyDichVu1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.uC_QuanLyDichVu1.Location = new System.Drawing.Point(0, 0);
            this.uC_QuanLyDichVu1.Name = "uC_QuanLyDichVu1";
            this.uC_QuanLyDichVu1.Size = new System.Drawing.Size(1120, 570);
            this.uC_QuanLyDichVu1.TabIndex = 4;
            // 
            // quanly
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "quanly";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "quanly";
            this.Load += new System.EventHandler(this.quanly_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2GradientButton btnDong;
        private Guna.UI2.WinForms.Guna2GradientButton btnThunho;
        private Guna.UI2.WinForms.Guna2GradientCircleButton btnQlPhong;
        private Guna.UI2.WinForms.Guna2GradientCircleButton btnQlkhach;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2GradientCircleButton btnQlDichVu;
        private Guna.UI2.WinForms.Guna2GradientCircleButton btnQlNhanVien;
        private System.Windows.Forms.Panel panel2;
        private All_Use_Control.UC_AddRoom uC_AddRoom1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private All_Use_Control.UC_AddRoom uC_AddRoom2;
        private All_Use_Control.UC_DangKiKhach uC_DangKiKhach1;
        private All_Use_Control.UC_QuanLyNhanVien uC_QuanLyNhanVien1;
        private Guna.UI2.WinForms.Guna2GradientCircleButton btnThongke;
        private System.Windows.Forms.Label labelGiaodiennhanvien;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelDangxuat;
        private All_Use_Control.UC_QuanLyDichVu uC_QuanLyDichVu1;
    }
}