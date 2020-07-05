namespace Nomio.Forms
{
    partial class AboutForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
            this.softwareTitleLabel = new System.Windows.Forms.Label();
            this.licenseGroupBox = new System.Windows.Forms.GroupBox();
            this.licenseTextBox = new System.Windows.Forms.RichTextBox();
            this.softwareVersionLabel = new System.Windows.Forms.Label();
            this.okButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.licenseGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // softwareTitleLabel
            // 
            this.softwareTitleLabel.AutoSize = true;
            this.softwareTitleLabel.Location = new System.Drawing.Point(74, 20);
            this.softwareTitleLabel.Name = "softwareTitleLabel";
            this.softwareTitleLabel.Size = new System.Drawing.Size(72, 13);
            this.softwareTitleLabel.TabIndex = 1;
            this.softwareTitleLabel.Text = "Software Title";
            // 
            // licenseGroupBox
            // 
            this.licenseGroupBox.Controls.Add(this.licenseTextBox);
            this.licenseGroupBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.licenseGroupBox.Location = new System.Drawing.Point(15, 67);
            this.licenseGroupBox.Name = "licenseGroupBox";
            this.licenseGroupBox.Size = new System.Drawing.Size(457, 200);
            this.licenseGroupBox.TabIndex = 4;
            this.licenseGroupBox.TabStop = false;
            this.licenseGroupBox.Text = "GNU General Public License";
            // 
            // licenseTextBox
            // 
            this.licenseTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.licenseTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.licenseTextBox.Location = new System.Drawing.Point(6, 19);
            this.licenseTextBox.Name = "licenseTextBox";
            this.licenseTextBox.ReadOnly = true;
            this.licenseTextBox.Size = new System.Drawing.Size(445, 173);
            this.licenseTextBox.TabIndex = 0;
            this.licenseTextBox.Text = "";
            this.licenseTextBox.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.licenseTextBox_LinkClicked);
            // 
            // softwareVersionLabel
            // 
            this.softwareVersionLabel.AutoSize = true;
            this.softwareVersionLabel.Location = new System.Drawing.Point(74, 40);
            this.softwareVersionLabel.Name = "softwareVersionLabel";
            this.softwareVersionLabel.Size = new System.Drawing.Size(63, 13);
            this.softwareVersionLabel.TabIndex = 5;
            this.softwareVersionLabel.Text = "Version: 1.0";
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(209, 277);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 6;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Nomio.Properties.Resources.nomio;
            this.pictureBox1.Location = new System.Drawing.Point(15, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(53, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 312);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.softwareVersionLabel);
            this.Controls.Add(this.licenseGroupBox);
            this.Controls.Add(this.softwareTitleLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AboutForm";
            this.Text = "About";
            this.licenseGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label softwareTitleLabel;
        private System.Windows.Forms.GroupBox licenseGroupBox;
        private System.Windows.Forms.RichTextBox licenseTextBox;
        private System.Windows.Forms.Label softwareVersionLabel;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}