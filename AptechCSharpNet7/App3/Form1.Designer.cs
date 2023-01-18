namespace App3
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageStu = new System.Windows.Forms.TabPage();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnUpdateStu = new System.Windows.Forms.Button();
            this.btnAddStu = new System.Windows.Forms.Button();
            this.dtpDob = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.txtStuEmail = new System.Windows.Forms.TextBox();
            this.txtStuPhone = new System.Windows.Forms.TextBox();
            this.txtStuAdrs = new System.Windows.Forms.TextBox();
            this.txtStuName = new System.Windows.Forms.TextBox();
            this.txtStuId = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblStuId = new System.Windows.Forms.Label();
            this.tabPageSub = new System.Windows.Forms.TabPage();
            this.tabPageClass = new System.Windows.Forms.TabPage();
            this.tabPageCou = new System.Windows.Forms.TabPage();
            this.tabPageDept = new System.Windows.Forms.TabPage();
            this.tabPageEx = new System.Windows.Forms.TabPage();
            this.tabPageTot = new System.Windows.Forms.TabPage();
            this.tabPageClassDt = new System.Windows.Forms.TabPage();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl.SuspendLayout();
            this.tabPageStu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageStu);
            this.tabControl.Controls.Add(this.tabPageSub);
            this.tabControl.Controls.Add(this.tabPageClass);
            this.tabControl.Controls.Add(this.tabPageCou);
            this.tabControl.Controls.Add(this.tabPageDept);
            this.tabControl.Controls.Add(this.tabPageEx);
            this.tabControl.Controls.Add(this.tabPageTot);
            this.tabControl.Controls.Add(this.tabPageClassDt);
            this.tabControl.Location = new System.Drawing.Point(11, 14);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1166, 760);
            this.tabControl.TabIndex = 0;
            // 
            // tabPageStu
            // 
            this.tabPageStu.Controls.Add(this.bindingNavigator1);
            this.tabPageStu.Controls.Add(this.dataGridView1);
            this.tabPageStu.Controls.Add(this.panel1);
            this.tabPageStu.Location = new System.Drawing.Point(4, 22);
            this.tabPageStu.Name = "tabPageStu";
            this.tabPageStu.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageStu.Size = new System.Drawing.Size(1158, 734);
            this.tabPageStu.TabIndex = 0;
            this.tabPageStu.Text = "Thông Tin Sinh Viên";
            this.tabPageStu.UseVisualStyleBackColor = true;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.bindingNavigator1.Location = new System.Drawing.Point(3, 3);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(1152, 25);
            this.bindingNavigator1.TabIndex = 2;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 343);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1077, 336);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.IndianRed;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.comboBox2);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.btnUpdateStu);
            this.panel1.Controls.Add(this.btnAddStu);
            this.panel1.Controls.Add(this.dtpDob);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtStuEmail);
            this.panel1.Controls.Add(this.txtStuPhone);
            this.panel1.Controls.Add(this.txtStuAdrs);
            this.panel1.Controls.Add(this.txtStuName);
            this.panel1.Controls.Add(this.txtStuId);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblStuId);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1152, 728);
            this.panel1.TabIndex = 0;
            this.panel1.AutoSizeChanged += new System.EventHandler(this.Form1_Load);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(763, 280);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 16);
            this.label7.TabIndex = 19;
            this.label7.Text = "Tình Trạng:";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.comboBox2.Location = new System.Drawing.Point(844, 275);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(233, 21);
            this.comboBox2.TabIndex = 18;
            this.comboBox2.Text = "Yes";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Nam",
            "Nu"});
            this.comboBox1.Location = new System.Drawing.Point(187, 191);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(233, 21);
            this.comboBox1.TabIndex = 17;
            this.comboBox1.Text = "Nam";
            // 
            // btnUpdateStu
            // 
            this.btnUpdateStu.BackColor = System.Drawing.Color.White;
            this.btnUpdateStu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateStu.Location = new System.Drawing.Point(261, 263);
            this.btnUpdateStu.Name = "btnUpdateStu";
            this.btnUpdateStu.Size = new System.Drawing.Size(159, 42);
            this.btnUpdateStu.TabIndex = 16;
            this.btnUpdateStu.Text = "Sửa";
            this.btnUpdateStu.UseVisualStyleBackColor = false;
            // 
            // btnAddStu
            // 
            this.btnAddStu.BackColor = System.Drawing.Color.White;
            this.btnAddStu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddStu.Location = new System.Drawing.Point(99, 263);
            this.btnAddStu.Name = "btnAddStu";
            this.btnAddStu.Size = new System.Drawing.Size(159, 42);
            this.btnAddStu.TabIndex = 15;
            this.btnAddStu.Text = "Thêm Sinh Viên";
            this.btnAddStu.UseVisualStyleBackColor = false;
            // 
            // dtpDob
            // 
            this.dtpDob.CustomFormat = "dd/MM/yyyy";
            this.dtpDob.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDob.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDob.Location = new System.Drawing.Point(844, 207);
            this.dtpDob.Name = "dtpDob";
            this.dtpDob.Size = new System.Drawing.Size(233, 29);
            this.dtpDob.TabIndex = 14;
            this.dtpDob.UseWaitCursor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(692, 217);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Ngày Tháng Năm Sinh:";
            // 
            // txtStuEmail
            // 
            this.txtStuEmail.Location = new System.Drawing.Point(844, 146);
            this.txtStuEmail.Name = "txtStuEmail";
            this.txtStuEmail.Size = new System.Drawing.Size(233, 20);
            this.txtStuEmail.TabIndex = 11;
            this.txtStuEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtStuPhone
            // 
            this.txtStuPhone.Location = new System.Drawing.Point(844, 95);
            this.txtStuPhone.Name = "txtStuPhone";
            this.txtStuPhone.Size = new System.Drawing.Size(233, 20);
            this.txtStuPhone.TabIndex = 10;
            this.txtStuPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtStuAdrs
            // 
            this.txtStuAdrs.Location = new System.Drawing.Point(844, 44);
            this.txtStuAdrs.Name = "txtStuAdrs";
            this.txtStuAdrs.Size = new System.Drawing.Size(233, 20);
            this.txtStuAdrs.TabIndex = 9;
            this.txtStuAdrs.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtStuName
            // 
            this.txtStuName.Location = new System.Drawing.Point(187, 117);
            this.txtStuName.Name = "txtStuName";
            this.txtStuName.Size = new System.Drawing.Size(233, 20);
            this.txtStuName.TabIndex = 7;
            this.txtStuName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtStuId
            // 
            this.txtStuId.Location = new System.Drawing.Point(187, 43);
            this.txtStuId.Name = "txtStuId";
            this.txtStuId.ReadOnly = true;
            this.txtStuId.Size = new System.Drawing.Size(233, 20);
            this.txtStuId.TabIndex = 6;
            this.txtStuId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(794, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Email:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(743, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Số Điện Thoại:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(786, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Địa Chỉ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(118, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Giới Tính:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(67, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ Tên Sinh Viên:";
            // 
            // lblStuId
            // 
            this.lblStuId.AutoSize = true;
            this.lblStuId.BackColor = System.Drawing.Color.White;
            this.lblStuId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStuId.Location = new System.Drawing.Point(96, 43);
            this.lblStuId.Name = "lblStuId";
            this.lblStuId.Size = new System.Drawing.Size(85, 16);
            this.lblStuId.TabIndex = 0;
            this.lblStuId.Text = "ID Sinh Viên: ";
            // 
            // tabPageSub
            // 
            this.tabPageSub.Location = new System.Drawing.Point(4, 22);
            this.tabPageSub.Name = "tabPageSub";
            this.tabPageSub.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSub.Size = new System.Drawing.Size(1158, 734);
            this.tabPageSub.TabIndex = 1;
            this.tabPageSub.Text = "Thông Tin Môn Học";
            this.tabPageSub.UseVisualStyleBackColor = true;
            this.tabPageSub.Click += new System.EventHandler(this.tabPageSub_Click);
            // 
            // tabPageClass
            // 
            this.tabPageClass.Location = new System.Drawing.Point(4, 22);
            this.tabPageClass.Name = "tabPageClass";
            this.tabPageClass.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageClass.Size = new System.Drawing.Size(1158, 734);
            this.tabPageClass.TabIndex = 2;
            this.tabPageClass.Text = "Thông Tin Lớp Học";
            this.tabPageClass.UseVisualStyleBackColor = true;
            // 
            // tabPageCou
            // 
            this.tabPageCou.Location = new System.Drawing.Point(4, 22);
            this.tabPageCou.Name = "tabPageCou";
            this.tabPageCou.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCou.Size = new System.Drawing.Size(1158, 734);
            this.tabPageCou.TabIndex = 3;
            this.tabPageCou.Text = "Thông Tin Khóa Học";
            this.tabPageCou.UseVisualStyleBackColor = true;
            // 
            // tabPageDept
            // 
            this.tabPageDept.Location = new System.Drawing.Point(4, 22);
            this.tabPageDept.Name = "tabPageDept";
            this.tabPageDept.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDept.Size = new System.Drawing.Size(1158, 734);
            this.tabPageDept.TabIndex = 4;
            this.tabPageDept.Text = "Thông Tin Khoa";
            this.tabPageDept.UseVisualStyleBackColor = true;
            // 
            // tabPageEx
            // 
            this.tabPageEx.Location = new System.Drawing.Point(4, 22);
            this.tabPageEx.Name = "tabPageEx";
            this.tabPageEx.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageEx.Size = new System.Drawing.Size(1158, 734);
            this.tabPageEx.TabIndex = 5;
            this.tabPageEx.Text = "Thông Tin Bài Thi";
            this.tabPageEx.UseVisualStyleBackColor = true;
            // 
            // tabPageTot
            // 
            this.tabPageTot.Location = new System.Drawing.Point(4, 22);
            this.tabPageTot.Name = "tabPageTot";
            this.tabPageTot.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTot.Size = new System.Drawing.Size(1158, 734);
            this.tabPageTot.TabIndex = 6;
            this.tabPageTot.Text = "Các Hệ Đào Tạo";
            this.tabPageTot.UseVisualStyleBackColor = true;
            // 
            // tabPageClassDt
            // 
            this.tabPageClassDt.Location = new System.Drawing.Point(4, 22);
            this.tabPageClassDt.Name = "tabPageClassDt";
            this.tabPageClassDt.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageClassDt.Size = new System.Drawing.Size(1158, 734);
            this.tabPageClassDt.TabIndex = 7;
            this.tabPageClassDt.Text = "Thông Tin Lớp Học Chi Tiết";
            this.tabPageClassDt.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1227, 716);
            this.Controls.Add(this.tabControl);
            this.Name = "Form1";
            this.Text = "Main Page";
            this.AutoSizeChanged += new System.EventHandler(this.Form1_Load);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl.ResumeLayout(false);
            this.tabPageStu.ResumeLayout(false);
            this.tabPageStu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageStu;
        private System.Windows.Forms.TabPage tabPageSub;
        private System.Windows.Forms.TabPage tabPageClass;
        private System.Windows.Forms.TabPage tabPageCou;
        private System.Windows.Forms.TabPage tabPageDept;
        private System.Windows.Forms.TabPage tabPageEx;
        private System.Windows.Forms.TabPage tabPageTot;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblStuId;
        private System.Windows.Forms.TextBox txtStuName;
        private System.Windows.Forms.TextBox txtStuId;
        private System.Windows.Forms.TextBox txtStuEmail;
        private System.Windows.Forms.TextBox txtStuPhone;
        private System.Windows.Forms.TextBox txtStuAdrs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpDob;
        private System.Windows.Forms.Button btnUpdateStu;
        private System.Windows.Forms.Button btnAddStu;
        private System.Windows.Forms.TabPage tabPageClassDt;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
    }
}

