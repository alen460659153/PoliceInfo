using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace PoliceInfo
{
    public partial class FrmInputPerson : Form
    {
        public FrmInputPerson()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmInputPerson_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmMain.frmInputPerson = null;
        }

        private void btnDownLoad_Click(object sender, EventArgs e)
        {
            bool result = new WriteToExcel().WriteDataToExcel(null);
            if (result)
            {
                MessageBox.Show("模板文件下载成功！请到桌面上查看下载的模板文件！","系统提示");
            }
            else
            {
                MessageBox.Show("模板文件下载失败！请联系开发人员寻求帮助！", "系统提示");
            }
        }

        private void btnInputData_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.CheckFileExists = true;
            fileDialog.CheckPathExists = true;
            fileDialog.ValidateNames = true;
            fileDialog.Title = "请选择你要导入的文件";
            fileDialog.Filter = "Microsoft Excel文件(*.xlsx)|*.xlsx";
            if (fileDialog.ShowDialog()==DialogResult.OK)
            {
                string path = fileDialog.FileName;
                try
                {
                    FileStream fs = File.OpenWrite(path);
                    fs.Close();
                    fs.Dispose();
                    Thread t = new Thread(FrmMain.ShowProgress);
                    t.Start();
                    string result = new WriteToExcel().InputPerson(path);
                    FrmShowProgress.flag = true;
                    MessageBox.Show(result,"系统提示");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("导入文件数据失败，程序运行发生异常错误，原因："+ex.Message,"系统提示");
                }
            }
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
