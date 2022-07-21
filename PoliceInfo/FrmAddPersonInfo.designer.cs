namespace PoliceInfo
{
    partial class FrmAddPersonInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddPersonInfo));
            this.label5 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnInsertPic = new System.Windows.Forms.Button();
            this.btnEnter = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.picFuKuan = new System.Windows.Forms.PictureBox();
            this.txtPersonName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.rdoMale = new System.Windows.Forms.RadioButton();
            this.rdoFemale = new System.Windows.Forms.RadioButton();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCardNo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtActionType = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtStatusNow = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblClose = new System.Windows.Forms.Label();
            this.lblInput = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.txtGuanKong = new System.Windows.Forms.TextBox();
            this.txtSType = new System.Windows.Forms.RichTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtAnQing = new System.Windows.Forms.RichTextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.dtpLGTime = new System.Windows.Forms.DateTimePicker();
            this.label16 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picFuKuan)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(237, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "（必填 *）";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(95, 238);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(206, 42);
            this.txtAddress.TabIndex = 6;
            this.txtAddress.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(16, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "姓 名：";
            // 
            // txtAge
            // 
            this.txtAge.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtAge.Location = new System.Drawing.Point(95, 153);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(139, 23);
            this.txtAge.TabIndex = 4;
            this.txtAge.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAge_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.Yellow;
            this.label3.Location = new System.Drawing.Point(16, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "年 龄：";
            // 
            // btnInsertPic
            // 
            this.btnInsertPic.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(71)))), ((int)(((byte)(157)))));
            this.btnInsertPic.Location = new System.Drawing.Point(337, 206);
            this.btnInsertPic.Name = "btnInsertPic";
            this.btnInsertPic.Size = new System.Drawing.Size(133, 26);
            this.btnInsertPic.TabIndex = 10;
            this.btnInsertPic.Text = "选择照片";
            this.btnInsertPic.UseVisualStyleBackColor = true;
            this.btnInsertPic.Click += new System.EventHandler(this.btnInsertPic_Click);
            // 
            // btnEnter
            // 
            this.btnEnter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEnter.BackgroundImage")));
            this.btnEnter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnEnter.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnEnter.Location = new System.Drawing.Point(115, 555);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(75, 28);
            this.btnEnter.TabIndex = 13;
            this.btnEnter.Text = "    保 存";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(315, 555);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 28);
            this.btnClose.TabIndex = 15;
            this.btnClose.Text = "   取 消";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // picFuKuan
            // 
            this.picFuKuan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picFuKuan.ErrorImage = null;
            this.picFuKuan.Image = ((System.Drawing.Image)(resources.GetObject("picFuKuan.Image")));
            this.picFuKuan.Location = new System.Drawing.Point(337, 44);
            this.picFuKuan.Name = "picFuKuan";
            this.picFuKuan.Size = new System.Drawing.Size(133, 156);
            this.picFuKuan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFuKuan.TabIndex = 7;
            this.picFuKuan.TabStop = false;
            // 
            // txtPersonName
            // 
            this.txtPersonName.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtPersonName.Location = new System.Drawing.Point(95, 42);
            this.txtPersonName.Name = "txtPersonName";
            this.txtPersonName.Size = new System.Drawing.Size(139, 23);
            this.txtPersonName.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.ForeColor = System.Drawing.Color.Yellow;
            this.label10.Location = new System.Drawing.Point(16, 120);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 19);
            this.label10.TabIndex = 11;
            this.label10.Text = "性 别：";
            // 
            // rdoMale
            // 
            this.rdoMale.AutoSize = true;
            this.rdoMale.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rdoMale.ForeColor = System.Drawing.Color.Yellow;
            this.rdoMale.Location = new System.Drawing.Point(95, 120);
            this.rdoMale.Name = "rdoMale";
            this.rdoMale.Size = new System.Drawing.Size(40, 18);
            this.rdoMale.TabIndex = 2;
            this.rdoMale.TabStop = true;
            this.rdoMale.Text = "男";
            this.rdoMale.UseVisualStyleBackColor = true;
            // 
            // rdoFemale
            // 
            this.rdoFemale.AutoSize = true;
            this.rdoFemale.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rdoFemale.ForeColor = System.Drawing.Color.Yellow;
            this.rdoFemale.Location = new System.Drawing.Point(162, 120);
            this.rdoFemale.Name = "rdoFemale";
            this.rdoFemale.Size = new System.Drawing.Size(40, 18);
            this.rdoFemale.TabIndex = 3;
            this.rdoFemale.TabStop = true;
            this.rdoFemale.Text = "女";
            this.rdoFemale.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.ForeColor = System.Drawing.Color.Yellow;
            this.label11.Location = new System.Drawing.Point(16, 196);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 19);
            this.label11.TabIndex = 13;
            this.label11.Text = "身份证号：";
            // 
            // txtCardNo
            // 
            this.txtCardNo.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtCardNo.Location = new System.Drawing.Point(95, 196);
            this.txtCardNo.Name = "txtCardNo";
            this.txtCardNo.Size = new System.Drawing.Size(206, 23);
            this.txtCardNo.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(237, 158);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 4;
            this.label7.Text = "（必填 *）";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.ForeColor = System.Drawing.Color.Yellow;
            this.label12.Location = new System.Drawing.Point(16, 238);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 19);
            this.label12.TabIndex = 13;
            this.label12.Text = "地 址：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(237, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "（必选 *）";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.Color.Yellow;
            this.label4.Location = new System.Drawing.Point(257, 466);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 19);
            this.label4.TabIndex = 13;
            this.label4.Text = "同案犯：";
            // 
            // txtActionType
            // 
            this.txtActionType.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtActionType.Location = new System.Drawing.Point(338, 464);
            this.txtActionType.Name = "txtActionType";
            this.txtActionType.Size = new System.Drawing.Size(133, 23);
            this.txtActionType.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.ForeColor = System.Drawing.Color.Yellow;
            this.label6.Location = new System.Drawing.Point(15, 514);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 19);
            this.label6.TabIndex = 13;
            this.label6.Text = "现 状：";
            // 
            // txtStatusNow
            // 
            this.txtStatusNow.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtStatusNow.Location = new System.Drawing.Point(96, 512);
            this.txtStatusNow.Name = "txtStatusNow";
            this.txtStatusNow.Size = new System.Drawing.Size(133, 23);
            this.txtStatusNow.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.ForeColor = System.Drawing.Color.Yellow;
            this.label8.Location = new System.Drawing.Point(257, 514);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 19);
            this.label8.TabIndex = 13;
            this.label8.Text = "联系电话：";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtPhoneNumber.Location = new System.Drawing.Point(338, 512);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(133, 23);
            this.txtPhoneNumber.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(48)))));
            this.panel1.Controls.Add(this.lblClose);
            this.panel1.Controls.Add(this.lblInput);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(489, 25);
            this.panel1.TabIndex = 15;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Frm_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Frm_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Frm_MouseUp);
            // 
            // lblClose
            // 
            this.lblClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(44)))), ((int)(((byte)(40)))));
            this.lblClose.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblClose.ForeColor = System.Drawing.Color.White;
            this.lblClose.Location = new System.Drawing.Point(453, 3);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(32, 19);
            this.lblClose.TabIndex = 17;
            this.lblClose.Text = "×";
            this.lblClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            // 
            // lblInput
            // 
            this.lblInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(44)))), ((int)(((byte)(40)))));
            this.lblInput.ForeColor = System.Drawing.Color.White;
            this.lblInput.Image = ((System.Drawing.Image)(resources.GetObject("lblInput.Image")));
            this.lblInput.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblInput.Location = new System.Drawing.Point(3, 2);
            this.lblInput.Name = "lblInput";
            this.lblInput.Size = new System.Drawing.Size(90, 19);
            this.lblInput.TabIndex = 16;
            this.lblInput.Text = " 信息详情";
            this.lblInput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(216, 555);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 28);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "   删 除";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label13.ForeColor = System.Drawing.Color.Yellow;
            this.label13.Location = new System.Drawing.Point(16, 466);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(79, 19);
            this.label13.TabIndex = 13;
            this.label13.Text = "管控记录：";
            // 
            // txtGuanKong
            // 
            this.txtGuanKong.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtGuanKong.Location = new System.Drawing.Point(96, 464);
            this.txtGuanKong.Name = "txtGuanKong";
            this.txtGuanKong.Size = new System.Drawing.Size(133, 23);
            this.txtGuanKong.TabIndex = 9;
            // 
            // txtSType
            // 
            this.txtSType.Location = new System.Drawing.Point(96, 298);
            this.txtSType.Name = "txtSType";
            this.txtSType.Size = new System.Drawing.Size(206, 49);
            this.txtSType.TabIndex = 7;
            this.txtSType.Text = "";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.ForeColor = System.Drawing.Color.Yellow;
            this.label9.Location = new System.Drawing.Point(17, 298);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 19);
            this.label9.TabIndex = 13;
            this.label9.Text = "涉案类型：";
            // 
            // txtAnQing
            // 
            this.txtAnQing.Location = new System.Drawing.Point(96, 367);
            this.txtAnQing.Name = "txtAnQing";
            this.txtAnQing.Size = new System.Drawing.Size(375, 75);
            this.txtAnQing.TabIndex = 8;
            this.txtAnQing.Text = "";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label14.ForeColor = System.Drawing.Color.Yellow;
            this.label14.Location = new System.Drawing.Point(17, 372);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(59, 19);
            this.label14.TabIndex = 13;
            this.label14.Text = "案 情 ：";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label15.ForeColor = System.Drawing.Color.Yellow;
            this.label15.Location = new System.Drawing.Point(15, 87);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(79, 19);
            this.label15.TabIndex = 11;
            this.label15.Text = "列管时间：";
            // 
            // dtpLGTime
            // 
            this.dtpLGTime.CustomFormat = "yyyy-MM-dd";
            this.dtpLGTime.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dtpLGTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpLGTime.Location = new System.Drawing.Point(95, 83);
            this.dtpLGTime.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dtpLGTime.Name = "dtpLGTime";
            this.dtpLGTime.Size = new System.Drawing.Size(139, 26);
            this.dtpLGTime.TabIndex = 1;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.Color.Red;
            this.label16.Location = new System.Drawing.Point(237, 90);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(65, 12);
            this.label16.TabIndex = 4;
            this.label16.Text = "（必选 *）";
            // 
            // FrmAddPersonInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(71)))), ((int)(((byte)(157)))));
            this.ClientSize = new System.Drawing.Size(489, 606);
            this.Controls.Add(this.dtpLGTime);
            this.Controls.Add(this.txtGuanKong);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.txtStatusNow);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtActionType);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.rdoFemale);
            this.Controls.Add(this.rdoMale);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtCardNo);
            this.Controls.Add(this.txtPersonName);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.btnInsertPic);
            this.Controls.Add(this.picFuKuan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAnQing);
            this.Controls.Add(this.txtSType);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtAge);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmAddPersonInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "7";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmFuKuan_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.picFuKuan)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox txtAddress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox picFuKuan;
        private System.Windows.Forms.Button btnInsertPic;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtPersonName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RadioButton rdoMale;
        private System.Windows.Forms.RadioButton rdoFemale;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtCardNo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtActionType;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtStatusNow;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblInput;
        private System.Windows.Forms.Label lblClose;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtGuanKong;
        private System.Windows.Forms.RichTextBox txtSType;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RichTextBox txtAnQing;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DateTimePicker dtpLGTime;
        private System.Windows.Forms.Label label16;
    }
}