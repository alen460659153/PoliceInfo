namespace PoliceInfo
{
    partial class FrmPhoneInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPhoneInfo));
            this.label1 = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.dgvZhuJiao = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvBeiJiao = new System.Windows.Forms.DataGridView();
            this.UserPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TalkTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserPhone2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Count2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TalkTime2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZhuJiao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBeiJiao)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "手机号码：";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblPhone.ForeColor = System.Drawing.Color.White;
            this.lblPhone.Location = new System.Drawing.Point(87, 18);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(51, 19);
            this.lblPhone.TabIndex = 3;
            this.lblPhone.Text = "手机号";
            // 
            // dgvZhuJiao
            // 
            this.dgvZhuJiao.AllowUserToAddRows = false;
            this.dgvZhuJiao.AllowUserToDeleteRows = false;
            this.dgvZhuJiao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvZhuJiao.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserPhone,
            this.Count,
            this.TalkTime});
            this.dgvZhuJiao.Location = new System.Drawing.Point(5, 85);
            this.dgvZhuJiao.Name = "dgvZhuJiao";
            this.dgvZhuJiao.ReadOnly = true;
            this.dgvZhuJiao.RowHeadersVisible = false;
            this.dgvZhuJiao.RowTemplate.Height = 23;
            this.dgvZhuJiao.Size = new System.Drawing.Size(310, 513);
            this.dgvZhuJiao.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(114, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "主叫号码信息";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(439, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "被叫号码信息";
            // 
            // dgvBeiJiao
            // 
            this.dgvBeiJiao.AllowUserToAddRows = false;
            this.dgvBeiJiao.AllowUserToDeleteRows = false;
            this.dgvBeiJiao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBeiJiao.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserPhone2,
            this.Count2,
            this.TalkTime2});
            this.dgvBeiJiao.Location = new System.Drawing.Point(335, 85);
            this.dgvBeiJiao.Name = "dgvBeiJiao";
            this.dgvBeiJiao.ReadOnly = true;
            this.dgvBeiJiao.RowHeadersVisible = false;
            this.dgvBeiJiao.RowTemplate.Height = 23;
            this.dgvBeiJiao.Size = new System.Drawing.Size(310, 513);
            this.dgvBeiJiao.TabIndex = 4;
            // 
            // UserPhone
            // 
            this.UserPhone.DataPropertyName = "UserPhone";
            this.UserPhone.HeaderText = "号码";
            this.UserPhone.Name = "UserPhone";
            this.UserPhone.ReadOnly = true;
            // 
            // Count
            // 
            this.Count.DataPropertyName = "Count";
            this.Count.HeaderText = "次数";
            this.Count.Name = "Count";
            this.Count.ReadOnly = true;
            // 
            // TalkTime
            // 
            this.TalkTime.DataPropertyName = "TalkTime";
            this.TalkTime.HeaderText = "总通话时长";
            this.TalkTime.Name = "TalkTime";
            this.TalkTime.ReadOnly = true;
            // 
            // UserPhone2
            // 
            this.UserPhone2.DataPropertyName = "UserPhone2";
            this.UserPhone2.HeaderText = "号码";
            this.UserPhone2.Name = "UserPhone2";
            this.UserPhone2.ReadOnly = true;
            // 
            // Count2
            // 
            this.Count2.DataPropertyName = "Count2";
            this.Count2.HeaderText = "次数";
            this.Count2.Name = "Count2";
            this.Count2.ReadOnly = true;
            // 
            // TalkTime2
            // 
            this.TalkTime2.DataPropertyName = "TalkTime2";
            this.TalkTime2.HeaderText = "总通话时长";
            this.TalkTime2.Name = "TalkTime2";
            this.TalkTime2.ReadOnly = true;
            // 
            // FrmPhoneInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(68)))), ((int)(((byte)(146)))));
            this.ClientSize = new System.Drawing.Size(652, 610);
            this.Controls.Add(this.dgvBeiJiao);
            this.Controls.Add(this.dgvZhuJiao);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPhoneInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "主被叫信息展示";
            ((System.ComponentModel.ISupportInitialize)(this.dgvZhuJiao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBeiJiao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.DataGridView dgvZhuJiao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvBeiJiao;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Count;
        private System.Windows.Forms.DataGridViewTextBoxColumn TalkTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserPhone2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Count2;
        private System.Windows.Forms.DataGridViewTextBoxColumn TalkTime2;
    }
}