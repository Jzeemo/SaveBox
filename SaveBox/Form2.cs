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
using System.Security.AccessControl;
using System.Windows.Forms;

namespace SaveBox
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnbroswer_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                txtFIlePath.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void btnLock_Click(object sender, EventArgs e)
        {
            if (txtFIlePath.Text.Length > 0)
            {
                try
                {
                    string folderPath = txtFIlePath.Text;
                    string adminUserName = Environment.UserName;// getting your adminUserName
                    DirectorySecurity ds = Directory.GetAccessControl(folderPath);
                    FileSystemAccessRule fsa = new FileSystemAccessRule(adminUserName, FileSystemRights.FullControl, AccessControlType.Deny);
                    ds.AddAccessRule(fsa);
                    Directory.SetAccessControl(folderPath, ds);
                    MessageBox.Show("Locked");
                }

                catch
                {
                }
            }

        }

        private void btnunlock_Click(object sender, EventArgs e)
        {
            if (txtFIlePath.Text.Length > 0)
            {
                try
                {
                    string folderPath = txtFIlePath.Text;
                    string adminUserName = Environment.UserName;// getting your adminUserName
                    DirectorySecurity ds = Directory.GetAccessControl(folderPath);
                    FileSystemAccessRule fsa = new FileSystemAccessRule(adminUserName, FileSystemRights.FullControl, AccessControlType.Deny);
                    ds.RemoveAccessRule(fsa);
                    Directory.SetAccessControl(folderPath, ds);
                    MessageBox.Show("Unlocked");
                }
                catch
                {
                }
            }
        }
    }
}
