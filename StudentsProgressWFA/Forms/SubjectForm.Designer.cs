namespace StudentsProgressWFA
{
    partial class SubjectForm
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
            this.SubjectdataGridView = new System.Windows.Forms.DataGridView();
            this.Idlabel = new System.Windows.Forms.Label();
            this.IdtextBox = new System.Windows.Forms.TextBox();
            this.namelabel = new System.Windows.Forms.Label();
            this.nametextBox = new System.Windows.Forms.TextBox();
            this.Insertbutton = new System.Windows.Forms.Button();
            this.Deletebutton = new System.Windows.Forms.Button();
            this.Updatebutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SubjectdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // SubjectdataGridView
            // 
            this.SubjectdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SubjectdataGridView.Location = new System.Drawing.Point(479, 140);
            this.SubjectdataGridView.Name = "SubjectdataGridView";
            this.SubjectdataGridView.RowTemplate.Height = 25;
            this.SubjectdataGridView.Size = new System.Drawing.Size(268, 166);
            this.SubjectdataGridView.TabIndex = 0;
            // 
            // Idlabel
            // 
            this.Idlabel.AutoSize = true;
            this.Idlabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Idlabel.Location = new System.Drawing.Point(66, 148);
            this.Idlabel.Name = "Idlabel";
            this.Idlabel.Size = new System.Drawing.Size(20, 15);
            this.Idlabel.TabIndex = 1;
            this.Idlabel.Text = "ID";
            // 
            // IdtextBox
            // 
            this.IdtextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.IdtextBox.Location = new System.Drawing.Point(175, 140);
            this.IdtextBox.Name = "IdtextBox";
            this.IdtextBox.Size = new System.Drawing.Size(136, 23);
            this.IdtextBox.TabIndex = 2;
            // 
            // namelabel
            // 
            this.namelabel.AutoSize = true;
            this.namelabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.namelabel.Location = new System.Drawing.Point(66, 204);
            this.namelabel.Name = "namelabel";
            this.namelabel.Size = new System.Drawing.Size(40, 15);
            this.namelabel.TabIndex = 3;
            this.namelabel.Text = "Name";
            // 
            // nametextBox
            // 
            this.nametextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nametextBox.Location = new System.Drawing.Point(175, 201);
            this.nametextBox.Name = "nametextBox";
            this.nametextBox.Size = new System.Drawing.Size(136, 23);
            this.nametextBox.TabIndex = 4;
            // 
            // Insertbutton
            // 
            this.Insertbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Insertbutton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Insertbutton.Location = new System.Drawing.Point(65, 272);
            this.Insertbutton.Name = "Insertbutton";
            this.Insertbutton.Size = new System.Drawing.Size(80, 34);
            this.Insertbutton.TabIndex = 5;
            this.Insertbutton.Text = "INSERT";
            this.Insertbutton.UseVisualStyleBackColor = true;
            this.Insertbutton.Click += new System.EventHandler(this.Insertbutton_Click);
            // 
            // Deletebutton
            // 
            this.Deletebutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Deletebutton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Deletebutton.Location = new System.Drawing.Point(329, 272);
            this.Deletebutton.Name = "Deletebutton";
            this.Deletebutton.Size = new System.Drawing.Size(80, 34);
            this.Deletebutton.TabIndex = 6;
            this.Deletebutton.Text = "DELETE";
            this.Deletebutton.UseVisualStyleBackColor = true;
            this.Deletebutton.Click += new System.EventHandler(this.Deletebutton_Click);
            // 
            // Updatebutton
            // 
            this.Updatebutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Updatebutton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Updatebutton.Location = new System.Drawing.Point(198, 272);
            this.Updatebutton.Name = "Updatebutton";
            this.Updatebutton.Size = new System.Drawing.Size(80, 34);
            this.Updatebutton.TabIndex = 7;
            this.Updatebutton.Text = "UPDATE";
            this.Updatebutton.UseVisualStyleBackColor = true;
            this.Updatebutton.Click += new System.EventHandler(this.Updatebutton_Click);
            // 
            // SubjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::StudentsProgressWFA.Properties.Resources.pexels_george_pak_7972506;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Updatebutton);
            this.Controls.Add(this.Deletebutton);
            this.Controls.Add(this.Insertbutton);
            this.Controls.Add(this.nametextBox);
            this.Controls.Add(this.namelabel);
            this.Controls.Add(this.IdtextBox);
            this.Controls.Add(this.Idlabel);
            this.Controls.Add(this.SubjectdataGridView);
            this.Name = "SubjectForm";
            this.Text = "SubjectForm";
            this.Load += new System.EventHandler(this.SubjectForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SubjectdataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView SubjectdataGridView;
        private Label Idlabel;
        private TextBox IdtextBox;
        private Label namelabel;
        private TextBox nametextBox;
        private Button Insertbutton;
        private Button Deletebutton;
        private Button Updatebutton;
    }
}