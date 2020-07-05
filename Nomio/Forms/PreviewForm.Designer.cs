namespace Nomio
{
    partial class PreviewForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PreviewForm));
            this.previewDataGridView = new System.Windows.Forms.DataGridView();
            this.oldFileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.newFileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.executeRenameButton = new System.Windows.Forms.Button();
            this.cancelRenameButton = new System.Windows.Forms.Button();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.previewInfoTextBox = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.previewDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // previewDataGridView
            // 
            this.previewDataGridView.AllowUserToAddRows = false;
            this.previewDataGridView.AllowUserToDeleteRows = false;
            this.previewDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.previewDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.oldFileName,
            this.newFileName});
            this.previewDataGridView.Location = new System.Drawing.Point(13, 81);
            this.previewDataGridView.Name = "previewDataGridView";
            this.previewDataGridView.Size = new System.Drawing.Size(775, 476);
            this.previewDataGridView.TabIndex = 0;
            // 
            // oldFileName
            // 
            this.oldFileName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.oldFileName.HeaderText = "Old File Name";
            this.oldFileName.Name = "oldFileName";
            this.oldFileName.ReadOnly = true;
            // 
            // newFileName
            // 
            this.newFileName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.newFileName.HeaderText = "New File Name";
            this.newFileName.Name = "newFileName";
            // 
            // executeRenameButton
            // 
            this.executeRenameButton.BackColor = System.Drawing.Color.LightGreen;
            this.executeRenameButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.executeRenameButton.FlatAppearance.BorderColor = System.Drawing.Color.ForestGreen;
            this.executeRenameButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.executeRenameButton.Location = new System.Drawing.Point(12, 563);
            this.executeRenameButton.Name = "executeRenameButton";
            this.executeRenameButton.Size = new System.Drawing.Size(135, 30);
            this.executeRenameButton.TabIndex = 1;
            this.executeRenameButton.Text = "Rename";
            this.executeRenameButton.UseVisualStyleBackColor = false;
            this.executeRenameButton.Click += new System.EventHandler(this.executeRenameButton_Click);
            // 
            // cancelRenameButton
            // 
            this.cancelRenameButton.BackColor = System.Drawing.Color.Salmon;
            this.cancelRenameButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelRenameButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.cancelRenameButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelRenameButton.Location = new System.Drawing.Point(153, 563);
            this.cancelRenameButton.Name = "cancelRenameButton";
            this.cancelRenameButton.Size = new System.Drawing.Size(135, 30);
            this.cancelRenameButton.TabIndex = 2;
            this.cancelRenameButton.Text = "Cancel";
            this.cancelRenameButton.UseVisualStyleBackColor = false;
            this.cancelRenameButton.Click += new System.EventHandler(this.cancelRenameButton_Click);
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // previewInfoTextBox
            // 
            this.previewInfoTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.previewInfoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.previewInfoTextBox.Location = new System.Drawing.Point(13, 13);
            this.previewInfoTextBox.Name = "previewInfoTextBox";
            this.previewInfoTextBox.ReadOnly = true;
            this.previewInfoTextBox.Size = new System.Drawing.Size(774, 62);
            this.previewInfoTextBox.TabIndex = 3;
            this.previewInfoTextBox.Text = "";
            // 
            // PreviewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 605);
            this.Controls.Add(this.previewInfoTextBox);
            this.Controls.Add(this.cancelRenameButton);
            this.Controls.Add(this.executeRenameButton);
            this.Controls.Add(this.previewDataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PreviewForm";
            this.Text = "Preview";
            ((System.ComponentModel.ISupportInitialize)(this.previewDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView previewDataGridView;
        private System.Windows.Forms.Button executeRenameButton;
        private System.Windows.Forms.Button cancelRenameButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn oldFileName;
        private System.Windows.Forms.DataGridViewTextBoxColumn newFileName;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.Windows.Forms.RichTextBox previewInfoTextBox;
    }
}