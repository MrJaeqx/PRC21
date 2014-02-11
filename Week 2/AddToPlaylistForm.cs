/*      COPYRIGHT MR. FISH 2014
 * 
 *      |\   \\\\__     o
 *      | \_/    o \    o 
 *      > _   (( <_  oo  
 *      | / \__+___/      
 *      |/     |/
 */

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
    public partial class AddToPlaylistForm : Form
    {
        public string SelectedItem { get; private set; }
        

        public AddToPlaylistForm(List<Playlist> playlists)
        {
            InitializeComponent();

            listViewPlaylists.Items.Clear();

            foreach (Playlist playlist in playlists)
            {
                ListViewItem item = new ListViewItem(playlist.ToString());
                listViewPlaylists.Items.Add(item);
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (listViewPlaylists.SelectedItems.Count > 0)
            {
                SelectedItem = listViewPlaylists.SelectedItems[0].Text;
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Er is geen afspeellijst geselecteerd.", "Toevoegen aan afspeellijst", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            SelectedItem = null;
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }
    }
}
