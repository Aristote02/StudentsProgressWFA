namespace StudentsProgressWFA
{
    partial class SpecialtyForm
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
            this.idtextBox = new System.Windows.Forms.TextBox();
            this.SpecialtydataGridView = new System.Windows.Forms.DataGridView();
            this.labelname = new System.Windows.Forms.Label();
            this.nametextBox = new System.Windows.Forms.TextBox();
            this.insertbutton = new System.Windows.Forms.Button();
            this.deletebutton = new System.Windows.Forms.Button();
            this.Updatebutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SpecialtydataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // labelid
            // 
            this.labelid.AutoSize = true;
            this.labelid.BackColor = System.Drawing.Color.Transparent;
            this.labelid.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelid.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelid.Location = new System.Drawing.Point(42, 143);
            this.labelid.Name = "labelid";
            this.labelid.Size = new System.Drawing.Size(20, 15);
            this.labelid.TabIndex = 0;
            this.labelid.Text = "ID";
            // 
            // idtextBox
            // 
            this.idtextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.idtextBox.Location = new System.Drawing.Point(139, 135);
            this.idtextBox.Name = "idtextBox";
            this.idtextBox.Size = new System.Drawing.Size(151, 23);
            this.idtextBox.TabIndex = 1;
            // 
            // SpecialtydataGridView
            // 
            this.SpecialtydataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SpecialtydataGridView.Location = new System.Drawing.Point(395, 143);
            this.SpecialtydataGridView.Name = "SpecialtydataGridView";
            this.SpecialtydataGridView.RowTemplate.Height = 25;
            this.SpecialtydataGridView.Size = new System.Drawing.Size(274, 171);
            this.SpecialtydataGridView.TabIndex = 2;
            // 
            // labelname
            // 
            this.labelname.AutoSize = true;
            this.labelname.BackColor = System.Drawing.Color.Transparent;
            this.labelname.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelname.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelname.Location = new System.Drawing.Point(42, 209);
            this.labelname.Name = "labelname";
            this.labelname.Size = new System.Drawing.Size(40, 15);
            this.labelname.TabIndex = 3;
            this.labelname.Text = "Name";
            // 
            // nametextBox
            // 
            this.nametextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nametextBox.Location = new System.Drawing.Point(139, 201);
            this.nametextBox.Name = "nametextBox";
            this.nametextBox.Size = new System.Drawing.Size(151, 23);
            this.nametextBox.TabIndex = 4;
            // 
            // insertbutton
            // 
            this.insertbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.insertbutton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.insertbutton.Location = new System.Drawing.Point(42, 278);
            this.insertbutton.Name = "insertbutton";
            this.insertbutton.Size = new System.Drawing.Size(75, 36);
            this.insertbutton.TabIndex = 5;
            this.insertbutton.Text = "INSERT";
            this.insertbutton.UseVisualStyleBackColor = true;
            this.insertbutton.Click += new System.EventHandler(this.insertbutton_Click);
            // 
            // deletebutton
            // 
            this.deletebutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deletebutton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.deletebutton.Location = new System.Drawing.Point(284, 278);
            this.deletebutton.Name = "deletebutton";
            this.deletebutton.Size = new System.Drawing.Size(75, 36);
            this.deletebutton.TabIndex = 6;
            this.deletebutton.Text = "DELETE";
            this.deletebutton.UseVisualStyleBackColor = true;
            this.deletebutton.Click += new System.EventHandler(this.deletebutton_Click);
            // 
            // Updatebutton
            // 
            this.Updatebutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Updatebutton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Updatebutton.Location = new System.Drawing.Point(161, 278);
            this.Updatebutton.Name = "Updatebutton";
            this.Updatebutton.Size = new System.Drawing.Size(75, 36);
            this.Updatebutton.TabIndex = 7;
            this.Updatebutton.Text = "UPDATE";
            this.Updatebutton.UseVisualStyleBackColor = true;
            this.Updatebutton.Click += new System.EventHandler(this.Updatebutton_Click);
            // 
            // SpecialtyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::StudentsProgressWFA.Properties.Resources.SpecialtyImage;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Updatebutton);
            this.Controls.Add(this.deletebutton);
            this.Controls.Add(this.insertbutton);
            this.Controls.Add(this.nametextBox);
            this.Controls.Add(this.labelname);
            this.Controls.Add(this.SpecialtydataGridView);
            this.Controls.Add(this.idtextBox);
            this.Controls.Add(this.labelid);
            this.Name = "SpecialtyForm";
            this.Text = "SpecialtyForm";
            this.Load += new System.EventHandler(this.SpecialtyForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SpecialtydataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelid;
        private TextBox idtextBox;
        private DataGridView SpecialtydataGridView;
        private Label labelname;
        private TextBox nametextBox;
        private Button insertbutton;
        private Button deletebutton;
        private Button Updatebutton;
    }
}