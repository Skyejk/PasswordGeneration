namespace GuardPRO
{
    partial class FormAuth
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAuth));
            this.headerText = new System.Windows.Forms.Label();
            this.BTMinBox = new System.Windows.Forms.Button();
            this.BTExit = new System.Windows.Forms.Button();
            this.penelHeader = new System.Windows.Forms.Panel();
            this.PBTheme = new System.Windows.Forms.PictureBox();
            this.PBHeaderLogo = new System.Windows.Forms.PictureBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.TBPassword = new System.Windows.Forms.TextBox();
            this.BTEnter = new System.Windows.Forms.Button();
            this.BTGetPass = new System.Windows.Forms.Button();
            this.PBHide = new System.Windows.Forms.PictureBox();
            this.PBView = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelLogin = new System.Windows.Forms.Label();
            this.TBLogin = new System.Windows.Forms.TextBox();
            this.penelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBTheme)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBHeaderLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBHide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // headerText
            // 
            this.headerText.AutoSize = true;
            this.headerText.Location = new System.Drawing.Point(47, 6);
            this.headerText.Name = "headerText";
            this.headerText.Size = new System.Drawing.Size(96, 18);
            this.headerText.TabIndex = 9;
            this.headerText.Text = "header text";
            // 
            // BTMinBox
            // 
            this.BTMinBox.FlatAppearance.BorderSize = 0;
            this.BTMinBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTMinBox.Font = new System.Drawing.Font("Consolas", 11F);
            this.BTMinBox.Location = new System.Drawing.Point(534, 0);
            this.BTMinBox.Name = "BTMinBox";
            this.BTMinBox.Size = new System.Drawing.Size(30, 30);
            this.BTMinBox.TabIndex = 0;
            this.BTMinBox.TabStop = false;
            this.BTMinBox.Text = "—";
            this.BTMinBox.UseVisualStyleBackColor = false;
            this.BTMinBox.Click += new System.EventHandler(this.BTMinBox_Click);
            // 
            // BTExit
            // 
            this.BTExit.FlatAppearance.BorderSize = 0;
            this.BTExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTExit.Font = new System.Drawing.Font("Consolas", 11F);
            this.BTExit.Location = new System.Drawing.Point(570, 0);
            this.BTExit.Name = "BTExit";
            this.BTExit.Size = new System.Drawing.Size(30, 30);
            this.BTExit.TabIndex = 0;
            this.BTExit.TabStop = false;
            this.BTExit.Text = "X";
            this.BTExit.UseVisualStyleBackColor = false;
            this.BTExit.Click += new System.EventHandler(this.BTExit_Click);
            // 
            // penelHeader
            // 
            this.penelHeader.Controls.Add(this.PBTheme);
            this.penelHeader.Controls.Add(this.PBHeaderLogo);
            this.penelHeader.Controls.Add(this.headerText);
            this.penelHeader.Controls.Add(this.BTMinBox);
            this.penelHeader.Controls.Add(this.BTExit);
            this.penelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.penelHeader.Location = new System.Drawing.Point(0, 0);
            this.penelHeader.Name = "penelHeader";
            this.penelHeader.Size = new System.Drawing.Size(600, 30);
            this.penelHeader.TabIndex = 21;
            this.penelHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.penelHeader_MouseDown);
            this.penelHeader.MouseMove += new System.Windows.Forms.MouseEventHandler(this.penelHeader_MouseMove);
            // 
            // PBTheme
            // 
            this.PBTheme.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PBTheme.Image = global::GuardPRO.Properties.Resources.theme;
            this.PBTheme.Location = new System.Drawing.Point(499, 0);
            this.PBTheme.Name = "PBTheme";
            this.PBTheme.Size = new System.Drawing.Size(29, 29);
            this.PBTheme.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBTheme.TabIndex = 12;
            this.PBTheme.TabStop = false;
            this.PBTheme.Click += new System.EventHandler(this.PBTheme_Click);
            // 
            // PBHeaderLogo
            // 
            this.PBHeaderLogo.Image = global::GuardPRO.Properties.Resources.GuardProLogo;
            this.PBHeaderLogo.Location = new System.Drawing.Point(3, 0);
            this.PBHeaderLogo.Name = "PBHeaderLogo";
            this.PBHeaderLogo.Size = new System.Drawing.Size(29, 29);
            this.PBHeaderLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBHeaderLogo.TabIndex = 12;
            this.PBHeaderLogo.TabStop = false;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Consolas", 11F);
            this.labelPassword.Location = new System.Drawing.Point(127, 260);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(64, 18);
            this.labelPassword.TabIndex = 28;
            this.labelPassword.Text = "Пароль:";
            // 
            // TBPassword
            // 
            this.TBPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBPassword.Location = new System.Drawing.Point(215, 258);
            this.TBPassword.Name = "TBPassword";
            this.TBPassword.Size = new System.Drawing.Size(170, 25);
            this.TBPassword.TabIndex = 29;
            this.TBPassword.UseSystemPasswordChar = true;
            this.TBPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TBPassword_KeyDown);
            // 
            // BTEnter
            // 
            this.BTEnter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.BTEnter.FlatAppearance.BorderSize = 0;
            this.BTEnter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTEnter.Font = new System.Drawing.Font("Consolas", 20F);
            this.BTEnter.Location = new System.Drawing.Point(215, 289);
            this.BTEnter.Name = "BTEnter";
            this.BTEnter.Size = new System.Drawing.Size(170, 40);
            this.BTEnter.TabIndex = 24;
            this.BTEnter.Text = "Войти";
            this.BTEnter.UseVisualStyleBackColor = false;
            this.BTEnter.Click += new System.EventHandler(this.BTEnter_Click);
            // 
            // BTGetPass
            // 
            this.BTGetPass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTGetPass.FlatAppearance.BorderSize = 0;
            this.BTGetPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTGetPass.Font = new System.Drawing.Font("Consolas", 9F);
            this.BTGetPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(114)))), ((int)(((byte)(120)))));
            this.BTGetPass.Location = new System.Drawing.Point(215, 335);
            this.BTGetPass.Name = "BTGetPass";
            this.BTGetPass.Size = new System.Drawing.Size(170, 25);
            this.BTGetPass.TabIndex = 25;
            this.BTGetPass.TabStop = false;
            this.BTGetPass.Text = "получить пароль";
            this.BTGetPass.UseVisualStyleBackColor = false;
            this.BTGetPass.Click += new System.EventHandler(this.BTGetPass_Click);
            // 
            // PBHide
            // 
            this.PBHide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PBHide.Image = global::GuardPRO.Properties.Resources.hide;
            this.PBHide.Location = new System.Drawing.Point(391, 258);
            this.PBHide.Name = "PBHide";
            this.PBHide.Size = new System.Drawing.Size(25, 25);
            this.PBHide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBHide.TabIndex = 22;
            this.PBHide.TabStop = false;
            this.PBHide.Click += new System.EventHandler(this.PBHide_Click);
            // 
            // PBView
            // 
            this.PBView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PBView.Image = global::GuardPRO.Properties.Resources.view;
            this.PBView.Location = new System.Drawing.Point(391, 258);
            this.PBView.Name = "PBView";
            this.PBView.Size = new System.Drawing.Size(25, 25);
            this.PBView.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBView.TabIndex = 23;
            this.PBView.TabStop = false;
            this.PBView.Click += new System.EventHandler(this.PBView_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GuardPRO.Properties.Resources.EmblemRussianFederation;
            this.pictureBox1.Location = new System.Drawing.Point(215, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(170, 170);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("Consolas", 11F);
            this.labelLogin.Location = new System.Drawing.Point(135, 223);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(56, 18);
            this.labelLogin.TabIndex = 27;
            this.labelLogin.Text = "Логин:";
            // 
            // TBLogin
            // 
            this.TBLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBLogin.Location = new System.Drawing.Point(215, 221);
            this.TBLogin.Name = "TBLogin";
            this.TBLogin.Size = new System.Drawing.Size(170, 25);
            this.TBLogin.TabIndex = 26;
            this.TBLogin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TBLogin_KeyDown);
            // 
            // FormAuth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(68)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.penelHeader);
            this.Controls.Add(this.PBHide);
            this.Controls.Add(this.PBView);
            this.Controls.Add(this.TBLogin);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.TBPassword);
            this.Controls.Add(this.BTEnter);
            this.Controls.Add(this.BTGetPass);
            this.Font = new System.Drawing.Font("Consolas", 11F);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "FormAuth";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            this.penelHeader.ResumeLayout(false);
            this.penelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBTheme)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBHeaderLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBHide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headerText;
        private System.Windows.Forms.Button BTMinBox;
        private System.Windows.Forms.Button BTExit;
        private System.Windows.Forms.Panel penelHeader;
        private System.Windows.Forms.PictureBox PBTheme;
        private System.Windows.Forms.PictureBox PBHeaderLogo;
        private System.Windows.Forms.PictureBox PBHide;
        private System.Windows.Forms.PictureBox PBView;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox TBPassword;
        private System.Windows.Forms.Button BTEnter;
        private System.Windows.Forms.Button BTGetPass;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.TextBox TBLogin;
    }
}

