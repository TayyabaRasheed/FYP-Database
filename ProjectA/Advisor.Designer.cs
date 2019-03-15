namespace ProjectA
{
    partial class Advisor
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
            this.individualEvaluationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupWiseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.evaluateGroupsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateDeleteEvaluationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addInstructorToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.addAdvisorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projectAdvisorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateDeleteAdvisorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editStudentDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchStudentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addStudentToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.homeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.groupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteGroupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.assignGroupProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateDeletePojectDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.cmdSave = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.editGroupEvaluationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // individualEvaluationToolStripMenuItem
            // 
            this.individualEvaluationToolStripMenuItem.Name = "individualEvaluationToolStripMenuItem";
            this.individualEvaluationToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.individualEvaluationToolStripMenuItem.Text = "Group Evaluation";
            this.individualEvaluationToolStripMenuItem.Click += new System.EventHandler(this.individualEvaluationToolStripMenuItem_Click);
            // 
            // groupWiseToolStripMenuItem
            // 
            this.groupWiseToolStripMenuItem.Name = "groupWiseToolStripMenuItem";
            this.groupWiseToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.groupWiseToolStripMenuItem.Text = "Evaluation Details";
            this.groupWiseToolStripMenuItem.Click += new System.EventHandler(this.groupWiseToolStripMenuItem_Click);
            // 
            // evaluateGroupsToolStripMenuItem
            // 
            this.evaluateGroupsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.groupWiseToolStripMenuItem,
            this.individualEvaluationToolStripMenuItem,
            this.updateDeleteEvaluationToolStripMenuItem,
            this.editGroupEvaluationToolStripMenuItem});
            this.evaluateGroupsToolStripMenuItem.Name = "evaluateGroupsToolStripMenuItem";
            this.evaluateGroupsToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.evaluateGroupsToolStripMenuItem.Text = "Evaluation";
            // 
            // updateDeleteEvaluationToolStripMenuItem
            // 
            this.updateDeleteEvaluationToolStripMenuItem.Name = "updateDeleteEvaluationToolStripMenuItem";
            this.updateDeleteEvaluationToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.updateDeleteEvaluationToolStripMenuItem.Text = "UpdateDelete Evaluation";
            this.updateDeleteEvaluationToolStripMenuItem.Click += new System.EventHandler(this.updateDeleteEvaluationToolStripMenuItem_Click);
            // 
            // addInstructorToolStripMenuItem1
            // 
            this.addInstructorToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addAdvisorToolStripMenuItem,
            this.projectAdvisorToolStripMenuItem,
            this.updateDeleteAdvisorToolStripMenuItem});
            this.addInstructorToolStripMenuItem1.Name = "addInstructorToolStripMenuItem1";
            this.addInstructorToolStripMenuItem1.Size = new System.Drawing.Size(70, 20);
            this.addInstructorToolStripMenuItem1.Text = "Instructor";
            // 
            // addAdvisorToolStripMenuItem
            // 
            this.addAdvisorToolStripMenuItem.Name = "addAdvisorToolStripMenuItem";
            this.addAdvisorToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.addAdvisorToolStripMenuItem.Text = "Add Advisor";
            this.addAdvisorToolStripMenuItem.Click += new System.EventHandler(this.addAdvisorToolStripMenuItem_Click);
            // 
            // projectAdvisorToolStripMenuItem
            // 
            this.projectAdvisorToolStripMenuItem.Name = "projectAdvisorToolStripMenuItem";
            this.projectAdvisorToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.projectAdvisorToolStripMenuItem.Text = "Project Advisor";
            this.projectAdvisorToolStripMenuItem.Click += new System.EventHandler(this.projectAdvisorToolStripMenuItem_Click);
            // 
            // updateDeleteAdvisorToolStripMenuItem
            // 
            this.updateDeleteAdvisorToolStripMenuItem.Name = "updateDeleteAdvisorToolStripMenuItem";
            this.updateDeleteAdvisorToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.updateDeleteAdvisorToolStripMenuItem.Text = "UpdateDelete Advisor";
            this.updateDeleteAdvisorToolStripMenuItem.Click += new System.EventHandler(this.updateDeleteAdvisorToolStripMenuItem_Click);
            // 
            // editStudentDataToolStripMenuItem
            // 
            this.editStudentDataToolStripMenuItem.Name = "editStudentDataToolStripMenuItem";
            this.editStudentDataToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.editStudentDataToolStripMenuItem.Text = "UpdateDelete Student Data";
            this.editStudentDataToolStripMenuItem.Click += new System.EventHandler(this.editStudentDataToolStripMenuItem_Click);
            // 
            // searchStudentsToolStripMenuItem
            // 
            this.searchStudentsToolStripMenuItem.Name = "searchStudentsToolStripMenuItem";
            this.searchStudentsToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.searchStudentsToolStripMenuItem.Text = "Students Record";
            this.searchStudentsToolStripMenuItem.Click += new System.EventHandler(this.searchStudentsToolStripMenuItem_Click);
            // 
            // seToolStripMenuItem
            // 
            this.seToolStripMenuItem.Name = "seToolStripMenuItem";
            this.seToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.seToolStripMenuItem.Text = "Add Students";
            this.seToolStripMenuItem.Click += new System.EventHandler(this.seToolStripMenuItem_Click);
            // 
            // addStudentToolStripMenuItem1
            // 
            this.addStudentToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.seToolStripMenuItem,
            this.searchStudentsToolStripMenuItem,
            this.editStudentDataToolStripMenuItem});
            this.addStudentToolStripMenuItem1.Name = "addStudentToolStripMenuItem1";
            this.addStudentToolStripMenuItem1.Size = new System.Drawing.Size(63, 20);
            this.addStudentToolStripMenuItem1.Text = "Student ";
            // 
            // homeToolStripMenuItem1
            // 
            this.homeToolStripMenuItem1.Name = "homeToolStripMenuItem1";
            this.homeToolStripMenuItem1.Size = new System.Drawing.Size(52, 20);
            this.homeToolStripMenuItem1.Text = "Home";
            this.homeToolStripMenuItem1.Click += new System.EventHandler(this.homeToolStripMenuItem1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem1,
            this.addStudentToolStripMenuItem1,
            this.addInstructorToolStripMenuItem1,
            this.evaluateGroupsToolStripMenuItem,
            this.groupToolStripMenuItem,
            this.projectToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(806, 24);
            this.menuStrip1.TabIndex = 29;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // groupToolStripMenuItem
            // 
            this.groupToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.groupStudentToolStripMenuItem,
            this.deleteGroupToolStripMenuItem});
            this.groupToolStripMenuItem.Name = "groupToolStripMenuItem";
            this.groupToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.groupToolStripMenuItem.Text = "Group";
            // 
            // groupStudentToolStripMenuItem
            // 
            this.groupStudentToolStripMenuItem.Name = "groupStudentToolStripMenuItem";
            this.groupStudentToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.groupStudentToolStripMenuItem.Text = "Group Student";
            this.groupStudentToolStripMenuItem.Click += new System.EventHandler(this.groupStudentToolStripMenuItem_Click);
            // 
            // deleteGroupToolStripMenuItem
            // 
            this.deleteGroupToolStripMenuItem.Name = "deleteGroupToolStripMenuItem";
            this.deleteGroupToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.deleteGroupToolStripMenuItem.Text = "Delete Group";
            this.deleteGroupToolStripMenuItem.Click += new System.EventHandler(this.deleteGroupToolStripMenuItem_Click);
            // 
            // projectToolStripMenuItem
            // 
            this.projectToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createProjectToolStripMenuItem,
            this.assignGroupProjectToolStripMenuItem,
            this.updateDeletePojectDetailsToolStripMenuItem});
            this.projectToolStripMenuItem.Name = "projectToolStripMenuItem";
            this.projectToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.projectToolStripMenuItem.Text = "Project";
            this.projectToolStripMenuItem.Click += new System.EventHandler(this.projectToolStripMenuItem_Click);
            // 
            // createProjectToolStripMenuItem
            // 
            this.createProjectToolStripMenuItem.Name = "createProjectToolStripMenuItem";
            this.createProjectToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.createProjectToolStripMenuItem.Text = "Create Project";
            this.createProjectToolStripMenuItem.Click += new System.EventHandler(this.createProjectToolStripMenuItem_Click);
            // 
            // assignGroupProjectToolStripMenuItem
            // 
            this.assignGroupProjectToolStripMenuItem.Name = "assignGroupProjectToolStripMenuItem";
            this.assignGroupProjectToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.assignGroupProjectToolStripMenuItem.Text = "Assign Group Project";
            this.assignGroupProjectToolStripMenuItem.Click += new System.EventHandler(this.assignGroupProjectToolStripMenuItem_Click);
            // 
            // updateDeletePojectDetailsToolStripMenuItem
            // 
            this.updateDeletePojectDetailsToolStripMenuItem.Name = "updateDeletePojectDetailsToolStripMenuItem";
            this.updateDeletePojectDetailsToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.updateDeletePojectDetailsToolStripMenuItem.Text = "UpdateDelete Poject Details";
            this.updateDeletePojectDetailsToolStripMenuItem.Click += new System.EventHandler(this.updateDeletePojectDetailsToolStripMenuItem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(102, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Designation";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(102, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Salary";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtSalary
            // 
            this.txtSalary.Location = new System.Drawing.Point(258, 130);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(121, 20);
            this.txtSalary.TabIndex = 17;
            this.txtSalary.TextChanged += new System.EventHandler(this.txtSalary_TextChanged);
            // 
            // cmdSave
            // 
            this.cmdSave.Location = new System.Drawing.Point(129, 184);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(209, 39);
            this.cmdSave.TabIndex = 16;
            this.cmdSave.Text = "Save";
            this.cmdSave.UseVisualStyleBackColor = true;
            this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Professor",
            "Associate Professor",
            "Assisstant Professor",
            "Lecturer",
            "Industry Professional"});
            this.comboBox1.Location = new System.Drawing.Point(258, 71);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 30;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(468, 71);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 31;
            // 
            // editGroupEvaluationToolStripMenuItem
            // 
            this.editGroupEvaluationToolStripMenuItem.Name = "editGroupEvaluationToolStripMenuItem";
            this.editGroupEvaluationToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.editGroupEvaluationToolStripMenuItem.Text = "EditGroup Evaluation";
            this.editGroupEvaluationToolStripMenuItem.Click += new System.EventHandler(this.editGroupEvaluationToolStripMenuItem_Click);
            // 
            // Advisor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 370);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(this.cmdSave);
            this.Name = "Advisor";
            this.Text = "Advisor";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem individualEvaluationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem groupWiseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem evaluateGroupsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addInstructorToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem editStudentDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchStudentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addStudentToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.Button cmdSave;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ToolStripMenuItem groupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem groupStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem projectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addAdvisorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem projectAdvisorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem assignGroupProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateDeleteAdvisorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateDeleteEvaluationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateDeletePojectDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteGroupToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripMenuItem editGroupEvaluationToolStripMenuItem;
    }
}