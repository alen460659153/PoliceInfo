using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Models;
using DAL;

namespace PoliceInfo
{
    public partial class FrmLoginShow : Form
    {
        public FrmLoginShow(ReFreshLabel fresh)
        {
            InitializeComponent();
            this.lblLoginName.Text = Program.currentLogin.LoginName;
            this.lblLoginShow.Text = Program.currentLogin.LoginShow;
            this.myFresh = fresh;
        }
        private ServicesLogin objLogin = new ServicesLogin();
        private ReFreshLabel myFresh;
        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (this.txtLoginShow.Text.Trim().Length == 0)
            {
                MessageBox.Show("修改失败，要显示的用户名不能为空！", "系统提示");
                return;
            }
            Login login = new Login()
            {
                LoginShow = this.txtLoginShow.Text.Trim()
            };
            try
            {
                int result = objLogin.EditLoginShowByLoginName(login);
                if (result >= 1)
                {
                    MessageBox.Show("修改显示的用户名成功！", "系统提示");
                    Program.currentLogin.LoginShow = this.txtLoginShow.Text.Trim();
                    myFresh();   //调用委托方法
                    this.Close();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmLoginShow_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmMain.objFrmLoginShow = null;
        }
    }
}
