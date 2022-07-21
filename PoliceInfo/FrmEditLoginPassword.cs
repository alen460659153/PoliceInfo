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
    public partial class FrmEditLoginPassword : Form
    {
        public FrmEditLoginPassword()
        {
            InitializeComponent();
            this.lblLoginId.Text = Program.currentLogin.LoginName;
        }
        private ServicesLogin objLogin = new ServicesLogin();
        private void btnEnter_Click(object sender, EventArgs e)
        {

            #region 数据较验
            if (this.txtOldPassword.Text.Length==0)
            {
                MessageBox.Show("修改失败，原密码不能为空！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txtOldPassword.Focus();
                return;
            }
            if (this.txtOldPassword.Text!=Program.currentLogin.LoginPassword)
            {
                MessageBox.Show("修改失败，原密码输入不正确！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txtOldPassword.Focus();
                return;
            }
            if (this.txtLoginPassword.Text.Length == 0)
            {
                MessageBox.Show("修改失败，密码不能为空！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txtLoginPassword.Focus();
                return;
            }
            else if (this.txtLoginPassword.Text.Length < 5)
            {
                MessageBox.Show("修改失败，密码不能少于5位！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txtLoginPassword.Focus();
                return;
            }
            bool bl = this.IsNumeric(this.txtLoginPassword.Text.Trim());
            if (bl)
            {
                MessageBox.Show("密码不能全是数字！","系统提示");
                return;
            }            
            if (this.txtRePassword.Text.Length == 0)
            {
                MessageBox.Show("修改失败，重复密码不能为空且必须与上面一致！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txtRePassword.Focus();
                return;
            }
            if (!this.txtLoginPassword.Text.Equals(this.txtRePassword.Text))
            {
                MessageBox.Show("修改失败，两次输入的密码不一致！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txtLoginPassword.Focus();
                return;
            }
            #endregion

            DialogResult dr = MessageBox.Show("确定修改密码吗？点击【是】立即修改。。","系统提示",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (dr == DialogResult.No)
            {
                this.Close();
                return;
            }          
            Login obj = new Login()
            {
                LoginName = this.lblLoginId.Text,
                LoginPassword = this.txtLoginPassword.Text
            };
            try
            {
                int result = this.objLogin.EditLoginPassword(obj);
                if (result == 1)
                {
                    MessageBox.Show("修改成功!\r\n账号：" + this.lblLoginId.Text + "\r\n密码：" + this.txtLoginPassword.Text + "\r\n请牢记您的账号和密码！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Program.currentLogin.LoginPassword = obj.LoginPassword;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("修改失败，请联系开发人员寻求帮助！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void FrmEditLoginPassword_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmMain.objFrmPassword = null;
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
    }
}
