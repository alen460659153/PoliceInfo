using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PoliceInfo
{
    public partial class FrmPhoneInfo : Form
    {
        public FrmPhoneInfo(DataTable dt1,DataTable dt2,string re)
        {
            InitializeComponent();
            this.dgvZhuJiao.DataSource = dt1;
            this.dgvBeiJiao.DataSource = dt2;
            this.lblPhone.Text = re;
        }
    }
}
