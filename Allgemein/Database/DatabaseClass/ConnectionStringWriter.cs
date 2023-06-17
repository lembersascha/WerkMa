// Kopierrechte bei Sascha Lember 2023
// Erstellt 17.06.2023

#region Verweise

using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using DevExpress.XtraEditors;

#endregion

namespace Lember.WerkMa.Allgemein.Database.DatabaseClass
{
    public class ConnectionStringWriter
    {
        #region Methods

        public void WriteEncryptedConnectionStringToFile(
                string connectionString)
        {
            var filePath                  = @"c:\Lember\ConnectionString.txt";
            var encryptedConnectionString = Encrypt(connectionString);

            try
            {
                var directoryPath = Path.GetDirectoryName(filePath);
                if (!Directory.Exists(directoryPath))
                    if (directoryPath != null)
                        Directory.CreateDirectory(directoryPath);

                File.WriteAllText(filePath, encryptedConnectionString);
                XtraMessageBox.Show(
                        $"Verschlüsselte Verbindungszeichenfolge wurde erfolgreich in die Datei {filePath} geschrieben.");
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show($"Ein Fehler ist aufgetreten: {ex.Message}");
            }
        }

        private string Encrypt(string clearText)
        {
            var clearBytes = Encoding.Unicode.GetBytes(clearText);

            using (var encryptor = Aes.Create())
            {
                var pdb = new Rfc2898DeriveBytes("!an.GE1032",
                        new byte[]
                        {
                                0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76,
                                0x65, 0x64, 0x65, 0x76
                        });
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV  = pdb.GetBytes(16);

                using (var ms = new MemoryStream())
                {
                    using (var cs = new CryptoStream(ms, encryptor.CreateEncryptor(),
                                   CryptoStreamMode.Write))
                    {
                        cs.Write(clearBytes, 0, clearBytes.Length);
                        cs.Close();
                    }

                    clearText = Convert.ToBase64String(ms.ToArray());
                }
            }

            return clearText;
        }

        #endregion
    }
}