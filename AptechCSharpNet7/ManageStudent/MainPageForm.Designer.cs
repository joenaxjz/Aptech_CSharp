namespace ManageStudent
{
    partial class MainPageForm
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
            this.btnStu = new System.Windows.Forms.Button();
            this.btnSub = new System.Windows.Forms.Button();
            this.btnClass = new System.Windows.Forms.Button();
            this.btnDept = new System.Windows.Forms.Button();
            this.btnExam = new System.Windows.Forms.Button();
            this.btnTot = new System.Windows.Forms.Button();
            this.btnCou = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStu
            // 
            this.btnStu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStu.Location = new System.Drawing.Point(401, 241);
            this.btnStu.Name = "btnStu";
            this.btnStu.Size = new System.Drawing.Size(216, 79);
            this.btnStu.TabIndex = 0;
            this.btnStu.Text = "Student";
            this.btnStu.UseVisualStyleBackColor = true;
            this.btnStu.Click += new System.EventHandler(this.btnStu_Click);
            // 
            // btnSub
            // 
            this.btnSub.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSub.Location = new System.Drawing.Point(813, 241);
            this.btnSub.Name = "btnSub";
            this.btnSub.Size = new System.Drawing.Size(180, 79);
            this.btnSub.TabIndex = 1;
            this.btnSub.Text = "Subject";
            this.btnSub.UseVisualStyleBackColor = true;
            this.btnSub.Click += new System.EventHandler(this.btnSub_Click);
            // 
            // btnClass
            // 
            this.btnClass.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClass.AutoSize = true;
            this.btnClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClass.Location = new System.Drawing.Point(12, 31);
            this.btnClass.Name = "btnClass";
            this.btnClass.Size = new System.Drawing.Size(184, 78);
            this.btnClass.TabIndex = 2;
            this.btnClass.Text = "Class";
            this.btnClass.UseVisualStyleBackColor = true;
            this.btnClass.Click += new System.EventHandler(this.btnClass_Click);
            // 
            // btnDept
            // 
            this.btnDept.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDept.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDept.Location = new System.Drawing.Point(813, 31);
            this.btnDept.Name = "btnDept";
            this.btnDept.Size = new System.Drawing.Size(180, 78);
            this.btnDept.TabIndex = 3;
            this.btnDept.Text = "Department";
            this.btnDept.UseVisualStyleBackColor = true;
            this.btnDept.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnExam
            // 
            this.btnExam.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExam.Location = new System.Drawing.Point(12, 241);
            this.btnExam.Name = "btnExam";
            this.btnExam.Size = new System.Drawing.Size(184, 79);
            this.btnExam.TabIndex = 4;
            this.btnExam.Text = "Exam and Test";
            this.btnExam.UseVisualStyleBackColor = true;
            this.btnExam.Click += new System.EventHandler(this.btnExam_Click);
            // 
            // btnTot
            // 
            this.btnTot.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTot.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTot.Location = new System.Drawing.Point(381, 416);
            this.btnTot.Name = "btnTot";
            this.btnTot.Size = new System.Drawing.Size(254, 81);
            this.btnTot.TabIndex = 5;
            this.btnTot.Text = "Type of Training";
            this.btnTot.UseVisualStyleBackColor = true;
            this.btnTot.Click += new System.EventHandler(this.btnTot_Click);
            // 
            // btnCou
            // 
            this.btnCou.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCou.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCou.Location = new System.Drawing.Point(401, 42);
            this.btnCou.Name = "btnCou";
            this.btnCou.Size = new System.Drawing.Size(216, 78);
            this.btnCou.TabIndex = 6;
            this.btnCou.Text = "Course";
            this.btnCou.UseVisualStyleBackColor = true;
            this.btnCou.Click += new System.EventHandler(this.btnCou_Click);
            // 
            // MainPageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1005, 563);
            this.Controls.Add(this.btnCou);
            this.Controls.Add(this.btnTot);
            this.Controls.Add(this.btnExam);
            this.Controls.Add(this.btnDept);
            this.Controls.Add(this.btnClass);
            this.Controls.Add(this.btnSub);
            this.Controls.Add(this.btnStu);
            this.Name = "MainPageForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Page";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button btnStu;
        private System.Windows.Forms.Button btnSub;
        private System.Windows.Forms.Button btnClass;
        private System.Windows.Forms.Button btnDept;
        private System.Windows.Forms.Button btnExam;
        private System.Windows.Forms.Button btnTot;
        private System.Windows.Forms.Button btnCou;
    }
}

