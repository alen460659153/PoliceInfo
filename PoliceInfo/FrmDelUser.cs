using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DAL;
using Models;

namespace PoliceInfo
{
    public partial class FrmDelUser : Form
    {
        public FrmDelUser()
        {
            InitializeComponent();
            loginList = servicesLogin.GetLoginNameList();
            this.cmbLoginName.DataSource = loginList.ToArray();
            this.cmbLoginName.SelectedIndex = -1;
        }
        private ServicesLogin servicesLogin = new ServicesLogin();
        List<string> loginList = new List<string>();

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (this.cmbLoginName.SelectedIndex==-1)
            {
                MessageBox.Show("您没有选择要删除的用户，请选择之后再删除！","系统提示",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }
            DialogResult result= MessageBox.Show("您确定要删除用户名："+this.cmbLoginName.Text+"？", "系统提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result==DialogResult.Yes)
            {
                int re = this.servicesLogin.DeleteLoginName(this.cmbLoginName.Text);
                if (re>=1)
                {
                    MessageBox.Show("删除成功！","系统提示");
                    this.Close();
                }
            }
        }

        private void FrmDelUser_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmMain.frmDelUser = null;
        }
    }
}
