namespace PoliceInfo
{
    partial class FrmMain
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblClose = new System.Windows.Forms.Label();
            this.dgvPersons = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PicImage = new System.Windows.Forms.DataGridViewImageColumn();
            this.PersonName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LGTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CardNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AnQing = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GuanKong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ActionType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusNow = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tlsLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditUserName = new System.Windows.Forms.ToolStripMenuItem();
            this.AddLogin = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDeleteUserName = new System.Windows.Forms.ToolStripMenuItem();
            this.EditPassword = new System.Windows.Forms.ToolStripMenuItem();
            this.btnReplaceUserName = new System.Windows.Forms.ToolStripMenuItem();
            this.数据管理GToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddPersonInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.InputPerson = new System.Windows.Forms.ToolStripMenuItem();
            this.OutPutPerson = new System.Windows.Forms.ToolStripMenuItem();
            this.关于HToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddPhoneList = new System.Windows.Forms.ToolStripMenuItem();
            this.PhoneManage = new System.Windows.Forms.ToolStripMenuItem();
            this.Help = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSelect = new System.Windows.Forms.Button();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSerch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersons)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblClose
            // 
            this.lblClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(44)))), ((int)(((byte)(40)))));
            this.lblClose.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblClose.ForeColor = System.Drawing.Color.White;
            this.lblClose.Location = new System.Drawing.Point(961, 3);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(32, 19);
            this.lblClose.TabIndex = 2;
            this.lblClose.Text = "×";
            this.lblClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            // 
            // dgvPersons
            // 
            this.dgvPersons.AllowUserToAddRows = false;
            this.dgvPersons.AllowUserToDeleteRows = false;
            this.dgvPersons.BackgroundColor = System.Drawing.Color.White;
            this.dgvPersons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersons.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.PicImage,
            this.PersonName,
            this.LGTime,
            this.Gender,
            this.Age,
            this.CardNO,
            this.Address,
            this.SType,
            this.AnQing,
            this.GuanKong,
            this.ActionType,
            this.StatusNow,
            this.PhoneNumber});
            this.dgvPersons.Location = new System.Drawing.Point(0, 141);
            this.dgvPersons.Name = "dgvPersons";
            this.dgvPersons.ReadOnly = true;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(193)))), ((int)(((byte)(1)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPersons.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvPersons.RowHeadersVisible = false;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvPersons.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvPersons.RowTemplate.Height = 23;
            this.dgvPersons.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPersons.Size = new System.Drawing.Size(996, 492);
            this.dgvPersons.TabIndex = 3;
            this.dgvPersons.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPersons_CellDoubleClick);
            this.dgvPersons.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvPersons_CellFormatting);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Id.DefaultCellStyle = dataGridViewCellStyle1;
            this.Id.Frozen = true;
            this.Id.HeaderText = "序号";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 60;
            // 
            // PicImage
            // 
            this.PicImage.DataPropertyName = "PicImage";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(190)))), ((int)(((byte)(1)))));
            dataGridViewCellStyle2.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle2.NullValue")));
            this.PicImage.DefaultCellStyle = dataGridViewCellStyle2;
            this.PicImage.HeaderText = "照片";
            this.PicImage.Name = "PicImage";
            this.PicImage.ReadOnly = true;
            this.PicImage.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.PicImage.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // PersonName
            // 
            this.PersonName.DataPropertyName = "PersonName";
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(190)))), ((int)(((byte)(1)))));
            this.PersonName.DefaultCellStyle = dataGridViewCellStyle3;
            this.PersonName.HeaderText = "姓名";
            this.PersonName.Name = "PersonName";
            this.PersonName.ReadOnly = true;
            // 
            // LGTime
            // 
            this.LGTime.DataPropertyName = "LGTime";
            this.LGTime.HeaderText = "列管时间";
            this.LGTime.Name = "LGTime";
            this.LGTime.ReadOnly = true;
            // 
            // Gender
            // 
            this.Gender.DataPropertyName = "Gender";
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(190)))), ((int)(((byte)(1)))));
            this.Gender.DefaultCellStyle = dataGridViewCellStyle4;
            this.Gender.HeaderText = "性别";
            this.Gender.Name = "Gender";
            this.Gender.ReadOnly = true;
            this.Gender.Width = 40;
            // 
            // Age
            // 
            this.Age.DataPropertyName = "Age";
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(190)))), ((int)(((byte)(1)))));
            this.Age.DefaultCellStyle = dataGridViewCellStyle5;
            this.Age.HeaderText = "年龄";
            this.Age.Name = "Age";
            this.Age.ReadOnly = true;
            this.Age.Width = 40;
            // 
            // CardNO
            // 
            this.CardNO.DataPropertyName = "CardNO";
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(190)))), ((int)(((byte)(1)))));
            this.CardNO.DefaultCellStyle = dataGridViewCellStyle6;
            this.CardNO.HeaderText = "身份证号";
            this.CardNO.Name = "CardNO";
            this.CardNO.ReadOnly = true;
            this.CardNO.Width = 180;
            // 
            // Address
            // 
            this.Address.DataPropertyName = "Address";
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(190)))), ((int)(((byte)(1)))));
            this.Address.DefaultCellStyle = dataGridViewCellStyle7;
            this.Address.HeaderText = "住址";
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            this.Address.Width = 230;
            // 
            // SType
            // 
            this.SType.DataPropertyName = "SType";
            this.SType.HeaderText = "涉案类型";
            this.SType.Name = "SType";
            this.SType.ReadOnly = true;
            // 
            // AnQing
            // 
            this.AnQing.DataPropertyName = "AnQing";
            this.AnQing.HeaderText = "案情";
            this.AnQing.Name = "AnQing";
            this.AnQing.ReadOnly = true;
            this.AnQing.Width = 180;
            // 
            // GuanKong
            // 
            this.GuanKong.DataPropertyName = "GuanKong";
            this.GuanKong.HeaderText = "管控记录";
            this.GuanKong.Name = "GuanKong";
            this.GuanKong.ReadOnly = true;
            // 
            // ActionType
            // 
            this.ActionType.DataPropertyName = "ActionType";
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(190)))), ((int)(((byte)(1)))));
            this.ActionType.DefaultCellStyle = dataGridViewCellStyle8;
            this.ActionType.HeaderText = "同案犯";
            this.ActionType.Name = "ActionType";
            this.ActionType.ReadOnly = true;
            this.ActionType.Width = 80;
            // 
            // StatusNow
            // 
            this.StatusNow.DataPropertyName = "StatusNow";
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(190)))), ((int)(((byte)(1)))));
            this.StatusNow.DefaultCellStyle = dataGridViewCellStyle9;
            this.StatusNow.HeaderText = "现状";
            this.StatusNow.Name = "StatusNow";
            this.StatusNow.ReadOnly = true;
            this.StatusNow.Width = 80;
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.DataPropertyName = "PhoneNumber";
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(190)))), ((int)(((byte)(1)))));
            this.PhoneNumber.DefaultCellStyle = dataGridViewCellStyle10;
            this.PhoneNumber.HeaderText = "联系电话";
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.ReadOnly = true;
            this.PhoneNumber.Width = 120;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlsLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 636);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(996, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tlsLabel
            // 
            this.tlsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tlsLabel.Name = "tlsLabel";
            this.tlsLabel.Size = new System.Drawing.Size(18, 17);
            this.tlsLabel.Text = "  ";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(44)))), ((int)(((byte)(40)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem,
            this.数据管理GToolStripMenuItem,
            this.关于HToolStripMenuItem,
            this.Help});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(996, 25);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            this.menuStrip1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Frm_MouseDown);
            this.menuStrip1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Frm_MouseMove);
            this.menuStrip1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Frm_MouseUp);
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EditUserName,
            this.AddLogin,
            this.btnDeleteUserName,
            this.EditPassword,
            this.btnReplaceUserName});
            this.文件ToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(58, 21);
            this.文件ToolStripMenuItem.Text = "系统(&F)";
            // 
            // EditUserName
            // 
            this.EditUserName.Name = "EditUserName";
            this.EditUserName.Size = new System.Drawing.Size(151, 22);
            this.EditUserName.Text = "修改用户名(&E)";
            this.EditUserName.Click += new System.EventHandler(this.EditUserName_Click);
            // 
            // AddLogin
            // 
            this.AddLogin.Name = "AddLogin";
            this.AddLogin.Size = new System.Drawing.Size(151, 22);
            this.AddLogin.Text = "注册账号(&Z)";
            this.AddLogin.Click += new System.EventHandler(this.AddLogin_Click);
            // 
            // btnDeleteUserName
            // 
            this.btnDeleteUserName.Name = "btnDeleteUserName";
            this.btnDeleteUserName.Size = new System.Drawing.Size(151, 22);
            this.btnDeleteUserName.Text = "删除账号(&D)";
            this.btnDeleteUserName.Click += new System.EventHandler(this.btnDeleteUserName_Click);
            // 
            // EditPassword
            // 
            this.EditPassword.Name = "EditPassword";
            this.EditPassword.Size = new System.Drawing.Size(151, 22);
            this.EditPassword.Text = "修改密码(&P)";
            this.EditPassword.Click += new System.EventHandler(this.EditPassword_Click);
            // 
            // btnReplaceUserName
            // 
            this.btnReplaceUserName.Name = "btnReplaceUserName";
            this.btnReplaceUserName.Size = new System.Drawing.Size(151, 22);
            this.btnReplaceUserName.Text = "切换账号(&X)";
            this.btnReplaceUserName.Click += new System.EventHandler(this.btnReplaceUserName_Click);
            // 
            // 数据管理GToolStripMenuItem
            // 
            this.数据管理GToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddPersonInfo,
            this.InputPerson,
            this.OutPutPerson});
            this.数据管理GToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.数据管理GToolStripMenuItem.Name = "数据管理GToolStripMenuItem";
            this.数据管理GToolStripMenuItem.Size = new System.Drawing.Size(109, 21);
            this.数据管理GToolStripMenuItem.Text = "违法人员管理(&G)";
            // 
            // AddPersonInfo
            // 
            this.AddPersonInfo.Name = "AddPersonInfo";
            this.AddPersonInfo.Size = new System.Drawing.Size(166, 22);
            this.AddPersonInfo.Text = "添加数据(&A)";
            this.AddPersonInfo.Click += new System.EventHandler(this.lblInput_Click);
            // 
            // InputPerson
            // 
            this.InputPerson.Name = "InputPerson";
            this.InputPerson.Size = new System.Drawing.Size(166, 22);
            this.InputPerson.Text = "批量导入数据(&I)";
            this.InputPerson.Click += new System.EventHandler(this.InputPerson_Click);
            // 
            // OutPutPerson
            // 
            this.OutPutPerson.Name = "OutPutPerson";
            this.OutPutPerson.Size = new System.Drawing.Size(166, 22);
            this.OutPutPerson.Text = "批量导出数据(&O)";
            this.OutPutPerson.Click += new System.EventHandler(this.OutPutPerson_Click);
            // 
            // 关于HToolStripMenuItem
            // 
            this.关于HToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddPhoneList,
            this.PhoneManage});
            this.关于HToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.关于HToolStripMenuItem.Name = "关于HToolStripMenuItem";
            this.关于HToolStripMenuItem.Size = new System.Drawing.Size(108, 21);
            this.关于HToolStripMenuItem.Text = "电话记录管理(&K)";
            // 
            // AddPhoneList
            // 
            this.AddPhoneList.Name = "AddPhoneList";
            this.AddPhoneList.Size = new System.Drawing.Size(163, 22);
            this.AddPhoneList.Text = "批量导入记录(&L)";
            this.AddPhoneList.Click += new System.EventHandler(this.AddPhoneList_Click);
            // 
            // PhoneManage
            // 
            this.PhoneManage.Name = "PhoneManage";
            this.PhoneManage.Size = new System.Drawing.Size(163, 22);
            this.PhoneManage.Text = "通话记录查询(&S)";
            this.PhoneManage.Click += new System.EventHandler(this.PhoneManage_Click);
            // 
            // Help
            // 
            this.Help.ForeColor = System.Drawing.Color.White;
            this.Help.Name = "Help";
            this.Help.Size = new System.Drawing.Size(61, 21);
            this.Help.Text = "关于(&H)";
            this.Help.Click += new System.EventHandler(this.Help_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.btnSelect);
            this.panel1.Controls.Add(this.dtpEnd);
            this.panel1.Controls.Add(this.dtpStart);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtSerch);
            this.panel1.Location = new System.Drawing.Point(0, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(996, 120);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Frm_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Frm_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Frm_MouseUp);
            // 
            // btnSelect
            // 
            this.btnSelect.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSelect.Location = new System.Drawing.Point(842, 76);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(64, 24);
            this.btnSelect.TabIndex = 3;
            this.btnSelect.Text = "查询";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // dtpEnd
            // 
            this.dtpEnd.CustomFormat = "yyyy-MM-dd";
            this.dtpEnd.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEnd.Location = new System.Drawing.Point(729, 77);
            this.dtpEnd.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(106, 23);
            this.dtpEnd.TabIndex = 2;
            // 
            // dtpStart
            // 
            this.dtpStart.CustomFormat = "yyyy-MM-dd";
            this.dtpStart.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStart.Location = new System.Drawing.Point(588, 77);
            this.dtpStart.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(106, 23);
            this.dtpStart.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(68)))), ((int)(((byte)(146)))));
            this.label3.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(700, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "至";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(68)))), ((int)(((byte)(146)))));
            this.label2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(458, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "按列管时间段查询：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(68)))), ((int)(((byte)(146)))));
            this.label1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(206, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "结合查询：";
            // 
            // txtSerch
            // 
            this.txtSerch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(255)))), ((int)(((byte)(254)))));
            this.txtSerch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSerch.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtSerch.Location = new System.Drawing.Point(291, 77);
            this.txtSerch.Name = "txtSerch";
            this.txtSerch.Size = new System.Drawing.Size(133, 22);
            this.txtSerch.TabIndex = 0;
            this.txtSerch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSerch_KeyPress);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(996, 658);
            this.Controls.Add(this.lblClose);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dgvPersons);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "违法犯罪查询系统";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersons)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblClose;
        private System.Windows.Forms.TextBox txtSerch;
        private System.Windows.Forms.DataGridView dgvPersons;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tlsLabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EditUserName;
        private System.Windows.Forms.ToolStripMenuItem EditPassword;
        private System.Windows.Forms.ToolStripMenuItem 数据管理GToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddPersonInfo;
        private System.Windows.Forms.ToolStripMenuItem InputPerson;
        private System.Windows.Forms.ToolStripMenuItem 关于HToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddPhoneList;
        private System.Windows.Forms.ToolStripMenuItem PhoneManage;
        private System.Windows.Forms.ToolStripMenuItem Help;
        private System.Windows.Forms.ToolStripMenuItem OutPutPerson;
        private System.Windows.Forms.ToolStripMenuItem AddLogin;
        private System.Windows.Forms.ToolStripMenuItem btnDeleteUserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewImageColumn PicImage;
        private System.Windows.Forms.DataGridViewTextBoxColumn PersonName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LGTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn Age;
        private System.Windows.Forms.DataGridViewTextBoxColumn CardNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn SType;
        private System.Windows.Forms.DataGridViewTextBoxColumn AnQing;
        private System.Windows.Forms.DataGridViewTextBoxColumn GuanKong;
        private System.Windows.Forms.DataGridViewTextBoxColumn ActionType;
        private System.Windows.Forms.DataGridViewTextBoxColumn StatusNow;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneNumber;
        private System.Windows.Forms.ToolStripMenuItem btnReplaceUserName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.Label label3;
    }
}