using GuardPRO.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net.NetworkInformation;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuardPRO.Forms
{
    public partial class FormGetPass : Form
    {
        public FormGetPass()
        {
            InitializeComponent();

            PanelHeaderSettings();
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
            Opacity = .90;
        }
        
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
            BTGenerate.BackColor = Color.FromArgb(41, 50, 56);
            BackColor = Color.FromArgb(56, 68, 76);
            ForeColor = Color.FromArgb(240, 242, 243);
            penelHeader.BackColor = Color.FromArgb(54, 66, 74);
        }
        //Светлая тема
        public void LightTheme()
        {
            lblWarning.ForeColor = Color.White;
            lblWarnText.ForeColor = Color.White;
            BTGenerate.BackColor = Color.FromArgb(201, 203, 205);
            BackColor = Color.FromArgb(240, 242, 243);
            ForeColor = Color.FromArgb(56, 68, 76);
            penelHeader.BackColor = Color.FromArgb(236, 238, 240);
        }

        private void BTEnter_Click(object sender, EventArgs e)
        {
            try { 
            string login = TBUserName.Text;
                if (login == "")
                {
                    CustomMessage("Заполните поле логин.", "Уведомление", MessageBoxIcon.Asterisk);
                }
                else
                {
                    string macAddress = GetMacAddress();
                    string salt = GetSalt();
                    string encryptMacAddress = EncryptMacAddress(macAddress, salt);

                    var currentUser = SaltEntities.GetContext().Users.Where(u => u.PasswordHash == encryptMacAddress).FirstOrDefault();



                    if (currentUser == null)
                    {
                        Users newUser = new Users();
                        if (MessageBox.Show($"Вы уверены, что хотите создать пользователя с именем {login}?", "Уведомление", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification) == DialogResult.Yes)
                        {
                            newUser.Username = login;
                            newUser.Salt = salt;
                            newUser.RoleID = 3;
                            newUser.PasswordHash = encryptMacAddress;
                            SaltEntities.GetContext().Users.Add(newUser);
                            SaltEntities.GetContext().SaveChanges();
                            TBPassGen.Text = encryptMacAddress;
                        }
                    }
                    else
                    {
                        CustomMessage("Вы уже создавали аккаунт.", "Уведомление", MessageBoxIcon.Asterisk);
                    }
                }
            }
            catch(Exception ex)
            {
                CustomMessage(ex.Message, null, MessageBoxIcon.Error);
            }
        }



        private void BTGetPass_Click(object sender, EventArgs e)
        {
            CustomMessage("Обратитесь к своему офицеру за помощью.", "Уведомление", MessageBoxIcon.Asterisk);
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
        private string GetMacAddress() { 
            var networkInterfaces = NetworkInterface.GetAllNetworkInterfaces();
            var macAddress = string.Empty;
            foreach (var networkInterface in networkInterfaces) { 
                if(networkInterface.NetworkInterfaceType == NetworkInterfaceType.Wireless80211 ||
                    networkInterface.NetworkInterfaceType == NetworkInterfaceType.Ethernet) {
                    macAddress = networkInterface.GetPhysicalAddress().ToString();
                    break;
                }
            }
            return macAddress;
        }
        //Получение соли
        private string GetSalt() { 
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
        //MessageBox
        public void CustomMessage(string txt, string head, MessageBoxIcon icon)
        {
            MessageBox.Show(txt, head, MessageBoxButtons.OK, icon, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
        }
    }
}
