using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Week_2
{
    public partial class CreatePlaylistForm : Form
    {
        public string PlaylistName { get; private set; }

        public CreatePlaylistForm()
        {
            InitializeComponent();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text != null)
            {
                PlaylistName = textBoxName.Text;
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("De naam van de afspeellijst mag niet leeg zijn.", "Nieuwe afspeellijst", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
