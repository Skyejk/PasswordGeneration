using GuardPRO.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Cryptography;
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
        }

        //Переход с поля ввода логина на поле ввода пароля по клавише Enter
        
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
            BTGetPass.ForeColor = Color.FromArgb(105, 114, 120);
            penelHeader.BackColor = Color.FromArgb(54, 66, 74);
        }
        //Светлая тема
        public void LightTheme()
        {
            BackColor = Color.FromArgb(240, 242, 243);
            ForeColor = Color.FromArgb(56, 68, 76);
            BTEnter.BackColor = Color.FromArgb(201, 203, 205);
            BTGetPass.ForeColor = Color.FromArgb(105, 114, 120);
            penelHeader.BackColor = Color.FromArgb(236, 238, 240);
        }

        /// <summary>
        /// 
        /// Application Client Logic
        /// 
        /// </summary>
        private void BTEnter_Click(object sender, EventArgs e) {            
            try {
                string pass = TBPassword.Text;
                string encryptMacAddress = EncryptMacAddress(GetMacAddress(), GetSalt());
                if (pass != encryptMacAddress)
                {
                    CustomMessage("Введенный ключ неверен. Убедитесь, что вы правильно ввели его.", null, MessageBoxIcon.Error);
                } else {
                    ApplicationMainForm mainForm = new ApplicationMainForm();
                    mainForm.Show();
                    this.Hide();

                }

            } catch(Exception ex) {
                CustomMessage($@"Что-то пошло не так, обратитесь в службу поддержки с этим кодом: {ex.Message}", null, MessageBoxIcon.Warning);
            }
        }

        private void BTGetPass_Click(object sender, EventArgs e)
        {
            FormGetPass formGetPass = new FormGetPass();
            formGetPass.ShowDialog();
        }
        //шифрование MAC адреса
        public static string EncryptMacAddress(string macAddress, string salt)
        {
            // Проверка входных параметров
            if (string.IsNullOrEmpty(macAddress))
            {
                throw new ArgumentException("Mac Address should not be empty or null", "macAddress");
            }

            if (string.IsNullOrEmpty(salt))
            {
                throw new ArgumentException("Salt should not be empty or null", "salt");
            }

            // Приведение Mac Address к нижнему регистру и удаление разделителей
            macAddress = macAddress.ToLower().Replace("-", "").Replace(":", "");

            // Добавление соли в конец Mac Address
            string saltedMacAddress = macAddress + salt;

            // Вычисление MD5 хеша соленого Mac Address
            using (MD5 md5 = MD5.Create())
            {
                byte[] hashBytes = md5.ComputeHash(Encoding.UTF8.GetBytes(saltedMacAddress));

                // Преобразование байтов хеша в строку в шестнадцатеричном формате
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("x2"));
                }

                return sb.ToString();
            }
        }
        //Получение MAC адреса
        private string GetMacAddress()
        {
            var networkInterfaces = NetworkInterface.GetAllNetworkInterfaces();
            var macAddress = string.Empty;
            foreach (var networkInterface in networkInterfaces)
            {
                if (networkInterface.NetworkInterfaceType == NetworkInterfaceType.Wireless80211 ||
                    networkInterface.NetworkInterfaceType == NetworkInterfaceType.Ethernet)
                {
                    macAddress = networkInterface.GetPhysicalAddress().ToString();
                    break;
                }
            }
            return macAddress;
        }
        //Получение соли
        private string GetSalt()
        {
            string salt = System.Net.Dns.GetHostName();
            // Приведение соли к нижнему регистру и удаление разделителей
            salt = salt.ToLower()
                .Replace(" ", "").Replace("!", "")
                .Replace("#", "").Replace("$", "")
                .Replace("%", "").Replace("&", "")
                .Replace("(", "").Replace(")", "")
                .Replace("[", "").Replace("]", "")
                .Replace("{", "").Replace("}", "")
                .Replace("<", "").Replace(">", "")
                .Replace("\\", "").Replace("/", "")
                .Replace(@"""", "").Replace("'", "")
                .Replace(",", "").Replace(".", "")
                .Replace("*", "").Replace("+", "")
                .Replace(":", "").Replace(";", "")
                .Replace("=", "").Replace("?", "")
                .Replace("|", "").Replace("-", "")
                .Replace("_", "").Replace("^", "")
                .Replace("@", "").Replace("`", "")
                .Replace("~", "");
            return salt;
        }
        public void CustomMessage(string txt, string head, MessageBoxIcon icon) {
            MessageBox.Show(txt, head, MessageBoxButtons.OK, icon, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
        }
    }
}
