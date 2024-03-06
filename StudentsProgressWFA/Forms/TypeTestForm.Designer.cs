namespace StudentsProgressWFA
{
    partial class TypeTestForm
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
            this.TypetestdataGridView = new System.Windows.Forms.DataGridView();
            this.IDlabel = new System.Windows.Forms.Label();
            this.IdtextBox = new System.Windows.Forms.TextBox();
            this.Namelabel = new System.Windows.Forms.Label();
            this.NameTexbox = new System.Windows.Forms.TextBox();
            this.Insertbutton = new System.Windows.Forms.Button();
            this.Deletebutton = new System.Windows.Forms.Button();
            this.Updatebutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TypetestdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // TypetestdataGridView
            // 
            this.TypetestdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TypetestdataGridView.Location = new System.Drawing.Point(381, 158);
            this.TypetestdataGridView.Name = "TypetestdataGridView";
            this.TypetestdataGridView.RowTemplate.Height = 25;
            this.TypetestdataGridView.Size = new System.Drawing.Size(298, 149);
            this.TypetestdataGridView.TabIndex = 0;
            // 
            // IDlabel
            // 
            this.IDlabel.AutoSize = true;
            this.IDlabel.BackColor = System.Drawing.Color.Transparent;
            this.IDlabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.IDlabel.Location = new System.Drawing.Point(29, 166);
            this.IDlabel.Name = "IDlabel";
            this.IDlabel.Size = new System.Drawing.Size(20, 15);
            this.IDlabel.TabIndex = 1;
            this.IDlabel.Text = "ID";
            // 
            // IdtextBox
            // 
            this.IdtextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.IdtextBox.Location = new System.Drawing.Point(121, 158);
            this.IdtextBox.Name = "IdtextBox";
            this.IdtextBox.Size = new System.Drawing.Size(130, 23);
            this.IdtextBox.TabIndex = 2;
            // 
            // Namelabel
            // 
            this.Namelabel.AutoSize = true;
            this.Namelabel.BackColor = System.Drawing.Color.Transparent;
            this.Namelabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Namelabel.Location = new System.Drawing.Point(29, 224);
            this.Namelabel.Name = "Namelabel";
            this.Namelabel.Size = new System.Drawing.Size(40, 15);
            this.Namelabel.TabIndex = 3;
            this.Namelabel.Text = "Name";
            // 
            // NameTexbox
            // 
            this.NameTexbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NameTexbox.Location = new System.Drawing.Point(121, 216);
            this.NameTexbox.Name = "NameTexbox";
            this.NameTexbox.Size = new System.Drawing.Size(130, 23);
            this.NameTexbox.TabIndex = 4;
            // 
            // Insertbutton
            // 
            this.Insertbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Insertbutton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Insertbutton.Location = new System.Drawing.Point(29, 270);
            this.Insertbutton.Name = "Insertbutton";
            this.Insertbutton.Size = new System.Drawing.Size(75, 37);
            this.Insertbutton.TabIndex = 5;
            this.Insertbutton.Text = "INSERT";
            this.Insertbutton.UseVisualStyleBackColor = true;
            this.Insertbutton.Click += new System.EventHandler(this.Insertbutton_Click);
            // 
            // Deletebutton
            // 
            this.Deletebutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Deletebutton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Deletebutton.Location = new System.Drawing.Point(270, 270);
            this.Deletebutton.Name = "Deletebutton";
            this.Deletebutton.Size = new System.Drawing.Size(75, 37);
            this.Deletebutton.TabIndex = 6;
            this.Deletebutton.Text = "DELETE";
            this.Deletebutton.UseVisualStyleBackColor = true;
            this.Deletebutton.Click += new System.EventHandler(this.Deletebutton_Click);
            // 
            // Updatebutton
            // 
            this.Updatebutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Updatebutton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Updatebutton.Location = new System.Drawing.Point(144, 270);
            this.Updatebutton.Name = "Updatebutton";
            this.Updatebutton.Size = new System.Drawing.Size(75, 37);
            this.Updatebutton.TabIndex = 7;
            this.Updatebutton.Text = "UPDATE";
            this.Updatebutton.UseVisualStyleBackColor = true;
            this.Updatebutton.Click += new System.EventHandler(this.Updatebutton_Click);
            // 
            // TypeTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::StudentsProgressWFA.Properties.Resources.TypeTestImage;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Updatebutton);
            this.Controls.Add(this.Deletebutton);
            this.Controls.Add(this.Insertbutton);
            this.Controls.Add(this.NameTexbox);
            this.Controls.Add(this.Namelabel);
            this.Controls.Add(this.IdtextBox);
            this.Controls.Add(this.IDlabel);
            this.Controls.Add(this.TypetestdataGridView);
            this.Name = "TypeTestForm";
            this.Text = "TypeTestForm";
            this.Load += new System.EventHandler(this.TypeTestForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TypetestdataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView TypetestdataGridView;
        private Label IDlabel;
        private TextBox IdtextBox;
        private Label Namelabel;
        private TextBox NameTexbox;
        private Button Insertbutton;
        private Button Deletebutton;
        private Button Updatebutton;
    }
}