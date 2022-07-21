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
using System.IO;
using System.Threading;

namespace PoliceInfo
{
    public delegate void ReFreshLabel();
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            this.menuStrip1.Renderer = new CustomProfessionalRenderer();
            this.dgvPersons.EnableHeadersVisualStyles = false;
            this.dgvPersons.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(255, 190, 1);
            this.dgvPersons.AutoGenerateColumns = false;
            this.dgvPersons.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.tlsLabel.Text = "当前登陆用户名【" + Program.currentLogin.LoginShow + "】";
        }
        private ServicesPersonInfo servicesInfo = new ServicesPersonInfo();
        private ServicesPhoneList servicesPhone = new ServicesPhoneList();
        void FreshLabel()
        {
            this.tlsLabel.Text = "当前登陆用户名【" + Program.currentLogin.LoginShow + "】";
        }

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

        private void lblClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public static FrmAddPersonInfo frmPerson = null;
        private void lblInput_Click(object sender, EventArgs e)
        {
            if (frmPerson == null)
            {
                frmPerson = new FrmAddPersonInfo(null, null, null);
                frmPerson.ShowDialog();
            }
            else
            {
                frmPerson.WindowState = FormWindowState.Normal;
                frmPerson.Activate();
            }
        }
        private void txtSerch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 13) return;
            DataTable dt = this.servicesInfo.GetDataTableByCondition(((TextBox)sender).Text);
            this.dgvPersons.DataSource = dt;
            this.dgvPersons.ClearSelection();
        }

        private void dgvPersons_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                Image pic = (Image)new SerializeObjectToString().DeserializeObject(e.Value.ToString());
                e.Value = pic;
                this.dgvPersons.Rows[e.RowIndex].Height = 90;
                this.dgvPersons.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
            }
        }

        private void dgvPersons_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dgvPersons.Rows[e.RowIndex];
            string id = row.Cells["Id"].Value.ToString();
            PersonInfo objInfo = new PersonInfo();
            objInfo.PicImage = row.Cells["PicImage"].Value.ToString();
            objInfo.PersonName = row.Cells["PersonName"].Value.ToString();
            objInfo.LGTime = Convert.ToDateTime(row.Cells["LGTime"].Value.ToString()).Date;
            objInfo.Gender = row.Cells["Gender"].Value.ToString();
            objInfo.Age = Convert.ToInt32(row.Cells["Age"].Value);
            objInfo.CardNo = row.Cells["CardNo"].Value.ToString();
            objInfo.Address = row.Cells["Address"].Value.ToString();
            objInfo.SType = row.Cells["SType"].Value.ToString();
            objInfo.AnQing = row.Cells["AnQing"].Value.ToString();
            objInfo.GuanKong = row.Cells["GuanKong"].Value.ToString();
            objInfo.ActionType = row.Cells["ActionType"].Value.ToString();
            objInfo.StatusNow = row.Cells["StatusNow"].Value.ToString();
            objInfo.PhoneNumber = row.Cells["PhoneNumber"].Value.ToString();
            frmPerson = new FrmAddPersonInfo(objInfo, id, row);
            frmPerson.ShowDialog();
        }

        public static FrmEditLoginPassword objFrmPassword = null;
        private void EditPassword_Click(object sender, EventArgs e)
        {
            if (objFrmPassword == null)
            {
                objFrmPassword = new FrmEditLoginPassword();
                objFrmPassword.ShowDialog();
            }
            else
            {
                objFrmPassword.WindowState = FormWindowState.Normal;
                objFrmPassword.Activate();
            }
        }

        public static FrmLoginShow objFrmLoginShow = null;
        private void EditUserName_Click(object sender, EventArgs e)
        {
            ReFreshLabel freshLabel = new ReFreshLabel(FreshLabel);
            if (objFrmLoginShow == null)
            {
                objFrmLoginShow = new FrmLoginShow(freshLabel);
                objFrmLoginShow.ShowDialog();
            }
            else
            {
                objFrmLoginShow.WindowState = FormWindowState.Normal;
                objFrmLoginShow.Activate();
            }
        }

        /// <summary>
        /// 批量导出数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OutPutPerson_Click(object sender, EventArgs e)
        {
            if (this.dgvPersons.Rows.Count == 0)
            {
                MessageBox.Show("导出失败，没有需要导出的数据，请先查询数据后再导出！", "系统提示");
                return;
            }
            bool resut = new WriteToExcel().WriteDataToExcel(this.dgvPersons);
            if (resut)
            {
                MessageBox.Show("导出成功，请到桌面查看导出的文件！", "系统提示");
            }
        }

        public static FrmInputPerson frmInputPerson = null;
        private void InputPerson_Click(object sender, EventArgs e)
        {
            if (frmInputPerson == null)
            {
                frmInputPerson = new FrmInputPerson();
                frmInputPerson.ShowDialog();
            }
            else
            {
                frmInputPerson.WindowState = FormWindowState.Normal;
                frmInputPerson.Activate();
            }
        }

        private void AddPhoneList_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.CheckFileExists = true;
            fileDialog.CheckPathExists = true;
            fileDialog.ValidateNames = true;
            fileDialog.Title = "请选择你要导入的文件";
            fileDialog.Filter = "Microsoft CSV文件(*.csv)|*.csv";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                string path = fileDialog.FileName;
                string[] array = new string[]
                {
                    "开始时间","主被叫标志","用户号码","IMSI","IMEI","对端号码","对端归属地","通话时长","活动地区","LAC","CI","归属地","基站地址"
                };
                FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs, Encoding.Default);
                int countRight = 1;
                try
                {
                    string result = sr.ReadLine();
                    string[] re = result.Split(',');
                    if (!Enumerable.SequenceEqual(array, re))
                    {
                        sr.Close();
                        fs.Close();
                        MessageBox.Show("您选择的CSV文件不正确！\r\nCSV文件的标题必须为以下序列：\r\n开始时间,主被叫标志,用户号码,IMSI,IMEI,对端号码,对端归属地,通话时长,活动地区,LAC,CI,归属地,基站地址", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    List<PhoneList> list = new List<PhoneList>();
                    Thread t = new Thread(ShowProgress);
                    t.Start();
                    string strLine = "";
                    while ((strLine = sr.ReadLine()) != null)
                    {
                        countRight++;
                        strLine = strLine.Replace("\"", "").Replace("\t", "").Trim();
                        re = strLine.Split(',');
                        PhoneList phone = new PhoneList()
                        {
                            StartTime = Convert.ToDateTime(re[0]),
                            Type = re[1],
                            UserPhone = re[2],
                            IMSI = re[3],
                            IMEI = re[4],
                            OtherPhone = re[5],
                            OtherAddress = re[6],
                            TalkTime = Convert.ToInt32(re[7] == "" ? "0" : re[7]),
                            ActivityAddress = re[8],
                            LAC = re[9],
                            CI = re[10],
                            GuiShu = re[11],
                            JiZhanAddress = re[12]
                        };
                        list.Add(phone);
                    }
                    int count = this.servicesPhone.AddPhoneList(list);
                    FrmShowProgress.flag = true;
                    if (count > 0)
                    {
                        MessageBox.Show("批量导入成功，请导入【" + count + "】条数据！", "系统提示");
                    }
                    sr.Close();
                    fs.Close();
                }
                catch (Exception)
                {
                    FrmShowProgress.flag = true;
                    sr.Close();
                    fs.Close();
                    MessageBox.Show("CSV文件当中第【" + countRight + "】行数据不符合要求，程序异常终止！", "系统提示");
                }
            }
        }
        public static void ShowProgress()
        {
            FrmShowProgress frm = new FrmShowProgress();
            frm.TopMost = true;
            frm.ShowDialog();
        }

        public static FrmPhoneList frmPhone = null;
        private void PhoneManage_Click(object sender, EventArgs e)
        {
            if (frmPhone == null)
            {
                frmPhone = new FrmPhoneList();
                frmPhone.ShowDialog();
            }
            else
            {
                frmPhone.WindowState = FormWindowState.Normal;
                frmPhone.Activate();
            }
        }

        public static FrmAddLogin frmLogin = null;
        private void AddLogin_Click(object sender, EventArgs e)
        {
            if (frmLogin==null)
            {
                frmLogin = new FrmAddLogin();
                frmLogin.ShowDialog();
            }
            else
            {
                frmLogin.WindowState = FormWindowState.Normal;
                frmLogin.Activate();
            }
        }
        private void FrmMain_Load(object sender, EventArgs e)
        {
            if (Program.currentLogin.LoginName != "admin")
            {
                this.EditUserName.Visible = false;  //隐藏更改用户名
                this.AddLogin.Visible = false;          //隐藏注册用户名
                this.btnDeleteUserName.Visible = false;  //隐藏删除用户名
            }
            foreach (ToolStripMenuItem item in this.menuStrip1.Items)
            {
                foreach (ToolStripMenuItem it in item.DropDownItems)
                {
                    it.ForeColor = Color.White;
                }
            }
        }

        public static FrmDelUser frmDelUser = null;
        private void btnDeleteUserName_Click(object sender, EventArgs e)
        {
            if(frmDelUser==null)
            {
                frmDelUser = new FrmDelUser();
                frmDelUser.ShowDialog();
            }
            else
            {
                frmDelUser.WindowState = FormWindowState.Normal;
                frmDelUser.Activate();
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            e.ClickedItem.BackColor = Color.FromArgb(45, 44, 40);
        }

        private void Help_Click(object sender, EventArgs e)
        {
            AboutBox1 box = new AboutBox1();
            box.ShowDialog();
        }

        private void btnReplaceUserName_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            DataTable dt = this.servicesInfo.GetDataTableByCondition(this.dtpStart.Text,this.dtpEnd.Text);
            this.dgvPersons.DataSource = dt;
            this.dgvPersons.ClearSelection();
        }
    }
}
