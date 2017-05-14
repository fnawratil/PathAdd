using Microsoft.Win32;
using PathAdd.Installer.Properties;
using System;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace PathAdd.Installer
{
    public partial class Installer : Form
    {
        private bool installed = false;

        private bool installedTree, installedFolder, installedFiles;

        private string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "PathAdd", "PathAdd.exe");

        public Installer()
        {
            InitializeComponent();

            installedTree = Registry.ClassesRoot.OpenSubKey("Directory\\Background\\shell\\PathAdd") != null;
            installedFolder = Registry.ClassesRoot.OpenSubKey("Directory\\shell\\PathAdd") != null;
            installedFiles = Registry.ClassesRoot.OpenSubKey("*\\shell\\PathAdd") != null;

            installed = installedTree || installedFolder || installedFiles;

            if (installed)
            {
                button_install.Text = "Uninstall";

                groupBox1.Enabled = false;

                checkBox_files.Checked = installedFiles;
                checkBox_foldersRightPane.Checked = installedFolder;
                checkBox_folderTree.Checked = installedTree;
            }
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_install_Click(object sender, EventArgs e)
        {
            if (installed)
            {
                try
                {
                    Registry.ClassesRoot.DeleteSubKeyTree("Directory\\Background\\shell\\PathAdd", false);
                    Registry.ClassesRoot.DeleteSubKeyTree("Directory\\shell\\PathAdd", false);
                    Registry.ClassesRoot.DeleteSubKeyTree("*\\shell\\PathAdd", false);
                    MessageBox.Show("Uninstall successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch(Exception)
                {
                    MessageBox.Show("Uninstall might have been successful but at least one error occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                try
                {
                    if (!Directory.Exists(Path.GetDirectoryName(filePath)))
                        Directory.CreateDirectory(Path.GetDirectoryName(filePath));

                    if(!File.Exists(filePath))
                        File.WriteAllBytes(filePath, Resources.PathAdd);

                    if (checkBox_folderTree.Checked)
                    {
                        var key = Registry.ClassesRoot.OpenSubKey("Directory\\Background\\shell", true);
                        CreateCommand(key);
                    }

                    if (checkBox_foldersRightPane.Checked)
                    {
                        var key = Registry.ClassesRoot.OpenSubKey("Directory\\shell", true);
                        CreateCommand(key);
                    }

                    if (checkBox_files.Checked)
                    {
                        var key = Registry.ClassesRoot.OpenSubKey("*\\shell", true);
                        CreateCommand(key);
                    }

                    MessageBox.Show("Installation successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch(Exception)
                {
                    MessageBox.Show("Install might have been successful but at least one error occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


            this.Close();
        }

        private void CreateCommand(RegistryKey key)
        {
            var baseKey = key.CreateSubKey("PathAdd");
            baseKey.SetValue("", "Add to Path");

            var commandKey = baseKey.CreateSubKey("command");
            commandKey.SetValue("", $"\"{filePath}\" \" %V\"");
        }
    }
}
