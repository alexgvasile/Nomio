namespace Nomio
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.browseDirTextBox = new System.Windows.Forms.TextBox();
            this.browseDirButton = new System.Windows.Forms.Button();
            this.browseDirLabel = new System.Windows.Forms.Label();
            this.delimiterTextBox = new System.Windows.Forms.TextBox();
            this.delimiterLabel = new System.Windows.Forms.Label();
            this.tvShowNameLabel = new System.Windows.Forms.Label();
            this.tvShowNameTextBox = new System.Windows.Forms.TextBox();
            this.confirmButton = new System.Windows.Forms.Button();
            this.removalsGroupBox = new System.Windows.Forms.GroupBox();
            this.removalsDataGridView = new System.Windows.Forms.DataGridView();
            this.removalsColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.replacementsGroupBox = new System.Windows.Forms.GroupBox();
            this.replacementsDataGridView = new System.Windows.Forms.DataGridView();
            this.oldWordColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.newWordColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.presetFormatsLabel = new System.Windows.Forms.Label();
            this.presetFormatsComboBox = new System.Windows.Forms.ComboBox();
            this.regexSingleEpTextBox = new System.Windows.Forms.TextBox();
            this.regexSingleEpLabel = new System.Windows.Forms.Label();
            this.numberingOrLabel = new System.Windows.Forms.Label();
            this.episodeTitleFormattingGroupBox = new System.Windows.Forms.GroupBox();
            this.numberingGroupBox = new System.Windows.Forms.GroupBox();
            this.presetInfoTextBox = new System.Windows.Forms.RichTextBox();
            this.regexMultiEpTextBox = new System.Windows.Forms.TextBox();
            this.regexMultiEpLabel = new System.Windows.Forms.Label();
            this.regexEpisodeTextBox = new System.Windows.Forms.TextBox();
            this.regexSeasonTextBox = new System.Windows.Forms.TextBox();
            this.regexEpisodeLabel = new System.Windows.Forms.Label();
            this.regexSeasonLabel = new System.Windows.Forms.Label();
            this.removalsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.removalsDataGridView)).BeginInit();
            this.replacementsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.replacementsDataGridView)).BeginInit();
            this.mainMenuStrip.SuspendLayout();
            this.episodeTitleFormattingGroupBox.SuspendLayout();
            this.numberingGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // browseDirTextBox
            // 
            this.browseDirTextBox.Location = new System.Drawing.Point(15, 55);
            this.browseDirTextBox.Name = "browseDirTextBox";
            this.browseDirTextBox.Size = new System.Drawing.Size(691, 20);
            this.browseDirTextBox.TabIndex = 1;
            this.browseDirTextBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.browseDirTextBox_MouseDown);
            // 
            // browseDirButton
            // 
            this.browseDirButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.browseDirButton.Location = new System.Drawing.Point(712, 53);
            this.browseDirButton.Name = "browseDirButton";
            this.browseDirButton.Size = new System.Drawing.Size(75, 23);
            this.browseDirButton.TabIndex = 2;
            this.browseDirButton.Text = "Browse";
            this.browseDirButton.UseVisualStyleBackColor = true;
            this.browseDirButton.Click += new System.EventHandler(this.browseDirButton_Click);
            // 
            // browseDirLabel
            // 
            this.browseDirLabel.AutoSize = true;
            this.browseDirLabel.Location = new System.Drawing.Point(12, 39);
            this.browseDirLabel.Name = "browseDirLabel";
            this.browseDirLabel.Size = new System.Drawing.Size(122, 13);
            this.browseDirLabel.TabIndex = 0;
            this.browseDirLabel.Text = "TV Show Main Directory";
            // 
            // delimiterTextBox
            // 
            this.delimiterTextBox.Location = new System.Drawing.Point(642, 45);
            this.delimiterTextBox.Name = "delimiterTextBox";
            this.delimiterTextBox.Size = new System.Drawing.Size(123, 20);
            this.delimiterTextBox.TabIndex = 6;
            // 
            // delimiterLabel
            // 
            this.delimiterLabel.AutoSize = true;
            this.delimiterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delimiterLabel.Location = new System.Drawing.Point(639, 29);
            this.delimiterLabel.Name = "delimiterLabel";
            this.delimiterLabel.Size = new System.Drawing.Size(47, 13);
            this.delimiterLabel.TabIndex = 5;
            this.delimiterLabel.Text = "Delimiter";
            // 
            // tvShowNameLabel
            // 
            this.tvShowNameLabel.AutoSize = true;
            this.tvShowNameLabel.Location = new System.Drawing.Point(6, 29);
            this.tvShowNameLabel.Name = "tvShowNameLabel";
            this.tvShowNameLabel.Size = new System.Drawing.Size(82, 13);
            this.tvShowNameLabel.TabIndex = 3;
            this.tvShowNameLabel.Text = "TV Show Name";
            // 
            // tvShowNameTextBox
            // 
            this.tvShowNameTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.tvShowNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tvShowNameTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tvShowNameTextBox.Location = new System.Drawing.Point(9, 45);
            this.tvShowNameTextBox.Name = "tvShowNameTextBox";
            this.tvShowNameTextBox.Size = new System.Drawing.Size(627, 20);
            this.tvShowNameTextBox.TabIndex = 4;
            this.tvShowNameTextBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tvShowNameTextBox_MouseDown);
            // 
            // confirmButton
            // 
            this.confirmButton.BackColor = System.Drawing.Color.LightGreen;
            this.confirmButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.confirmButton.FlatAppearance.BorderColor = System.Drawing.Color.ForestGreen;
            this.confirmButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.confirmButton.Location = new System.Drawing.Point(12, 561);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(125, 30);
            this.confirmButton.TabIndex = 11;
            this.confirmButton.Text = "Preview Changes";
            this.confirmButton.UseVisualStyleBackColor = false;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // removalsGroupBox
            // 
            this.removalsGroupBox.Controls.Add(this.removalsDataGridView);
            this.removalsGroupBox.Location = new System.Drawing.Point(9, 243);
            this.removalsGroupBox.Name = "removalsGroupBox";
            this.removalsGroupBox.Size = new System.Drawing.Size(250, 200);
            this.removalsGroupBox.TabIndex = 15;
            this.removalsGroupBox.TabStop = false;
            this.removalsGroupBox.Text = "Removals";
            // 
            // removalsDataGridView
            // 
            this.removalsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.removalsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.removalsColumn});
            this.removalsDataGridView.Location = new System.Drawing.Point(6, 19);
            this.removalsDataGridView.Name = "removalsDataGridView";
            this.removalsDataGridView.Size = new System.Drawing.Size(238, 175);
            this.removalsDataGridView.TabIndex = 0;
            // 
            // removalsColumn
            // 
            this.removalsColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.removalsColumn.HeaderText = "Word to Remove";
            this.removalsColumn.Name = "removalsColumn";
            this.removalsColumn.ToolTipText = "Per row, list a word found in one or more episode titles that should be removed. " +
    "Any continuous text separated by the specified delimiter value, counts as a word" +
    ".";
            // 
            // replacementsGroupBox
            // 
            this.replacementsGroupBox.Controls.Add(this.replacementsDataGridView);
            this.replacementsGroupBox.Location = new System.Drawing.Point(265, 243);
            this.replacementsGroupBox.Name = "replacementsGroupBox";
            this.replacementsGroupBox.Size = new System.Drawing.Size(500, 200);
            this.replacementsGroupBox.TabIndex = 16;
            this.replacementsGroupBox.TabStop = false;
            this.replacementsGroupBox.Text = "Replacements";
            // 
            // replacementsDataGridView
            // 
            this.replacementsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.replacementsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.oldWordColumn,
            this.newWordColumn});
            this.replacementsDataGridView.Location = new System.Drawing.Point(7, 20);
            this.replacementsDataGridView.Name = "replacementsDataGridView";
            this.replacementsDataGridView.Size = new System.Drawing.Size(487, 174);
            this.replacementsDataGridView.TabIndex = 0;
            // 
            // oldWordColumn
            // 
            this.oldWordColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.oldWordColumn.HeaderText = "Old Word";
            this.oldWordColumn.Name = "oldWordColumn";
            this.oldWordColumn.ToolTipText = "Per row, list an old word present in one or more episode titles, that should be r" +
    "eplaced.";
            // 
            // newWordColumn
            // 
            this.newWordColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.newWordColumn.HeaderText = "New Word(s)";
            this.newWordColumn.Name = "newWordColumn";
            this.newWordColumn.ToolTipText = "Per row, list a new word to replace the respective old word in one or more episod" +
    "e titles.";
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(799, 24);
            this.mainMenuStrip.TabIndex = 17;
            this.mainMenuStrip.Text = "menuStrip1";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // presetFormatsLabel
            // 
            this.presetFormatsLabel.AutoSize = true;
            this.presetFormatsLabel.Location = new System.Drawing.Point(3, 26);
            this.presetFormatsLabel.Name = "presetFormatsLabel";
            this.presetFormatsLabel.Size = new System.Drawing.Size(77, 13);
            this.presetFormatsLabel.TabIndex = 18;
            this.presetFormatsLabel.Text = "Preset Formats";
            // 
            // presetFormatsComboBox
            // 
            this.presetFormatsComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.presetFormatsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.presetFormatsComboBox.FormattingEnabled = true;
            this.presetFormatsComboBox.Location = new System.Drawing.Point(6, 42);
            this.presetFormatsComboBox.Name = "presetFormatsComboBox";
            this.presetFormatsComboBox.Size = new System.Drawing.Size(325, 21);
            this.presetFormatsComboBox.TabIndex = 19;
            this.presetFormatsComboBox.SelectedIndexChanged += new System.EventHandler(this.presetFormatsComboBox_SelectedIndexChanged);
            // 
            // regexSingleEpTextBox
            // 
            this.regexSingleEpTextBox.Location = new System.Drawing.Point(425, 42);
            this.regexSingleEpTextBox.Name = "regexSingleEpTextBox";
            this.regexSingleEpTextBox.Size = new System.Drawing.Size(325, 20);
            this.regexSingleEpTextBox.TabIndex = 20;
            this.regexSingleEpTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.regexSingleEpTextBox_KeyUp);
            // 
            // regexSingleEpLabel
            // 
            this.regexSingleEpLabel.AutoSize = true;
            this.regexSingleEpLabel.Location = new System.Drawing.Point(422, 26);
            this.regexSingleEpLabel.Name = "regexSingleEpLabel";
            this.regexSingleEpLabel.Size = new System.Drawing.Size(138, 13);
            this.regexSingleEpLabel.TabIndex = 21;
            this.regexSingleEpLabel.Text = "Regex: Single-Episode Files";
            // 
            // numberingOrLabel
            // 
            this.numberingOrLabel.AutoSize = true;
            this.numberingOrLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberingOrLabel.Location = new System.Drawing.Point(357, 39);
            this.numberingOrLabel.Name = "numberingOrLabel";
            this.numberingOrLabel.Size = new System.Drawing.Size(40, 24);
            this.numberingOrLabel.TabIndex = 22;
            this.numberingOrLabel.Text = "OR";
            // 
            // episodeTitleFormattingGroupBox
            // 
            this.episodeTitleFormattingGroupBox.Controls.Add(this.numberingGroupBox);
            this.episodeTitleFormattingGroupBox.Controls.Add(this.tvShowNameLabel);
            this.episodeTitleFormattingGroupBox.Controls.Add(this.replacementsGroupBox);
            this.episodeTitleFormattingGroupBox.Controls.Add(this.delimiterTextBox);
            this.episodeTitleFormattingGroupBox.Controls.Add(this.removalsGroupBox);
            this.episodeTitleFormattingGroupBox.Controls.Add(this.tvShowNameTextBox);
            this.episodeTitleFormattingGroupBox.Controls.Add(this.delimiterLabel);
            this.episodeTitleFormattingGroupBox.Location = new System.Drawing.Point(12, 94);
            this.episodeTitleFormattingGroupBox.Name = "episodeTitleFormattingGroupBox";
            this.episodeTitleFormattingGroupBox.Size = new System.Drawing.Size(775, 452);
            this.episodeTitleFormattingGroupBox.TabIndex = 23;
            this.episodeTitleFormattingGroupBox.TabStop = false;
            this.episodeTitleFormattingGroupBox.Text = "Episode Title Formatting";
            // 
            // numberingGroupBox
            // 
            this.numberingGroupBox.Controls.Add(this.presetInfoTextBox);
            this.numberingGroupBox.Controls.Add(this.regexMultiEpTextBox);
            this.numberingGroupBox.Controls.Add(this.regexMultiEpLabel);
            this.numberingGroupBox.Controls.Add(this.regexEpisodeTextBox);
            this.numberingGroupBox.Controls.Add(this.regexSeasonTextBox);
            this.numberingGroupBox.Controls.Add(this.regexEpisodeLabel);
            this.numberingGroupBox.Controls.Add(this.regexSeasonLabel);
            this.numberingGroupBox.Controls.Add(this.presetFormatsLabel);
            this.numberingGroupBox.Controls.Add(this.numberingOrLabel);
            this.numberingGroupBox.Controls.Add(this.presetFormatsComboBox);
            this.numberingGroupBox.Controls.Add(this.regexSingleEpLabel);
            this.numberingGroupBox.Controls.Add(this.regexSingleEpTextBox);
            this.numberingGroupBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.numberingGroupBox.Location = new System.Drawing.Point(9, 85);
            this.numberingGroupBox.Name = "numberingGroupBox";
            this.numberingGroupBox.Size = new System.Drawing.Size(756, 152);
            this.numberingGroupBox.TabIndex = 7;
            this.numberingGroupBox.TabStop = false;
            this.numberingGroupBox.Text = "Numbering";
            // 
            // presetInfoTextBox
            // 
            this.presetInfoTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.presetInfoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.presetInfoTextBox.Location = new System.Drawing.Point(6, 69);
            this.presetInfoTextBox.Name = "presetInfoTextBox";
            this.presetInfoTextBox.ReadOnly = true;
            this.presetInfoTextBox.Size = new System.Drawing.Size(325, 71);
            this.presetInfoTextBox.TabIndex = 30;
            this.presetInfoTextBox.Text = "";
            // 
            // regexMultiEpTextBox
            // 
            this.regexMultiEpTextBox.Location = new System.Drawing.Point(425, 81);
            this.regexMultiEpTextBox.Name = "regexMultiEpTextBox";
            this.regexMultiEpTextBox.Size = new System.Drawing.Size(325, 20);
            this.regexMultiEpTextBox.TabIndex = 28;
            this.regexMultiEpTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.regexMultiEpTextBox_KeyUp);
            // 
            // regexMultiEpLabel
            // 
            this.regexMultiEpLabel.AutoSize = true;
            this.regexMultiEpLabel.Location = new System.Drawing.Point(422, 65);
            this.regexMultiEpLabel.Name = "regexMultiEpLabel";
            this.regexMultiEpLabel.Size = new System.Drawing.Size(179, 13);
            this.regexMultiEpLabel.TabIndex = 27;
            this.regexMultiEpLabel.Text = "Regex: Multi-Episode Files (Optional)";
            // 
            // regexEpisodeTextBox
            // 
            this.regexEpisodeTextBox.Location = new System.Drawing.Point(600, 120);
            this.regexEpisodeTextBox.Name = "regexEpisodeTextBox";
            this.regexEpisodeTextBox.Size = new System.Drawing.Size(150, 20);
            this.regexEpisodeTextBox.TabIndex = 26;
            this.regexEpisodeTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.regexEpisodeTextBox_KeyUp);
            // 
            // regexSeasonTextBox
            // 
            this.regexSeasonTextBox.Location = new System.Drawing.Point(425, 120);
            this.regexSeasonTextBox.Name = "regexSeasonTextBox";
            this.regexSeasonTextBox.Size = new System.Drawing.Size(150, 20);
            this.regexSeasonTextBox.TabIndex = 25;
            this.regexSeasonTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.regexSeasonTextBox_KeyUp);
            // 
            // regexEpisodeLabel
            // 
            this.regexEpisodeLabel.AutoSize = true;
            this.regexEpisodeLabel.Location = new System.Drawing.Point(597, 104);
            this.regexEpisodeLabel.Name = "regexEpisodeLabel";
            this.regexEpisodeLabel.Size = new System.Drawing.Size(82, 13);
            this.regexEpisodeLabel.TabIndex = 24;
            this.regexEpisodeLabel.Text = "Regex: Episode";
            // 
            // regexSeasonLabel
            // 
            this.regexSeasonLabel.AutoSize = true;
            this.regexSeasonLabel.Location = new System.Drawing.Point(422, 104);
            this.regexSeasonLabel.Name = "regexSeasonLabel";
            this.regexSeasonLabel.Size = new System.Drawing.Size(80, 13);
            this.regexSeasonLabel.TabIndex = 23;
            this.regexSeasonLabel.Text = "Regex: Season";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 605);
            this.Controls.Add(this.episodeTitleFormattingGroupBox);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.browseDirLabel);
            this.Controls.Add(this.browseDirButton);
            this.Controls.Add(this.browseDirTextBox);
            this.Controls.Add(this.mainMenuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mainMenuStrip;
            this.Name = "MainForm";
            this.Text = "Main";
            this.removalsGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.removalsDataGridView)).EndInit();
            this.replacementsGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.replacementsDataGridView)).EndInit();
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.episodeTitleFormattingGroupBox.ResumeLayout(false);
            this.episodeTitleFormattingGroupBox.PerformLayout();
            this.numberingGroupBox.ResumeLayout(false);
            this.numberingGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox browseDirTextBox;
        private System.Windows.Forms.Button browseDirButton;
        private System.Windows.Forms.Label browseDirLabel;
        private System.Windows.Forms.TextBox delimiterTextBox;
        private System.Windows.Forms.Label delimiterLabel;
        private System.Windows.Forms.Label tvShowNameLabel;
        private System.Windows.Forms.TextBox tvShowNameTextBox;
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.GroupBox removalsGroupBox;
        private System.Windows.Forms.GroupBox replacementsGroupBox;
        private System.Windows.Forms.DataGridView removalsDataGridView;
        private System.Windows.Forms.DataGridView replacementsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn removalsColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oldWordColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn newWordColumn;
        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Label presetFormatsLabel;
        private System.Windows.Forms.ComboBox presetFormatsComboBox;
        private System.Windows.Forms.TextBox regexSingleEpTextBox;
        private System.Windows.Forms.Label regexSingleEpLabel;
        private System.Windows.Forms.Label numberingOrLabel;
        private System.Windows.Forms.GroupBox episodeTitleFormattingGroupBox;
        private System.Windows.Forms.GroupBox numberingGroupBox;
        private System.Windows.Forms.TextBox regexEpisodeTextBox;
        private System.Windows.Forms.TextBox regexSeasonTextBox;
        private System.Windows.Forms.Label regexEpisodeLabel;
        private System.Windows.Forms.Label regexSeasonLabel;
        private System.Windows.Forms.TextBox regexMultiEpTextBox;
        private System.Windows.Forms.Label regexMultiEpLabel;
        private System.Windows.Forms.RichTextBox presetInfoTextBox;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}

