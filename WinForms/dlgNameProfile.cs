using ImageEditor.Editing;
using System;
using System.Windows.Forms;

namespace ImageEditor.WinForms
{
    public partial class dlgNameProfile : Form
    {
        public string ProfileName
        {
            get 
            { 
                return txtName.Text; 
            }

            private set { }
        } 

        public dlgNameProfile()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
