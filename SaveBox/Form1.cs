using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Security.Cryptography;
using System.IO.Compression;
namespace SaveBox
{
    public partial class Form1 : Form
    {
        
        String FileName = @"C:\FileType";
        public Form1()
        {
            InitializeComponent();
          //  Directory.CreateDirectory(@"C:\FileType");
          //  File.AppendAllText(@"C:\FileType\bls.txt", "bla bla");
          ////  this.EncryptFile();
          //  Directory.Move(@"C:\FileType", @"D:\test.txt.tfo");
            //using (ZipFile zip = new ZipFile())
            //{
            //    zip.UseUnicodeAsNecessary = true;  // utf-8
            //    zip.AddDirectory(@"MyDocuments\ProjectX");
            //    zip.Comment = "This zip was created at " + System.DateTime.Now.ToString("G");
            //    zip.Save(pathToSaveZipFile);
            //}
            string startPath = @"C:\FileType\test";
            string zipPath = @"C:\FileType\test.bla";
            string extractPath = @"C:\FileType\extract";
          
            ZipFile.CreateFromDirectory(startPath, zipPath);

            //ZipFile.ExtractToDirectory(zipPath, extractPath);
        }

        public void EncryptFile()
        {
            string file = @"C:\FileType";
            string password = "abcd1234";

            byte[] bytesToBeEncrypted = File.ReadAllBytes(file);
            byte[] passwordBytes = Encoding.UTF8.GetBytes(password);
           
            // Hash the password with SHA256
            passwordBytes = SHA256.Create().ComputeHash(passwordBytes);

            byte[] bytesEncrypted = AES_Encrypt(bytesToBeEncrypted, passwordBytes);

            string fileEncrypted = "C:\\SampleFileEncrypted.DLL";

            File.WriteAllBytes(fileEncrypted, bytesEncrypted);
        }
        public byte[] AES_Encrypt(byte[] bytesToBeEncrypted, byte[] passwordBytes)
        {
            byte[] encryptedBytes = null;

            // Set your salt here, change it to meet your flavor:
            // The salt bytes must be at least 8 bytes.
            byte[] saltBytes = new byte[] { 1, 2, 3, 4, 5, 6, 7, 8 };

            using (MemoryStream ms = new MemoryStream())
            {
                using (RijndaelManaged AES = new RijndaelManaged())
                {
                    AES.KeySize = 256;
                    AES.BlockSize = 128;

                    var key = new Rfc2898DeriveBytes(passwordBytes, saltBytes, 1000);
                    AES.Key = key.GetBytes(AES.KeySize / 8);
                    AES.IV = key.GetBytes(AES.BlockSize / 8);

                    AES.Mode = CipherMode.CBC;

                    using (var cs = new CryptoStream(ms, AES.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(bytesToBeEncrypted, 0, bytesToBeEncrypted.Length);
                        cs.Close();
                    }
                    encryptedBytes = ms.ToArray();
                }
            }

            return encryptedBytes;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            File.Encrypt(FileName);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            File.Decrypt(FileName);
        }
    }
}
