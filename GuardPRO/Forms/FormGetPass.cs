using System;
using System.Drawing;
using System.IO;
using System.Net.NetworkInformation;
using System.Security.Cryptography;
using System.Text;
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
                string pass = GetSalt() + GetMacAddress();
                string encryptMacAddress = EncryptionHelper.Encrypt(pass, "passwordKey");
                TBPassGen.Text = encryptMacAddress;
            }
            catch(Exception ex)
            {
                CustomMessage(ex.Message, null, MessageBoxIcon.Error);
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
        //MessageBox
        public void CustomMessage(string txt, string head, MessageBoxIcon icon)
        {
            MessageBox.Show(txt, head, MessageBoxButtons.OK, icon, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
        }

    }

    //Шифрование
    public static class EncryptionHelper
    {
        private static readonly byte[] SALT = new byte[] { 0x26, 0x19, 0x88, 0x44, 0x55, 0x66, 0x77, 0x29 };
        //зашифровать
        public static string Encrypt(string plainText, string password)
        {
            byte[] plainTextBytes = Encoding.UTF8.GetBytes(plainText);

            using (AesManaged aes = new AesManaged())
            {
                Rfc2898DeriveBytes keyDerivationFunction = new Rfc2898DeriveBytes(password, SALT);
                aes.Key = keyDerivationFunction.GetBytes(aes.KeySize / 8);
                aes.IV = keyDerivationFunction.GetBytes(aes.BlockSize / 8);

                using (MemoryStream memoryStream = new MemoryStream())
                {
                    using (CryptoStream cryptoStream = new CryptoStream(memoryStream, aes.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        cryptoStream.Write(plainTextBytes, 0, plainTextBytes.Length);
                        cryptoStream.FlushFinalBlock();
                        byte[] cipherTextBytes = memoryStream.ToArray();
                        return Convert.ToBase64String(cipherTextBytes);
                    }
                }
            }
        }
        //дешифровать
        public static string Decrypt(string cipherText, string password)
        {
            byte[] cipherTextBytes = Convert.FromBase64String(cipherText);
            byte[] decryptedBytes = new byte[cipherTextBytes.Length];
            using (AesManaged aes = new AesManaged())
            {
                Rfc2898DeriveBytes keyDerivationFunction = new Rfc2898DeriveBytes(password, SALT);
                aes.Key = keyDerivationFunction.GetBytes(aes.KeySize / 8);
                aes.IV = keyDerivationFunction.GetBytes(aes.BlockSize / 8);

                using (MemoryStream memoryStream = new MemoryStream(cipherTextBytes))
                {
                    using (CryptoStream cryptoStream = new CryptoStream(memoryStream, aes.CreateDecryptor(), CryptoStreamMode.Read))
                    {
                        int decryptedByteCount = cryptoStream.Read(decryptedBytes, 0, decryptedBytes.Length);
                        return Encoding.UTF8.GetString(decryptedBytes, 0, decryptedByteCount);
                    }
                }
            }
        }
    }
}
