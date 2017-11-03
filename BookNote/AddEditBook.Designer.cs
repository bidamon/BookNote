namespace BookNote
{
    partial class AddEditBook
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.picture = new System.Windows.Forms.PictureBox();
            this.cbCategory = new MetroFramework.Controls.MetroComboBox();
            this.tbAuthor = new MetroFramework.Controls.MetroTextBox();
            this.tbTitle = new MetroFramework.Controls.MetroTextBox();
            this.btnBrowse = new MetroFramework.Controls.MetroButton();
            this.btnCancel = new MetroFramework.Controls.MetroButton();
            this.btnSave = new MetroFramework.Controls.MetroButton();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 109F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 217F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.picture, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.tbAuthor, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tbTitle, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.cbCategory, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnBrowse, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnCancel, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.btnSave, 2, 5);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(23, 78);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 147F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(408, 306);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Title:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Author:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Image:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Category:";
            // 
            // picture
            // 
            this.picture.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picture.Location = new System.Drawing.Point(147, 64);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(141, 140);
            this.picture.TabIndex = 1;
            this.picture.TabStop = false;
            // 
            // cbCategory
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.cbCategory, 2);
            this.cbCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.ItemHeight = 23;
            this.cbCategory.Location = new System.Drawing.Point(112, 241);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(293, 29);
            this.cbCategory.TabIndex = 2;
            this.cbCategory.UseSelectable = true;
            // 
            // tbAuthor
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.tbAuthor, 2);
            // 
            // 
            // 
            this.tbAuthor.CustomButton.Image = null;
            this.tbAuthor.CustomButton.Location = new System.Drawing.Point(271, 2);
            this.tbAuthor.CustomButton.Name = "";
            this.tbAuthor.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.tbAuthor.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbAuthor.CustomButton.TabIndex = 1;
            this.tbAuthor.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbAuthor.CustomButton.UseSelectable = true;
            this.tbAuthor.CustomButton.Visible = false;
            this.tbAuthor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbAuthor.Lines = new string[0];
            this.tbAuthor.Location = new System.Drawing.Point(112, 34);
            this.tbAuthor.MaxLength = 32767;
            this.tbAuthor.Name = "tbAuthor";
            this.tbAuthor.PasswordChar = '\0';
            this.tbAuthor.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbAuthor.SelectedText = "";
            this.tbAuthor.SelectionLength = 0;
            this.tbAuthor.SelectionStart = 0;
            this.tbAuthor.ShortcutsEnabled = true;
            this.tbAuthor.Size = new System.Drawing.Size(293, 24);
            this.tbAuthor.TabIndex = 3;
            this.tbAuthor.UseSelectable = true;
            this.tbAuthor.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbAuthor.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tbTitle
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.tbTitle, 2);
            // 
            // 
            // 
            this.tbTitle.CustomButton.Image = null;
            this.tbTitle.CustomButton.Location = new System.Drawing.Point(269, 1);
            this.tbTitle.CustomButton.Name = "";
            this.tbTitle.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.tbTitle.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbTitle.CustomButton.TabIndex = 1;
            this.tbTitle.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbTitle.CustomButton.UseSelectable = true;
            this.tbTitle.CustomButton.Visible = false;
            this.tbTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbTitle.Lines = new string[0];
            this.tbTitle.Location = new System.Drawing.Point(112, 3);
            this.tbTitle.MaxLength = 32767;
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.PasswordChar = '\0';
            this.tbTitle.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbTitle.SelectedText = "";
            this.tbTitle.SelectionLength = 0;
            this.tbTitle.SelectionStart = 0;
            this.tbTitle.ShortcutsEnabled = true;
            this.tbTitle.Size = new System.Drawing.Size(293, 25);
            this.tbTitle.TabIndex = 3;
            this.tbTitle.UseSelectable = true;
            this.tbTitle.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbTitle.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBrowse.Location = new System.Drawing.Point(180, 211);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 4;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseSelectable = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(248, 277);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseSelectable = true;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnSave.Location = new System.Drawing.Point(330, 277);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseSelectable = true;
            // 
            // AddEditBook
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(454, 400);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AddEditBook";
            this.Padding = new System.Windows.Forms.Padding(23, 78, 23, 26);
            this.Text = "Books";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddEditBook_FormClosing);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox picture;
        private MetroFramework.Controls.MetroTextBox tbAuthor;
        private MetroFramework.Controls.MetroTextBox tbTitle;
        private MetroFramework.Controls.MetroComboBox cbCategory;
        private MetroFramework.Controls.MetroButton btnBrowse;
        private MetroFramework.Controls.MetroButton btnCancel;
        private MetroFramework.Controls.MetroButton btnSave;
    }
}