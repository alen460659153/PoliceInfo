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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();            
        }

        private ServicesLogin objServicesLogin = new ServicesLogin();        

        #region  窗体拖动

        private Point mouseOff;//鼠标移动位置变量
        private bool leftFlag;//标签是否为左键
        private void Frm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouseOff = new Point(-e.X, -e.Y); //得到变量的值
                leftFlag = true;                  //点击左键按下时标注为true;
            }
        }
        private void Frm_MouseMove(object sender, MouseEventArgs e)
        {
            if (leftFlag)
            {
                Point mouseSet = Control.MousePosition;
                mouseSet.Offset(mouseOff.X, mouseOff.Y);  //设置移动后的位置
                Location = mouseSet;
            }
        }
        private void Frm_MouseUp(object sender, MouseEventArgs e)
        {
            if (leftFlag)
            {
                leftFlag = false;//释放鼠标后标注为false;
            }
        }

        #endregion

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==13)  //如果按下的是回车键
            {
                if (this.txtUserName.Text.Trim().Length==0)
                {
                    MessageBox.Show("用户名不能为空！","系统提示");
                    this.txtUserName.Focus();
                    return;
                }
                if (this.txtPassword.Text.Trim().Length==0)
                {
                    MessageBox.Show("用户密码不能为空！", "系统提示");
                    this.txtPassword.Focus();
                    return;
                }
                Login obj = new Login()
                {
                    LoginName = this.txtUserName.Text.Trim(),
                    LoginPassword = this.txtPassword.Text.Trim()
                };
                Login result = this.objServicesLogin.CheckLogin(obj);
                if (result !=null)
                {
                    this.DialogResult = DialogResult.OK;
                    Program.currentLogin = result;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("用户名或者密码错误，请重新输入后重试","系统提示");
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtUserName_MouseEnter(object sender, EventArgs e)
        {
            ToolTip tip = new ToolTip();
            tip.Show("管理员账号为admin", this.txtUserName);
        }
    }
}
