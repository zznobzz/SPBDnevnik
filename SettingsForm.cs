using System;
using System.Windows.Forms;

namespace SPBDnevnik
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
            loginTB.Text = Properties.Settings.Default.login;
            passwordTB.Text = Properties.Settings.Default.password;
            saveFolderTB.Text = Properties.Settings.Default.saveFolder;
        }

        //Кнопка отмены
        private void cancelBTN_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ofdBTN_Click(object sender, EventArgs e)
        {
            attachFBD.ShowDialog();
            saveFolderTB.Text = attachFBD.SelectedPath;
        }

        private void saveBTN_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.login = loginTB.Text;
            Properties.Settings.Default.password = passwordTB.Text;
            Properties.Settings.Default.saveFolder = saveFolderTB.Text;
            Properties.Settings.Default.Save();
            Close();
        }

        private void saveFolderTB_DoubleClick(object sender, EventArgs e)
        {
            attachFBD.ShowDialog();
            saveFolderTB.Text = attachFBD.SelectedPath;
        }
    }
}
