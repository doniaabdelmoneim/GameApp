namespace ClientGameApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent ()
        {
            loginTextBox = new MaterialSkin.Controls.MaterialMaskedTextBox ();
            loginBtn = new MaterialSkin.Controls.MaterialButton ();
            SuspendLayout ();
            // 
            // loginTextBox
            // 
            loginTextBox.AllowPromptAsInput = true;
            loginTextBox.AnimateReadOnly = false;
            loginTextBox.AsciiOnly = false;
            loginTextBox.BackgroundImageLayout = ImageLayout.None;
            loginTextBox.BeepOnError = false;
            loginTextBox.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            loginTextBox.Depth = 0;
            loginTextBox.Font = new Font ("Lucida Sans Typewriter", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            loginTextBox.HidePromptOnLeave = false;
            loginTextBox.HideSelection = true;
            loginTextBox.InsertKeyMode = InsertKeyMode.Default;
            loginTextBox.LeadingIcon = null;
            loginTextBox.Location = new Point (37, 350);
            loginTextBox.Margin = new Padding (3, 2, 3, 2);
            loginTextBox.Mask = "";
            loginTextBox.MaxLength = 32767;
            loginTextBox.MouseState = MaterialSkin.MouseState.OUT;
            loginTextBox.Name = "loginTextBox";
            loginTextBox.PasswordChar = '\0';
            loginTextBox.PrefixSuffix = MaterialSkin.Controls.MaterialMaskedTextBox.PrefixSuffixTypes.Prefix;
            loginTextBox.PrefixSuffixText = "Enter Your Name";
            loginTextBox.PromptChar = '_';
            loginTextBox.ReadOnly = false;
            loginTextBox.RejectInputOnFirstFailure = false;
            loginTextBox.ResetOnPrompt = true;
            loginTextBox.ResetOnSpace = true;
            loginTextBox.RightToLeft = RightToLeft.No;
            loginTextBox.SelectedText = "";
            loginTextBox.SelectionLength = 0;
            loginTextBox.SelectionStart = 0;
            loginTextBox.ShortcutsEnabled = true;
            loginTextBox.Size = new Size (454, 48);
            loginTextBox.SkipLiterals = true;
            loginTextBox.TabIndex = 0;
            loginTextBox.TabStop = false;
            loginTextBox.TextAlign = HorizontalAlignment.Left;
            loginTextBox.TextMaskFormat = MaskFormat.IncludeLiterals;
            loginTextBox.TrailingIcon = null;
            loginTextBox.UseSystemPasswordChar = false;
            loginTextBox.ValidatingType = null;
            // 
            // loginBtn
            // 
            loginBtn.AutoSize = false;
            loginBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            loginBtn.BackColor = Color.SlateGray;
            loginBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            loginBtn.Depth = 0;
            loginBtn.Font = new Font ("Trebuchet MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            loginBtn.ForeColor = Color.MediumBlue;
            loginBtn.HighEmphasis = true;
            loginBtn.Icon = null;
            loginBtn.Location = new Point (596, 350);
            loginBtn.Margin = new Padding (5, 4, 5, 4);
            loginBtn.MouseState = MaterialSkin.MouseState.HOVER;
            loginBtn.Name = "loginBtn";
            loginBtn.NoAccentTextColor = Color.Empty;
            loginBtn.Size = new Size (132, 48);
            loginBtn.TabIndex = 1;
            loginBtn.Text = "Login";
            loginBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            loginBtn.UseAccentColor = false;
            loginBtn.UseVisualStyleBackColor = false;
            loginBtn.Click +=  loginBtn_Click ;
            loginBtn.Resize +=  loginBtn_Resize ;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF (8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.img4;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size (805, 424);
            Controls.Add (loginBtn);
            Controls.Add (loginTextBox);
            Font = new Font ("MS Reference Sans Serif", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Margin = new Padding (3, 2, 3, 2);
            Name = "Form1";
            Padding = new Padding (3, 51, 3, 2);
            Text = "Guess The Name";
            Resize +=  Form1_Resize ;
            ResumeLayout (false);
        }

        #endregion

        private MaterialSkin.Controls.MaterialMaskedTextBox loginTextBox;
        private MaterialSkin.Controls.MaterialButton loginBtn;
    }
}
