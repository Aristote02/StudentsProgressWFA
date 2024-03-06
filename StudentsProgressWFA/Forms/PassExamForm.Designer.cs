namespace StudentsProgressWFA
{
    partial class PassExamForm
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
            this.passExdataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxIdPassEx = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxpassexstName = new System.Windows.Forms.TextBox();
            this.textBoxpassExTesttype = new System.Windows.Forms.TextBox();
            this.textBoxpassExPoint = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.passEx_buttonInsert = new System.Windows.Forms.Button();
            this.passEx_buttonUpdate = new System.Windows.Forms.Button();
            this.passEx_buttonDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.passExdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // passExdataGridView
            // 
            this.passExdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.passExdataGridView.Location = new System.Drawing.Point(347, 99);
            this.passExdataGridView.Name = "passExdataGridView";
            this.passExdataGridView.RowTemplate.Height = 25;
            this.passExdataGridView.Size = new System.Drawing.Size(417, 161);
            this.passExdataGridView.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(31, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID";
            // 
            // textBoxIdPassEx
            // 
            this.textBoxIdPassEx.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxIdPassEx.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxIdPassEx.Location = new System.Drawing.Point(147, 106);
            this.textBoxIdPassEx.Name = "textBoxIdPassEx";
            this.textBoxIdPassEx.Size = new System.Drawing.Size(170, 23);
            this.textBoxIdPassEx.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(31, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "StudentName";
            // 
            // textBoxpassexstName
            // 
            this.textBoxpassexstName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxpassexstName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxpassexstName.Location = new System.Drawing.Point(147, 149);
            this.textBoxpassexstName.Name = "textBoxpassexstName";
            this.textBoxpassexstName.Size = new System.Drawing.Size(170, 23);
            this.textBoxpassexstName.TabIndex = 4;
            this.textBoxpassexstName.TextChanged += new System.EventHandler(this.textBoxpassexstName_TextChanged);
            // 
            // textBoxpassExTesttype
            // 
            this.textBoxpassExTesttype.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxpassExTesttype.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxpassExTesttype.Location = new System.Drawing.Point(147, 193);
            this.textBoxpassExTesttype.Name = "textBoxpassExTesttype";
            this.textBoxpassExTesttype.Size = new System.Drawing.Size(170, 23);
            this.textBoxpassExTesttype.TabIndex = 5;
            this.textBoxpassExTesttype.TextChanged += new System.EventHandler(this.textBoxpassExTesttype_TextChanged);
            // 
            // textBoxpassExPoint
            // 
            this.textBoxpassExPoint.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxpassExPoint.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxpassExPoint.Location = new System.Drawing.Point(147, 237);
            this.textBoxpassExPoint.Name = "textBoxpassExPoint";
            this.textBoxpassExPoint.Size = new System.Drawing.Size(170, 23);
            this.textBoxpassExPoint.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(31, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "TestType";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(31, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Point";
            // 
            // passEx_buttonInsert
            // 
            this.passEx_buttonInsert.AccessibleDescription = "";
            this.passEx_buttonInsert.AccessibleName = "";
            this.passEx_buttonInsert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.passEx_buttonInsert.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.passEx_buttonInsert.Location = new System.Drawing.Point(50, 320);
            this.passEx_buttonInsert.Name = "passEx_buttonInsert";
            this.passEx_buttonInsert.Size = new System.Drawing.Size(75, 31);
            this.passEx_buttonInsert.TabIndex = 9;
            this.passEx_buttonInsert.Tag = "";
            this.passEx_buttonInsert.Text = "INSERT";
            this.passEx_buttonInsert.UseVisualStyleBackColor = true;
            this.passEx_buttonInsert.Click += new System.EventHandler(this.passEx_buttonInsert_Click);
            // 
            // passEx_buttonUpdate
            // 
            this.passEx_buttonUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.passEx_buttonUpdate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.passEx_buttonUpdate.Location = new System.Drawing.Point(158, 320);
            this.passEx_buttonUpdate.Name = "passEx_buttonUpdate";
            this.passEx_buttonUpdate.Size = new System.Drawing.Size(75, 31);
            this.passEx_buttonUpdate.TabIndex = 10;
            this.passEx_buttonUpdate.Text = "UPDATE";
            this.passEx_buttonUpdate.UseVisualStyleBackColor = true;
            this.passEx_buttonUpdate.Click += new System.EventHandler(this.passEx_buttonUpdate_Click);
            // 
            // passEx_buttonDelete
            // 
            this.passEx_buttonDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.passEx_buttonDelete.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.passEx_buttonDelete.Location = new System.Drawing.Point(284, 320);
            this.passEx_buttonDelete.Name = "passEx_buttonDelete";
            this.passEx_buttonDelete.Size = new System.Drawing.Size(75, 31);
            this.passEx_buttonDelete.TabIndex = 11;
            this.passEx_buttonDelete.Text = "DELETE";
            this.passEx_buttonDelete.UseVisualStyleBackColor = true;
            this.passEx_buttonDelete.Click += new System.EventHandler(this.passEx_buttonDelete_Click);
            // 
            // PassExamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::StudentsProgressWFA.Properties.Resources.PassExamimage2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.passEx_buttonDelete);
            this.Controls.Add(this.passEx_buttonUpdate);
            this.Controls.Add(this.passEx_buttonInsert);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxpassExPoint);
            this.Controls.Add(this.textBoxpassExTesttype);
            this.Controls.Add(this.textBoxpassexstName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxIdPassEx);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.passExdataGridView);
            this.Name = "PassExamForm";
            this.Text = "PassExamForm";
            this.Load += new System.EventHandler(this.PassExamForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.passExdataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView passExdataGridView;
        private Label label1;
        private TextBox textBoxIdPassEx;
        private Label label2;
        private TextBox textBoxpassexstName;
        private TextBox textBoxpassExTesttype;
        private TextBox textBoxpassExPoint;
        private Label label3;
        private Label label4;
        private Button passEx_buttonInsert;
        private Button passEx_buttonUpdate;
        private Button passEx_buttonDelete;
    }
}