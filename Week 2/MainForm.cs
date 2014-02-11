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
    public partial class MainForm : Form
    {
        private List<Playlist> playlists = new List<Playlist>();

        public MainForm()
        {
            InitializeComponent();
            updatePlaylistList();
        }

        private void updateSongList()
        {

        }

        private void updatePlaylistList()
        {
            listViewLibrary.Groups.Clear();
            listViewLibrary.Items.Clear();
            ListViewGroup libraryGroup = new ListViewGroup("Bibliotheek");
            ListViewGroup playlistGroup = new ListViewGroup("Afspeellijsten");
            listViewLibrary.Groups.Add(playlistGroup);

            ListViewItem libraryItem = new ListViewItem("Alle muziek", playlistGroup);
            listViewLibrary.Items.Add(libraryItem);

            foreach (Playlist playlist in playlists)
            {
                ListViewItem item = new ListViewItem(playlist.Name, playlistGroup);
                listViewLibrary.Items.Add(item);
            }
            
        }

        private void changeList(object sender, EventArgs e)
        {

        }

        private void changeSong(object sender, EventArgs e)
        {

        }

        private void togglePlayback(object sender, EventArgs e)
        {

        }
        
        private void addSongToLibrary(object sender, EventArgs e)
        {

        }

        private void deleteSongFromLibrary(object sender, EventArgs e)
        {
            
        }

        private void addPlaylist(object sender, EventArgs e)
        {
            CreatePlaylistForm playlistForm = new CreatePlaylistForm();
            playlistForm.ShowDialog();
            if (playlistForm.DialogResult == System.Windows.Forms.DialogResult.OK)
            {
                playlists.Add(new Playlist(playlistForm.PlaylistName));
                updatePlaylistList();
            }
        }

        private void deletePlaylist(object sender, EventArgs e)
        {

        }

        private void addSongToPlaylist(object sender, EventArgs e)
        {
            // List<string> met strings van playlists in constructor
            AddToPlaylistForm addForm = new AddToPlaylistForm(null);
            addForm.ShowDialog();
            if (addForm.DialogResult == System.Windows.Forms.DialogResult.OK)
            {
                // Naam opvragen met addForm.SelectedItem
            }
        }

        private void deleteSongFromPlaylist(object sender, EventArgs e)
        {

        }
        
    }
}
