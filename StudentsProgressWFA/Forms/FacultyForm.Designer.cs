namespace StudentsProgressWFA
{
    partial class FacultyForm
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
            this.FacdataGridView = new System.Windows.Forms.DataGridView();
            this.labelF = new System.Windows.Forms.Label();
            this.labelname = new System.Windows.Forms.Label();
            this.IdtextBox = new System.Windows.Forms.TextBox();
            this.namefactextBox = new System.Windows.Forms.TextBox();
            this.Insertbutton = new System.Windows.Forms.Button();
            this.Updatefacbutton = new System.Windows.Forms.Button();
            this.Deletebutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.FacdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // FacdataGridView
            // 
            this.FacdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FacdataGridView.Location = new System.Drawing.Point(470, 130);
            this.FacdataGridView.Name = "FacdataGridView";
            this.FacdataGridView.RowTemplate.Height = 25;
            this.FacdataGridView.Size = new System.Drawing.Size(275, 162);
            this.FacdataGridView.TabIndex = 0;
            // 
            // labelF
            // 
            this.labelF.AutoSize = true;
            this.labelF.BackColor = System.Drawing.Color.Transparent;
            this.labelF.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelF.Location = new System.Drawing.Point(107, 139);
            this.labelF.Name = "labelF";
            this.labelF.Size = new System.Drawing.Size(20, 15);
            this.labelF.TabIndex = 1;
            this.labelF.Text = "ID";
            // 
            // labelname
            // 
            this.labelname.AutoSize = true;
            this.labelname.BackColor = System.Drawing.Color.Transparent;
            this.labelname.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelname.Location = new System.Drawing.Point(107, 178);
            this.labelname.Name = "labelname";
            this.labelname.Size = new System.Drawing.Size(40, 15);
            this.labelname.TabIndex = 2;
            this.labelname.Text = "Name";
            // 
            // IdtextBox
            // 
            this.IdtextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.IdtextBox.Location = new System.Drawing.Point(213, 131);
            this.IdtextBox.Name = "IdtextBox";
            this.IdtextBox.Size = new System.Drawing.Size(166, 23);
            this.IdtextBox.TabIndex = 3;
            // 
            // namefactextBox
            // 
            this.namefactextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.namefactextBox.Location = new System.Drawing.Point(213, 170);
            this.namefactextBox.Name = "namefactextBox";
            this.namefactextBox.Size = new System.Drawing.Size(166, 23);
            this.namefactextBox.TabIndex = 4;
            // 
            // Insertbutton
            // 
            this.Insertbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Insertbutton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Insertbutton.Location = new System.Drawing.Point(114, 259);
            this.Insertbutton.Name = "Insertbutton";
            this.Insertbutton.Size = new System.Drawing.Size(75, 33);
            this.Insertbutton.TabIndex = 5;
            this.Insertbutton.Text = "INSERT";
            this.Insertbutton.UseVisualStyleBackColor = true;
            this.Insertbutton.Click += new System.EventHandler(this.Insertbutton_Click);
            // 
            // Updatefacbutton
            // 
            this.Updatefacbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Updatefacbutton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Updatefacbutton.Location = new System.Drawing.Point(229, 259);
            this.Updatefacbutton.Name = "Updatefacbutton";
            this.Updatefacbutton.Size = new System.Drawing.Size(75, 33);
            this.Updatefacbutton.TabIndex = 6;
            this.Updatefacbutton.Text = "UPDATE";
            this.Updatefacbutton.UseVisualStyleBackColor = true;
            this.Updatefacbutton.Click += new System.EventHandler(this.Updatefacbutton_Click);
            // 
            // Deletebutton
            // 
            this.Deletebutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Deletebutton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Deletebutton.Location = new System.Drawing.Point(349, 259);
            this.Deletebutton.Name = "Deletebutton";
            this.Deletebutton.Size = new System.Drawing.Size(75, 33);
            this.Deletebutton.TabIndex = 7;
            this.Deletebutton.Text = "DELETE";
            this.Deletebutton.UseVisualStyleBackColor = true;
            this.Deletebutton.Click += new System.EventHandler(this.Deletebutton_Click);
            // 
            // FacultyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::StudentsProgressWFA.Properties.Resources.Faculty_image;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Deletebutton);
            this.Controls.Add(this.Updatefacbutton);
            this.Controls.Add(this.Insertbutton);
            this.Controls.Add(this.namefactextBox);
            this.Controls.Add(this.IdtextBox);
            this.Controls.Add(this.labelname);
            this.Controls.Add(this.labelF);
            this.Controls.Add(this.FacdataGridView);
            this.Name = "FacultyForm";
            this.Text = "FacultyForm";
            this.Load += new System.EventHandler(this.FacultyForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FacdataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView FacdataGridView;
        private Label labelF;
        private Label labelname;
        private TextBox IdtextBox;
        private TextBox namefactextBox;
        private Button Insertbutton;
        private Button Updatefacbutton;
        private Button Deletebutton;
    }
}