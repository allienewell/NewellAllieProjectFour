namespace NewellAllieFinalProject
{
    partial class frmCourses
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
            System.Windows.Forms.Label courseNoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCourses));
            this.label1 = new System.Windows.Forms.Label();
            this.txtNoCourses = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.startDateCalendar = new System.Windows.Forms.MonthCalendar();
            this.coursesDataSet = new NewellAllieFinalProject.CoursesDataSet();
            this.coursesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.coursesTableAdapter = new NewellAllieFinalProject.CoursesDataSetTableAdapters.CoursesTableAdapter();
            this.tableAdapterManager = new NewellAllieFinalProject.CoursesDataSetTableAdapters.TableAdapterManager();
            this.cboCourseNo = new System.Windows.Forms.ComboBox();
            this.coursesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.rdoHybrid = new System.Windows.Forms.RadioButton();
            this.rdoOnline = new System.Windows.Forms.RadioButton();
            this.btnSet = new System.Windows.Forms.Button();
            this.btnGet = new System.Windows.Forms.Button();
            this.txtNoCourses2 = new System.Windows.Forms.TextBox();
            this.txtStudentName2 = new System.Windows.Forms.TextBox();
            this.txtStartDate = new System.Windows.Forms.TextBox();
            this.txtCourseType = new System.Windows.Forms.TextBox();
            this.txtCourseNo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            courseNoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.coursesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // courseNoLabel
            // 
            courseNoLabel.AutoSize = true;
            courseNoLabel.BackColor = System.Drawing.Color.Transparent;
            courseNoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            courseNoLabel.ForeColor = System.Drawing.Color.White;
            courseNoLabel.Location = new System.Drawing.Point(62, 380);
            courseNoLabel.Name = "courseNoLabel";
            courseNoLabel.Size = new System.Drawing.Size(146, 20);
            courseNoLabel.TabIndex = 5;
            courseNoLabel.Text = "Course Number:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(62, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number of Courses:";
            // 
            // txtNoCourses
            // 
            this.txtNoCourses.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoCourses.Location = new System.Drawing.Point(306, 30);
            this.txtNoCourses.Name = "txtNoCourses";
            this.txtNoCourses.Size = new System.Drawing.Size(166, 27);
            this.txtNoCourses.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(62, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Student Name:";
            // 
            // txtStudentName
            // 
            this.txtStudentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStudentName.Location = new System.Drawing.Point(306, 78);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(166, 27);
            this.txtStudentName.TabIndex = 1;
            // 
            // startDateCalendar
            // 
            this.startDateCalendar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startDateCalendar.Location = new System.Drawing.Point(133, 138);
            this.startDateCalendar.MaxDate = new System.DateTime(2019, 1, 31, 0, 0, 0, 0);
            this.startDateCalendar.MaxSelectionCount = 1;
            this.startDateCalendar.MinDate = new System.DateTime(2019, 1, 1, 0, 0, 0, 0);
            this.startDateCalendar.Name = "startDateCalendar";
            this.startDateCalendar.TabIndex = 2;
            this.startDateCalendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // coursesDataSet
            // 
            this.coursesDataSet.DataSetName = "CoursesDataSet";
            this.coursesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // coursesBindingSource
            // 
            this.coursesBindingSource.DataMember = "Courses";
            this.coursesBindingSource.DataSource = this.coursesDataSet;
            // 
            // coursesTableAdapter
            // 
            this.coursesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CoursesTableAdapter = this.coursesTableAdapter;
            this.tableAdapterManager.UpdateOrder = NewellAllieFinalProject.CoursesDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // cboCourseNo
            // 
            this.cboCourseNo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.coursesBindingSource, "CourseNo", true));
            this.cboCourseNo.DataSource = this.coursesBindingSource1;
            this.cboCourseNo.DisplayMember = "CourseNo";
            this.cboCourseNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCourseNo.FormattingEnabled = true;
            this.cboCourseNo.Location = new System.Drawing.Point(306, 377);
            this.cboCourseNo.Name = "cboCourseNo";
            this.cboCourseNo.Size = new System.Drawing.Size(166, 28);
            this.cboCourseNo.TabIndex = 3;
            this.cboCourseNo.ValueMember = "CourseNo";
            // 
            // coursesBindingSource1
            // 
            this.coursesBindingSource1.DataMember = "Courses";
            this.coursesBindingSource1.DataSource = this.coursesDataSet;
            // 
            // rdoHybrid
            // 
            this.rdoHybrid.AutoSize = true;
            this.rdoHybrid.BackColor = System.Drawing.Color.Transparent;
            this.rdoHybrid.Checked = true;
            this.rdoHybrid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoHybrid.ForeColor = System.Drawing.Color.White;
            this.rdoHybrid.Location = new System.Drawing.Point(66, 435);
            this.rdoHybrid.Name = "rdoHybrid";
            this.rdoHybrid.Size = new System.Drawing.Size(79, 24);
            this.rdoHybrid.TabIndex = 4;
            this.rdoHybrid.TabStop = true;
            this.rdoHybrid.Text = "Hybrid";
            this.rdoHybrid.UseVisualStyleBackColor = false;
            // 
            // rdoOnline
            // 
            this.rdoOnline.AutoSize = true;
            this.rdoOnline.BackColor = System.Drawing.Color.Transparent;
            this.rdoOnline.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoOnline.ForeColor = System.Drawing.Color.White;
            this.rdoOnline.Location = new System.Drawing.Point(317, 435);
            this.rdoOnline.Name = "rdoOnline";
            this.rdoOnline.Size = new System.Drawing.Size(78, 24);
            this.rdoOnline.TabIndex = 5;
            this.rdoOnline.Text = "Online";
            this.rdoOnline.UseVisualStyleBackColor = false;
            // 
            // btnSet
            // 
            this.btnSet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSet.Location = new System.Drawing.Point(113, 502);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(262, 48);
            this.btnSet.TabIndex = 6;
            this.btnSet.Text = "&Set";
            this.btnSet.UseVisualStyleBackColor = true;
            this.btnSet.Click += new System.EventHandler(this.btnSet_Click);
            // 
            // btnGet
            // 
            this.btnGet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGet.Location = new System.Drawing.Point(573, 30);
            this.btnGet.Name = "btnGet";
            this.btnGet.Size = new System.Drawing.Size(262, 48);
            this.btnGet.TabIndex = 7;
            this.btnGet.Text = "&Get";
            this.btnGet.UseVisualStyleBackColor = true;
            this.btnGet.Click += new System.EventHandler(this.btnGet_Click);
            // 
            // txtNoCourses2
            // 
            this.txtNoCourses2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoCourses2.Location = new System.Drawing.Point(745, 126);
            this.txtNoCourses2.Name = "txtNoCourses2";
            this.txtNoCourses2.ReadOnly = true;
            this.txtNoCourses2.Size = new System.Drawing.Size(166, 27);
            this.txtNoCourses2.TabIndex = 8;
            this.txtNoCourses2.TabStop = false;
            // 
            // txtStudentName2
            // 
            this.txtStudentName2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStudentName2.Location = new System.Drawing.Point(745, 200);
            this.txtStudentName2.Name = "txtStudentName2";
            this.txtStudentName2.ReadOnly = true;
            this.txtStudentName2.Size = new System.Drawing.Size(166, 27);
            this.txtStudentName2.TabIndex = 9;
            this.txtStudentName2.TabStop = false;
            // 
            // txtStartDate
            // 
            this.txtStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStartDate.Location = new System.Drawing.Point(745, 274);
            this.txtStartDate.Name = "txtStartDate";
            this.txtStartDate.ReadOnly = true;
            this.txtStartDate.Size = new System.Drawing.Size(166, 27);
            this.txtStartDate.TabIndex = 10;
            this.txtStartDate.TabStop = false;
            // 
            // txtCourseType
            // 
            this.txtCourseType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCourseType.Location = new System.Drawing.Point(745, 423);
            this.txtCourseType.Name = "txtCourseType";
            this.txtCourseType.ReadOnly = true;
            this.txtCourseType.Size = new System.Drawing.Size(166, 27);
            this.txtCourseType.TabIndex = 12;
            this.txtCourseType.TabStop = false;
            // 
            // txtCourseNo
            // 
            this.txtCourseNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCourseNo.Location = new System.Drawing.Point(745, 347);
            this.txtCourseNo.Name = "txtCourseNo";
            this.txtCourseNo.ReadOnly = true;
            this.txtCourseNo.Size = new System.Drawing.Size(166, 27);
            this.txtCourseNo.TabIndex = 11;
            this.txtCourseNo.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(509, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Number of Courses:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(509, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "Student Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(509, 277);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 20);
            this.label5.TabIndex = 18;
            this.label5.Text = "Start Date:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(509, 350);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 20);
            this.label6.TabIndex = 19;
            this.label6.Text = "Course Number:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(509, 426);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 20);
            this.label7.TabIndex = 20;
            this.label7.Text = "Course Type:";
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(573, 502);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(262, 48);
            this.btnExit.TabIndex = 13;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmCourses
            // 
            this.AcceptButton = this.btnSet;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(969, 751);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCourseNo);
            this.Controls.Add(this.txtCourseType);
            this.Controls.Add(this.txtStartDate);
            this.Controls.Add(this.txtStudentName2);
            this.Controls.Add(this.txtNoCourses2);
            this.Controls.Add(this.btnGet);
            this.Controls.Add(this.btnSet);
            this.Controls.Add(this.rdoOnline);
            this.Controls.Add(this.rdoHybrid);
            this.Controls.Add(courseNoLabel);
            this.Controls.Add(this.cboCourseNo);
            this.Controls.Add(this.startDateCalendar);
            this.Controls.Add(this.txtStudentName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNoCourses);
            this.Controls.Add(this.label1);
            this.Name = "frmCourses";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Courses Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.coursesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNoCourses;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.MonthCalendar startDateCalendar;
        private CoursesDataSet coursesDataSet;
        private System.Windows.Forms.BindingSource coursesBindingSource;
        private CoursesDataSetTableAdapters.CoursesTableAdapter coursesTableAdapter;
        private CoursesDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox cboCourseNo;
        private System.Windows.Forms.BindingSource coursesBindingSource1;
        private System.Windows.Forms.RadioButton rdoHybrid;
        private System.Windows.Forms.RadioButton rdoOnline;
        private System.Windows.Forms.Button btnSet;
        private System.Windows.Forms.Button btnGet;
        private System.Windows.Forms.TextBox txtNoCourses2;
        private System.Windows.Forms.TextBox txtStudentName2;
        private System.Windows.Forms.TextBox txtStartDate;
        private System.Windows.Forms.TextBox txtCourseType;
        private System.Windows.Forms.TextBox txtCourseNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnExit;
    }
}

