using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace GuardServer
{
    class Program
    {

        //          NmTj1zAhN64z0RTwI+3YvfsCYaxOmNlakzhAz4CrWCM=

        //          1c4f5a86db4b0cf7b26ccce5af6111eb
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            bool showMenu = true;
            while (showMenu)
            {
                showMenu = MainMenu();
            }
        }
        private static bool MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Добро пожаловать в терминальную версию приложения GuardPRO.");
            Console.WriteLine("Меню:");
            Console.WriteLine("1. Создать ключ-пароль для клиентского приложения.");
            Console.WriteLine("2. Показать справку по приложению.");
            Console.WriteLine("3. Отмена");

            switch (Console.ReadLine().ToString())
            {
                case "1":
                    Encrypted();
                    PressAnyKey();
                    return true;
                case "2":
                    Console.WriteLine("Это приложение разработано специально для программы GuardPro,");
                    Console.WriteLine("Оно является KeyGen версией, которая не подлежит распространению.");
                    Console.WriteLine("Приложение написано студентом группы ПР-49, Ремезовым Кириллом.");
                    PressAnyKey();
                    return true;
                case "3":
                    Console.WriteLine("Отмена.");
                    PressAnyKey();
                    return false;
                default:
                    return true;
            }
        }
        private static void PressAnyKey() {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
            Console.WriteLine("Нажмите любую клавишу для продолжения.");
            Console.ReadKey();
            Console.ForegroundColor = ConsoleColor.Green;
        }
        private static void Encrypted() {
            Console.Clear();
            try
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("ВНИМАНИЕ!");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Введите клиентский код.");
                Console.ForegroundColor = ConsoleColor.Red;
                string encryptStr = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.Green;
                string decryptStr = EncryptionHelper.Decrypt(encryptStr, "passwordKey");
                string minusMAC = decryptStr.Substring(decryptStr.Length - 12);
                string minusSALT = decryptStr.Replace(minusMAC, "");
                Console.WriteLine("Processing...");
                Console.WriteLine($"Расшифровка данных: {minusMAC} {minusSALT}");
                PressAnyKey();
                Encryptions(minusMAC, minusSALT);
            }
            catch(Exception ex) {
                Console.WriteLine(ex.Message);
            }
        }
        private static bool Encryptions(string macAddress, string salt) {
            Console.Clear();
            Console.WriteLine("Какого типа ключ вы хотите создать?");
            Console.WriteLine("Меню:");
            Console.WriteLine("1. Шифрование MD5 для актуальной версии");
            Console.WriteLine("2. Шифрование SHA256 для расширенной версии - (недоступно)");
            Console.WriteLine("3. Шифрование AES для lite версии - (недоступно)");
            Console.WriteLine("4. Не создавать ключ.");

            switch (Console.ReadLine().ToString())
            {
                case "1":
                    Console.WriteLine($"MD5: {EncryptionHelper.EncryptMD5(macAddress, salt)}");
                    return false;
                case "2":
                    Console.WriteLine("Написано же, что недоступно!");
                    return false;
                case "3":
                    Console.WriteLine("Написано же, что недоступно!");
                    return false;
                case "4":
                    Console.WriteLine("Окей, не будем");
                    return false;
                default:
                    return false;
            }
        }
    }
    //Шифрование
    public static class EncryptionHelper
    {
        private static readonly byte[] SALT = new byte[] { 0x26, 0x19, 0x88, 0x44, 0x55, 0x66, 0x77, 0x29 };

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

        public static string EncryptMD5(string macAddress, string salt)
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
    }
}

