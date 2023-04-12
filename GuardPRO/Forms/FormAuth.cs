using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuardPRO
{
    public partial class FormAuth : Form
    {
        public FormAuth()
        {
            InitializeComponent();

            PanelHeaderSettings();
            AuthorizationFormSettings();
        }

        /// <summary>
        /// 
        /// Configuring the UI
        /// 
        /// </summary>
        public void PanelHeaderSettings()//Настройка панели
        {
            headerText.Text = this.Text;
            BTExit.FlatAppearance.BorderSize = 0;
            BTExit.FlatAppearance.MouseDownBackColor = Color.FromArgb(200, 0, 75);
            BTExit.FlatAppearance.MouseOverBackColor = Color.FromArgb(175, 0, 35);
            BTMinBox.FlatAppearance.BorderSize = 0;
            BTMinBox.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 150, 200);
            BTMinBox.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 100, 175);
        }
        public void AuthorizationFormSettings()//Настройка формы
        {
            Opacity = .90;
            PBView.Visible = false;
            TBPassword.MaxLength = 50;
            TBLogin.MaxLength = 50;
        }

        //Переход с поля ввода логина на поле ввода пароля по клавише Enter
        private void TBLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            { TBPassword.Focus(); }
        }
        //Переход с поля пароля на кнопку ввода по клавише Enter
        private void TBPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            { BTEnter.Focus(); }
        }
        //Показать пароль
        private void PBView_Click(object sender, EventArgs e)
        {
            TBPassword.UseSystemPasswordChar = true;
            PBHide.Visible = true;
            PBView.Visible = false;
        }
        //Скрыть пароль
        private void PBHide_Click(object sender, EventArgs e)
        {
            TBPassword.UseSystemPasswordChar = false;
            PBHide.Visible = false;
            PBView.Visible = true;
        }
        //Кнопка свернуть приложение
        private void BTMinBox_Click(object sender, EventArgs e)
        { this.WindowState = FormWindowState.Minimized; }
        //Кнопка закрыть приложение
        private void BTExit_Click(object sender, EventArgs e)
        { Close(); }
        // Передвигаем окошко по экрану, при зажатой клавише мыши на верхней панели
        Point lastPoint;
        //берём местонахождение мышки и отнимаем от нее данные из переменной lastPoint
        private void penelHeader_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
        //устанавливаем новые координаты в переменную lastPoin
        private void penelHeader_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
        //Переключение темы
        bool switchTheme = false;
        private void PBTheme_Click(object sender, EventArgs e)
        {
            switchTheme = !switchTheme;
            if (switchTheme != true)
            { DarkTheme(); }
            else { LightTheme(); }
        }
        //Тёмная тема
        public void DarkTheme()
        {
            BackColor = Color.FromArgb(56, 68, 76);
            ForeColor = Color.FromArgb(240, 242, 243);
            BTEnter.BackColor = Color.FromArgb(41, 50, 56);
            BTCreateAccount.ForeColor = Color.FromArgb(105, 114, 120);
            penelHeader.BackColor = Color.FromArgb(54, 66, 74);
        }
        //Светлая тема
        public void LightTheme()
        {
            BackColor = Color.FromArgb(240, 242, 243);
            ForeColor = Color.FromArgb(56, 68, 76);
            BTEnter.BackColor = Color.FromArgb(201, 203, 205);
            BTCreateAccount.ForeColor = Color.FromArgb(105, 114, 120);
            penelHeader.BackColor = Color.FromArgb(236, 238, 240);
        }



        private void BTEnter_Click(object sender, EventArgs e)
        {

        }

        
    }
}
