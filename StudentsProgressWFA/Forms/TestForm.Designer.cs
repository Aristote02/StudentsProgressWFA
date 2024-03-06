namespace StudentsProgressWFA
{
    partial class TestForm
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
            this.TestdataGridView = new System.Windows.Forms.DataGridView();
            this.IDlabel = new System.Windows.Forms.Label();
            this.IDtextBox = new System.Windows.Forms.TextBox();
            this.Datelabel = new System.Windows.Forms.Label();
            this.Typelabel = new System.Windows.Forms.Label();
            this.labelsubject = new System.Windows.Forms.Label();
            this.SubjecttextBox = new System.Windows.Forms.TextBox();
            this.TypetextBox = new System.Windows.Forms.TextBox();
            this.DatetextBox = new System.Windows.Forms.TextBox();
            this.Insertbutton = new System.Windows.Forms.Button();
            this.Deletebutton = new System.Windows.Forms.Button();
            this.Updatebutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TestdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // TestdataGridView
            // 
            this.TestdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TestdataGridView.Location = new System.Drawing.Point(335, 112);
            this.TestdataGridView.Name = "TestdataGridView";
            this.TestdataGridView.RowTemplate.Height = 25;
            this.TestdataGridView.Size = new System.Drawing.Size(444, 205);
            this.TestdataGridView.TabIndex = 0;
            // 
            // IDlabel
            // 
            this.IDlabel.AutoSize = true;
            this.IDlabel.BackColor = System.Drawing.Color.LightGray;
            this.IDlabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.IDlabel.ForeColor = System.Drawing.Color.Black;
            this.IDlabel.Location = new System.Drawing.Point(30, 124);
            this.IDlabel.MaximumSize = new System.Drawing.Size(0, 50);
            this.IDlabel.Name = "IDlabel";
            this.IDlabel.Size = new System.Drawing.Size(20, 15);
            this.IDlabel.TabIndex = 1;
            this.IDlabel.Text = "ID";
            // 
            // IDtextBox
            // 
            this.IDtextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.IDtextBox.Location = new System.Drawing.Point(96, 116);
            this.IDtextBox.Name = "IDtextBox";
            this.IDtextBox.Size = new System.Drawing.Size(124, 23);
            this.IDtextBox.TabIndex = 2;
            // 
            // Datelabel
            // 
            this.Datelabel.AutoSize = true;
            this.Datelabel.BackColor = System.Drawing.Color.Transparent;
            this.Datelabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Datelabel.ForeColor = System.Drawing.Color.LightGray;
            this.Datelabel.Location = new System.Drawing.Point(30, 247);
            this.Datelabel.MaximumSize = new System.Drawing.Size(0, 50);
            this.Datelabel.Name = "Datelabel";
            this.Datelabel.Size = new System.Drawing.Size(34, 15);
            this.Datelabel.TabIndex = 3;
            this.Datelabel.Text = "Date";
            // 
            // Typelabel
            // 
            this.Typelabel.AutoSize = true;
            this.Typelabel.BackColor = System.Drawing.Color.Transparent;
            this.Typelabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Typelabel.ForeColor = System.Drawing.Color.LightGray;
            this.Typelabel.Location = new System.Drawing.Point(30, 210);
            this.Typelabel.MaximumSize = new System.Drawing.Size(0, 50);
            this.Typelabel.Name = "Typelabel";
            this.Typelabel.Size = new System.Drawing.Size(33, 15);
            this.Typelabel.TabIndex = 4;
            this.Typelabel.Text = "Type";
            // 
            // labelsubject
            // 
            this.labelsubject.AutoSize = true;
            this.labelsubject.BackColor = System.Drawing.Color.LightGray;
            this.labelsubject.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelsubject.ForeColor = System.Drawing.Color.Black;
            this.labelsubject.Location = new System.Drawing.Point(30, 169);
            this.labelsubject.MaximumSize = new System.Drawing.Size(0, 50);
            this.labelsubject.Name = "labelsubject";
            this.labelsubject.Size = new System.Drawing.Size(49, 15);
            this.labelsubject.TabIndex = 5;
            this.labelsubject.Text = "Subject";
            // 
            // SubjecttextBox
            // 
            this.SubjecttextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SubjecttextBox.Location = new System.Drawing.Point(96, 161);
            this.SubjecttextBox.Name = "SubjecttextBox";
            this.SubjecttextBox.Size = new System.Drawing.Size(124, 23);
            this.SubjecttextBox.TabIndex = 6;
            // 
            // TypetextBox
            // 
            this.TypetextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TypetextBox.Location = new System.Drawing.Point(96, 202);
            this.TypetextBox.Name = "TypetextBox";
            this.TypetextBox.Size = new System.Drawing.Size(124, 23);
            this.TypetextBox.TabIndex = 7;
            // 
            // DatetextBox
            // 
            this.DatetextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.DatetextBox.Location = new System.Drawing.Point(96, 244);
            this.DatetextBox.Name = "DatetextBox";
            this.DatetextBox.Size = new System.Drawing.Size(124, 23);
            this.DatetextBox.TabIndex = 8;
            // 
            // Insertbutton
            // 
            this.Insertbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Insertbutton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Insertbutton.Location = new System.Drawing.Point(4, 284);
            this.Insertbutton.Name = "Insertbutton";
            this.Insertbutton.Size = new System.Drawing.Size(75, 33);
            this.Insertbutton.TabIndex = 9;
            this.Insertbutton.Text = "INSERT";
            this.Insertbutton.UseVisualStyleBackColor = true;
            this.Insertbutton.Click += new System.EventHandler(this.Insertbutton_Click);
            // 
            // Deletebutton
            // 
            this.Deletebutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Deletebutton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Deletebutton.Location = new System.Drawing.Point(234, 284);
            this.Deletebutton.Name = "Deletebutton";
            this.Deletebutton.Size = new System.Drawing.Size(75, 33);
            this.Deletebutton.TabIndex = 10;
            this.Deletebutton.Text = "DELETE";
            this.Deletebutton.UseVisualStyleBackColor = true;
            this.Deletebutton.Click += new System.EventHandler(this.Deletebutton_Click);
            // 
            // Updatebutton
            // 
            this.Updatebutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Updatebutton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Updatebutton.Location = new System.Drawing.Point(115, 284);
            this.Updatebutton.Name = "Updatebutton";
            this.Updatebutton.Size = new System.Drawing.Size(75, 33);
            this.Updatebutton.TabIndex = 11;
            this.Updatebutton.Text = "UPDATE";
            this.Updatebutton.UseVisualStyleBackColor = true;
            this.Updatebutton.Click += new System.EventHandler(this.Updatebutton_Click);
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::StudentsProgressWFA.Properties.Resources.TestImage;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Updatebutton);
            this.Controls.Add(this.Deletebutton);
            this.Controls.Add(this.Insertbutton);
            this.Controls.Add(this.DatetextBox);
            this.Controls.Add(this.TypetextBox);
            this.Controls.Add(this.SubjecttextBox);
            this.Controls.Add(this.labelsubject);
            this.Controls.Add(this.Typelabel);
            this.Controls.Add(this.Datelabel);
            this.Controls.Add(this.IDtextBox);
            this.Controls.Add(this.IDlabel);
            this.Controls.Add(this.TestdataGridView);
            this.Name = "TestForm";
            this.Text = "TestForm";
            this.Load += new System.EventHandler(this.TestForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TestdataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView TestdataGridView;
        private Label IDlabel;
        private TextBox IDtextBox;
        private Label Datelabel;
        private Label Typelabel;
        private Label labelsubject;
        private TextBox SubjecttextBox;
        private TextBox TypetextBox;
        private TextBox DatetextBox;
        private Button Insertbutton;
        private Button Deletebutton;
        private Button Updatebutton;
    }
}