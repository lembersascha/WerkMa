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
    public class ConnectionStringReader
    {
        #region Methods

        public string ReadAndDecryptConnectionString()
        {
            var filePath = @"c:\Lember\ConnectionString.txt";

            try
            {
                if (!File.Exists(filePath))
                {
                    XtraMessageBox.Show($"Die Datei {filePath} existiert nicht.");
                    return null;
                }

                var encryptedConnectionString = File.ReadAllText(filePath);
                var decryptedConnectionString
                        = Decrypt(encryptedConnectionString);

                return decryptedConnectionString;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show($"Ein Fehler ist aufgetreten: {ex.Message}");
                return null;
            }
        }

        private string Decrypt(string cipherText)
        {
            var cipherBytes = Convert.FromBase64String(cipherText);

            using (var decryptor = Aes.Create())
            {
                var pdb = new Rfc2898DeriveBytes("!an.GE1032",
                        new byte[]
                        {
                                0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76,
                                0x65, 0x64, 0x65, 0x76
                        });
                decryptor.Key = pdb.GetBytes(32);
                decryptor.IV  = pdb.GetBytes(16);

                using (var ms = new MemoryStream())
                {
                    using (var cs = new CryptoStream(ms, decryptor.CreateDecryptor(),
                                   CryptoStreamMode.Write))
                    {
                        cs.Write(cipherBytes, 0, cipherBytes.Length);
                        cs.Close();
                    }

                    cipherText = Encoding.Unicode.GetString(ms.ToArray());
                }
            }

            return cipherText;
        }

        #endregion
    }
}