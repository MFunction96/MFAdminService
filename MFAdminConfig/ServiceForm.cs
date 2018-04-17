using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MFAdminConfig
{
    public partial class ServiceForm : Form
    {
        /// <summary>
        /// 
        /// </summary>
        private IList<ServiceModel> Items { get; }
        /// <summary>
        /// 
        /// </summary>
        public Action<IList<ServiceModel>> ServiceAction { get; set; }
        /// <inheritdoc />
        /// <summary>
        /// </summary>
        /// <param name="items"></param>
        public ServiceForm(IList<ServiceModel> items)
        {
            InitializeComponent();
            Items = items;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ServiceForm_Load(object sender, EventArgs e)
        {
            if (Items.Count == 0) return;
            foreach (var item in Items)
            {
                CbItems.Items.Add(item.Nickname);
            }

            CbItems.SelectedIndex = 0;
            BtnAddSerivce.Enabled = true;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            ServiceAction(Items);
            Close();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnNewItem_Click(object sender, EventArgs e)
        {
            var form = new InputForm(@"请输入项目名称", string.Empty)
            {
                InputAction = s =>
                {
                    CbItems.Items.Add(s);
                    CbItems.Text = s;
                    Items.Add(new ServiceModel
                    {
                        Nickname = s,
                        Enabled = true
                    });
                }
            };
            var result = form.ShowDialog(this);
            if (result != DialogResult.OK) return;
            CbEnabled.Checked = true;
            CbEnabled.Enabled = true;
            BtnEditItem.Enabled = true;
            BtnDelItem.Enabled = true;
            BtnAddSerivce.Enabled = true;
            BtnEditService.Enabled = false;
            BtnDelService.Enabled = false;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnEditItem_Click(object sender, EventArgs e)
        {
            var selected = CbItems.SelectedItem;
            if (selected.ToString() == string.Empty) return;
            var form = new InputForm(@"请输入项目名称", selected.ToString())
            {
                InputAction = s =>
                {
                    CbItems.Items.Add(s);
                    CbItems.Text = s;
                    Items.Add(new ServiceModel { Nickname = s });
                }
            };
            var result = form.ShowDialog(this);
            if (result != DialogResult.OK) return;
            CbItems.Items.Remove(selected);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnDelItem_Click(object sender, EventArgs e)
        {
            CbItems.Items.Remove(CbItems.SelectedItem);
            if (CbItems.Items.Count != 0) return;
            BtnEditItem.Enabled = false;
            BtnDelItem.Enabled = false;
            BtnAddSerivce.Enabled = false;
            BtnEditService.Enabled = false;
            BtnDelService.Enabled = false;
            CbEnabled.Enabled = false;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAddSerivce_Click(object sender, EventArgs e)
        {
            var item = Items.First(tmp => tmp.Nickname == CbItems.Text);
            var form = new InputForm(@"请输入项目名称", string.Empty)
            {
                InputAction = s =>
                {
                    LbServices.Items.Add(s);
                    item.Services.Add(s);
                }
            };
            var result = form.ShowDialog(this);
            if (result != DialogResult.OK) return;
            BtnEditService.Enabled = true;
            BtnDelService.Enabled = true;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnEditService_Click(object sender, EventArgs e)
        {
            var selected = LbServices.SelectedItem;
            var service = (string)LbServices.SelectedItem;
            var item = Items.First(tmp => tmp.Nickname == CbItems.Text);
            var form = new InputForm(@"请输入项目名称", string.Empty)
            {
                InputAction = s =>
                {
                    LbServices.Items.Add(s);
                    item.Services.Add(s);
                }
            };
            var result = form.ShowDialog(this);
            if (result != DialogResult.OK) return;
            LbServices.Items.Remove(service);
            item.Services.Remove((string)selected);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnDelService_Click(object sender, EventArgs e)
        {
            LbServices.Items.Remove(LbServices.SelectedItem);
            var item = Items.First(tmp => tmp.Nickname == CbItems.Text);
            item.Services.Remove(item.Services.First(tmp => tmp == (string)LbServices.SelectedItem));
            if (LbServices.Items.Count != 0) return;
            BtnEditService.Enabled = false;
            BtnDelService.Enabled = false;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CbItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            LbServices.Items.Clear();
            if (Items.Count == 0) return;
            var item = Items.First(tmp => tmp.Nickname == CbItems.Text);
            foreach (var service in item.Services)
            {
                LbServices.Items.Add(service);
            }
            BtnEditService.Enabled = true;
            BtnDelService.Enabled = true;
        }
    }
}
