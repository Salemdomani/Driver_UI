namespace DriverUI
{
    partial class DashBoard
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
            this.components = new System.ComponentModel.Container();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.Worker = new System.ComponentModel.BackgroundWorker();
            this.AddVmsBtn = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.StopVMBtn = new DevExpress.XtraEditors.SimpleButton();
            this.StartVMBtn = new DevExpress.XtraEditors.SimpleButton();
            this.IP_Box = new System.Windows.Forms.TextBox();
            this.VMS_Name_Box = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.Profile_Box = new System.Windows.Forms.TextBox();
            this.Password_Box = new System.Windows.Forms.TextBox();
            this.Username_Box = new System.Windows.Forms.TextBox();
            this.AddAccBtn = new DevExpress.XtraEditors.SimpleButton();
            this.Account_Name = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Action_Box = new DevExpress.XtraEditors.ComboBoxEdit();
            this.Post_Id_Box = new System.Windows.Forms.TextBox();
            this.Text_Box = new System.Windows.Forms.TextBox();
            this.VMS_Number_Box = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.AddJobBtn = new DevExpress.XtraEditors.SimpleButton();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.VMSGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.JobGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpost_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colaction = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltext = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TodosGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVMS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colstate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xtraTabPage3 = new DevExpress.XtraTab.XtraTabPage();
            this.AccountGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPassword = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProfile = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStatus1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUsername = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVMS1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xtraTabPage4 = new DevExpress.XtraTab.XtraTabPage();
            this.logListBox = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit.Properties)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Action_Box.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VMSGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.JobGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TodosGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.xtraTabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AccountGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            this.xtraTabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 30000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Worker
            // 
            this.Worker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.Worker_DoWork);
            // 
            // AddVmsBtn
            // 
            this.AddVmsBtn.Location = new System.Drawing.Point(265, 87);
            this.AddVmsBtn.Margin = new System.Windows.Forms.Padding(4);
            this.AddVmsBtn.Name = "AddVmsBtn";
            this.AddVmsBtn.Size = new System.Drawing.Size(100, 28);
            this.AddVmsBtn.TabIndex = 2;
            this.AddVmsBtn.Text = "add VMS";
            this.AddVmsBtn.Click += new System.EventHandler(this.AddVmsBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.StopVMBtn);
            this.groupBox1.Controls.Add(this.StartVMBtn);
            this.groupBox1.Controls.Add(this.IP_Box);
            this.groupBox1.Controls.Add(this.VMS_Name_Box);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.AddVmsBtn);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(385, 123);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ADD_VM";
            // 
            // StopVMBtn
            // 
            this.StopVMBtn.Location = new System.Drawing.Point(164, 86);
            this.StopVMBtn.Name = "StopVMBtn";
            this.StopVMBtn.Size = new System.Drawing.Size(94, 29);
            this.StopVMBtn.TabIndex = 11;
            this.StopVMBtn.Text = "Stop";
            this.StopVMBtn.Click += new System.EventHandler(this.StopVMBtn_Click);
            // 
            // StartVMBtn
            // 
            this.StartVMBtn.Location = new System.Drawing.Point(64, 86);
            this.StartVMBtn.Name = "StartVMBtn";
            this.StartVMBtn.Size = new System.Drawing.Size(94, 29);
            this.StartVMBtn.TabIndex = 11;
            this.StartVMBtn.Text = "Start";
            this.StartVMBtn.Click += new System.EventHandler(this.StartVMBtn_Click);
            // 
            // IP_Box
            // 
            this.IP_Box.Location = new System.Drawing.Point(97, 57);
            this.IP_Box.Margin = new System.Windows.Forms.Padding(4);
            this.IP_Box.Name = "IP_Box";
            this.IP_Box.Size = new System.Drawing.Size(267, 22);
            this.IP_Box.TabIndex = 1;
            this.IP_Box.Enter += new System.EventHandler(this.IP_Box_Enter);
            // 
            // VMS_Name_Box
            // 
            this.VMS_Name_Box.Location = new System.Drawing.Point(97, 26);
            this.VMS_Name_Box.Margin = new System.Windows.Forms.Padding(4);
            this.VMS_Name_Box.Name = "VMS_Name_Box";
            this.VMS_Name_Box.Size = new System.Drawing.Size(267, 22);
            this.VMS_Name_Box.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 60);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "IP";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "VMS_Num";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lookUpEdit);
            this.groupBox2.Controls.Add(this.Profile_Box);
            this.groupBox2.Controls.Add(this.Password_Box);
            this.groupBox2.Controls.Add(this.Username_Box);
            this.groupBox2.Controls.Add(this.AddAccBtn);
            this.groupBox2.Controls.Add(this.Account_Name);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(13, 144);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(385, 219);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Accounts";
            // 
            // lookUpEdit
            // 
            this.lookUpEdit.Location = new System.Drawing.Point(97, 151);
            this.lookUpEdit.Margin = new System.Windows.Forms.Padding(4);
            this.lookUpEdit.Name = "lookUpEdit";
            this.lookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEdit.Properties.DataSource = typeof(DriverUI.Vm);
            this.lookUpEdit.Properties.DisplayMember = "Id";
            this.lookUpEdit.Properties.NullText = "";
            this.lookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lookUpEdit.Size = new System.Drawing.Size(267, 22);
            this.lookUpEdit.TabIndex = 7;
            // 
            // Profile_Box
            // 
            this.Profile_Box.Location = new System.Drawing.Point(97, 121);
            this.Profile_Box.Margin = new System.Windows.Forms.Padding(4);
            this.Profile_Box.Name = "Profile_Box";
            this.Profile_Box.Size = new System.Drawing.Size(267, 22);
            this.Profile_Box.TabIndex = 6;
            // 
            // Password_Box
            // 
            this.Password_Box.Location = new System.Drawing.Point(97, 89);
            this.Password_Box.Margin = new System.Windows.Forms.Padding(4);
            this.Password_Box.Name = "Password_Box";
            this.Password_Box.Size = new System.Drawing.Size(267, 22);
            this.Password_Box.TabIndex = 5;
            // 
            // Username_Box
            // 
            this.Username_Box.Location = new System.Drawing.Point(97, 57);
            this.Username_Box.Margin = new System.Windows.Forms.Padding(4);
            this.Username_Box.Name = "Username_Box";
            this.Username_Box.Size = new System.Drawing.Size(267, 22);
            this.Username_Box.TabIndex = 4;
            // 
            // AddAccBtn
            // 
            this.AddAccBtn.Location = new System.Drawing.Point(265, 181);
            this.AddAccBtn.Margin = new System.Windows.Forms.Padding(4);
            this.AddAccBtn.Name = "AddAccBtn";
            this.AddAccBtn.Size = new System.Drawing.Size(100, 28);
            this.AddAccBtn.TabIndex = 8;
            this.AddAccBtn.Text = "add Acc";
            this.AddAccBtn.Click += new System.EventHandler(this.AddAccBtn_Click);
            // 
            // Account_Name
            // 
            this.Account_Name.Location = new System.Drawing.Point(97, 26);
            this.Account_Name.Margin = new System.Windows.Forms.Padding(4);
            this.Account_Name.Name = "Account_Name";
            this.Account_Name.Size = new System.Drawing.Size(267, 22);
            this.Account_Name.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(52, 154);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "VMS";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 124);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Profile";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 92);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 60);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 29);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Acc_Name";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Action_Box);
            this.groupBox3.Controls.Add(this.Post_Id_Box);
            this.groupBox3.Controls.Add(this.Text_Box);
            this.groupBox3.Controls.Add(this.VMS_Number_Box);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.AddJobBtn);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Location = new System.Drawing.Point(13, 371);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(385, 202);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Add_Job";
            // 
            // Action_Box
            // 
            this.Action_Box.Location = new System.Drawing.Point(96, 95);
            this.Action_Box.Name = "Action_Box";
            this.Action_Box.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.Action_Box.Properties.Items.AddRange(new object[] {
            "like",
            "comment",
            "share",
            "ShrToGroub"});
            this.Action_Box.Size = new System.Drawing.Size(268, 22);
            this.Action_Box.TabIndex = 17;
            // 
            // Post_Id_Box
            // 
            this.Post_Id_Box.Location = new System.Drawing.Point(97, 61);
            this.Post_Id_Box.Margin = new System.Windows.Forms.Padding(4);
            this.Post_Id_Box.Name = "Post_Id_Box";
            this.Post_Id_Box.Size = new System.Drawing.Size(267, 22);
            this.Post_Id_Box.TabIndex = 10;
            // 
            // Text_Box
            // 
            this.Text_Box.Location = new System.Drawing.Point(97, 128);
            this.Text_Box.Margin = new System.Windows.Forms.Padding(4);
            this.Text_Box.Name = "Text_Box";
            this.Text_Box.Size = new System.Drawing.Size(267, 22);
            this.Text_Box.TabIndex = 12;
            // 
            // VMS_Number_Box
            // 
            this.VMS_Number_Box.Location = new System.Drawing.Point(97, 26);
            this.VMS_Number_Box.Margin = new System.Windows.Forms.Padding(4);
            this.VMS_Number_Box.Name = "VMS_Number_Box";
            this.VMS_Number_Box.Size = new System.Drawing.Size(267, 22);
            this.VMS_Number_Box.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(34, 64);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 17);
            this.label9.TabIndex = 10;
            this.label9.Text = "Post_Id";
            // 
            // AddJobBtn
            // 
            this.AddJobBtn.Location = new System.Drawing.Point(265, 166);
            this.AddJobBtn.Margin = new System.Windows.Forms.Padding(4);
            this.AddJobBtn.Name = "AddJobBtn";
            this.AddJobBtn.Size = new System.Drawing.Size(100, 28);
            this.AddJobBtn.TabIndex = 13;
            this.AddJobBtn.Text = "add Job";
            this.AddJobBtn.Click += new System.EventHandler(this.AddJobBtn_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(54, 131);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 17);
            this.label11.TabIndex = 10;
            this.label11.Text = "Text";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(42, 98);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 17);
            this.label10.TabIndex = 10;
            this.label10.Text = "Action";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(52, 29);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 17);
            this.label8.TabIndex = 10;
            this.label8.Text = "VMS";
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Right;
            this.xtraTabControl1.Location = new System.Drawing.Point(405, 0);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(692, 586);
            this.xtraTabControl1.TabIndex = 11;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2,
            this.xtraTabPage3,
            this.xtraTabPage4});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.VMSGridControl);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(690, 556);
            this.xtraTabPage1.Text = "VMS";
            // 
            // VMSGridControl
            // 
            this.VMSGridControl.DataSource = typeof(DriverUI.Vm);
            this.VMSGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.VMSGridControl.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.VMSGridControl.Location = new System.Drawing.Point(0, 0);
            this.VMSGridControl.MainView = this.gridView1;
            this.VMSGridControl.Margin = new System.Windows.Forms.Padding(4);
            this.VMSGridControl.Name = "VMSGridControl";
            this.VMSGridControl.Size = new System.Drawing.Size(690, 556);
            this.VMSGridControl.TabIndex = 16;
            this.VMSGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colIP,
            this.colStatus});
            this.gridView1.DetailHeight = 431;
            this.gridView1.GridControl = this.VMSGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridView_CellValueChanged);
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.MinWidth = 25;
            this.colId.Name = "colId";
            this.colId.Visible = true;
            this.colId.VisibleIndex = 0;
            this.colId.Width = 94;
            // 
            // colIP
            // 
            this.colIP.FieldName = "IP";
            this.colIP.MinWidth = 25;
            this.colIP.Name = "colIP";
            this.colIP.Visible = true;
            this.colIP.VisibleIndex = 1;
            this.colIP.Width = 94;
            // 
            // colStatus
            // 
            this.colStatus.FieldName = "Status";
            this.colStatus.MinWidth = 25;
            this.colStatus.Name = "colStatus";
            this.colStatus.Visible = true;
            this.colStatus.VisibleIndex = 2;
            this.colStatus.Width = 94;
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.JobGridControl);
            this.xtraTabPage2.Controls.Add(this.TodosGridControl);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(690, 556);
            this.xtraTabPage2.Text = "Todos_Jobs";
            // 
            // JobGridControl
            // 
            this.JobGridControl.DataSource = typeof(DriverUI.JOB);
            this.JobGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.JobGridControl.Location = new System.Drawing.Point(343, 0);
            this.JobGridControl.MainView = this.gridView3;
            this.JobGridControl.Name = "JobGridControl";
            this.JobGridControl.Size = new System.Drawing.Size(347, 556);
            this.JobGridControl.TabIndex = 0;
            this.JobGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView3});
            this.JobGridControl.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.gridControl2_MouseDoubleClick);
            // 
            // gridView3
            // 
            this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId1,
            this.colpost_id,
            this.colaction,
            this.coltext});
            this.gridView3.GridControl = this.JobGridControl;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsView.ShowFooter = true;
            this.gridView3.OptionsView.ShowGroupPanel = false;
            this.gridView3.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridView_CellValueChanged);
            // 
            // colId1
            // 
            this.colId1.FieldName = "Id";
            this.colId1.MinWidth = 25;
            this.colId1.Name = "colId1";
            this.colId1.Visible = true;
            this.colId1.VisibleIndex = 0;
            this.colId1.Width = 94;
            // 
            // colpost_id
            // 
            this.colpost_id.FieldName = "post_id";
            this.colpost_id.MinWidth = 25;
            this.colpost_id.Name = "colpost_id";
            this.colpost_id.Visible = true;
            this.colpost_id.VisibleIndex = 1;
            this.colpost_id.Width = 94;
            // 
            // colaction
            // 
            this.colaction.FieldName = "action";
            this.colaction.MinWidth = 25;
            this.colaction.Name = "colaction";
            this.colaction.Visible = true;
            this.colaction.VisibleIndex = 2;
            this.colaction.Width = 94;
            // 
            // coltext
            // 
            this.coltext.FieldName = "text";
            this.coltext.MinWidth = 25;
            this.coltext.Name = "coltext";
            this.coltext.Visible = true;
            this.coltext.VisibleIndex = 3;
            this.coltext.Width = 94;
            // 
            // TodosGridControl
            // 
            this.TodosGridControl.DataSource = typeof(DriverUI.TODO);
            this.TodosGridControl.Dock = System.Windows.Forms.DockStyle.Left;
            this.TodosGridControl.Location = new System.Drawing.Point(0, 0);
            this.TodosGridControl.MainView = this.gridView2;
            this.TodosGridControl.Name = "TodosGridControl";
            this.TodosGridControl.Size = new System.Drawing.Size(343, 556);
            this.TodosGridControl.TabIndex = 0;
            this.TodosGridControl.UseEmbeddedNavigator = true;
            this.TodosGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId2,
            this.colVMS,
            this.colstate});
            this.gridView2.GridControl = this.TodosGridControl;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsView.ShowFooter = true;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            this.gridView2.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridView_CellValueChanged);
            this.gridView2.RowDeleting += new DevExpress.Data.RowDeletingEventHandler(this.gridView2_RowDeleting);
            // 
            // colId2
            // 
            this.colId2.FieldName = "Id";
            this.colId2.MinWidth = 25;
            this.colId2.Name = "colId2";
            this.colId2.Visible = true;
            this.colId2.VisibleIndex = 0;
            this.colId2.Width = 94;
            // 
            // colVMS
            // 
            this.colVMS.FieldName = "VMS";
            this.colVMS.MinWidth = 25;
            this.colVMS.Name = "colVMS";
            this.colVMS.Visible = true;
            this.colVMS.VisibleIndex = 1;
            this.colVMS.Width = 94;
            // 
            // colstate
            // 
            this.colstate.FieldName = "state";
            this.colstate.MinWidth = 25;
            this.colstate.Name = "colstate";
            this.colstate.Visible = true;
            this.colstate.VisibleIndex = 2;
            this.colstate.Width = 94;
            // 
            // xtraTabPage3
            // 
            this.xtraTabPage3.Controls.Add(this.AccountGridControl);
            this.xtraTabPage3.Name = "xtraTabPage3";
            this.xtraTabPage3.Size = new System.Drawing.Size(690, 556);
            this.xtraTabPage3.Text = "Accounts";
            // 
            // AccountGridControl
            // 
            this.AccountGridControl.DataSource = typeof(DriverUI.Account);
            this.AccountGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AccountGridControl.Location = new System.Drawing.Point(0, 0);
            this.AccountGridControl.MainView = this.gridView4;
            this.AccountGridControl.Name = "AccountGridControl";
            this.AccountGridControl.Size = new System.Drawing.Size(690, 556);
            this.AccountGridControl.TabIndex = 0;
            this.AccountGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView4});
            // 
            // gridView4
            // 
            this.gridView4.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colName,
            this.colPassword,
            this.colProfile,
            this.colStatus1,
            this.colUsername,
            this.colVMS1});
            this.gridView4.GridControl = this.AccountGridControl;
            this.gridView4.Name = "gridView4";
            this.gridView4.OptionsView.ShowFooter = true;
            this.gridView4.OptionsView.ShowGroupPanel = false;
            this.gridView4.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridView_CellValueChanged);
            // 
            // colName
            // 
            this.colName.FieldName = "Name";
            this.colName.MinWidth = 25;
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 0;
            this.colName.Width = 94;
            // 
            // colPassword
            // 
            this.colPassword.FieldName = "Password";
            this.colPassword.MinWidth = 25;
            this.colPassword.Name = "colPassword";
            this.colPassword.Visible = true;
            this.colPassword.VisibleIndex = 1;
            this.colPassword.Width = 94;
            // 
            // colProfile
            // 
            this.colProfile.FieldName = "Profile";
            this.colProfile.MinWidth = 25;
            this.colProfile.Name = "colProfile";
            this.colProfile.Visible = true;
            this.colProfile.VisibleIndex = 2;
            this.colProfile.Width = 94;
            // 
            // colStatus1
            // 
            this.colStatus1.FieldName = "Status";
            this.colStatus1.MinWidth = 25;
            this.colStatus1.Name = "colStatus1";
            this.colStatus1.Visible = true;
            this.colStatus1.VisibleIndex = 3;
            this.colStatus1.Width = 94;
            // 
            // colUsername
            // 
            this.colUsername.FieldName = "Username";
            this.colUsername.MinWidth = 25;
            this.colUsername.Name = "colUsername";
            this.colUsername.Visible = true;
            this.colUsername.VisibleIndex = 4;
            this.colUsername.Width = 94;
            // 
            // colVMS1
            // 
            this.colVMS1.FieldName = "VMS";
            this.colVMS1.MinWidth = 25;
            this.colVMS1.Name = "colVMS1";
            this.colVMS1.Visible = true;
            this.colVMS1.VisibleIndex = 5;
            this.colVMS1.Width = 94;
            // 
            // xtraTabPage4
            // 
            this.xtraTabPage4.Controls.Add(this.logListBox);
            this.xtraTabPage4.Name = "xtraTabPage4";
            this.xtraTabPage4.Size = new System.Drawing.Size(690, 556);
            this.xtraTabPage4.Text = "Logs";
            // 
            // logListBox
            // 
            this.logListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logListBox.FormattingEnabled = true;
            this.logListBox.ItemHeight = 16;
            this.logListBox.Location = new System.Drawing.Point(0, 0);
            this.logListBox.Name = "logListBox";
            this.logListBox.Size = new System.Drawing.Size(690, 556);
            this.logListBox.TabIndex = 0;
            // 
            // DashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1097, 586);
            this.Controls.Add(this.xtraTabControl1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DashBoard";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DashBoard_FormClosing);
            this.Load += new System.EventHandler(this.DashBoard_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit.Properties)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Action_Box.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.VMSGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.xtraTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.JobGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TodosGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.xtraTabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AccountGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            this.xtraTabPage4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer;
        private System.ComponentModel.BackgroundWorker Worker;
        private DevExpress.XtraEditors.SimpleButton AddVmsBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox IP_Box;
        private System.Windows.Forms.TextBox VMS_Name_Box;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraEditors.LookUpEdit lookUpEdit;
        private System.Windows.Forms.TextBox Username_Box;
        private System.Windows.Forms.TextBox Account_Name;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.SimpleButton AddAccBtn;
        private System.Windows.Forms.TextBox Profile_Box;
        private System.Windows.Forms.TextBox Password_Box;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox Post_Id_Box;
        private System.Windows.Forms.TextBox Text_Box;
        private System.Windows.Forms.TextBox VMS_Number_Box;
        private System.Windows.Forms.Label label9;
        private DevExpress.XtraEditors.SimpleButton AddJobBtn;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraGrid.GridControl VMSGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colIP;
        private DevExpress.XtraGrid.Columns.GridColumn colStatus;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraGrid.GridControl TodosGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colId2;
        private DevExpress.XtraGrid.Columns.GridColumn colVMS;
        private DevExpress.XtraGrid.Columns.GridColumn colstate;
        private DevExpress.XtraGrid.GridControl JobGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraGrid.Columns.GridColumn colId1;
        private DevExpress.XtraGrid.Columns.GridColumn colpost_id;
        private DevExpress.XtraGrid.Columns.GridColumn colaction;
        private DevExpress.XtraGrid.Columns.GridColumn coltext;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage3;
        private DevExpress.XtraGrid.GridControl AccountGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colPassword;
        private DevExpress.XtraGrid.Columns.GridColumn colProfile;
        private DevExpress.XtraGrid.Columns.GridColumn colStatus1;
        private DevExpress.XtraGrid.Columns.GridColumn colUsername;
        private DevExpress.XtraGrid.Columns.GridColumn colVMS1;
        private DevExpress.XtraEditors.SimpleButton StopVMBtn;
        private DevExpress.XtraEditors.SimpleButton StartVMBtn;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage4;
        private System.Windows.Forms.ListBox logListBox;
        private DevExpress.XtraEditors.ComboBoxEdit Action_Box;
    }
}

