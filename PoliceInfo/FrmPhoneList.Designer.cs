namespace PoliceInfo
{
    partial class FrmPhoneList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPhoneList));
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvPhoneList = new System.Windows.Forms.DataGridView();
            this.lblClose = new System.Windows.Forms.Label();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IMSI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IMEI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OtherPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OtherAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TalkTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ActivityAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LAC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GuiShu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JiZhanAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhoneList)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtPhone.Location = new System.Drawing.Point(185, 18);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(139, 23);
            this.txtPhone.TabIndex = 1;
            this.txtPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPhone_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "请输入您要查询的手机号：";
            // 
            // dgvPhoneList
            // 
            this.dgvPhoneList.AllowUserToAddRows = false;
            this.dgvPhoneList.AllowUserToDeleteRows = false;
            this.dgvPhoneList.BackgroundColor = System.Drawing.Color.White;
            this.dgvPhoneList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhoneList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.StartTime,
            this.Type,
            this.UserPhone,
            this.IMSI,
            this.IMEI,
            this.OtherPhone,
            this.OtherAddress,
            this.TalkTime,
            this.ActivityAddress,
            this.LAC,
            this.CI,
            this.GuiShu,
            this.JiZhanAddress});
            this.dgvPhoneList.Location = new System.Drawing.Point(3, 58);
            this.dgvPhoneList.Name = "dgvPhoneList";
            this.dgvPhoneList.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(193)))), ((int)(((byte)(1)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPhoneList.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPhoneList.RowHeadersVisible = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvPhoneList.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvPhoneList.RowTemplate.Height = 23;
            this.dgvPhoneList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvPhoneList.Size = new System.Drawing.Size(856, 475);
            this.dgvPhoneList.TabIndex = 4;
            this.dgvPhoneList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhoneList_CellClick);
            // 
            // lblClose
            // 
            this.lblClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(44)))), ((int)(((byte)(40)))));
            this.lblClose.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblClose.ForeColor = System.Drawing.Color.White;
            this.lblClose.Location = new System.Drawing.Point(827, 9);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(32, 19);
            this.lblClose.TabIndex = 9;
            this.lblClose.Text = "×";
            this.lblClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.Frozen = true;
            this.Id.HeaderText = "序号";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 60;
            // 
            // StartTime
            // 
            this.StartTime.DataPropertyName = "StartTime";
            this.StartTime.HeaderText = "开始时间";
            this.StartTime.Name = "StartTime";
            this.StartTime.ReadOnly = true;
            this.StartTime.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Type
            // 
            this.Type.DataPropertyName = "Type";
            this.Type.HeaderText = "主被叫标志";
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            this.Type.Width = 90;
            // 
            // UserPhone
            // 
            this.UserPhone.DataPropertyName = "UserPhone";
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Blue;
            this.UserPhone.DefaultCellStyle = dataGridViewCellStyle1;
            this.UserPhone.HeaderText = "用户号码";
            this.UserPhone.Name = "UserPhone";
            this.UserPhone.ReadOnly = true;
            this.UserPhone.Width = 90;
            // 
            // IMSI
            // 
            this.IMSI.DataPropertyName = "IMSI";
            this.IMSI.HeaderText = "IMSI";
            this.IMSI.Name = "IMSI";
            this.IMSI.ReadOnly = true;
            this.IMSI.Width = 90;
            // 
            // IMEI
            // 
            this.IMEI.DataPropertyName = "IMEI";
            this.IMEI.HeaderText = "IMEI";
            this.IMEI.Name = "IMEI";
            this.IMEI.ReadOnly = true;
            this.IMEI.Width = 90;
            // 
            // OtherPhone
            // 
            this.OtherPhone.DataPropertyName = "OtherPhone";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Blue;
            this.OtherPhone.DefaultCellStyle = dataGridViewCellStyle2;
            this.OtherPhone.HeaderText = "对端号码";
            this.OtherPhone.Name = "OtherPhone";
            this.OtherPhone.ReadOnly = true;
            this.OtherPhone.Width = 90;
            // 
            // OtherAddress
            // 
            this.OtherAddress.DataPropertyName = "OtherAddress";
            this.OtherAddress.HeaderText = "对端归属地";
            this.OtherAddress.Name = "OtherAddress";
            this.OtherAddress.ReadOnly = true;
            // 
            // TalkTime
            // 
            this.TalkTime.DataPropertyName = "TalkTime";
            this.TalkTime.HeaderText = "通话时长";
            this.TalkTime.Name = "TalkTime";
            this.TalkTime.ReadOnly = true;
            this.TalkTime.Width = 80;
            // 
            // ActivityAddress
            // 
            this.ActivityAddress.DataPropertyName = "ActivityAddress";
            this.ActivityAddress.HeaderText = "活动地区";
            this.ActivityAddress.Name = "ActivityAddress";
            this.ActivityAddress.ReadOnly = true;
            this.ActivityAddress.Width = 110;
            // 
            // LAC
            // 
            this.LAC.DataPropertyName = "LAC";
            this.LAC.HeaderText = "LAC";
            this.LAC.Name = "LAC";
            this.LAC.ReadOnly = true;
            this.LAC.Width = 90;
            // 
            // CI
            // 
            this.CI.HeaderText = "CI";
            this.CI.Name = "CI";
            this.CI.ReadOnly = true;
            this.CI.Width = 90;
            // 
            // GuiShu
            // 
            this.GuiShu.DataPropertyName = "GuiShu";
            this.GuiShu.HeaderText = "归属地";
            this.GuiShu.Name = "GuiShu";
            this.GuiShu.ReadOnly = true;
            this.GuiShu.Width = 90;
            // 
            // JiZhanAddress
            // 
            this.JiZhanAddress.DataPropertyName = "JiZhanAddress";
            this.JiZhanAddress.HeaderText = "基站地址";
            this.JiZhanAddress.Name = "JiZhanAddress";
            this.JiZhanAddress.ReadOnly = true;
            this.JiZhanAddress.Width = 90;
            // 
            // FrmPhoneList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(68)))), ((int)(((byte)(146)))));
            this.ClientSize = new System.Drawing.Size(864, 540);
            this.Controls.Add(this.lblClose);
            this.Controls.Add(this.dgvPhoneList);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPhoneList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "查询通话记录";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmPhoneList_FormClosed);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Frm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Frm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Frm_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhoneList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvPhoneList;
        private System.Windows.Forms.Label lblClose;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn IMSI;
        private System.Windows.Forms.DataGridViewTextBoxColumn IMEI;
        private System.Windows.Forms.DataGridViewTextBoxColumn OtherPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn OtherAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn TalkTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn ActivityAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn LAC;
        private System.Windows.Forms.DataGridViewTextBoxColumn CI;
        private System.Windows.Forms.DataGridViewTextBoxColumn GuiShu;
        private System.Windows.Forms.DataGridViewTextBoxColumn JiZhanAddress;
    }
}