namespace demo01
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
            this.components = new System.ComponentModel.Container();
            Guna.UI2.AnimatorNS.Animation animation2 = new Guna.UI2.AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Transition1 = new Guna.UI2.WinForms.Guna2Transition();
            this.btnDangnhap = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.labelError = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2ToggleSwitch1 = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnDong = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnThunho = new Guna.UI2.WinForms.Guna2GradientButton();
            this.txtTaikhoan = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtMatkhau = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 25;
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2Transition1
            // 
            this.guna2Transition1.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(0);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 0F;
            this.guna2Transition1.DefaultAnimation = animation2;
            // 
            // btnDangnhap
            // 
            this.btnDangnhap.Animated = true;
            this.btnDangnhap.AutoRoundedCorners = true;
            this.btnDangnhap.BorderRadius = 21;
            this.guna2Transition1.SetDecoration(this.btnDangnhap, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnDangnhap.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDangnhap.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDangnhap.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDangnhap.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDangnhap.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDangnhap.FillColor = System.Drawing.Color.Black;
            this.btnDangnhap.FillColor2 = System.Drawing.Color.Silver;
            this.btnDangnhap.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDangnhap.ForeColor = System.Drawing.Color.White;
            this.btnDangnhap.Location = new System.Drawing.Point(694, 409);
            this.btnDangnhap.Name = "btnDangnhap";
            this.btnDangnhap.Size = new System.Drawing.Size(180, 45);
            this.btnDangnhap.TabIndex = 1;
            this.btnDangnhap.Text = "ĐĂNG NHẬP";
            this.btnDangnhap.Click += new System.EventHandler(this.btnDangnhap_Click);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.guna2HtmlLabel1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(706, 160);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(148, 39);
            this.guna2HtmlLabel1.TabIndex = 4;
            this.guna2HtmlLabel1.Text = "Đăng Nhập";
            // 
            // labelError
            // 
            this.labelError.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.labelError, Guna.UI2.AnimatorNS.DecorationType.None);
            this.labelError.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelError.Location = new System.Drawing.Point(622, 499);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(352, 22);
            this.labelError.TabIndex = 5;
            this.labelError.Text = "Thông tin tài khoản hoặc mật khẩu không chính xác";
            // 
            // guna2ToggleSwitch1
            // 
            this.guna2ToggleSwitch1.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ToggleSwitch1.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ToggleSwitch1.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch1.CheckedState.InnerColor = System.Drawing.Color.White;
            this.guna2Transition1.SetDecoration(this.guna2ToggleSwitch1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2ToggleSwitch1.Location = new System.Drawing.Point(652, 361);
            this.guna2ToggleSwitch1.Name = "guna2ToggleSwitch1";
            this.guna2ToggleSwitch1.Size = new System.Drawing.Size(35, 20);
            this.guna2ToggleSwitch1.TabIndex = 6;
            this.guna2ToggleSwitch1.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2ToggleSwitch1.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2ToggleSwitch1.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch1.UncheckedState.InnerColor = System.Drawing.Color.White;
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.guna2HtmlLabel3, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(694, 361);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(125, 22);
            this.guna2HtmlLabel3.TabIndex = 7;
            this.guna2HtmlLabel3.Text = "Hiển thị mật khẩu";
            // 
            // btnDong
            // 
            this.btnDong.Animated = true;
            this.btnDong.AutoRoundedCorners = true;
            this.btnDong.BorderRadius = 14;
            this.guna2Transition1.SetDecoration(this.btnDong, Guna.UI2.AnimatorNS.DecorationType.None);
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
            this.btnDong.Location = new System.Drawing.Point(1036, 12);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(31, 30);
            this.btnDong.TabIndex = 10;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnThunho
            // 
            this.btnThunho.Animated = true;
            this.btnThunho.AutoRoundedCorners = true;
            this.btnThunho.BorderRadius = 14;
            this.guna2Transition1.SetDecoration(this.btnThunho, Guna.UI2.AnimatorNS.DecorationType.None);
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
            this.btnThunho.Location = new System.Drawing.Point(999, 12);
            this.btnThunho.Name = "btnThunho";
            this.btnThunho.Size = new System.Drawing.Size(31, 30);
            this.btnThunho.TabIndex = 9;
            this.btnThunho.Click += new System.EventHandler(this.btnThunho_Click);
            // 
            // txtTaikhoan
            // 
            this.txtTaikhoan.Animated = true;
            this.txtTaikhoan.AutoRoundedCorners = true;
            this.txtTaikhoan.BorderRadius = 23;
            this.txtTaikhoan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2Transition1.SetDecoration(this.txtTaikhoan, Guna.UI2.AnimatorNS.DecorationType.None);
            this.txtTaikhoan.DefaultText = "";
            this.txtTaikhoan.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTaikhoan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTaikhoan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTaikhoan.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTaikhoan.FillColor = System.Drawing.Color.Silver;
            this.txtTaikhoan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTaikhoan.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.txtTaikhoan.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTaikhoan.IconLeft = global::demo01.Properties.Resources.person_FILL0_wght400_GRAD0_opsz24;
            this.txtTaikhoan.Location = new System.Drawing.Point(642, 245);
            this.txtTaikhoan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTaikhoan.Name = "txtTaikhoan";
            this.txtTaikhoan.PasswordChar = '\0';
            this.txtTaikhoan.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.txtTaikhoan.PlaceholderText = "Tài Khoản";
            this.txtTaikhoan.SelectedText = "";
            this.txtTaikhoan.Size = new System.Drawing.Size(287, 48);
            this.txtTaikhoan.TabIndex = 8;
            this.txtTaikhoan.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTaikhoan_KeyDown);
            // 
            // txtMatkhau
            // 
            this.txtMatkhau.Animated = true;
            this.txtMatkhau.AutoRoundedCorners = true;
            this.txtMatkhau.BorderRadius = 25;
            this.txtMatkhau.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2Transition1.SetDecoration(this.txtMatkhau, Guna.UI2.AnimatorNS.DecorationType.None);
            this.txtMatkhau.DefaultText = "";
            this.txtMatkhau.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMatkhau.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMatkhau.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMatkhau.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMatkhau.FillColor = System.Drawing.Color.Silver;
            this.txtMatkhau.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMatkhau.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.txtMatkhau.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMatkhau.IconLeft = global::demo01.Properties.Resources.lock_FILL0_wght400_GRAD0_opsz24;
            this.txtMatkhau.Location = new System.Drawing.Point(642, 301);
            this.txtMatkhau.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMatkhau.Name = "txtMatkhau";
            this.txtMatkhau.PasswordChar = '●';
            this.txtMatkhau.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.txtMatkhau.PlaceholderText = "Mật Khẩu";
            this.txtMatkhau.SelectedText = "";
            this.txtMatkhau.Size = new System.Drawing.Size(287, 53);
            this.txtMatkhau.TabIndex = 3;
            this.txtMatkhau.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMatkhau_KeyDown);
            // 
            // guna2PictureBox1
            // 
            this.guna2Transition1.SetDecoration(this.guna2PictureBox1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2PictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.ErrorImage")));
            this.guna2PictureBox1.Image = global::demo01.Properties.Resources.LOGO_TRANG;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.InitialImage")));
            this.guna2PictureBox1.Location = new System.Drawing.Point(12, 71);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(533, 517);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 0;
            this.guna2PictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1079, 656);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnThunho);
            this.Controls.Add(this.txtTaikhoan);
            this.Controls.Add(this.guna2HtmlLabel3);
            this.Controls.Add(this.guna2ToggleSwitch1);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.txtMatkhau);
            this.Controls.Add(this.btnDangnhap);
            this.Controls.Add(this.guna2PictureBox1);
            this.guna2Transition1.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2Transition guna2Transition1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2TextBox txtMatkhau;
        private Guna.UI2.WinForms.Guna2GradientButton btnDangnhap;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2ToggleSwitch guna2ToggleSwitch1;
        private Guna.UI2.WinForms.Guna2HtmlLabel labelError;
        private Guna.UI2.WinForms.Guna2TextBox txtTaikhoan;
        private Guna.UI2.WinForms.Guna2GradientButton btnDong;
        private Guna.UI2.WinForms.Guna2GradientButton btnThunho;
    }
}

