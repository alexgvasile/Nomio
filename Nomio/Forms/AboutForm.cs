using System;
using System.Windows.Forms;

namespace Nomio.Forms
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            ControlBox = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = System.Reflection.Assembly.GetExecutingAssembly().GetName().Name + " - About";
            AcceptButton = okButton;
            
            softwareTitleLabel.Text = System.Reflection.Assembly.GetExecutingAssembly().GetName().Name + " - A Home Media Server File Renaming Tool.";
            softwareVersionLabel.Text = "Version: " + System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();
            licenseTextBox.Text = System.Reflection.Assembly.GetExecutingAssembly().GetName().Name +
                "\nCopyright (C) " + (DateTime.Now.Year > 2019 ? "2019 - " + DateTime.Now.Year : "2019") + " Alexandru G. Vasile t.a. Lonewolf Software" +
                "\n\nThis program is free software: you can redistribute it and/or modify it under the terms of the GNU General Public License as published by the Free Software Foundation, either version 3 of the License, or (at your option) any later version." +
                "\n\nThis program is distributed in the hope that it will be useful, but WITHOUT ANY WARRANTY; without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the GNU General Public License for more details." +
                "\n\nYou should have received a copy of the GNU General Public License along with this program. If not, see <https://www.gnu.org/licenses/>.";
        }

        private void okButton_Click(object sender, System.EventArgs e)
        {
            AcceptButton.DialogResult = DialogResult.OK;
            Close();
        }

        private void licenseTextBox_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(e.LinkText);
            }
            catch (Exception ex)
            {
                MessageBox.Show("There was a problem opening the link. Please copy paste it into your preffered browser instead.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
