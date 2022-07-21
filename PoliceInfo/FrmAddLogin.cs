using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DAL;

namespace PoliceInfo
{
    public partial class FrmAddLogin : Form
    {
        public FrmAddLogin()
        {
            InitializeComponent();
        }
        private ServicesLogin servicesLogin = new ServicesLogin();

        private void btnEnter_Click(object sender, EventArgs e)
        {

            #region 数据较验
            if (this.txtLoginName.Text.Length == 0)
            {
                MessageBox.Show("注册失败，用户名不能为空！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txtLoginName.Focus();
                return;
            }
            if (this.txtLoginName.Text == "admin")
            {
                MessageBox.Show("注册失败，您不能注册管理员账号！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txtLoginName.Focus();
                return;
            }
            if(this.servicesLogin.IsExists(this.txtLoginName.Text.Trim()))
            {
                MessageBox.Show("注册失败，您注册的账号系统已经存在！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txtLoginName.Focus();
                return;
            }
            bool blx = this.IsNumeric(this.txtLoginName.Text.Trim());
            if (blx)
            {
                MessageBox.Show("用户名不能为纯数字！", "系统提示");
                return;
            }
            if (this.txtLoginPassword.Text.Length == 0)
            {
                MessageBox.Show("注册失败，密码不能为空！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txtLoginPassword.Focus();
                return;
            }
            else if (this.txtLoginPassword.Text.Length < 5)
            {
                MessageBox.Show("注册失败，密码不能少于5位！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txtLoginPassword.Focus();
                return;
            }
            bool bl = this.IsNumeric(this.txtLoginPassword.Text.Trim());
            if (bl)
            {
                MessageBox.Show("密码不能全是数字！", "系统提示");
                return;
            }
            if (this.txtRePassword.Text.Length == 0)
            {
                MessageBox.Show("注册失败，重复密码不能为空且必须与上面一致！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txtRePassword.Focus();
                return;
            }
            if (!this.txtLoginPassword.Text.Equals(this.txtRePassword.Text))
            {
                MessageBox.Show("注册失败，两次输入的密码不一致！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txtLoginPassword.Focus();
                return;
            }
            #endregion

            Login obj = new Login()
            {
                LoginName = this.txtLoginName.Text.Trim(),
                LoginPassword = this.txtLoginPassword.Text.Trim(),
                LoginShow = this.servicesLogin.GetLoginShow()
            };
            try
            {
                int result = this.servicesLogin.AddLoginName(obj);
                if (result == 1)
                {
                    MessageBox.Show("注册成功!\r\n账号：" + this.txtLoginName.Text + "\r\n密码：" + this.txtLoginPassword.Text + "\r\n请牢记您的账号和密码！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("注册失败，请联系开发人员寻求帮助！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private bool IsNumeric(string str) //接收一个string类型的参数,保存到str里
        {
            if (str == null || str.Length == 0)    //验证这个参数是否为空
                return false;                           //是，就返回False
            ASCIIEncoding ascii = new ASCIIEncoding();//new ASCIIEncoding 的实例
            byte[] bytestr = ascii.GetBytes(str);         //把string类型的参数保存到数组里

            foreach (byte c in bytestr)                   //遍历这个数组里的内容
            {
                if (c < 48 || c > 57)                          //判断是否为数字
                {
                    return false;                              //不是，就返回False
                }
            }
            return true;                                        //是，就返回True
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmAddLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmMain.frmLogin = null;
        }
    }
}
