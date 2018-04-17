using System;
using System.Windows.Forms;

namespace MFAdminConfig
{
    public partial class InputForm : Form
    {
        public Action<string> InputAction { get; set; }

        public InputForm(string tip, string defaultInput)
        {
            InitializeComponent();
            LblTip.Text = tip;
            TbInput.Text = defaultInput;
        }

        private void BtnAccept_Click(object sender, EventArgs e)
        {
            if (TbInput.Text == string.Empty)
            {
                MessageBox.Show(@"Invalid Input");
                return;
            }
            InputAction(TbInput.Text);
            Close();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
