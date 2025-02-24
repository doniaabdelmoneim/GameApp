namespace ClientGameApp
{
    partial class LobbyForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent ()
        {
            welcomeNamedLabel = new Label ();
            joinBtn = new MaterialSkin.Controls.MaterialButton ();
            createBtn = new MaterialSkin.Controls.MaterialButton ();
            watchBtn = new MaterialSkin.Controls.MaterialButton ();
            materialButton1 = new MaterialSkin.Controls.MaterialButton ();
            roomListView = new ListView ();
            SuspendLayout ();
            // 
            // welcomeNamedLabel
            // 
            welcomeNamedLabel.AutoSize = true;
            welcomeNamedLabel.BackColor = Color.Transparent;
            welcomeNamedLabel.Font = new Font ("Verdana", 11.25F,  FontStyle.Bold  |  FontStyle.Italic , GraphicsUnit.Point, 0);
            welcomeNamedLabel.ForeColor = Color.White;
            welcomeNamedLabel.Location = new Point (546, 37);
            welcomeNamedLabel.Name = "welcomeNamedLabel";
            welcomeNamedLabel.Size = new Size (94, 18);
            welcomeNamedLabel.TabIndex = 1;
            welcomeNamedLabel.Text = "Welcome ,";
            welcomeNamedLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // joinBtn
            // 
            joinBtn.AutoSize = false;
            joinBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            joinBtn.BackColor = SystemColors.Control;
            joinBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            joinBtn.Depth = 0;
            joinBtn.HighEmphasis = true;
            joinBtn.Icon = null;
            joinBtn.Location = new Point (645, 198);
            joinBtn.Margin = new Padding (4);
            joinBtn.MouseState = MaterialSkin.MouseState.HOVER;
            joinBtn.Name = "joinBtn";
            joinBtn.NoAccentTextColor = Color.Empty;
            joinBtn.Size = new Size (130, 45);
            joinBtn.TabIndex = 4;
            joinBtn.Text = "Join";
            joinBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            joinBtn.UseAccentColor = false;
            joinBtn.UseVisualStyleBackColor = false;
            joinBtn.Click +=  joinBtn_Click ;
            // 
            // createBtn
            // 
            createBtn.AutoSize = false;
            createBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            createBtn.BackColor = SystemColors.Control;
            createBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            createBtn.Depth = 0;
            createBtn.HighEmphasis = true;
            createBtn.Icon = null;
            createBtn.Location = new Point (645, 283);
            createBtn.Margin = new Padding (4);
            createBtn.MouseState = MaterialSkin.MouseState.HOVER;
            createBtn.Name = "createBtn";
            createBtn.NoAccentTextColor = Color.Empty;
            createBtn.Size = new Size (130, 45);
            createBtn.TabIndex = 5;
            createBtn.Text = "Create";
            createBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            createBtn.UseAccentColor = false;
            createBtn.UseVisualStyleBackColor = false;
            createBtn.Click +=  createBtn_Click ;
            // 
            // watchBtn
            // 
            watchBtn.AutoSize = false;
            watchBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            watchBtn.BackColor = SystemColors.Control;
            watchBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            watchBtn.Depth = 0;
            watchBtn.HighEmphasis = true;
            watchBtn.Icon = null;
            watchBtn.Location = new Point (645, 366);
            watchBtn.Margin = new Padding (4);
            watchBtn.MouseState = MaterialSkin.MouseState.HOVER;
            watchBtn.Name = "watchBtn";
            watchBtn.NoAccentTextColor = Color.Empty;
            watchBtn.Size = new Size (130, 45);
            watchBtn.TabIndex = 6;
            watchBtn.Text = "Watch";
            watchBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            watchBtn.UseAccentColor = false;
            watchBtn.UseVisualStyleBackColor = false;
            watchBtn.Click +=  watchBtn_Click ;
            // 
            // materialButton1
            // 
            materialButton1.AccessibleRole = AccessibleRole.None;
            materialButton1.AutoSize = false;
            materialButton1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton1.Depth = 0;
            materialButton1.HighEmphasis = true;
            materialButton1.Icon = null;
            materialButton1.Location = new Point (645, 118);
            materialButton1.Margin = new Padding (4);
            materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton1.Name = "materialButton1";
            materialButton1.NoAccentTextColor = Color.Empty;
            materialButton1.Size = new Size (130, 45);
            materialButton1.TabIndex = 7;
            materialButton1.Text = "Refresh";
            materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton1.UseAccentColor = false;
            materialButton1.UseVisualStyleBackColor = true;
            materialButton1.Click +=  LobbyForm_Load ;
            // 
            // roomListView
            // 
            roomListView.Font = new Font ("MS Reference Sans Serif", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            roomListView.FullRowSelect = true;
            roomListView.HoverSelection = true;
            roomListView.Location = new Point (24, 118);
            roomListView.Name = "roomListView";
            roomListView.Size = new Size (597, 293);
            roomListView.TabIndex = 9;
            roomListView.UseCompatibleStateImageBehavior = false;
            roomListView.SelectedIndexChanged +=  roomListView_SelectedValueChanged ;
            // 
            // LobbyForm
            // 
            AutoScaleDimensions = new SizeF (7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size (799, 464);
            Controls.Add (roomListView);
            Controls.Add (materialButton1);
            Controls.Add (watchBtn);
            Controls.Add (createBtn);
            Controls.Add (joinBtn);
            Controls.Add (welcomeNamedLabel);
            Margin = new Padding (3, 2, 3, 2);
            Name = "LobbyForm";
            Padding = new Padding (3, 48, 3, 2);
            Text = "LobbyForm";
            Load +=  LobbyForm_Load ;
            ResumeLayout (false);
            PerformLayout ();
        }

        #endregion

        private Label welcomeNamedLabel;
        private MaterialSkin.Controls.MaterialButton joinBtn;
        private MaterialSkin.Controls.MaterialButton createBtn;
        private MaterialSkin.Controls.MaterialButton watchBtn;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private ListView roomListView;
    }
}