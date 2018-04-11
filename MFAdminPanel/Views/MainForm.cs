using MFAdminPanel.Controllers;
using System;
using System.Windows.Forms;

namespace MFAdminPanel.Views
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var sc = new ServiceController();
            MessageBox.Show(System.Environment.UserName);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Show();
        }
    }
}
