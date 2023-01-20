namespace ManageStudent
{
    partial class DepartmentForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DepartmentForm));
            this.btnBackToMainPage = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
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
            this.txtSta = new System.Windows.Forms.TextBox();
            this.txtDeptAdrs = new System.Windows.Forms.TextBox();
            this.txtDeptName = new System.Windows.Forms.TextBox();
            this.txtDeptId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDeptNum = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnUpd = new System.Windows.Forms.ToolStripButton();
            this.btnAdd = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBackToMainPage
            // 
            this.btnBackToMainPage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnBackToMainPage.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackToMainPage.Location = new System.Drawing.Point(12, 760);
            this.btnBackToMainPage.Name = "btnBackToMainPage";
            this.btnBackToMainPage.Size = new System.Drawing.Size(162, 28);
            this.btnBackToMainPage.TabIndex = 1;
            this.btnBackToMainPage.Text = "Back to MainPage";
            this.btnBackToMainPage.UseVisualStyleBackColor = true;
            this.btnBackToMainPage.Click += new System.EventHandler(this.btnBackToMainPage_Click);
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 374);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1258, 375);
            this.dataGridView1.TabIndex = 2;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.Dock = System.Windows.Forms.DockStyle.None;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.btnUpd,
            this.btnAdd});
            this.bindingNavigator1.Location = new System.Drawing.Point(514, 766);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(333, 25);
            this.bindingNavigator1.TabIndex = 3;
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
            // txtSta
            // 
            this.txtSta.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtSta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSta.Location = new System.Drawing.Point(477, 273);
            this.txtSta.Name = "txtSta";
            this.txtSta.Size = new System.Drawing.Size(292, 21);
            this.txtSta.TabIndex = 20;
            this.txtSta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDeptAdrs
            // 
            this.txtDeptAdrs.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtDeptAdrs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDeptAdrs.Location = new System.Drawing.Point(794, 38);
            this.txtDeptAdrs.Name = "txtDeptAdrs";
            this.txtDeptAdrs.Size = new System.Drawing.Size(292, 21);
            this.txtDeptAdrs.TabIndex = 19;
            this.txtDeptAdrs.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDeptName
            // 
            this.txtDeptName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtDeptName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDeptName.Location = new System.Drawing.Point(200, 142);
            this.txtDeptName.Name = "txtDeptName";
            this.txtDeptName.Size = new System.Drawing.Size(292, 21);
            this.txtDeptName.TabIndex = 18;
            this.txtDeptName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDeptId
            // 
            this.txtDeptId.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtDeptId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDeptId.Location = new System.Drawing.Point(200, 38);
            this.txtDeptId.Name = "txtDeptId";
            this.txtDeptId.Size = new System.Drawing.Size(292, 21);
            this.txtDeptId.TabIndex = 17;
            this.txtDeptId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(424, 276);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 16);
            this.label4.TabIndex = 16;
            this.label4.Text = "Status:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(654, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "Department Address:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(74, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "Department Name:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(98, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Department ID:";
            // 
            // txtDeptNum
            // 
            this.txtDeptNum.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtDeptNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDeptNum.Location = new System.Drawing.Point(794, 138);
            this.txtDeptNum.Name = "txtDeptNum";
            this.txtDeptNum.Size = new System.Drawing.Size(292, 21);
            this.txtDeptNum.TabIndex = 22;
            this.txtDeptNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(615, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(173, 16);
            this.label5.TabIndex = 21;
            this.label5.Text = "Department Phone Number:";
            // 
            // btnUpd
            // 
            this.btnUpd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnUpd.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpd.Image = ((System.Drawing.Image)(resources.GetObject("btnUpd.Image")));
            this.btnUpd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnUpd.Name = "btnUpd";
            this.btnUpd.Size = new System.Drawing.Size(56, 22);
            this.btnUpd.Text = "Update";
            this.btnUpd.Click += new System.EventHandler(this.btnUpd_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(37, 22);
            this.btnAdd.Text = "Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // DepartmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1263, 800);
            this.Controls.Add(this.txtDeptNum);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSta);
            this.Controls.Add(this.txtDeptAdrs);
            this.Controls.Add(this.txtDeptName);
            this.Controls.Add(this.txtDeptId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnBackToMainPage);
            this.Name = "DepartmentForm";
            this.Text = "DepartmentForm";
            this.Load += new System.EventHandler(this.DepartmentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBackToMainPage;
        private System.Windows.Forms.DataGridView dataGridView1;
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
        private System.Windows.Forms.TextBox txtSta;
        private System.Windows.Forms.TextBox txtDeptAdrs;
        private System.Windows.Forms.TextBox txtDeptName;
        private System.Windows.Forms.TextBox txtDeptId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDeptNum;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolStripButton btnUpd;
        private System.Windows.Forms.ToolStripButton btnAdd;
    }
}