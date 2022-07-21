using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DAL;
using System.IO;
using Models;

namespace PoliceInfo
{
    public partial class FrmAddPersonInfo : Form
    {
        public FrmAddPersonInfo(PersonInfo person, string id, DataGridViewRow row)
        {
            InitializeComponent();
            img = this.picFuKuan.Image;
            this.rdoMale.Checked = true;
            if (Program.currentLogin.LoginName != "admin") this.btnDelete.Visible = false;
            if (person == null)
            {
                this.btnDelete.Visible = false;
                this.Tag = null;
            }
            else
            {
                this.Tag = id;
                this.btnEnter.Text = "    修 改";
                this.iRow = row;
                this.txtPersonName.Text = person.PersonName;
                this.dtpLGTime.Text = person.LGTime.ToString("yyyy-MM-dd");
                if (person.Gender == "男")
                {
                    this.rdoMale.Checked = true;
                }
                else
                {
                    this.rdoFemale.Checked = true;
                }
                this.txtAge.Text = person.Age.ToString();
                this.txtCardNo.Text = person.CardNo;
                this.txtAddress.Text = person.Address;
                this.txtSType.Text = person.SType;
                this.txtAnQing.Text = person.AnQing;
                this.txtActionType.Text = person.ActionType;
                this.txtStatusNow.Text = person.StatusNow;
                this.txtPhoneNumber.Text = person.PhoneNumber;
                this.txtGuanKong.Text = person.GuanKong;
                this.picFuKuan.Image = (Image)new SerializeObjectToString().DeserializeObject(person.PicImage);
            }
        }
        private ServicesPersonInfo servicesPerson = new ServicesPersonInfo();
        private Image img = null;
        private DataGridViewRow iRow = null;

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
        private void FrmFuKuan_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmMain.frmPerson = null;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInsertPic_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = false;
            ofd.Title = "请选择人员照片";
            ofd.Filter = "图片文件(*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png";
            ofd.ValidateNames = true;
            ofd.CheckFileExists = true;
            ofd.CheckPathExists = true;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string fileName = ofd.FileName;
                this.picFuKuan.Image = Image.FromFile(fileName);
            }
        }


        #region 插入人员信息
        private void btnEnter_Click(object sender, EventArgs e)
        {
            #region 数据验证
            if (this.txtPersonName.Text.Trim().Length == 0)
            {
                MessageBox.Show("姓名不能为空！保存失败", "系统提示");
                return;
            }
            if (this.txtAge.Text.Trim().Length == 0)
            {
                MessageBox.Show("年龄不能为空！保存失败", "系统提示");
                return;
            }
            if (this.txtAddress.Text.Trim().Length == 0)
            {
                MessageBox.Show("地址不能为空！保存失败", "系统提示");
                return;
            }
            if (this.txtCardNo.Text.Trim().Length > 0)
            {
                if (this.txtCardNo.Text.Trim().Length != 18)
                {
                    MessageBox.Show("身份证号必须18位，保存失败！", "系统提示");
                    return;
                }
            }
            #endregion

            PersonInfo objInfo = new PersonInfo();
            objInfo.PersonName = this.txtPersonName.Text.Trim();
            objInfo.LGTime = Convert.ToDateTime(this.dtpLGTime.Text).Date;
            objInfo.Gender = this.rdoMale.Checked ? "男" : "女";
            objInfo.Age = Convert.ToInt32(this.txtAge.Text);
            objInfo.CardNo = this.txtCardNo.Text.Trim();
            objInfo.Address = this.txtAddress.Text.Trim();
            objInfo.SType = this.txtSType.Text.Trim();
            objInfo.AnQing = this.txtAnQing.Text.Trim();
            objInfo.GuanKong = this.txtGuanKong.Text.Trim();
            objInfo.ActionType = this.txtActionType.Text.Trim();
            objInfo.StatusNow = this.txtStatusNow.Text.Trim();
            objInfo.PhoneNumber = this.txtPhoneNumber.Text.Trim();
            objInfo.PicImage = new SerializeObjectToString().SerializeObject(this.picFuKuan.Image);
            try
            {
                if (this.Tag == null)
                {
                    int result = this.servicesPerson.AddPersonInfo(objInfo);
                    if (result == 1)
                    {
                        MessageBox.Show("保存成功！成功向数据库添加一条数据！", "系统提示");
                    }
                    this.picFuKuan.Image = img;      //将图片框设置成无照片     
                }
                else
                {
                    DialogResult re = MessageBox.Show("确定要修改序号为【" + this.Tag.ToString() + "】的人员信息吗？", "修改询问", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                    if (re == DialogResult.Yes)
                    {
                        int result = this.servicesPerson.UpdtePersonInfoById(objInfo, this.Tag.ToString());
                        if (result == 1)
                        {
                            iRow.Cells["PicImage"].Value = objInfo.PicImage;
                            iRow.Cells["PersonName"].Value = objInfo.PersonName;
                            iRow.Cells["LGTime"].Value = objInfo.LGTime.ToString("yyyy-MM-dd");
                            iRow.Cells["Gender"].Value = objInfo.Gender;
                            iRow.Cells["Age"].Value = objInfo.Age;
                            iRow.Cells["CardNo"].Value = objInfo.CardNo;
                            iRow.Cells["Address"].Value = objInfo.Address;
                            iRow.Cells["SType"].Value = objInfo.SType;
                            iRow.Cells["AnQing"].Value = objInfo.AnQing;
                            iRow.Cells["GuanKong"].Value = objInfo.GuanKong;
                            iRow.Cells["ActionType"].Value = objInfo.ActionType;
                            iRow.Cells["StatusNow"].Value = objInfo.StatusNow;
                            iRow.Cells["PhoneNumber"].Value = objInfo.PhoneNumber;
                            MessageBox.Show("修改成功！", "系统提示");
                            this.Close();
                        }
                    }
                    else
                    {
                        return;
                    }
                }
                foreach (Control item in this.Controls)
                {
                    if (item.Name.Substring(0, 3) == "txt")
                    {
                        item.Text = "";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("保存失败，具体原因：" + ex.Message, "系统提示");
            }

        }
        #endregion

        private void lblClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 0x20) e.KeyChar = (char)0;  //禁止空格键  
            if (e.KeyChar == 0x2C) e.KeyChar = (char)0; //禁止输入负号        
            if (e.KeyChar > 0x20)
            {
                try
                {
                    int.Parse(((TextBox)sender).Text + e.KeyChar.ToString());
                }
                catch
                {
                    e.KeyChar = (char)0;   //处理非法字符
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult re = MessageBox.Show("确定要删除序号为【" + this.Tag.ToString() + "】的人员信息吗？", "删除询问", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (re == DialogResult.Yes)
            {
                int result = this.servicesPerson.DeletePersonById(this.Tag.ToString());
                if (result == 1)
                {
                    iRow.DataGridView.Rows.Remove(iRow);
                    MessageBox.Show("删除成功！");
                    this.Close();
                }
            }
        }
    }
}
