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
    public partial class FrmPhoneList : Form
    {
        public FrmPhoneList()
        {
            InitializeComponent();
        }
        private ServicesPhoneList servicesPhone = new ServicesPhoneList();

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
        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 13) return;
            DataTable dt = servicesPhone.SelectPhoneListByNum(this.txtPhone.Text.Trim());
            this.dgvPhoneList.DataSource = dt;
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmPhoneList_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmMain.frmPhone = null;
        }

        private void dgvPhoneList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex==4 || e.ColumnIndex==7)
            {
                DataGridViewRow row = this.dgvPhoneList.Rows[e.RowIndex];
                string result = row.Cells[e.ColumnIndex].Value.ToString();
                if ( result== string.Empty) return;
                List<DataTable> list = servicesPhone.GetDataTableByNum(result);
                FrmPhoneInfo frm = new FrmPhoneInfo(list[0], list[1],result);
                frm.ShowDialog();
            }
            else
            {
                this.dgvPhoneList.ClearSelection();
            }
        }
    }
}
