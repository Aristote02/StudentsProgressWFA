namespace StudentsProgressWFA
{
    partial class StudentForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.studentGridView = new System.Windows.Forms.DataGridView();
            this.Stlabel = new System.Windows.Forms.Label();
            this.stNametextBox = new System.Windows.Forms.TextBox();
            this.IDlabel = new System.Windows.Forms.Label();
            this.stIDtextBox = new System.Windows.Forms.TextBox();
            this.FacultyIDlabel = new System.Windows.Forms.Label();
            this.GroupIDlabel = new System.Windows.Forms.Label();
            this.SpecialtyIDlabel = new System.Windows.Forms.Label();
            this.GrIDtextBox = new System.Windows.Forms.TextBox();
            this.SpecIDtextBox = new System.Windows.Forms.TextBox();
            this.FacIDtextBox = new System.Windows.Forms.TextBox();
            this.Insertbutton = new System.Windows.Forms.Button();
            this.Updatebutton = new System.Windows.Forms.Button();
            this.Deletebutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.studentGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // studentGridView
            // 
            this.studentGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentGridView.Location = new System.Drawing.Point(261, 103);
            this.studentGridView.Name = "studentGridView";
            this.studentGridView.RowTemplate.Height = 25;
            this.studentGridView.Size = new System.Drawing.Size(527, 206);
            this.studentGridView.TabIndex = 0;
            // 
            // Stlabel
            // 
            this.Stlabel.AutoSize = true;
            this.Stlabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Stlabel.Location = new System.Drawing.Point(7, 145);
            this.Stlabel.Name = "Stlabel";
            this.Stlabel.Size = new System.Drawing.Size(40, 15);
            this.Stlabel.TabIndex = 1;
            this.Stlabel.Text = "Name";
            // 
            // stNametextBox
            // 
            this.stNametextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.stNametextBox.Location = new System.Drawing.Point(94, 137);
            this.stNametextBox.Name = "stNametextBox";
            this.stNametextBox.Size = new System.Drawing.Size(138, 23);
            this.stNametextBox.TabIndex = 2;
            this.stNametextBox.TextChanged += new System.EventHandler(this.stNametextBox_TextChanged);
            // 
            // IDlabel
            // 
            this.IDlabel.AutoSize = true;
            this.IDlabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.IDlabel.Location = new System.Drawing.Point(7, 111);
            this.IDlabel.Name = "IDlabel";
            this.IDlabel.Size = new System.Drawing.Size(20, 15);
            this.IDlabel.TabIndex = 3;
            this.IDlabel.Text = "ID";
            this.IDlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // stIDtextBox
            // 
            this.stIDtextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.stIDtextBox.Location = new System.Drawing.Point(94, 103);
            this.stIDtextBox.Name = "stIDtextBox";
            this.stIDtextBox.Size = new System.Drawing.Size(138, 23);
            this.stIDtextBox.TabIndex = 4;
            this.stIDtextBox.TextChanged += new System.EventHandler(this.stIDtextBox_TextChanged);
            // 
            // FacultyIDlabel
            // 
            this.FacultyIDlabel.AutoSize = true;
            this.FacultyIDlabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FacultyIDlabel.Location = new System.Drawing.Point(7, 178);
            this.FacultyIDlabel.Name = "FacultyIDlabel";
            this.FacultyIDlabel.Size = new System.Drawing.Size(46, 15);
            this.FacultyIDlabel.TabIndex = 5;
            this.FacultyIDlabel.Text = "Faculty";
            // 
            // GroupIDlabel
            // 
            this.GroupIDlabel.AutoSize = true;
            this.GroupIDlabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.GroupIDlabel.Location = new System.Drawing.Point(7, 240);
            this.GroupIDlabel.Name = "GroupIDlabel";
            this.GroupIDlabel.Size = new System.Drawing.Size(42, 15);
            this.GroupIDlabel.TabIndex = 6;
            this.GroupIDlabel.Text = "Group";
            // 
            // SpecialtyIDlabel
            // 
            this.SpecialtyIDlabel.AutoSize = true;
            this.SpecialtyIDlabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SpecialtyIDlabel.Location = new System.Drawing.Point(7, 211);
            this.SpecialtyIDlabel.Name = "SpecialtyIDlabel";
            this.SpecialtyIDlabel.Size = new System.Drawing.Size(57, 15);
            this.SpecialtyIDlabel.TabIndex = 7;
            this.SpecialtyIDlabel.Text = "Specialty";
            // 
            // GrIDtextBox
            // 
            this.GrIDtextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.GrIDtextBox.Location = new System.Drawing.Point(94, 232);
            this.GrIDtextBox.Name = "GrIDtextBox";
            this.GrIDtextBox.Size = new System.Drawing.Size(138, 23);
            this.GrIDtextBox.TabIndex = 8;
            this.GrIDtextBox.TextChanged += new System.EventHandler(this.GrIDtextBox_TextChanged);
            // 
            // SpecIDtextBox
            // 
            this.SpecIDtextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SpecIDtextBox.Location = new System.Drawing.Point(94, 203);
            this.SpecIDtextBox.Name = "SpecIDtextBox";
            this.SpecIDtextBox.Size = new System.Drawing.Size(138, 23);
            this.SpecIDtextBox.TabIndex = 9;
            this.SpecIDtextBox.TextChanged += new System.EventHandler(this.SpecIDtextBox_TextChanged);
            // 
            // FacIDtextBox
            // 
            this.FacIDtextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.FacIDtextBox.Location = new System.Drawing.Point(94, 170);
            this.FacIDtextBox.Name = "FacIDtextBox";
            this.FacIDtextBox.Size = new System.Drawing.Size(138, 23);
            this.FacIDtextBox.TabIndex = 10;
            this.FacIDtextBox.TextChanged += new System.EventHandler(this.FacIDtextBox_TextChanged);
            // 
            // Insertbutton
            // 
            this.Insertbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Insertbutton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Insertbutton.Location = new System.Drawing.Point(7, 279);
            this.Insertbutton.Name = "Insertbutton";
            this.Insertbutton.Size = new System.Drawing.Size(75, 30);
            this.Insertbutton.TabIndex = 11;
            this.Insertbutton.Text = "INSERT";
            this.Insertbutton.UseVisualStyleBackColor = true;
            this.Insertbutton.Click += new System.EventHandler(this.Insertbutton_Click);
            // 
            // Updatebutton
            // 
            this.Updatebutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Updatebutton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Updatebutton.Location = new System.Drawing.Point(94, 279);
            this.Updatebutton.Name = "Updatebutton";
            this.Updatebutton.Size = new System.Drawing.Size(75, 30);
            this.Updatebutton.TabIndex = 12;
            this.Updatebutton.Text = "UPDATE";
            this.Updatebutton.UseVisualStyleBackColor = true;
            this.Updatebutton.Click += new System.EventHandler(this.Updatebutton_Click);
            // 
            // Deletebutton
            // 
            this.Deletebutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Deletebutton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Deletebutton.Location = new System.Drawing.Point(184, 279);
            this.Deletebutton.Name = "Deletebutton";
            this.Deletebutton.Size = new System.Drawing.Size(75, 30);
            this.Deletebutton.TabIndex = 13;
            this.Deletebutton.Text = "DELETE";
            this.Deletebutton.UseVisualStyleBackColor = true;
            this.Deletebutton.Click += new System.EventHandler(this.Deletebutton_Click);
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::StudentsProgressWFA.Properties.Resources.StImage;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Deletebutton);
            this.Controls.Add(this.Updatebutton);
            this.Controls.Add(this.Insertbutton);
            this.Controls.Add(this.FacIDtextBox);
            this.Controls.Add(this.SpecIDtextBox);
            this.Controls.Add(this.GrIDtextBox);
            this.Controls.Add(this.SpecialtyIDlabel);
            this.Controls.Add(this.GroupIDlabel);
            this.Controls.Add(this.FacultyIDlabel);
            this.Controls.Add(this.stIDtextBox);
            this.Controls.Add(this.IDlabel);
            this.Controls.Add(this.stNametextBox);
            this.Controls.Add(this.Stlabel);
            this.Controls.Add(this.studentGridView);
            this.Name = "StudentForm";
            this.Text = "StudentForm";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studentGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView studentGridView;
        private Label Stlabel;
        private TextBox stNametextBox;
        private Label IDlabel;
        private TextBox stIDtextBox;
        private Label FacultyIDlabel;
        private Label GroupIDlabel;
        private Label SpecialtyIDlabel;
        private TextBox GrIDtextBox;
        private TextBox SpecIDtextBox;
        private TextBox FacIDtextBox;
        private Button Insertbutton;
        private Button Updatebutton;
        private Button Deletebutton;
    }
}