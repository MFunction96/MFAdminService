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

        }
    }
}
