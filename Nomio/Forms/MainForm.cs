using Newtonsoft.Json;
using Nomio.Components;
using Nomio.Forms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Nomio
{
    public partial class MainForm : Form
    {
        public Controller controller;
        public List<Preset> defaultPresets;
        private Color invalidColor = Color.Salmon;
        private Color validColor = Color.LightGreen;

        public MainForm()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = System.Reflection.Assembly.GetExecutingAssembly().GetName().Name;

            defaultPresets = JsonConvert.DeserializeObject<List<Preset>>(File.ReadAllText(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\Presets\\DefaultPresets.json"));
            foreach (Preset preset in defaultPresets) presetFormatsComboBox.Items.Add(preset.PresetName);
            presetFormatsComboBox.SelectedIndex = 0;

            controller = new Controller();
        }

        #region Form Events
        private void browseDirButton_Click(object sender, EventArgs e)
        {
            if (browseDirTextBox.BackColor == invalidColor)
            {
                browseDirTextBox.BackColor = Color.White;
                browseDirTextBox.Text = "";
            }

            using (var folderBrowser = new FolderBrowserDialog())
            {
                DialogResult result = folderBrowser.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBrowser.SelectedPath))
                {
                    browseDirTextBox.Text = folderBrowser.SelectedPath;
                }
            }
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                controller.mainDirectory = browseDirTextBox.Text;
                controller.tvShowName = tvShowNameTextBox.Text;
                controller.delimiter = string.IsNullOrWhiteSpace(delimiterTextBox.Text) ? " " : delimiterTextBox.Text;

                if (!string.IsNullOrWhiteSpace(regexSingleEpTextBox.Text))
                {
                    controller.rxSingleEp = regexSingleEpTextBox.Text;
                    controller.rxMultiEp = regexMultiEpTextBox.Text;
                    controller.rxSeason = regexSeasonTextBox.Text;
                    controller.rxEpisode = regexEpisodeTextBox.Text;
                }
                else
                {
                    var selectedPreset = defaultPresets.First(x => x.PresetName.Equals(presetFormatsComboBox.SelectedItem.ToString()));
                    controller.rxSingleEp = selectedPreset.RegexSingleEpisode;
                    controller.rxMultiEp = selectedPreset.RegexMultiEpisode;
                    controller.rxSeason = selectedPreset.RegexSeasonOnly;
                    controller.rxEpisode = selectedPreset.RegexEpisodeOnly;
                }

                List<string> removalWords = new List<string>();
                List<string> replacementOldWords = new List<string>();
                List<string> replacementNewWords = new List<string>();
                Dictionary<string, string> replacementWords = new Dictionary<string, string>();

                foreach (DataGridViewRow row in removalsDataGridView.Rows)
                {
                    if (row.Cells[removalsColumn.Index].Value != null)
                    {
                        removalWords.Add(row.Cells[removalsColumn.Index].Value.ToString());
                    }
                }

                foreach (DataGridViewRow row in replacementsDataGridView.Rows)
                {
                    if (row.Cells[oldWordColumn.Index].Value != null)
                    {
                        replacementOldWords.Add(row.Cells[oldWordColumn.Index].Value.ToString());
                        replacementNewWords.Add(row.Cells[newWordColumn.Index].Value.ToString());
                        replacementWords.Add(row.Cells[oldWordColumn.Index].Value.ToString(), row.Cells[newWordColumn.Index].Value.ToString());
                    }
                }

                controller.removalWords = removalWords;
                controller.replacementOldWords = replacementOldWords;
                controller.replacementNewWords = replacementNewWords;
                controller.replacementWords = replacementWords;
                                
                PreviewForm confirmationView = new PreviewForm();
                Visible = false;
                confirmationView.ShowUserPreview(controller.PreviewRename());
                confirmationView.ShowDialog();                
                if(confirmationView.AcceptButton.DialogResult == DialogResult.OK)
                {
                    Visible = true;
                    controller.ExecuteRename(confirmationView.confirmedFileNames);
                    SuccessForm successForm = new SuccessForm();
                    successForm.ShowDialog();
                    if(successForm.AcceptButton.DialogResult == DialogResult.OK)
                    {
                        ClearInputFields();
                    }
                    else
                    {
                        controller.UndoRename();
                        MessageBox.Show("Changes have been undone. File names should be back to their original state.", "Undo Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    successForm.Dispose();
                }
                if(confirmationView.CancelButton.DialogResult == DialogResult.Cancel)
                {
                    Visible = true;
                    controller.ClearProperties();
                }
                confirmationView.Dispose();
            }
        }

        private void browseDirTextBox_MouseDown(object sender, MouseEventArgs e)
        {
            browseDirTextBox.BackColor = Color.White;
        }

        private void tvShowNameTextBox_MouseDown(object sender, MouseEventArgs e)
        {
            tvShowNameTextBox.BackColor = Color.White;
        }
        
        private void presetFormatsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            presetInfoTextBox.Text = defaultPresets.First(x => x.PresetName.Equals(presetFormatsComboBox.SelectedItem.ToString())).PresetDescription;
        }

        private void regexSingleEpTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            ProccessRegexInputEvent(sender, e, regexSingleEpTextBox);
        }

        private void regexMultiEpTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            ProccessRegexInputEvent(sender, e, regexMultiEpTextBox);
        }

        private void regexSeasonTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            ProccessRegexInputEvent(sender, e, regexSeasonTextBox);
        }

        private void regexEpisodeTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            ProccessRegexInputEvent(sender, e, regexEpisodeTextBox);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm about = new AboutForm();
            about.Show();
            if(about.AcceptButton.DialogResult == DialogResult.OK)
            {
                about.Dispose();
            }
        }
        #endregion

        private bool ValidateInputs()
        {
            bool validationStatus = true;
            string errorString = "One or more input errors have occurred. Check details below:\n\n";

            if (!Directory.Exists(browseDirTextBox.Text))
            {
                browseDirTextBox.BackColor = invalidColor;
                errorString += browseDirLabel.Text + ": Invalid directory!\n";
                validationStatus = false;
            }

            if (string.IsNullOrWhiteSpace(tvShowNameTextBox.Text))
            {
                tvShowNameTextBox.BackColor = invalidColor;
                errorString += tvShowNameLabel.Text + ": This field can't be empty!\n";
                validationStatus = false;
            }

            //if (string.IsNullOrEmpty(delimiterTextBox.Text))
            //{
            //    delimiterTextBox.BackColor = invalidColor;
            //    errorString += delimiterLabel.Text + ": This field can't be empty!\n";
            //    validationStatus = false;
            //}

            if ((!string.IsNullOrWhiteSpace(regexSingleEpTextBox.Text) || !string.IsNullOrWhiteSpace(regexSeasonTextBox.Text) || !string.IsNullOrWhiteSpace(regexEpisodeTextBox.Text)) &&
                (string.IsNullOrWhiteSpace(regexSingleEpTextBox.Text) || string.IsNullOrWhiteSpace(regexSeasonTextBox.Text) || string.IsNullOrWhiteSpace(regexEpisodeTextBox.Text)))
            {
                regexSingleEpTextBox.BackColor = string.IsNullOrWhiteSpace(regexSingleEpTextBox.Text) ? invalidColor : regexSingleEpTextBox.BackColor;
                regexSeasonTextBox.BackColor = string.IsNullOrWhiteSpace(regexSeasonTextBox.Text) ? invalidColor : regexSeasonTextBox.BackColor;
                regexEpisodeTextBox.BackColor = string.IsNullOrWhiteSpace(regexEpisodeTextBox.Text) ? invalidColor : regexEpisodeTextBox.BackColor;
                errorString += "Regex Fields: One or more Regex fields was left empty. If using Regex, please complete all non-optional Regex fields.";
                validationStatus = false;
            }

            if (!validationStatus) MessageBox.Show(errorString, "Input Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            return validationStatus;
        }

        private void ProccessRegexInputEvent(object sender, KeyEventArgs e, TextBox regexTextBox)
        {
            bool presetsEnable = !string.IsNullOrWhiteSpace(regexSingleEpTextBox.Text)
                || !string.IsNullOrWhiteSpace(regexMultiEpTextBox.Text)
                || !string.IsNullOrWhiteSpace(regexSeasonTextBox.Text)
                || !string.IsNullOrWhiteSpace(regexEpisodeTextBox.Text) ? false : true;

            presetFormatsComboBox.Enabled = presetsEnable;
            presetInfoTextBox.Enabled = presetsEnable;

            regexTextBox.BackColor = string.IsNullOrWhiteSpace(regexTextBox.Text) ? Color.White
               : (IsValidRegex(regexTextBox.Text) ? validColor : invalidColor);
        }

        private bool IsValidRegex(string pattern)
        {
            try
            {
                Regex.Match("", pattern);
            }
            catch (ArgumentException)
            {
                return false;
            }

            return true;
        }
        
        private void ClearInputFields()
        {
            browseDirTextBox.Text = "";
            browseDirTextBox.BackColor = Color.White;
            tvShowNameTextBox.Text = "";
            tvShowNameTextBox.BackColor = Color.White;
            delimiterTextBox.Text = "";
            delimiterTextBox.BackColor = Color.White;
            presetFormatsComboBox.SelectedIndex = 0;
            regexSingleEpTextBox.Text = "";
            regexSingleEpTextBox.BackColor = Color.White;
            regexMultiEpTextBox.Text = "";
            regexMultiEpTextBox.BackColor = Color.White;
            regexSeasonTextBox.Text = "";
            regexSeasonTextBox.BackColor = Color.White;
            regexEpisodeTextBox.Text = "";
            regexEpisodeTextBox.BackColor = Color.White;
            removalsDataGridView.Rows.Clear();
            replacementsDataGridView.Rows.Clear();
        }

        
    }
}
