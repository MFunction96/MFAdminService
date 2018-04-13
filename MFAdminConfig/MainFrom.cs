using Newtonsoft.Json;
using System;
using System.IO;
using System.Windows.Forms;

namespace MFAdminConfig
{
    public partial class MainFrom : Form
    {
        public MainFrom()
        {
            InitializeComponent();
        }

        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            var config = new SettingModel
            {
                Interval = int.Parse(TbInterval.Text),
                KmsServer = TbKmsAddress.Text
            };
            var json = JsonConvert.SerializeObject(config);
            const string path = @"C:\ProgramData\MFAdmin";
            var dir = new DirectoryInfo(path);
            if (!dir.Exists) dir.Create();
            File.WriteAllText($"{path}\\settings.json", json);
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
