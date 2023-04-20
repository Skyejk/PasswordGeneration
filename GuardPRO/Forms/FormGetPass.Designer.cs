namespace GuardPRO.Forms
{
    partial class FormGetPass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGetPass));
            this.penelHeader = new System.Windows.Forms.Panel();
            this.PBTheme = new System.Windows.Forms.PictureBox();
            this.PBHeaderLogo = new System.Windows.Forms.PictureBox();
            this.headerText = new System.Windows.Forms.Label();
            this.BTExit = new System.Windows.Forms.Button();
            this.panelWarning = new System.Windows.Forms.Panel();
            this.TBPassGen = new System.Windows.Forms.TextBox();
            this.BTGenerate = new System.Windows.Forms.Button();
            this.lblGen = new System.Windows.Forms.Label();
            this.lblWarning = new System.Windows.Forms.Label();
            this.lblWarnText = new System.Windows.Forms.Label();
            this.TBUserName = new System.Windows.Forms.TextBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.BTForgotMyPass = new System.Windows.Forms.Button();
            this.penelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBTheme)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBHeaderLogo)).BeginInit();
            this.panelWarning.SuspendLayout();
            this.SuspendLayout();
            // 
            // penelHeader
            // 
            this.penelHeader.Controls.Add(this.PBTheme);
            this.penelHeader.Controls.Add(this.PBHeaderLogo);
            this.penelHeader.Controls.Add(this.headerText);
            this.penelHeader.Controls.Add(this.BTExit);
            this.penelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.penelHeader.Location = new System.Drawing.Point(0, 0);
            this.penelHeader.Name = "penelHeader";
            this.penelHeader.Size = new System.Drawing.Size(600, 30);
            this.penelHeader.TabIndex = 24;
            this.penelHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.penelHeader_MouseDown);
            this.penelHeader.MouseMove += new System.Windows.Forms.MouseEventHandler(this.penelHeader_MouseMove);
            // 
            // PBTheme
            // 
            this.PBTheme.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PBTheme.Image = global::GuardPRO.Properties.Resources.theme;
            this.PBTheme.Location = new System.Drawing.Point(535, 0);
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
            // headerText
            // 
            this.headerText.AutoSize = true;
            this.headerText.Location = new System.Drawing.Point(47, 6);
            this.headerText.Name = "headerText";
            this.headerText.Size = new System.Drawing.Size(96, 18);
            this.headerText.TabIndex = 9;
            this.headerText.Text = "header text";
            // 
            // BTExit
            // 
            this.BTExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
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
            // panelWarning
            // 
            this.panelWarning.BackColor = System.Drawing.Color.DarkRed;
            this.panelWarning.Controls.Add(this.lblWarnText);
            this.panelWarning.Controls.Add(this.lblWarning);
            this.panelWarning.Location = new System.Drawing.Point(30, 53);
            this.panelWarning.Name = "panelWarning";
            this.panelWarning.Size = new System.Drawing.Size(540, 109);
            this.panelWarning.TabIndex = 25;
            // 
            // TBPassGen
            // 
            this.TBPassGen.Location = new System.Drawing.Point(164, 305);
            this.TBPassGen.Name = "TBPassGen";
            this.TBPassGen.ReadOnly = true;
            this.TBPassGen.Size = new System.Drawing.Size(406, 25);
            this.TBPassGen.TabIndex = 26;
            // 
            // BTGenerate
            // 
            this.BTGenerate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.BTGenerate.FlatAppearance.BorderSize = 0;
            this.BTGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTGenerate.Font = new System.Drawing.Font("Consolas", 20F);
            this.BTGenerate.Location = new System.Drawing.Point(164, 203);
            this.BTGenerate.Name = "BTGenerate";
            this.BTGenerate.Size = new System.Drawing.Size(273, 40);
            this.BTGenerate.TabIndex = 24;
            this.BTGenerate.Text = "Генерация шифра";
            this.BTGenerate.UseVisualStyleBackColor = false;
            this.BTGenerate.Click += new System.EventHandler(this.BTEnter_Click);
            // 
            // lblGen
            // 
            this.lblGen.AutoSize = true;
            this.lblGen.Location = new System.Drawing.Point(27, 308);
            this.lblGen.Name = "lblGen";
            this.lblGen.Size = new System.Drawing.Size(96, 18);
            this.lblGen.TabIndex = 27;
            this.lblGen.Text = "Ваш пароль:";
            // 
            // lblWarning
            // 
            this.lblWarning.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblWarning.Location = new System.Drawing.Point(3, 0);
            this.lblWarning.Name = "lblWarning";
            this.lblWarning.Size = new System.Drawing.Size(537, 47);
            this.lblWarning.TabIndex = 28;
            this.lblWarning.Text = "ВНИМАНИЕ!";
            this.lblWarning.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblWarnText
            // 
            this.lblWarnText.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblWarnText.Location = new System.Drawing.Point(3, 47);
            this.lblWarnText.Name = "lblWarnText";
            this.lblWarnText.Size = new System.Drawing.Size(534, 83);
            this.lblWarnText.TabIndex = 28;
            this.lblWarnText.Text = "Не передавайте сгенерированный здесь пароль никому.\r\nМы не несем ответственности " +
    "за ваши ошибки.\r\n";
            this.lblWarnText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TBUserName
            // 
            this.TBUserName.Location = new System.Drawing.Point(164, 274);
            this.TBUserName.Name = "TBUserName";
            this.TBUserName.Size = new System.Drawing.Size(406, 25);
            this.TBUserName.TabIndex = 26;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(27, 277);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(88, 18);
            this.lblUserName.TabIndex = 27;
            this.lblUserName.Text = "Ваш логин:";
            // 
            // BTForgotMyPass
            // 
            this.BTForgotMyPass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTForgotMyPass.FlatAppearance.BorderSize = 0;
            this.BTForgotMyPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTForgotMyPass.Font = new System.Drawing.Font("Consolas", 9F);
            this.BTForgotMyPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(114)))), ((int)(((byte)(120)))));
            this.BTForgotMyPass.Location = new System.Drawing.Point(215, 348);
            this.BTForgotMyPass.Name = "BTForgotMyPass";
            this.BTForgotMyPass.Size = new System.Drawing.Size(170, 25);
            this.BTForgotMyPass.TabIndex = 25;
            this.BTForgotMyPass.TabStop = false;
            this.BTForgotMyPass.Text = "забыли пароль?";
            this.BTForgotMyPass.UseVisualStyleBackColor = false;
            this.BTForgotMyPass.Click += new System.EventHandler(this.BTGetPass_Click);
            // 
            // FormGetPass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(68)))), ((int)(((byte)(76)))));
            this.CancelButton = this.BTExit;
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.ControlBox = false;
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.lblGen);
            this.Controls.Add(this.TBUserName);
            this.Controls.Add(this.TBPassGen);
            this.Controls.Add(this.panelWarning);
            this.Controls.Add(this.penelHeader);
            this.Controls.Add(this.BTGenerate);
            this.Controls.Add(this.BTForgotMyPass);
            this.Font = new System.Drawing.Font("Consolas", 11F);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "FormGetPass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Получение пароля";
            this.penelHeader.ResumeLayout(false);
            this.penelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBTheme)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBHeaderLogo)).EndInit();
            this.panelWarning.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel penelHeader;
        private System.Windows.Forms.PictureBox PBTheme;
        private System.Windows.Forms.PictureBox PBHeaderLogo;
        private System.Windows.Forms.Label headerText;
        private System.Windows.Forms.Button BTExit;
        private System.Windows.Forms.Panel panelWarning;
        private System.Windows.Forms.TextBox TBPassGen;
        private System.Windows.Forms.Button BTGenerate;
        private System.Windows.Forms.Label lblGen;
        private System.Windows.Forms.Label lblWarning;
        private System.Windows.Forms.Label lblWarnText;
        private System.Windows.Forms.TextBox TBUserName;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Button BTForgotMyPass;
    }
}