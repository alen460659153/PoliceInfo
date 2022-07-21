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
    public partial class FrmShowProgress : Form
    {
        public FrmShowProgress()
        {
            InitializeComponent();
            this.timer1.Start();
            flag = false;
        }
        public static bool flag = false;
        private int x = 1;
        private void timer1_Tick(object sender, EventArgs e)
        {
            switch (x)
            {
                case 1:
                    this.lbl1.ForeColor = Color.Red;
                    this.lbl3.ForeColor = Color.White;                    
                    x = 2;
                    break;
                case 2:                    
                    this.lbl2.ForeColor = Color.Red;
                    this.lbl1.ForeColor = Color.White;
                    x = 3;
                    break;
                case 3:
                    this.lbl3.ForeColor = Color.Red;
                    this.lbl2.ForeColor = Color.White;
                    x = 1;
                    break;
                default:
                    break;
            }
            if (flag==true)
            {
                this.timer1.Stop();
                this.Close();
            }                
        }
    }
}
