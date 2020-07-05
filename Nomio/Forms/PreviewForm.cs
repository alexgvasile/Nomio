using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nomio
{
    public partial class PreviewForm : Form
    {
        private List<string> fileDirectories { get; set; }
        public Dictionary<string, string> confirmedFileNames { get; set; }

        public PreviewForm()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            ControlBox = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = System.Reflection.Assembly.GetExecutingAssembly().GetName().Name + " - Rename Preview";

            confirmedFileNames = new Dictionary<string, string>();
            AcceptButton = executeRenameButton;
            CancelButton = cancelRenameButton;

            previewInfoTextBox.Text = "This window shows a preview of the change(s) between the old file names and the new file names. Any invalid changes can be corrected here by editing the cells under the \"" + newFileName.HeaderText + "\" column." +
                "\n\n Once happy with your changes, you can click the \"" + executeRenameButton.Text + "\" button to rename your files or click \"" + cancelRenameButton.Text + "\" to go back to the main form.";
        }

        public void ShowUserPreview(Dictionary<string, string> fileNameBuffer)
        {
            fileDirectories = new List<string>();

            foreach(KeyValuePair<string, string> fileName in fileNameBuffer)
            {
                fileDirectories.Add(fileName.Key.Substring(0, fileName.Key.Length - fileName.Key.Split(Path.DirectorySeparatorChar).Last().Length));
                previewDataGridView.Rows.Add(new string[] { fileName.Key.Split(Path.DirectorySeparatorChar).Last(), fileName.Value.Split(Path.DirectorySeparatorChar).Last() });
            }
        }

        private void executeRenameButton_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < previewDataGridView.RowCount; i++)
            {
                if (previewDataGridView.Rows[i].Cells[oldFileName.Index].Value != null)
                {
                    confirmedFileNames.Add(fileDirectories[i] + previewDataGridView.Rows[i].Cells[oldFileName.Index].Value.ToString(), fileDirectories[i] + previewDataGridView.Rows[i].Cells[newFileName.Index].Value.ToString());
                }
            }

            AcceptButton.DialogResult = DialogResult.OK;
            Visible = false;
        }

        private void cancelRenameButton_Click(object sender, EventArgs e)
        {
            CancelButton.DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
