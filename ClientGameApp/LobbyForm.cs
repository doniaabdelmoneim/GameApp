using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using MaterialSkin.Controls;
namespace ClientGameApp
{
    public partial class LobbyForm : MaterialForm
    {
        Dictionary<int, string> RoomList;
        BinaryReader Br;
        BinaryWriter Bw;
        string Name;
        NetworkStream Stream;
        string[] rooms;
        Thread chooseCategory;
        Thread goplay;
        string[] joinRoom;
        public LobbyForm (NetworkStream stream, string Name)
        {
            InitializeComponent ();
            InitializeRoomListView ();
            welcomeNamedLabel.Text = "Welcome , " + Name;
            Br = new BinaryReader (stream);
            Bw = new BinaryWriter (stream);
            Stream = stream;
            this.Name = Name;
            joinBtn.Enabled = false;
            watchBtn.Enabled = false;
            RoomList = new Dictionary<int, string> ();
            ToolTip toolTip = new ToolTip ();
            toolTip.SetToolTip (roomListView, "Select a room to join or watch.");

        }

        private void InitializeRoomListView ()
        {
            roomListView.View = View.Details;
            roomListView.Columns.Add ("Room ID", 100);
            roomListView.Columns.Add ("Host", 100);
            roomListView.Columns.Add ("Opponent", 100);
            roomListView.Columns.Add ("Status", 100);
            roomListView.Columns.Add ("Category", 100);
            roomListView.Columns.Add ("Watchers", 100);


        }
        public void getRooms ()
        {
            try
            {
                bool flag = true;
                roomListView.Items.Clear ();
                RoomList.Clear ();
                Bw.Write ("r,get");
                while (flag)
                {
                    if (Stream.DataAvailable)
                    {
                        rooms = Br.ReadString ().Split (';');
                        flag = false;
                    }
                }
                for (int i = 0; i < rooms.Length; i++)
                {
                    if (rooms[i].Contains (","))
                    {
                        try
                        {
                            string[] roomInfo = rooms[i].Split (",");
                            int roomId = int.Parse (roomInfo[0]);
                            RoomList.Add (roomId, rooms[i]);

                            // Create a ListViewItem and add subitems
                            ListViewItem item = new ListViewItem (roomInfo[0]); // Room ID
                            item.SubItems.Add (roomInfo[2]); // Host
                            item.SubItems.Add (roomInfo[3]); // Opponent
                            item.SubItems.Add (roomInfo[4]); // Status
                            item.SubItems.Add (roomInfo[6]); // Category
                            item.SubItems.Add (roomInfo[8]); // Watchers

                            roomListView.Items.Add (item);
                        }
                        catch (Exception e)
                        {
                        }
                    }
                }
            }
            catch (IOException)
            {
                MessageBox.Show ("Server is disconnected, please close and try again.");
            }
            catch (Exception ex)
            {
                MessageBox.Show ($"An error occurred: {ex.Message}");
            }
        }

        private void LobbyForm_Load (object sender, EventArgs e)
        {
            getRooms ();
        }

        private void createBtn_Click (object sender, EventArgs e)
        {
            chooseCategory = new Thread (openSelectRoomCategory);
            Close ();
            chooseCategory.Start ();
        }
        public void openSelectRoomCategory ()
        {
            Application.Run (new SelectRoomType (Stream, Name));
        }

        private void roomListView_SelectedValueChanged (object sender, EventArgs e)
        {
            if (roomListView.SelectedItems.Count > 0)
            {
                joinBtn.Enabled = true;
                watchBtn.Enabled = true;
            }
            else
            {
                joinBtn.Enabled = false;
                watchBtn.Enabled = false;
            }
        }

        private void joinBtn_Click (object sender, EventArgs e)
        {
            if (roomListView.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = roomListView.SelectedItems[0];

                string[] roomInfo = new string[selectedItem.SubItems.Count];
                for (int i = 0; i < selectedItem.SubItems.Count; i++)
                {
                    roomInfo[i] = selectedItem.SubItems[i].Text;
                }

                // Assuming the first subitem is the Room ID
                int roomId = int.Parse (roomInfo[0]); // Room ID
                string player2 = roomInfo[2]; // Opponent

                if (!string.IsNullOrEmpty (player2))
                {
                    MessageBox.Show ("Sorry, Room Is Full");
                }
                else
                {
                    joinRoom = RoomList[roomId].Split (",");
                    try
                    {
                        Bw.Write ("r,join," + roomId);
                        // Wait for the request
                        bool flag = true;
                        string OwnerMsg;

                        while (flag)
                        {
                            if (Stream.DataAvailable)
                            {
                                OwnerMsg = Br.ReadString ();
                                switch (OwnerMsg)
                                {
                                    case "accept":
                                        goplay = new Thread (play);
                                        Close ();
                                        goplay.Start ();
                                        break;
                                    case "reject":
                                        MessageBox.Show ("can't watch");
                                        break;
                                }
                                flag = false;
                            }
                        }
                    }
                    catch (IOException)
                    {
                        MessageBox.Show ("Server is disconnected, close and try again");
                    }
                }
            }
            else
            {
                MessageBox.Show ("Please select a room to join.");
            }
        }

        void play ()
        {
            // i will join to play else i will watch the game
            if (joinRoom[3] == "")
                Application.Run (new PlayingRoomForm (Stream, joinRoom[0], joinRoom[7], joinRoom[2], joinRoom[6], Name, "r"));
            else
                Application.Run (new PlayingRoomForm (Stream, joinRoom[0], joinRoom[7], joinRoom[2], joinRoom[6], joinRoom[3], "w", Name));

        }

        private void watchBtn_Click (object sender, EventArgs e)
        {
            if (roomListView.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = roomListView.SelectedItems[0];

                string[] roomInfo = new string[selectedItem.SubItems.Count];
                for (int i = 0; i < selectedItem.SubItems.Count; i++)
                {
                    roomInfo[i] = selectedItem.SubItems[i].Text;
                }

                int roomId = int.Parse (roomInfo[0]); 
                joinRoom = RoomList[roomId].Split (",");

                bool player2 = string.IsNullOrEmpty (roomInfo[2]); 

                if (player2)
                {
                    MessageBox.Show ("Sorry, Room Not Started Yet!");
                }
                else
                {
                    try
                    {
                        Bw.Write ($"r,watch,{roomId},i");

                        bool flag = true;
                        string OwnerMsg;
                        while (flag)
                        {
                            if (Stream.DataAvailable)
                            {
                                OwnerMsg = Br.ReadString ();
                                switch (OwnerMsg)
                                {
                                    case "watch,accept":
                                        goplay = new Thread (play);
                                        Close ();
                                        goplay.Start ();
                                        break;
                                    case "watch,reject":
                                        MessageBox.Show ("refused");
                                        break;
                                }
                                flag = false;
                            }
                        }
                    }
                    catch (IOException)
                    {
                        MessageBox.Show ("Server is disconnected, close and try again");
                    }
                }
            }
            else
            {
                MessageBox.Show ("Please select a room to watch.");
            }
        }

    }
}
