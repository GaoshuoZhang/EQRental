namespace EQRental
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnSearch = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.cobReturnTo = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cobHireFrom = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dateTimePickerReturn = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dateTimePickerStart = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cobEquType = new System.Windows.Forms.ComboBox();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.listRentRec = new System.Windows.Forms.ListView();
            this.colRecRentalID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colRecEquID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colRecEquType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colRecStartTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colRecReturnTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colRecHiredFrom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colRecReturnedTo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colRecEmail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TabControler = new System.Windows.Forms.TabControl();
            this.tabRecords = new System.Windows.Forms.TabPage();
            this.tabBooking = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.btnBookSearch = new System.Windows.Forms.Button();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.cobBookBranch = new System.Windows.Forms.ComboBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.txtBookEquType = new System.Windows.Forms.TextBox();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.listBookResult = new System.Windows.Forms.ListView();
            this.colEquID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTypeName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colBranch = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPurchDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btnCartDelete = new System.Windows.Forms.Button();
            this.btnSelectAll = new System.Windows.Forms.Button();
            this.listCart = new System.Windows.Forms.ListView();
            this.colCartID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCartTypeName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCartBranch = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCartHourRate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnBookSubmit = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.groupBox16 = new System.Windows.Forms.GroupBox();
            this.dtpStartTime = new System.Windows.Forms.DateTimePicker();
            this.groupBox15 = new System.Windows.Forms.GroupBox();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.panel4 = new System.Windows.Forms.Panel();
            this.groupBox14 = new System.Windows.Forms.GroupBox();
            this.txtBookLname = new System.Windows.Forms.TextBox();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.txtBookFname = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.txtBookPhone = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.txtBookEmail = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tabReturn = new System.Windows.Forms.TabPage();
            this.splitContainer5 = new System.Windows.Forms.SplitContainer();
            this.panel10 = new System.Windows.Forms.Panel();
            this.listViewReturnResult = new System.Windows.Forms.ListView();
            this.colReturnRentalID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colReturnEquID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colReturnEquType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colReturnFromBranch = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colReturnStartTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colReturnRate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colRentHours = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colReturnCost = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colReturnEmail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colReturnPhone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel9 = new System.Windows.Forms.Panel();
            this.groupBox21 = new System.Windows.Forms.GroupBox();
            this.btnReturnSearch = new System.Windows.Forms.Button();
            this.groupBox20 = new System.Windows.Forms.GroupBox();
            this.txtReturnPhone = new System.Windows.Forms.TextBox();
            this.groupBox19 = new System.Windows.Forms.GroupBox();
            this.txtReturnEmail = new System.Windows.Forms.TextBox();
            this.groupBox18 = new System.Windows.Forms.GroupBox();
            this.txtReturnEquID = new System.Windows.Forms.TextBox();
            this.groupBox17 = new System.Windows.Forms.GroupBox();
            this.txtReturnRentalID = new System.Windows.Forms.TextBox();
            this.panel13 = new System.Windows.Forms.Panel();
            this.panel16 = new System.Windows.Forms.Panel();
            this.btbSubmitReturn = new System.Windows.Forms.Button();
            this.panel12 = new System.Windows.Forms.Panel();
            this.groupBox24 = new System.Windows.Forms.GroupBox();
            this.lbTotalCost = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.groupBox22 = new System.Windows.Forms.GroupBox();
            this.timepickReturn = new System.Windows.Forms.DateTimePicker();
            this.panel15 = new System.Windows.Forms.Panel();
            this.groupBox23 = new System.Windows.Forms.GroupBox();
            this.cobReturnBranch = new System.Windows.Forms.ComboBox();
            this.panel14 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.panel18 = new System.Windows.Forms.Panel();
            this.treeViewSummary = new System.Windows.Forms.TreeView();
            this.panel17 = new System.Windows.Forms.Panel();
            this.panel20 = new System.Windows.Forms.Panel();
            this.btnSummary = new System.Windows.Forms.Button();
            this.Btn_Expend = new System.Windows.Forms.Button();
            this.panel19 = new System.Windows.Forms.Panel();
            this.Btn_SummaryExport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.TabControler.SuspendLayout();
            this.tabRecords.SuspendLayout();
            this.tabBooking.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.groupBox16.SuspendLayout();
            this.groupBox15.SuspendLayout();
            this.panel4.SuspendLayout();
            this.groupBox14.SuspendLayout();
            this.groupBox13.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox12.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabReturn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).BeginInit();
            this.splitContainer5.Panel1.SuspendLayout();
            this.splitContainer5.Panel2.SuspendLayout();
            this.splitContainer5.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel9.SuspendLayout();
            this.groupBox21.SuspendLayout();
            this.groupBox20.SuspendLayout();
            this.groupBox19.SuspendLayout();
            this.groupBox18.SuspendLayout();
            this.groupBox17.SuspendLayout();
            this.panel13.SuspendLayout();
            this.panel16.SuspendLayout();
            this.panel12.SuspendLayout();
            this.groupBox24.SuspendLayout();
            this.panel11.SuspendLayout();
            this.groupBox22.SuspendLayout();
            this.panel15.SuspendLayout();
            this.groupBox23.SuspendLayout();
            this.panel14.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.panel18.SuspendLayout();
            this.panel17.SuspendLayout();
            this.panel20.SuspendLayout();
            this.panel19.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            resources.ApplyResources(this.splitContainer1, "splitContainer1");
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnSearch);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox6);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox5);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox4);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox3);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel1.Controls.Add(this.btnShowAll);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.listRentRec);
            // 
            // btnSearch
            // 
            resources.ApplyResources(this.btnSearch, "btnSearch");
            this.btnSearch.ForeColor = System.Drawing.Color.Chocolate;
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.txtEmail);
            resources.ApplyResources(this.groupBox6, "groupBox6");
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.TabStop = false;
            // 
            // txtEmail
            // 
            resources.ApplyResources(this.txtEmail, "txtEmail");
            this.txtEmail.Name = "txtEmail";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.cobReturnTo);
            resources.ApplyResources(this.groupBox5, "groupBox5");
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.TabStop = false;
            // 
            // cobReturnTo
            // 
            resources.ApplyResources(this.cobReturnTo, "cobReturnTo");
            this.cobReturnTo.FormattingEnabled = true;
            this.cobReturnTo.Items.AddRange(new object[] {
            resources.GetString("cobReturnTo.Items")});
            this.cobReturnTo.Name = "cobReturnTo";
            this.cobReturnTo.Click += new System.EventHandler(this.cobReturnTo_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cobHireFrom);
            resources.ApplyResources(this.groupBox4, "groupBox4");
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.TabStop = false;
            // 
            // cobHireFrom
            // 
            resources.ApplyResources(this.cobHireFrom, "cobHireFrom");
            this.cobHireFrom.FormattingEnabled = true;
            this.cobHireFrom.Items.AddRange(new object[] {
            resources.GetString("cobHireFrom.Items")});
            this.cobHireFrom.Name = "cobHireFrom";
            this.cobHireFrom.Click += new System.EventHandler(this.cobHireFrom_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dateTimePickerReturn);
            resources.ApplyResources(this.groupBox3, "groupBox3");
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.TabStop = false;
            // 
            // dateTimePickerReturn
            // 
            this.dateTimePickerReturn.Checked = false;
            resources.ApplyResources(this.dateTimePickerReturn, "dateTimePickerReturn");
            this.dateTimePickerReturn.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerReturn.MaxDate = new System.DateTime(2030, 12, 31, 0, 0, 0, 0);
            this.dateTimePickerReturn.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerReturn.Name = "dateTimePickerReturn";
            this.dateTimePickerReturn.ShowCheckBox = true;
            this.dateTimePickerReturn.ValueChanged += new System.EventHandler(this.dateTimePickerReturn_ValueChanged);
            this.dateTimePickerReturn.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dateTimePickerReturn_KeyDown);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dateTimePickerStart);
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // dateTimePickerStart
            // 
            this.dateTimePickerStart.Checked = false;
            resources.ApplyResources(this.dateTimePickerStart, "dateTimePickerStart");
            this.dateTimePickerStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerStart.MaxDate = new System.DateTime(2030, 12, 31, 0, 0, 0, 0);
            this.dateTimePickerStart.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerStart.Name = "dateTimePickerStart";
            this.dateTimePickerStart.ShowCheckBox = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cobEquType);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // cobEquType
            // 
            resources.ApplyResources(this.cobEquType, "cobEquType");
            this.cobEquType.FormattingEnabled = true;
            this.cobEquType.Name = "cobEquType";
            this.cobEquType.Click += new System.EventHandler(this.ComboBox1_Click);
            // 
            // btnShowAll
            // 
            resources.ApplyResources(this.btnShowAll, "btnShowAll");
            this.btnShowAll.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.UseVisualStyleBackColor = true;
            this.btnShowAll.Click += new System.EventHandler(this.BtnShowAll_Click);
            // 
            // listRentRec
            // 
            resources.ApplyResources(this.listRentRec, "listRentRec");
            this.listRentRec.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colRecRentalID,
            this.colRecEquID,
            this.colRecEquType,
            this.colRecStartTime,
            this.colRecReturnTime,
            this.colRecHiredFrom,
            this.colRecReturnedTo,
            this.colRecEmail});
            this.listRentRec.FullRowSelect = true;
            this.listRentRec.GridLines = true;
            this.listRentRec.HideSelection = false;
            this.listRentRec.MultiSelect = false;
            this.listRentRec.Name = "listRentRec";
            this.listRentRec.ShowItemToolTips = true;
            this.listRentRec.UseCompatibleStateImageBehavior = false;
            this.listRentRec.View = System.Windows.Forms.View.Details;
            // 
            // colRecRentalID
            // 
            resources.ApplyResources(this.colRecRentalID, "colRecRentalID");
            // 
            // colRecEquID
            // 
            resources.ApplyResources(this.colRecEquID, "colRecEquID");
            // 
            // colRecEquType
            // 
            resources.ApplyResources(this.colRecEquType, "colRecEquType");
            // 
            // colRecStartTime
            // 
            resources.ApplyResources(this.colRecStartTime, "colRecStartTime");
            // 
            // colRecReturnTime
            // 
            resources.ApplyResources(this.colRecReturnTime, "colRecReturnTime");
            // 
            // colRecHiredFrom
            // 
            resources.ApplyResources(this.colRecHiredFrom, "colRecHiredFrom");
            // 
            // colRecReturnedTo
            // 
            resources.ApplyResources(this.colRecReturnedTo, "colRecReturnedTo");
            // 
            // colRecEmail
            // 
            resources.ApplyResources(this.colRecEmail, "colRecEmail");
            // 
            // TabControler
            // 
            this.TabControler.Controls.Add(this.tabRecords);
            this.TabControler.Controls.Add(this.tabBooking);
            this.TabControler.Controls.Add(this.tabReturn);
            this.TabControler.Controls.Add(this.tabPage4);
            resources.ApplyResources(this.TabControler, "TabControler");
            this.TabControler.HotTrack = true;
            this.TabControler.Name = "TabControler";
            this.TabControler.SelectedIndex = 0;
            // 
            // tabRecords
            // 
            this.tabRecords.Controls.Add(this.splitContainer1);
            resources.ApplyResources(this.tabRecords, "tabRecords");
            this.tabRecords.Name = "tabRecords";
            this.tabRecords.UseVisualStyleBackColor = true;
            // 
            // tabBooking
            // 
            this.tabBooking.Controls.Add(this.splitContainer2);
            resources.ApplyResources(this.tabBooking, "tabBooking");
            this.tabBooking.Name = "tabBooking";
            this.tabBooking.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            resources.ApplyResources(this.splitContainer2, "splitContainer2");
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.splitContainer3);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.panel6);
            this.splitContainer2.Panel2.Controls.Add(this.panel5);
            this.splitContainer2.Panel2.Controls.Add(this.panel4);
            this.splitContainer2.Panel2.Controls.Add(this.panel3);
            this.splitContainer2.Panel2.Controls.Add(this.panel2);
            this.splitContainer2.Panel2.Controls.Add(this.panel1);
            // 
            // splitContainer3
            // 
            resources.ApplyResources(this.splitContainer3, "splitContainer3");
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.BackColor = System.Drawing.Color.Transparent;
            this.splitContainer3.Panel1.Controls.Add(this.splitContainer4);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.groupBox11);
            // 
            // splitContainer4
            // 
            this.splitContainer4.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.splitContainer4, "splitContainer4");
            this.splitContainer4.Name = "splitContainer4";
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.BackColor = System.Drawing.Color.Transparent;
            this.splitContainer4.Panel1.Controls.Add(this.btnBookSearch);
            this.splitContainer4.Panel1.Controls.Add(this.groupBox8);
            this.splitContainer4.Panel1.Controls.Add(this.groupBox7);
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.groupBox10);
            // 
            // btnBookSearch
            // 
            resources.ApplyResources(this.btnBookSearch, "btnBookSearch");
            this.btnBookSearch.ForeColor = System.Drawing.Color.Green;
            this.btnBookSearch.Name = "btnBookSearch";
            this.btnBookSearch.UseVisualStyleBackColor = true;
            this.btnBookSearch.Click += new System.EventHandler(this.btnBookSearch_Click);
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.cobBookBranch);
            resources.ApplyResources(this.groupBox8, "groupBox8");
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.TabStop = false;
            this.groupBox8.Enter += new System.EventHandler(this.groupBox8_Enter);
            // 
            // cobBookBranch
            // 
            resources.ApplyResources(this.cobBookBranch, "cobBookBranch");
            this.cobBookBranch.FormattingEnabled = true;
            this.cobBookBranch.Name = "cobBookBranch";
            this.cobBookBranch.Click += new System.EventHandler(this.cobBookBranch_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.txtBookEquType);
            resources.ApplyResources(this.groupBox7, "groupBox7");
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.TabStop = false;
            this.groupBox7.Enter += new System.EventHandler(this.groupBox7_Enter);
            // 
            // txtBookEquType
            // 
            resources.ApplyResources(this.txtBookEquType, "txtBookEquType");
            this.txtBookEquType.Name = "txtBookEquType";
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.listBookResult);
            resources.ApplyResources(this.groupBox10, "groupBox10");
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.TabStop = false;
            // 
            // listBookResult
            // 
            this.listBookResult.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colEquID,
            this.colTypeName,
            this.colBranch,
            this.colPurchDate});
            resources.ApplyResources(this.listBookResult, "listBookResult");
            this.listBookResult.FullRowSelect = true;
            this.listBookResult.GridLines = true;
            this.listBookResult.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listBookResult.HideSelection = false;
            this.listBookResult.MultiSelect = false;
            this.listBookResult.Name = "listBookResult";
            this.listBookResult.ShowGroups = false;
            this.listBookResult.UseCompatibleStateImageBehavior = false;
            this.listBookResult.View = System.Windows.Forms.View.Details;
            this.listBookResult.DoubleClick += new System.EventHandler(this.listBookResult_DoubleClick);
            // 
            // colEquID
            // 
            resources.ApplyResources(this.colEquID, "colEquID");
            // 
            // colTypeName
            // 
            resources.ApplyResources(this.colTypeName, "colTypeName");
            // 
            // colBranch
            // 
            resources.ApplyResources(this.colBranch, "colBranch");
            // 
            // colPurchDate
            // 
            resources.ApplyResources(this.colPurchDate, "colPurchDate");
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.panel7);
            resources.ApplyResources(this.groupBox11, "groupBox11");
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.TabStop = false;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.panel8);
            this.panel7.Controls.Add(this.listCart);
            resources.ApplyResources(this.panel7, "panel7");
            this.panel7.Name = "panel7";
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.btnCartDelete);
            this.panel8.Controls.Add(this.btnSelectAll);
            resources.ApplyResources(this.panel8, "panel8");
            this.panel8.Name = "panel8";
            // 
            // btnCartDelete
            // 
            resources.ApplyResources(this.btnCartDelete, "btnCartDelete");
            this.btnCartDelete.ForeColor = System.Drawing.Color.Red;
            this.btnCartDelete.Name = "btnCartDelete";
            this.btnCartDelete.UseVisualStyleBackColor = true;
            this.btnCartDelete.Click += new System.EventHandler(this.btnCartDelete_Click);
            // 
            // btnSelectAll
            // 
            resources.ApplyResources(this.btnSelectAll, "btnSelectAll");
            this.btnSelectAll.ForeColor = System.Drawing.Color.Orange;
            this.btnSelectAll.Name = "btnSelectAll";
            this.btnSelectAll.UseVisualStyleBackColor = true;
            this.btnSelectAll.Click += new System.EventHandler(this.btnSelectAll_Click);
            // 
            // listCart
            // 
            this.listCart.CheckBoxes = true;
            this.listCart.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colCartID,
            this.colCartTypeName,
            this.colCartBranch,
            this.colCartHourRate});
            resources.ApplyResources(this.listCart, "listCart");
            this.listCart.FullRowSelect = true;
            this.listCart.GridLines = true;
            this.listCart.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listCart.HideSelection = false;
            this.listCart.Name = "listCart";
            this.listCart.ShowGroups = false;
            this.listCart.UseCompatibleStateImageBehavior = false;
            this.listCart.View = System.Windows.Forms.View.Details;
            // 
            // colCartID
            // 
            resources.ApplyResources(this.colCartID, "colCartID");
            // 
            // colCartTypeName
            // 
            resources.ApplyResources(this.colCartTypeName, "colCartTypeName");
            // 
            // colCartBranch
            // 
            resources.ApplyResources(this.colCartBranch, "colCartBranch");
            // 
            // colCartHourRate
            // 
            resources.ApplyResources(this.colCartHourRate, "colCartHourRate");
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btnBookSubmit);
            resources.ApplyResources(this.panel6, "panel6");
            this.panel6.Name = "panel6";
            // 
            // btnBookSubmit
            // 
            this.btnBookSubmit.BackColor = System.Drawing.Color.PapayaWhip;
            resources.ApplyResources(this.btnBookSubmit, "btnBookSubmit");
            this.btnBookSubmit.ForeColor = System.Drawing.Color.Green;
            this.btnBookSubmit.Name = "btnBookSubmit";
            this.btnBookSubmit.UseVisualStyleBackColor = false;
            this.btnBookSubmit.Click += new System.EventHandler(this.btnBookSubmit_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.groupBox16);
            this.panel5.Controls.Add(this.groupBox15);
            resources.ApplyResources(this.panel5, "panel5");
            this.panel5.Name = "panel5";
            // 
            // groupBox16
            // 
            this.groupBox16.Controls.Add(this.dtpStartTime);
            resources.ApplyResources(this.groupBox16, "groupBox16");
            this.groupBox16.Name = "groupBox16";
            this.groupBox16.TabStop = false;
            // 
            // dtpStartTime
            // 
            this.dtpStartTime.Checked = false;
            resources.ApplyResources(this.dtpStartTime, "dtpStartTime");
            this.dtpStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStartTime.MaxDate = new System.DateTime(2029, 12, 31, 0, 0, 0, 0);
            this.dtpStartTime.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dtpStartTime.Name = "dtpStartTime";
            this.dtpStartTime.ShowCheckBox = true;
            this.dtpStartTime.ShowUpDown = true;
            // 
            // groupBox15
            // 
            this.groupBox15.Controls.Add(this.dtpStartDate);
            resources.ApplyResources(this.groupBox15, "groupBox15");
            this.groupBox15.Name = "groupBox15";
            this.groupBox15.TabStop = false;
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Checked = false;
            resources.ApplyResources(this.dtpStartDate, "dtpStartDate");
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStartDate.MaxDate = new System.DateTime(2029, 12, 31, 0, 0, 0, 0);
            this.dtpStartDate.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.ShowCheckBox = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.groupBox14);
            this.panel4.Controls.Add(this.groupBox13);
            resources.ApplyResources(this.panel4, "panel4");
            this.panel4.Name = "panel4";
            // 
            // groupBox14
            // 
            this.groupBox14.Controls.Add(this.txtBookLname);
            resources.ApplyResources(this.groupBox14, "groupBox14");
            this.groupBox14.Name = "groupBox14";
            this.groupBox14.TabStop = false;
            // 
            // txtBookLname
            // 
            resources.ApplyResources(this.txtBookLname, "txtBookLname");
            this.txtBookLname.Name = "txtBookLname";
            // 
            // groupBox13
            // 
            this.groupBox13.Controls.Add(this.txtBookFname);
            resources.ApplyResources(this.groupBox13, "groupBox13");
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.TabStop = false;
            // 
            // txtBookFname
            // 
            resources.ApplyResources(this.txtBookFname, "txtBookFname");
            this.txtBookFname.Name = "txtBookFname";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.groupBox12);
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.Name = "panel3";
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.txtBookPhone);
            resources.ApplyResources(this.groupBox12, "groupBox12");
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.TabStop = false;
            // 
            // txtBookPhone
            // 
            resources.ApplyResources(this.txtBookPhone, "txtBookPhone");
            this.txtBookPhone.Name = "txtBookPhone";
            this.txtBookPhone.TextChanged += new System.EventHandler(this.txtBookPhone_TextChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox9);
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.txtBookEmail);
            resources.ApplyResources(this.groupBox9, "groupBox9");
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.TabStop = false;
            // 
            // txtBookEmail
            // 
            resources.ApplyResources(this.txtBookEmail, "txtBookEmail");
            this.txtBookEmail.Name = "txtBookEmail";
            this.txtBookEmail.TextChanged += new System.EventHandler(this.txtBookEmail_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Name = "label1";
            // 
            // tabReturn
            // 
            this.tabReturn.Controls.Add(this.splitContainer5);
            resources.ApplyResources(this.tabReturn, "tabReturn");
            this.tabReturn.Name = "tabReturn";
            this.tabReturn.UseVisualStyleBackColor = true;
            // 
            // splitContainer5
            // 
            resources.ApplyResources(this.splitContainer5, "splitContainer5");
            this.splitContainer5.Name = "splitContainer5";
            // 
            // splitContainer5.Panel1
            // 
            this.splitContainer5.Panel1.Controls.Add(this.panel10);
            this.splitContainer5.Panel1.Controls.Add(this.panel9);
            // 
            // splitContainer5.Panel2
            // 
            this.splitContainer5.Panel2.Controls.Add(this.panel13);
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.listViewReturnResult);
            resources.ApplyResources(this.panel10, "panel10");
            this.panel10.Name = "panel10";
            // 
            // listViewReturnResult
            // 
            this.listViewReturnResult.CheckBoxes = true;
            this.listViewReturnResult.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colReturnRentalID,
            this.colReturnEquID,
            this.colReturnEquType,
            this.colReturnFromBranch,
            this.colReturnStartTime,
            this.colReturnRate,
            this.colRentHours,
            this.colReturnCost,
            this.colReturnEmail,
            this.colReturnPhone});
            resources.ApplyResources(this.listViewReturnResult, "listViewReturnResult");
            this.listViewReturnResult.FullRowSelect = true;
            this.listViewReturnResult.GridLines = true;
            this.listViewReturnResult.HideSelection = false;
            this.listViewReturnResult.Name = "listViewReturnResult";
            this.listViewReturnResult.UseCompatibleStateImageBehavior = false;
            this.listViewReturnResult.View = System.Windows.Forms.View.Details;
            this.listViewReturnResult.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.listViewReturnResult_ItemChecked);
            // 
            // colReturnRentalID
            // 
            resources.ApplyResources(this.colReturnRentalID, "colReturnRentalID");
            // 
            // colReturnEquID
            // 
            resources.ApplyResources(this.colReturnEquID, "colReturnEquID");
            // 
            // colReturnEquType
            // 
            resources.ApplyResources(this.colReturnEquType, "colReturnEquType");
            // 
            // colReturnFromBranch
            // 
            resources.ApplyResources(this.colReturnFromBranch, "colReturnFromBranch");
            // 
            // colReturnStartTime
            // 
            resources.ApplyResources(this.colReturnStartTime, "colReturnStartTime");
            // 
            // colReturnRate
            // 
            resources.ApplyResources(this.colReturnRate, "colReturnRate");
            // 
            // colRentHours
            // 
            resources.ApplyResources(this.colRentHours, "colRentHours");
            // 
            // colReturnCost
            // 
            resources.ApplyResources(this.colReturnCost, "colReturnCost");
            // 
            // colReturnEmail
            // 
            resources.ApplyResources(this.colReturnEmail, "colReturnEmail");
            // 
            // colReturnPhone
            // 
            resources.ApplyResources(this.colReturnPhone, "colReturnPhone");
            // 
            // panel9
            // 
            this.panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel9.Controls.Add(this.groupBox21);
            this.panel9.Controls.Add(this.groupBox20);
            this.panel9.Controls.Add(this.groupBox19);
            this.panel9.Controls.Add(this.groupBox18);
            this.panel9.Controls.Add(this.groupBox17);
            resources.ApplyResources(this.panel9, "panel9");
            this.panel9.Name = "panel9";
            // 
            // groupBox21
            // 
            this.groupBox21.Controls.Add(this.btnReturnSearch);
            resources.ApplyResources(this.groupBox21, "groupBox21");
            this.groupBox21.Name = "groupBox21";
            this.groupBox21.TabStop = false;
            // 
            // btnReturnSearch
            // 
            resources.ApplyResources(this.btnReturnSearch, "btnReturnSearch");
            this.btnReturnSearch.Name = "btnReturnSearch";
            this.btnReturnSearch.UseVisualStyleBackColor = true;
            this.btnReturnSearch.Click += new System.EventHandler(this.btnReturnSearch_Click);
            // 
            // groupBox20
            // 
            this.groupBox20.Controls.Add(this.txtReturnPhone);
            resources.ApplyResources(this.groupBox20, "groupBox20");
            this.groupBox20.Name = "groupBox20";
            this.groupBox20.TabStop = false;
            // 
            // txtReturnPhone
            // 
            resources.ApplyResources(this.txtReturnPhone, "txtReturnPhone");
            this.txtReturnPhone.Name = "txtReturnPhone";
            // 
            // groupBox19
            // 
            this.groupBox19.Controls.Add(this.txtReturnEmail);
            resources.ApplyResources(this.groupBox19, "groupBox19");
            this.groupBox19.Name = "groupBox19";
            this.groupBox19.TabStop = false;
            // 
            // txtReturnEmail
            // 
            resources.ApplyResources(this.txtReturnEmail, "txtReturnEmail");
            this.txtReturnEmail.Name = "txtReturnEmail";
            // 
            // groupBox18
            // 
            this.groupBox18.Controls.Add(this.txtReturnEquID);
            resources.ApplyResources(this.groupBox18, "groupBox18");
            this.groupBox18.Name = "groupBox18";
            this.groupBox18.TabStop = false;
            // 
            // txtReturnEquID
            // 
            resources.ApplyResources(this.txtReturnEquID, "txtReturnEquID");
            this.txtReturnEquID.Name = "txtReturnEquID";
            this.txtReturnEquID.TextChanged += new System.EventHandler(this.txtReturnEquID_TextChanged);
            // 
            // groupBox17
            // 
            this.groupBox17.Controls.Add(this.txtReturnRentalID);
            resources.ApplyResources(this.groupBox17, "groupBox17");
            this.groupBox17.Name = "groupBox17";
            this.groupBox17.TabStop = false;
            // 
            // txtReturnRentalID
            // 
            resources.ApplyResources(this.txtReturnRentalID, "txtReturnRentalID");
            this.txtReturnRentalID.Name = "txtReturnRentalID";
            this.txtReturnRentalID.TextChanged += new System.EventHandler(this.txtReturnRentalID_TextChanged);
            // 
            // panel13
            // 
            this.panel13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel13.Controls.Add(this.panel16);
            this.panel13.Controls.Add(this.panel12);
            this.panel13.Controls.Add(this.panel11);
            this.panel13.Controls.Add(this.panel15);
            this.panel13.Controls.Add(this.panel14);
            resources.ApplyResources(this.panel13, "panel13");
            this.panel13.Name = "panel13";
            // 
            // panel16
            // 
            this.panel16.Controls.Add(this.btbSubmitReturn);
            resources.ApplyResources(this.panel16, "panel16");
            this.panel16.Name = "panel16";
            // 
            // btbSubmitReturn
            // 
            this.btbSubmitReturn.BackColor = System.Drawing.Color.MistyRose;
            resources.ApplyResources(this.btbSubmitReturn, "btbSubmitReturn");
            this.btbSubmitReturn.ForeColor = System.Drawing.Color.Green;
            this.btbSubmitReturn.Name = "btbSubmitReturn";
            this.btbSubmitReturn.UseVisualStyleBackColor = false;
            this.btbSubmitReturn.Click += new System.EventHandler(this.btbSubmitReturn_Click);
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.groupBox24);
            resources.ApplyResources(this.panel12, "panel12");
            this.panel12.Name = "panel12";
            // 
            // groupBox24
            // 
            this.groupBox24.Controls.Add(this.lbTotalCost);
            resources.ApplyResources(this.groupBox24, "groupBox24");
            this.groupBox24.Name = "groupBox24";
            this.groupBox24.TabStop = false;
            // 
            // lbTotalCost
            // 
            resources.ApplyResources(this.lbTotalCost, "lbTotalCost");
            this.lbTotalCost.ForeColor = System.Drawing.Color.Tomato;
            this.lbTotalCost.Name = "lbTotalCost";
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.groupBox22);
            resources.ApplyResources(this.panel11, "panel11");
            this.panel11.Name = "panel11";
            // 
            // groupBox22
            // 
            this.groupBox22.Controls.Add(this.timepickReturn);
            resources.ApplyResources(this.groupBox22, "groupBox22");
            this.groupBox22.Name = "groupBox22";
            this.groupBox22.TabStop = false;
            // 
            // timepickReturn
            // 
            this.timepickReturn.Checked = false;
            resources.ApplyResources(this.timepickReturn, "timepickReturn");
            this.timepickReturn.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timepickReturn.MaxDate = new System.DateTime(2030, 12, 31, 0, 0, 0, 0);
            this.timepickReturn.MinDate = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.timepickReturn.Name = "timepickReturn";
            this.timepickReturn.ShowCheckBox = true;
            this.timepickReturn.ValueChanged += new System.EventHandler(this.timepickReturn_ValueChanged);
            // 
            // panel15
            // 
            this.panel15.Controls.Add(this.groupBox23);
            resources.ApplyResources(this.panel15, "panel15");
            this.panel15.Name = "panel15";
            // 
            // groupBox23
            // 
            this.groupBox23.Controls.Add(this.cobReturnBranch);
            resources.ApplyResources(this.groupBox23, "groupBox23");
            this.groupBox23.Name = "groupBox23";
            this.groupBox23.TabStop = false;
            // 
            // cobReturnBranch
            // 
            resources.ApplyResources(this.cobReturnBranch, "cobReturnBranch");
            this.cobReturnBranch.FormattingEnabled = true;
            this.cobReturnBranch.Name = "cobReturnBranch";
            this.cobReturnBranch.Click += new System.EventHandler(this.cobReturnBranch_Click);
            // 
            // panel14
            // 
            this.panel14.Controls.Add(this.label3);
            resources.ApplyResources(this.panel14, "panel14");
            this.panel14.Name = "panel14";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Name = "label3";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.panel19);
            this.tabPage4.Controls.Add(this.panel18);
            this.tabPage4.Controls.Add(this.panel17);
            resources.ApplyResources(this.tabPage4, "tabPage4");
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // panel18
            // 
            this.panel18.Controls.Add(this.treeViewSummary);
            resources.ApplyResources(this.panel18, "panel18");
            this.panel18.Name = "panel18";
            // 
            // treeViewSummary
            // 
            resources.ApplyResources(this.treeViewSummary, "treeViewSummary");
            this.treeViewSummary.Name = "treeViewSummary";
            this.treeViewSummary.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            ((System.Windows.Forms.TreeNode)(resources.GetObject("treeViewSummary.Nodes"))),
            ((System.Windows.Forms.TreeNode)(resources.GetObject("treeViewSummary.Nodes1"))),
            ((System.Windows.Forms.TreeNode)(resources.GetObject("treeViewSummary.Nodes2"))),
            ((System.Windows.Forms.TreeNode)(resources.GetObject("treeViewSummary.Nodes3"))),
            ((System.Windows.Forms.TreeNode)(resources.GetObject("treeViewSummary.Nodes4")))});
            this.treeViewSummary.ShowPlusMinus = false;
            this.treeViewSummary.ShowRootLines = false;
            this.treeViewSummary.KeyDown += new System.Windows.Forms.KeyEventHandler(this.treeViewSummary_KeyDown);
            // 
            // panel17
            // 
            this.panel17.Controls.Add(this.panel20);
            resources.ApplyResources(this.panel17, "panel17");
            this.panel17.Name = "panel17";
            // 
            // panel20
            // 
            this.panel20.Controls.Add(this.btnSummary);
            resources.ApplyResources(this.panel20, "panel20");
            this.panel20.Name = "panel20";
            // 
            // btnSummary
            // 
            resources.ApplyResources(this.btnSummary, "btnSummary");
            this.btnSummary.ForeColor = System.Drawing.Color.Orange;
            this.btnSummary.Name = "btnSummary";
            this.btnSummary.UseVisualStyleBackColor = true;
            this.btnSummary.Click += new System.EventHandler(this.btnSummary_Click);
            // 
            // Btn_Expend
            // 
            resources.ApplyResources(this.Btn_Expend, "Btn_Expend");
            this.Btn_Expend.Name = "Btn_Expend";
            this.Btn_Expend.UseVisualStyleBackColor = true;
            this.Btn_Expend.Click += new System.EventHandler(this.Btn_Expend_Click);
            // 
            // panel19
            // 
            this.panel19.Controls.Add(this.Btn_SummaryExport);
            this.panel19.Controls.Add(this.Btn_Expend);
            resources.ApplyResources(this.panel19, "panel19");
            this.panel19.Name = "panel19";
            // 
            // Btn_SummaryExport
            // 
            resources.ApplyResources(this.Btn_SummaryExport, "Btn_SummaryExport");
            this.Btn_SummaryExport.Name = "Btn_SummaryExport";
            this.Btn_SummaryExport.UseVisualStyleBackColor = true;
            this.Btn_SummaryExport.Click += new System.EventHandler(this.Btn_SummaryExport_Click);
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TabControler);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.TabControler.ResumeLayout(false);
            this.tabRecords.ResumeLayout(false);
            this.tabBooking.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.groupBox11.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.groupBox16.ResumeLayout(false);
            this.groupBox15.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.groupBox14.ResumeLayout(false);
            this.groupBox14.PerformLayout();
            this.groupBox13.ResumeLayout(false);
            this.groupBox13.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.groupBox12.ResumeLayout(false);
            this.groupBox12.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.tabReturn.ResumeLayout(false);
            this.splitContainer5.Panel1.ResumeLayout(false);
            this.splitContainer5.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).EndInit();
            this.splitContainer5.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.groupBox21.ResumeLayout(false);
            this.groupBox20.ResumeLayout(false);
            this.groupBox20.PerformLayout();
            this.groupBox19.ResumeLayout(false);
            this.groupBox19.PerformLayout();
            this.groupBox18.ResumeLayout(false);
            this.groupBox18.PerformLayout();
            this.groupBox17.ResumeLayout(false);
            this.groupBox17.PerformLayout();
            this.panel13.ResumeLayout(false);
            this.panel16.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            this.groupBox24.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.groupBox22.ResumeLayout(false);
            this.panel15.ResumeLayout(false);
            this.groupBox23.ResumeLayout(false);
            this.panel14.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.panel18.ResumeLayout(false);
            this.panel17.ResumeLayout(false);
            this.panel20.ResumeLayout(false);
            this.panel19.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabControler;
        private System.Windows.Forms.TabPage tabRecords;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ComboBox cobEquType;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.TabPage tabBooking;
        private System.Windows.Forms.TabPage tabReturn;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DateTimePicker dateTimePickerStart;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.ComboBox cobHireFrom;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DateTimePicker dateTimePickerReturn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ComboBox cobReturnTo;
        private System.Windows.Forms.ListView listRentRec;
        private System.Windows.Forms.ColumnHeader colRecEquType;
        private System.Windows.Forms.ColumnHeader colRecStartTime;
        private System.Windows.Forms.ColumnHeader colRecReturnTime;
        private System.Windows.Forms.ColumnHeader colRecHiredFrom;
        private System.Windows.Forms.ColumnHeader colRecReturnedTo;
        private System.Windows.Forms.ColumnHeader colRecEmail;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Button btnBookSearch;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TextBox txtBookEquType;
        private System.Windows.Forms.TextBox txtBookEmail;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.ComboBox cobBookBranch;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.TextBox txtBookPhone;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.GroupBox groupBox14;
        private System.Windows.Forms.TextBox txtBookLname;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.GroupBox groupBox13;
        private System.Windows.Forms.TextBox txtBookFname;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnBookSubmit;
        private System.Windows.Forms.ListView listBookResult;
        private System.Windows.Forms.ColumnHeader colEquID;
        private System.Windows.Forms.ColumnHeader colTypeName;
        private System.Windows.Forms.ColumnHeader colBranch;
        private System.Windows.Forms.ColumnHeader colPurchDate;
        private System.Windows.Forms.ListView listCart;
        private System.Windows.Forms.ColumnHeader colCartID;
        private System.Windows.Forms.ColumnHeader colCartTypeName;
        private System.Windows.Forms.ColumnHeader colCartBranch;
        private System.Windows.Forms.ColumnHeader colCartHourRate;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.GroupBox groupBox15;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.GroupBox groupBox16;
        private System.Windows.Forms.DateTimePicker dtpStartTime;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button btnSelectAll;
        private System.Windows.Forms.Button btnCartDelete;
        private System.Windows.Forms.ColumnHeader colRecRentalID;
        private System.Windows.Forms.ColumnHeader colRecEquID;
        private System.Windows.Forms.SplitContainer splitContainer5;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.GroupBox groupBox18;
        private System.Windows.Forms.TextBox txtReturnEquID;
        private System.Windows.Forms.GroupBox groupBox17;
        private System.Windows.Forms.TextBox txtReturnEmail;
        private System.Windows.Forms.GroupBox groupBox19;
        private System.Windows.Forms.Button btnReturnSearch;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.ListView listViewReturnResult;
        private System.Windows.Forms.ColumnHeader colReturnRentalID;
        private System.Windows.Forms.ColumnHeader colReturnEquID;
        private System.Windows.Forms.ColumnHeader colReturnEquType;
        private System.Windows.Forms.ColumnHeader colReturnFromBranch;
        private System.Windows.Forms.ColumnHeader colReturnStartTime;
        private System.Windows.Forms.ColumnHeader colReturnRate;
        private System.Windows.Forms.TextBox txtReturnRentalID;
        private System.Windows.Forms.GroupBox groupBox21;
        private System.Windows.Forms.GroupBox groupBox20;
        private System.Windows.Forms.TextBox txtReturnPhone;
        private System.Windows.Forms.ColumnHeader colReturnCost;
        private System.Windows.Forms.ComboBox cobReturnBranch;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.GroupBox groupBox22;
        private System.Windows.Forms.DateTimePicker timepickReturn;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.GroupBox groupBox23;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.GroupBox groupBox24;
        private System.Windows.Forms.Label lbTotalCost;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.Button btbSubmitReturn;
        private System.Windows.Forms.ColumnHeader colReturnEmail;
        private System.Windows.Forms.ColumnHeader colReturnPhone;
        private System.Windows.Forms.ColumnHeader colRentHours;
        private System.Windows.Forms.Panel panel18;
        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.Panel panel20;
        private System.Windows.Forms.Button btnSummary;
        private System.Windows.Forms.TreeView treeViewSummary;
        private System.Windows.Forms.Panel panel19;
        private System.Windows.Forms.Button Btn_SummaryExport;
        private System.Windows.Forms.Button Btn_Expend;
    }
}

