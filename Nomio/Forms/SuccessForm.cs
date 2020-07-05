using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nomio
{
    public partial class SuccessForm : Form
    {
        public SuccessForm()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            ControlBox = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = System.Reflection.Assembly.GetExecutingAssembly().GetName().Name + " - Renaming Success";

            AcceptButton = doneButton;
            CancelButton = undoButton;
        }

        private void doneButton_Click(object sender, EventArgs e)
        {
            AcceptButton.DialogResult = DialogResult.OK;
            Close();
        }

        private void undoButton_Click(object sender, EventArgs e)
        {
            CancelButton.DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
