namespace ClientGameApp
{
    partial class SelectRoomType
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
            categoriesDropDown = new MaterialSkin.Controls.MaterialComboBox ();
            materialButton1 = new MaterialSkin.Controls.MaterialButton ();
            SuspendLayout ();
            // 
            // welcomeNamedLabel
            // 
            welcomeNamedLabel.AutoSize = true;
            welcomeNamedLabel.BackColor = Color.Transparent;
            welcomeNamedLabel.Font = new Font ("Verdana", 12F,  FontStyle.Bold  |  FontStyle.Italic , GraphicsUnit.Point, 0);
            welcomeNamedLabel.ForeColor = Color.White;
            welcomeNamedLabel.Location = new Point (481, 37);
            welcomeNamedLabel.Name = "welcomeNamedLabel";
            welcomeNamedLabel.Size = new Size (99, 18);
            welcomeNamedLabel.TabIndex = 2;
            welcomeNamedLabel.Text = "Welcome ,";
            welcomeNamedLabel.Click +=  welcomeNamedLabel_Click ;
            // 
            // categoriesDropDown
            // 
            categoriesDropDown.AutoResize = false;
            categoriesDropDown.BackColor = Color.FromArgb (255, 255, 255);
            categoriesDropDown.Depth = 0;
            categoriesDropDown.DrawMode = DrawMode.OwnerDrawVariable;
            categoriesDropDown.DropDownHeight = 174;
            categoriesDropDown.DropDownStyle = ComboBoxStyle.DropDownList;
            categoriesDropDown.DropDownWidth = 121;
            categoriesDropDown.Font = new Font ("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            categoriesDropDown.ForeColor = Color.FromArgb (222, 0, 0, 0);
            categoriesDropDown.FormattingEnabled = true;
            categoriesDropDown.IntegralHeight = false;
            categoriesDropDown.ItemHeight = 43;
            categoriesDropDown.Location = new Point (182, 149);
            categoriesDropDown.Margin = new Padding (3, 2, 3, 2);
            categoriesDropDown.MaxDropDownItems = 4;
            categoriesDropDown.MouseState = MaterialSkin.MouseState.OUT;
            categoriesDropDown.Name = "categoriesDropDown";
            categoriesDropDown.Size = new Size (345, 49);
            categoriesDropDown.StartIndex = 0;
            categoriesDropDown.TabIndex = 3;
            // 
            // materialButton1
            // 
            materialButton1.AutoSize = false;
            materialButton1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton1.Depth = 0;
            materialButton1.Font = new Font ("Segoe UI Semibold", 9.75F,  FontStyle.Bold  |  FontStyle.Italic , GraphicsUnit.Point, 0);
            materialButton1.HighEmphasis = true;
            materialButton1.Icon = null;
            materialButton1.Location = new Point (270, 251);
            materialButton1.Margin = new Padding (4);
            materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton1.Name = "materialButton1";
            materialButton1.NoAccentTextColor = Color.Empty;
            materialButton1.Size = new Size (129, 54);
            materialButton1.TabIndex = 4;
            materialButton1.Text = "Create";
            materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton1.UseAccentColor = false;
            materialButton1.UseVisualStyleBackColor = true;
            materialButton1.Click +=  materialButton1_Click ;
            // 
            // SelectRoomType
            // 
            AutoScaleDimensions = new SizeF (7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size (722, 440);
            Controls.Add (materialButton1);
            Controls.Add (categoriesDropDown);
            Controls.Add (welcomeNamedLabel);
            Margin = new Padding (3, 2, 3, 2);
            Name = "SelectRoomType";
            Padding = new Padding (3, 48, 3, 2);
            Text = "SelectRoomType";
            Load +=  SelectRoomType_Load ;
            ResumeLayout (false);
            PerformLayout ();
        }

        #endregion

        private Label welcomeNamedLabel;
        private MaterialSkin.Controls.MaterialComboBox categoriesDropDown;
        private MaterialSkin.Controls.MaterialButton materialButton1;
    }
}