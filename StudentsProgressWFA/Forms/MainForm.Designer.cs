namespace StudentsProgressWFA
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.studentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facultyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.specialtyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.subjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.typeOfTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.passExamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.AverageScore = new System.Windows.Forms.Button();
            this.AveragedataGridView = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.MostSuccSt_Button = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Minbutton = new System.Windows.Forms.Button();
            this.DiffanSimpdataGridView = new System.Windows.Forms.DataGridView();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AveragedataGridView)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DiffanSimpdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.studentToolStripMenuItem,
            this.facultyToolStripMenuItem,
            this.specialtyToolStripMenuItem,
            this.groupToolStripMenuItem,
            this.subjectToolStripMenuItem,
            this.testToolStripMenuItem,
            this.typeOfTestToolStripMenuItem,
            this.passExamToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // studentToolStripMenuItem
            // 
            this.studentToolStripMenuItem.Name = "studentToolStripMenuItem";
            this.studentToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.studentToolStripMenuItem.Text = "Student";
            this.studentToolStripMenuItem.Click += new System.EventHandler(this.studentToolStripMenuItem_Click);
            // 
            // facultyToolStripMenuItem
            // 
            this.facultyToolStripMenuItem.Name = "facultyToolStripMenuItem";
            this.facultyToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.facultyToolStripMenuItem.Text = "Faculty";
            this.facultyToolStripMenuItem.Click += new System.EventHandler(this.facultyToolStripMenuItem_Click);
            // 
            // specialtyToolStripMenuItem
            // 
            this.specialtyToolStripMenuItem.Name = "specialtyToolStripMenuItem";
            this.specialtyToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.specialtyToolStripMenuItem.Text = "Specialty";
            this.specialtyToolStripMenuItem.Click += new System.EventHandler(this.specialtyToolStripMenuItem_Click);
            // 
            // groupToolStripMenuItem
            // 
            this.groupToolStripMenuItem.Name = "groupToolStripMenuItem";
            this.groupToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.groupToolStripMenuItem.Text = "Group";
            this.groupToolStripMenuItem.Click += new System.EventHandler(this.groupToolStripMenuItem_Click);
            // 
            // subjectToolStripMenuItem
            // 
            this.subjectToolStripMenuItem.Name = "subjectToolStripMenuItem";
            this.subjectToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.subjectToolStripMenuItem.Text = "Subject";
            this.subjectToolStripMenuItem.Click += new System.EventHandler(this.subjectToolStripMenuItem_Click);
            // 
            // testToolStripMenuItem
            // 
            this.testToolStripMenuItem.Name = "testToolStripMenuItem";
            this.testToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.testToolStripMenuItem.Text = "Test";
            this.testToolStripMenuItem.Click += new System.EventHandler(this.testToolStripMenuItem_Click);
            // 
            // typeOfTestToolStripMenuItem
            // 
            this.typeOfTestToolStripMenuItem.Name = "typeOfTestToolStripMenuItem";
            this.typeOfTestToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.typeOfTestToolStripMenuItem.Text = "Type of Test";
            this.typeOfTestToolStripMenuItem.Click += new System.EventHandler(this.typeOfTestToolStripMenuItem_Click);
            // 
            // passExamToolStripMenuItem
            // 
            this.passExamToolStripMenuItem.Name = "passExamToolStripMenuItem";
            this.passExamToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.passExamToolStripMenuItem.Text = "PassExam";
            this.passExamToolStripMenuItem.Click += new System.EventHandler(this.passExamToolStripMenuItem_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 112);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(458, 336);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPage1.Controls.Add(this.AverageScore);
            this.tabPage1.Controls.Add(this.AveragedataGridView);
            this.tabPage1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabPage1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(450, 308);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "FirstPage";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // AverageScore
            // 
            this.AverageScore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AverageScore.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AverageScore.Location = new System.Drawing.Point(356, 16);
            this.AverageScore.Name = "AverageScore";
            this.AverageScore.Size = new System.Drawing.Size(85, 38);
            this.AverageScore.TabIndex = 1;
            this.AverageScore.Text = "Average";
            this.AverageScore.UseVisualStyleBackColor = true;
            this.AverageScore.Click += new System.EventHandler(this.AverageScore_Click);
            // 
            // AveragedataGridView
            // 
            this.AveragedataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AveragedataGridView.Location = new System.Drawing.Point(6, 60);
            this.AveragedataGridView.Name = "AveragedataGridView";
            this.AveragedataGridView.RowTemplate.Height = 25;
            this.AveragedataGridView.Size = new System.Drawing.Size(435, 228);
            this.AveragedataGridView.TabIndex = 0;
            this.AveragedataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AveragedataGridView_CellContentClick);
            // 
            // tabPage2
            // 
            this.tabPage2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPage2.Controls.Add(this.MostSuccSt_Button);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.Minbutton);
            this.tabPage2.Controls.Add(this.DiffanSimpdataGridView);
            this.tabPage2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabPage2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(450, 308);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "SecondPage";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // MostSuccSt_Button
            // 
            this.MostSuccSt_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MostSuccSt_Button.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MostSuccSt_Button.Location = new System.Drawing.Point(277, 24);
            this.MostSuccSt_Button.Name = "MostSuccSt_Button";
            this.MostSuccSt_Button.Size = new System.Drawing.Size(119, 40);
            this.MostSuccSt_Button.TabIndex = 3;
            this.MostSuccSt_Button.Text = "Most SuccesffulStudent";
            this.MostSuccSt_Button.UseVisualStyleBackColor = true;
            this.MostSuccSt_Button.Click += new System.EventHandler(this.MostSuccSt_Button_Click);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(137, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 40);
            this.button1.TabIndex = 2;
            this.button1.Text = "Simplest Subject";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Minbutton
            // 
            this.Minbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Minbutton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Minbutton.Location = new System.Drawing.Point(3, 24);
            this.Minbutton.Name = "Minbutton";
            this.Minbutton.Size = new System.Drawing.Size(106, 40);
            this.Minbutton.TabIndex = 1;
            this.Minbutton.Text = "Difficult Subject";
            this.Minbutton.UseVisualStyleBackColor = true;
            this.Minbutton.Click += new System.EventHandler(this.Minbutton_Click);
            // 
            // DiffanSimpdataGridView
            // 
            this.DiffanSimpdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DiffanSimpdataGridView.Location = new System.Drawing.Point(1, 70);
            this.DiffanSimpdataGridView.Name = "DiffanSimpdataGridView";
            this.DiffanSimpdataGridView.RowTemplate.Height = 25;
            this.DiffanSimpdataGridView.Size = new System.Drawing.Size(395, 230);
            this.DiffanSimpdataGridView.TabIndex = 0;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(16, 43);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 23);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(16, 83);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 23);
            this.dateTimePicker2.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::StudentsProgressWFA.Properties.Resources.StudentImage;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AveragedataGridView)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DiffanSimpdataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem studentToolStripMenuItem;
        private ToolStripMenuItem facultyToolStripMenuItem;
        private ToolStripMenuItem specialtyToolStripMenuItem;
        private ToolStripMenuItem groupToolStripMenuItem;
        private ToolStripMenuItem subjectToolStripMenuItem;
        private ToolStripMenuItem testToolStripMenuItem;
        private ToolStripMenuItem typeOfTestToolStripMenuItem;
        private ToolStripMenuItem passExamToolStripMenuItem;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private Button AverageScore;
        private DataGridView AveragedataGridView;
        private TabPage tabPage2;
        private Button button1;
        private Button Minbutton;
        private DataGridView DiffanSimpdataGridView;
        private Button MostSuccSt_Button;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
    }
}