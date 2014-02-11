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

        private const string libraryItemName = "Alle muziek";
        private List<Song> songs = new List<Song>();
        private List<Playlist> playlists = new List<Playlist>();
        private Song selectedSong;
        private bool doPlaylist = false;

        public MainForm()
        {
            InitializeComponent();
            updatePlaylistList();
        }

        private void updateSongList()
        {
            if (listViewLibrary.SelectedItems.Count > 0)
            {
                if (listViewLibrary.SelectedItems[0].Text == libraryItemName)
                {
                    doPlaylist = false;
                    listViewSongs.ContextMenuStrip = contextMenuStripSongs;
                    listViewSongs.Items.Clear();
                    foreach (Song song in songs)
                    {
                        ListViewItem item = new ListViewItem(song.ToStringArray());
                        listViewSongs.Items.Add(item);
                    }
                }
                else
                {
                    doPlaylist = true;
                    listViewSongs.ContextMenuStrip = contextMenuStripPlaylist;
                    Playlist selectedPlaylist = playlists.Find(x => x.Name.Equals(listViewLibrary.SelectedItems[0].Text));

                    listViewSongs.Items.Clear();
                    foreach (Song song in selectedPlaylist.Songs)
                    {
                        ListViewItem item = new ListViewItem(song.ToStringArray());
                        listViewSongs.Items.Add(item);
                    }
                }
            }
        }

        private void updatePlaylistList()
        {
            listViewLibrary.Groups.Clear();
            listViewLibrary.Items.Clear();
            ListViewGroup libraryGroup = new ListViewGroup("Bibliotheek");
            ListViewGroup playlistGroup = new ListViewGroup("Afspeellijsten");
            listViewLibrary.Groups.Add(playlistGroup);

            ListViewItem libraryItem = new ListViewItem(libraryItemName, libraryGroup);
            listViewLibrary.Items.Add(libraryItem);

            foreach (Playlist playlist in playlists)
            {
                ListViewItem item = new ListViewItem(playlist.Name, playlistGroup);
                listViewLibrary.Items.Add(item);
            }
            
        }

        private void changeList(object sender, EventArgs e)
        {
            updateSongList();
        }

        private void changeSong(object sender, EventArgs e)
        {
            if (listViewSongs.SelectedItems.Count > 0)
            {
                selectedSong = songs.Find(x => x.PathToFile.Equals(listViewSongs.SelectedItems[0].SubItems[3].Text));
                labelName.Text = selectedSong.Name;
                labelArtist.Text = selectedSong.GetArtist();
                axWindowsMediaPlayer1.URL = selectedSong.PathToFile;
            }
        }

        private void togglePlayback(object sender, EventArgs e)
        {

        }
        
        private void addSongToLibrary(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Bestand toevoegen";
            openFileDialog.FileName = "*.mp3";
            openFileDialog.Filter = "MP3 besjtand|*.mp3|WAV besjtand|*.wav";
            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                MessageBox.Show(openFileDialog.FileName);
                songs.Add(new Song(openFileDialog.FileName));
                updateSongList();
            }
            
        }

        private void deleteSongFromLibrary(object sender, EventArgs e)
        {
            if (listViewSongs.SelectedItems.Count > 0)
            {
                songs.Remove(songs.Find(x => x.PathToFile.Equals(listViewSongs.SelectedItems[0].SubItems[3].Text)));
                updateSongList();
            }
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
            if (listViewLibrary.SelectedItems.Count > 0)
            {
                playlists.Remove(playlists.Find(x => x.Name.Equals(listViewLibrary.SelectedItems[0].Text)));
                updatePlaylistList();
            }
        }

        private void addSongToPlaylist(object sender, EventArgs e)
        {
            if (listViewSongs.SelectedItems.Count > 0) {
                string path = listViewSongs.SelectedItems[0].SubItems[3].Text;
                // List<string> met strings van playlists in constructor
                AddToPlaylistForm addForm = new AddToPlaylistForm(playlists);
                addForm.ShowDialog();
                if (addForm.DialogResult == System.Windows.Forms.DialogResult.OK)
                {
                    Playlist playlist = playlists.Find(x => x.Name.Equals(addForm.SelectedItem));
                    playlist.Add(songs.Find(x => x.PathToFile.Equals(path)));
                }
            }
        }

        private void deleteSongFromPlaylist(object sender, EventArgs e)
        {
            if (listViewSongs.SelectedItems.Count > 0 && listViewLibrary.SelectedItems.Count > 0)
            {
                Playlist selectedPlaylist = playlists.Find(x => x.Name.Equals(listViewLibrary.SelectedItems[0].Text));
                selectedPlaylist.Songs.Remove(selectedPlaylist.Songs.Find(x => x.PathToFile.Equals(listViewSongs.SelectedItems[0].SubItems[3].Text)));
                updateSongList();
            }
        }

        private void axWindowsMediaPlayer1_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            
        }
        
    }
}
