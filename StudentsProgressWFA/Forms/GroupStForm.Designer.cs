namespace StudentsProgressWFA
{
    partial class GroupStForm
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
            this.labelid = new System.Windows.Forms.Label();
            this.IdtextBox = new System.Windows.Forms.TextBox();
            this.labelname = new System.Windows.Forms.Label();
            this.grNametextBox = new System.Windows.Forms.TextBox();
            this.GrdataGridView = new System.Windows.Forms.DataGridView();
            this.Insertbutton = new System.Windows.Forms.Button();
            this.Deletebutton = new System.Windows.Forms.Button();
            this.Updatebutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GrdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // labelid
            // 
            this.labelid.AutoSize = true;
            this.labelid.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelid.Location = new System.Drawing.Point(79, 185);
            this.labelid.Name = "labelid";
            this.labelid.Size = new System.Drawing.Size(20, 15);
            this.labelid.TabIndex = 0;
            this.labelid.Text = "ID";
            // 
            // IdtextBox
            // 
            this.IdtextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.IdtextBox.Location = new System.Drawing.Point(166, 185);
            this.IdtextBox.Name = "IdtextBox";
            this.IdtextBox.Size = new System.Drawing.Size(114, 23);
            this.IdtextBox.TabIndex = 1;
            // 
            // labelname
            // 
            this.labelname.AutoSize = true;
            this.labelname.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelname.Location = new System.Drawing.Point(79, 234);
            this.labelname.Name = "labelname";
            this.labelname.Size = new System.Drawing.Size(75, 15);
            this.labelname.TabIndex = 2;
            this.labelname.Text = "GroupName";
            // 
            // grNametextBox
            // 
            this.grNametextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.grNametextBox.Location = new System.Drawing.Point(166, 226);
            this.grNametextBox.Name = "grNametextBox";
            this.grNametextBox.Size = new System.Drawing.Size(114, 23);
            this.grNametextBox.TabIndex = 3;
            // 
            // GrdataGridView
            // 
            this.GrdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrdataGridView.Location = new System.Drawing.Point(466, 185);
            this.GrdataGridView.Name = "GrdataGridView";
            this.GrdataGridView.RowTemplate.Height = 25;
            this.GrdataGridView.Size = new System.Drawing.Size(271, 150);
            this.GrdataGridView.TabIndex = 4;
            // 
            // Insertbutton
            // 
            this.Insertbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Insertbutton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Insertbutton.Location = new System.Drawing.Point(79, 305);
            this.Insertbutton.Name = "Insertbutton";
            this.Insertbutton.Size = new System.Drawing.Size(75, 30);
            this.Insertbutton.TabIndex = 5;
            this.Insertbutton.Text = "INSERT";
            this.Insertbutton.UseVisualStyleBackColor = true;
            this.Insertbutton.Click += new System.EventHandler(this.Insertbutton_Click);
            // 
            // Deletebutton
            // 
            this.Deletebutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Deletebutton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Deletebutton.Location = new System.Drawing.Point(335, 305);
            this.Deletebutton.Name = "Deletebutton";
            this.Deletebutton.Size = new System.Drawing.Size(75, 30);
            this.Deletebutton.TabIndex = 6;
            this.Deletebutton.Text = "DELETE";
            this.Deletebutton.UseVisualStyleBackColor = true;
            this.Deletebutton.Click += new System.EventHandler(this.Deletebutton_Click);
            // 
            // Updatebutton
            // 
            this.Updatebutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Updatebutton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Updatebutton.Location = new System.Drawing.Point(205, 305);
            this.Updatebutton.Name = "Updatebutton";
            this.Updatebutton.Size = new System.Drawing.Size(75, 30);
            this.Updatebutton.TabIndex = 7;
            this.Updatebutton.Text = "UPDATE";
            this.Updatebutton.UseVisualStyleBackColor = true;
            this.Updatebutton.Click += new System.EventHandler(this.Updatebutton_Click);
            // 
            // GroupStForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::StudentsProgressWFA.Properties.Resources.GroupOfStImage;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Updatebutton);
            this.Controls.Add(this.Deletebutton);
            this.Controls.Add(this.Insertbutton);
            this.Controls.Add(this.GrdataGridView);
            this.Controls.Add(this.grNametextBox);
            this.Controls.Add(this.labelname);
            this.Controls.Add(this.IdtextBox);
            this.Controls.Add(this.labelid);
            this.Name = "GroupStForm";
            this.Text = "GroupStForm";
            this.Load += new System.EventHandler(this.GroupStForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GrdataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelid;
        private TextBox IdtextBox;
        private Label labelname;
        private TextBox grNametextBox;
        private DataGridView GrdataGridView;
        private Button Insertbutton;
        private Button Deletebutton;
        private Button Updatebutton;
    }
}