namespace ClientGameApp
{
    partial class PlayingRoomForm
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
            p1NameLabel = new Label ();
            p2NameLabel = new MaterialSkin.Controls.MaterialLabel ();
            p2StatusLabel = new MaterialSkin.Controls.MaterialLabel ();
            p1StatusLabel = new MaterialSkin.Controls.MaterialLabel ();
            categoryRoomLabel = new MaterialSkin.Controls.MaterialLabel ();
            welcomeNamedLabel = new Label ();
            exit = new MaterialSkin.Controls.MaterialButton ();
            groupBox_Key = new GroupBox ();
            btnQ = new Button ();
            btnV = new Button ();
            btnP = new Button ();
            btnW = new Button ();
            btnO = new Button ();
            btnS = new Button ();
            btnZ = new Button ();
            btnT = new Button ();
            btnR = new Button ();
            btnM = new Button ();
            btnY = new Button ();
            btnL = new Button ();
            btnN = new Button ();
            btnK = new Button ();
            btnX = new Button ();
            btnJ = new Button ();
            btnU = new Button ();
            btnH = new Button ();
            btnI = new Button ();
            btnF = new Button ();
            btnG = new Button ();
            btnE = new Button ();
            btnD = new Button ();
            btnC = new Button ();
            btnB = new Button ();
            btnA = new Button ();
            groupBox_word = new GroupBox ();
            lbl_word = new Label ();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel ();
            materialLabel2 = new MaterialSkin.Controls.MaterialLabel ();
            materialLabel3 = new MaterialSkin.Controls.MaterialLabel ();
            materialLabel4 = new MaterialSkin.Controls.MaterialLabel ();
            groupBox_Key.SuspendLayout ();
            groupBox_word.SuspendLayout ();
            SuspendLayout ();
            // 
            // p1NameLabel
            // 
            p1NameLabel.AutoSize = true;
            p1NameLabel.Font = new Font ("Verdana", 14.25F,  FontStyle.Bold  |  FontStyle.Italic , GraphicsUnit.Point, 0);
            p1NameLabel.Location = new Point (124, 71);
            p1NameLabel.Name = "p1NameLabel";
            p1NameLabel.Size = new Size (108, 23);
            p1NameLabel.TabIndex = 0;
            p1NameLabel.Text = "_______";
            // 
            // p2NameLabel
            // 
            p2NameLabel.AutoSize = true;
            p2NameLabel.Depth = 0;
            p2NameLabel.Font = new Font ("Verdana", 14.25F,  FontStyle.Bold  |  FontStyle.Italic , GraphicsUnit.Point, 0);
            p2NameLabel.Location = new Point (556, 77);
            p2NameLabel.MouseState = MaterialSkin.MouseState.HOVER;
            p2NameLabel.Name = "p2NameLabel";
            p2NameLabel.Size = new Size (113, 19);
            p2NameLabel.TabIndex = 1;
            p2NameLabel.Text = "________________";
            // 
            // p2StatusLabel
            // 
            p2StatusLabel.AutoSize = true;
            p2StatusLabel.Depth = 0;
            p2StatusLabel.Font = new Font ("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            p2StatusLabel.Location = new Point (556, 115);
            p2StatusLabel.MouseState = MaterialSkin.MouseState.HOVER;
            p2StatusLabel.Name = "p2StatusLabel";
            p2StatusLabel.Size = new Size (99, 19);
            p2StatusLabel.TabIndex = 2;
            p2StatusLabel.Text = "______________";
            // 
            // p1StatusLabel
            // 
            p1StatusLabel.AutoSize = true;
            p1StatusLabel.Depth = 0;
            p1StatusLabel.Font = new Font ("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            p1StatusLabel.Location = new Point (123, 117);
            p1StatusLabel.MouseState = MaterialSkin.MouseState.HOVER;
            p1StatusLabel.Name = "p1StatusLabel";
            p1StatusLabel.Size = new Size (85, 19);
            p1StatusLabel.TabIndex = 3;
            p1StatusLabel.Text = "____________";
            // 
            // categoryRoomLabel
            // 
            categoryRoomLabel.AutoSize = true;
            categoryRoomLabel.Depth = 0;
            categoryRoomLabel.Font = new Font ("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            categoryRoomLabel.Location = new Point (298, 77);
            categoryRoomLabel.MouseState = MaterialSkin.MouseState.HOVER;
            categoryRoomLabel.Name = "categoryRoomLabel";
            categoryRoomLabel.Size = new Size (13, 19);
            categoryRoomLabel.TabIndex = 4;
            categoryRoomLabel.Text = "...";
            // 
            // welcomeNamedLabel
            // 
            welcomeNamedLabel.AutoSize = true;
            welcomeNamedLabel.BackColor = Color.Transparent;
            welcomeNamedLabel.Font = new Font ("Verdana", 11.25F,  FontStyle.Bold  |  FontStyle.Italic , GraphicsUnit.Point, 0);
            welcomeNamedLabel.ForeColor = Color.White;
            welcomeNamedLabel.Location = new Point (502, 37);
            welcomeNamedLabel.Name = "welcomeNamedLabel";
            welcomeNamedLabel.Size = new Size (94, 18);
            welcomeNamedLabel.TabIndex = 5;
            welcomeNamedLabel.Text = "Welcome ,";
            // 
            // exit
            // 
            exit.AutoSize = false;
            exit.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            exit.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            exit.Depth = 0;
            exit.HighEmphasis = true;
            exit.Icon = null;
            exit.Location = new Point (571, 335);
            exit.Margin = new Padding (4);
            exit.MouseState = MaterialSkin.MouseState.HOVER;
            exit.Name = "exit";
            exit.NoAccentTextColor = Color.Empty;
            exit.Size = new Size (98, 42);
            exit.TabIndex = 6;
            exit.Text = "Exit";
            exit.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            exit.UseAccentColor = false;
            exit.UseVisualStyleBackColor = true;
            exit.Click +=  exit_Click ;
            // 
            // groupBox_Key
            // 
            groupBox_Key.BackColor = Color.Transparent;
            groupBox_Key.Controls.Add (btnQ);
            groupBox_Key.Controls.Add (btnV);
            groupBox_Key.Controls.Add (btnP);
            groupBox_Key.Controls.Add (btnW);
            groupBox_Key.Controls.Add (btnO);
            groupBox_Key.Controls.Add (btnS);
            groupBox_Key.Controls.Add (btnZ);
            groupBox_Key.Controls.Add (btnT);
            groupBox_Key.Controls.Add (btnR);
            groupBox_Key.Controls.Add (btnM);
            groupBox_Key.Controls.Add (btnY);
            groupBox_Key.Controls.Add (btnL);
            groupBox_Key.Controls.Add (btnN);
            groupBox_Key.Controls.Add (btnK);
            groupBox_Key.Controls.Add (btnX);
            groupBox_Key.Controls.Add (btnJ);
            groupBox_Key.Controls.Add (btnU);
            groupBox_Key.Controls.Add (btnH);
            groupBox_Key.Controls.Add (btnI);
            groupBox_Key.Controls.Add (btnF);
            groupBox_Key.Controls.Add (btnG);
            groupBox_Key.Controls.Add (btnE);
            groupBox_Key.Controls.Add (btnD);
            groupBox_Key.Controls.Add (btnC);
            groupBox_Key.Controls.Add (btnB);
            groupBox_Key.Controls.Add (btnA);
            groupBox_Key.Location = new Point (139, 236);
            groupBox_Key.Name = "groupBox_Key";
            groupBox_Key.Size = new Size (377, 141);
            groupBox_Key.TabIndex = 34;
            groupBox_Key.TabStop = false;
            groupBox_Key.Text = "KeyPad";
            // 
            // btnQ
            // 
            btnQ.Font = new Font ("Tahoma", 11.25F, FontStyle.Italic);
            btnQ.Location = new Point (240, 58);
            btnQ.Name = "btnQ";
            btnQ.Size = new Size (28, 30);
            btnQ.TabIndex = 51;
            btnQ.Text = "Q";
            btnQ.UseVisualStyleBackColor = true;
            btnQ.Click +=  btnA_Click ;
            // 
            // btnV
            // 
            btnV.Font = new Font ("Tahoma", 11.25F, FontStyle.Italic);
            btnV.Location = new Point (150, 89);
            btnV.Name = "btnV";
            btnV.Size = new Size (28, 30);
            btnV.TabIndex = 50;
            btnV.Text = "V";
            btnV.UseVisualStyleBackColor = true;
            btnV.Click +=  btnA_Click ;
            // 
            // btnP
            // 
            btnP.Font = new Font ("Tahoma", 11.25F, FontStyle.Italic);
            btnP.Location = new Point (210, 58);
            btnP.Name = "btnP";
            btnP.Size = new Size (28, 30);
            btnP.TabIndex = 49;
            btnP.Text = "P";
            btnP.UseVisualStyleBackColor = true;
            btnP.Click +=  btnA_Click ;
            // 
            // btnW
            // 
            btnW.Font = new Font ("Tahoma", 11.25F, FontStyle.Italic);
            btnW.Location = new Point (180, 89);
            btnW.Name = "btnW";
            btnW.Size = new Size (28, 30);
            btnW.TabIndex = 48;
            btnW.Text = "W";
            btnW.UseVisualStyleBackColor = true;
            btnW.Click +=  btnA_Click ;
            // 
            // btnO
            // 
            btnO.Font = new Font ("Tahoma", 11.25F, FontStyle.Italic);
            btnO.Location = new Point (180, 58);
            btnO.Name = "btnO";
            btnO.Size = new Size (28, 30);
            btnO.TabIndex = 47;
            btnO.Text = "O";
            btnO.UseVisualStyleBackColor = true;
            btnO.Click +=  btnA_Click ;
            // 
            // btnS
            // 
            btnS.Font = new Font ("Tahoma", 11.25F, FontStyle.Italic);
            btnS.Location = new Point (300, 58);
            btnS.Name = "btnS";
            btnS.Size = new Size (28, 30);
            btnS.TabIndex = 46;
            btnS.Text = "S";
            btnS.UseVisualStyleBackColor = true;
            btnS.Click +=  btnA_Click ;
            // 
            // btnZ
            // 
            btnZ.Font = new Font ("Tahoma", 11.25F, FontStyle.Italic);
            btnZ.Location = new Point (273, 89);
            btnZ.Name = "btnZ";
            btnZ.Size = new Size (28, 30);
            btnZ.TabIndex = 45;
            btnZ.Text = "Z";
            btnZ.UseVisualStyleBackColor = true;
            btnZ.Click +=  btnA_Click ;
            // 
            // btnT
            // 
            btnT.Font = new Font ("Tahoma", 11.25F, FontStyle.Italic);
            btnT.Location = new Point (87, 89);
            btnT.Name = "btnT";
            btnT.Size = new Size (28, 30);
            btnT.TabIndex = 44;
            btnT.Text = "T";
            btnT.UseVisualStyleBackColor = true;
            btnT.Click +=  btnA_Click ;
            // 
            // btnR
            // 
            btnR.Font = new Font ("Tahoma", 11.25F, FontStyle.Italic);
            btnR.Location = new Point (270, 58);
            btnR.Name = "btnR";
            btnR.Size = new Size (28, 30);
            btnR.TabIndex = 43;
            btnR.Text = "R";
            btnR.UseVisualStyleBackColor = true;
            btnR.Click +=  btnA_Click ;
            // 
            // btnM
            // 
            btnM.Font = new Font ("Tahoma", 11.25F, FontStyle.Italic);
            btnM.Location = new Point (120, 58);
            btnM.Name = "btnM";
            btnM.Size = new Size (28, 30);
            btnM.TabIndex = 42;
            btnM.Text = "M";
            btnM.UseVisualStyleBackColor = true;
            btnM.Click +=  btnA_Click ;
            // 
            // btnY
            // 
            btnY.Font = new Font ("Tahoma", 11.25F, FontStyle.Italic);
            btnY.Location = new Point (241, 89);
            btnY.Name = "btnY";
            btnY.Size = new Size (28, 30);
            btnY.TabIndex = 41;
            btnY.Text = "Y";
            btnY.UseVisualStyleBackColor = true;
            btnY.Click +=  btnA_Click ;
            // 
            // btnL
            // 
            btnL.Font = new Font ("Tahoma", 11.25F, FontStyle.Italic);
            btnL.Location = new Point (90, 58);
            btnL.Name = "btnL";
            btnL.Size = new Size (28, 30);
            btnL.TabIndex = 40;
            btnL.Text = "L";
            btnL.UseVisualStyleBackColor = true;
            btnL.Click +=  btnA_Click ;
            // 
            // btnN
            // 
            btnN.Font = new Font ("Tahoma", 11.25F, FontStyle.Italic);
            btnN.Location = new Point (150, 58);
            btnN.Name = "btnN";
            btnN.Size = new Size (28, 30);
            btnN.TabIndex = 39;
            btnN.Text = "N";
            btnN.UseVisualStyleBackColor = true;
            btnN.Click +=  btnA_Click ;
            // 
            // btnK
            // 
            btnK.Font = new Font ("Tahoma", 11.25F, FontStyle.Italic);
            btnK.Location = new Point (60, 58);
            btnK.Name = "btnK";
            btnK.Size = new Size (28, 30);
            btnK.TabIndex = 38;
            btnK.Text = "K";
            btnK.UseVisualStyleBackColor = true;
            btnK.Click +=  btnA_Click ;
            // 
            // btnX
            // 
            btnX.Font = new Font ("Tahoma", 11.25F, FontStyle.Italic);
            btnX.Location = new Point (210, 89);
            btnX.Name = "btnX";
            btnX.Size = new Size (28, 30);
            btnX.TabIndex = 37;
            btnX.Text = "X";
            btnX.UseVisualStyleBackColor = true;
            btnX.Click +=  btnA_Click ;
            // 
            // btnJ
            // 
            btnJ.Font = new Font ("Tahoma", 11.25F, FontStyle.Italic);
            btnJ.Location = new Point (311, 27);
            btnJ.Name = "btnJ";
            btnJ.Size = new Size (28, 30);
            btnJ.TabIndex = 36;
            btnJ.Text = "J";
            btnJ.UseVisualStyleBackColor = true;
            btnJ.Click +=  btnA_Click ;
            // 
            // btnU
            // 
            btnU.Font = new Font ("Tahoma", 11.25F, FontStyle.Italic);
            btnU.Location = new Point (120, 89);
            btnU.Name = "btnU";
            btnU.Size = new Size (28, 30);
            btnU.TabIndex = 35;
            btnU.Text = "U";
            btnU.UseVisualStyleBackColor = true;
            btnU.Click +=  btnA_Click ;
            // 
            // btnH
            // 
            btnH.Font = new Font ("Tahoma", 11.25F, FontStyle.Italic);
            btnH.Location = new Point (251, 27);
            btnH.Name = "btnH";
            btnH.Size = new Size (28, 30);
            btnH.TabIndex = 34;
            btnH.Text = "H";
            btnH.UseVisualStyleBackColor = true;
            btnH.Click +=  btnA_Click ;
            // 
            // btnI
            // 
            btnI.Font = new Font ("Tahoma", 11.25F, FontStyle.Italic);
            btnI.Location = new Point (281, 27);
            btnI.Name = "btnI";
            btnI.Size = new Size (28, 30);
            btnI.TabIndex = 33;
            btnI.Text = "I";
            btnI.UseVisualStyleBackColor = true;
            btnI.Click +=  btnA_Click ;
            // 
            // btnF
            // 
            btnF.Font = new Font ("Tahoma", 11.25F, FontStyle.Italic);
            btnF.Location = new Point (191, 27);
            btnF.Name = "btnF";
            btnF.Size = new Size (28, 30);
            btnF.TabIndex = 32;
            btnF.Text = "F";
            btnF.UseVisualStyleBackColor = true;
            btnF.Click +=  btnA_Click ;
            // 
            // btnG
            // 
            btnG.Font = new Font ("Tahoma", 11.25F, FontStyle.Italic);
            btnG.Location = new Point (221, 27);
            btnG.Name = "btnG";
            btnG.Size = new Size (28, 30);
            btnG.TabIndex = 31;
            btnG.Text = "G";
            btnG.UseVisualStyleBackColor = true;
            btnG.Click +=  btnA_Click ;
            // 
            // btnE
            // 
            btnE.Font = new Font ("Tahoma", 11.25F, FontStyle.Italic);
            btnE.Location = new Point (161, 27);
            btnE.Name = "btnE";
            btnE.Size = new Size (28, 30);
            btnE.TabIndex = 30;
            btnE.Text = "E";
            btnE.UseVisualStyleBackColor = true;
            btnE.Click +=  btnA_Click ;
            // 
            // btnD
            // 
            btnD.Font = new Font ("Tahoma", 11.25F, FontStyle.Italic);
            btnD.Location = new Point (131, 27);
            btnD.Name = "btnD";
            btnD.Size = new Size (28, 30);
            btnD.TabIndex = 29;
            btnD.Text = "D";
            btnD.UseVisualStyleBackColor = true;
            btnD.Click +=  btnA_Click ;
            // 
            // btnC
            // 
            btnC.Font = new Font ("Tahoma", 11.25F, FontStyle.Italic);
            btnC.Location = new Point (101, 27);
            btnC.Name = "btnC";
            btnC.Size = new Size (28, 30);
            btnC.TabIndex = 28;
            btnC.Text = "C";
            btnC.UseVisualStyleBackColor = true;
            btnC.Click +=  btnA_Click ;
            // 
            // btnB
            // 
            btnB.Font = new Font ("Tahoma", 11.25F, FontStyle.Italic);
            btnB.Location = new Point (71, 27);
            btnB.Name = "btnB";
            btnB.Size = new Size (28, 30);
            btnB.TabIndex = 27;
            btnB.Text = "B";
            btnB.UseVisualStyleBackColor = true;
            btnB.Click +=  btnA_Click ;
            // 
            // btnA
            // 
            btnA.Font = new Font ("Tahoma", 11.25F, FontStyle.Italic);
            btnA.Location = new Point (41, 27);
            btnA.Name = "btnA";
            btnA.Size = new Size (28, 30);
            btnA.TabIndex = 26;
            btnA.Text = "A";
            btnA.UseVisualStyleBackColor = true;
            btnA.Click +=  btnA_Click ;
            // 
            // groupBox_word
            // 
            groupBox_word.Controls.Add (lbl_word);
            groupBox_word.Location = new Point (139, 161);
            groupBox_word.Name = "groupBox_word";
            groupBox_word.Size = new Size (377, 54);
            groupBox_word.TabIndex = 35;
            groupBox_word.TabStop = false;
            groupBox_word.Text = "Guess The Following Word";
            // 
            // lbl_word
            // 
            lbl_word.AutoSize = true;
            lbl_word.Font = new Font ("Segoe UI", 20F);
            lbl_word.Location = new Point (150, 14);
            lbl_word.Name = "lbl_word";
            lbl_word.Size = new Size (78, 37);
            lbl_word.TabIndex = 0;
            lbl_word.Text = "word";
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font ("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.ForeColor = SystemColors.Desktop;
            materialLabel1.Location = new Point (60, 79);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size (58, 19);
            materialLabel1.TabIndex = 36;
            materialLabel1.Text = "Player 1";
            // 
            // materialLabel2
            // 
            materialLabel2.AutoSize = true;
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font ("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel2.Location = new Point (61, 115);
            materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size (47, 19);
            materialLabel2.TabIndex = 37;
            materialLabel2.Text = "Status";
            // 
            // materialLabel3
            // 
            materialLabel3.AutoSize = true;
            materialLabel3.Depth = 0;
            materialLabel3.Font = new Font ("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel3.Location = new Point (492, 115);
            materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel3.Name = "materialLabel3";
            materialLabel3.Size = new Size (47, 19);
            materialLabel3.TabIndex = 39;
            materialLabel3.Text = "Status";
            // 
            // materialLabel4
            // 
            materialLabel4.AutoSize = true;
            materialLabel4.Depth = 0;
            materialLabel4.Font = new Font ("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel4.Location = new Point (492, 79);
            materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel4.Name = "materialLabel4";
            materialLabel4.Size = new Size (58, 19);
            materialLabel4.TabIndex = 38;
            materialLabel4.Text = "Player 2";
            // 
            // PlayingRoomForm
            // 
            AutoScaleDimensions = new SizeF (7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size (700, 407);
            Controls.Add (materialLabel3);
            Controls.Add (materialLabel4);
            Controls.Add (materialLabel2);
            Controls.Add (materialLabel1);
            Controls.Add (groupBox_word);
            Controls.Add (groupBox_Key);
            Controls.Add (exit);
            Controls.Add (welcomeNamedLabel);
            Controls.Add (categoryRoomLabel);
            Controls.Add (p1StatusLabel);
            Controls.Add (p2StatusLabel);
            Controls.Add (p2NameLabel);
            Controls.Add (p1NameLabel);
            Margin = new Padding (3, 2, 3, 2);
            Name = "PlayingRoomForm";
            Padding = new Padding (3, 48, 3, 2);
            Text = "PlayingRoomForm";
            Load +=  PlayingRoomForm_Load ;
            groupBox_Key.ResumeLayout (false);
            groupBox_word.ResumeLayout (false);
            groupBox_word.PerformLayout ();
            ResumeLayout (false);
            PerformLayout ();
        }

        #endregion

        private Label p1NameLabel;
        private MaterialSkin.Controls.MaterialLabel p2NameLabel;
        private MaterialSkin.Controls.MaterialLabel p2StatusLabel;
        private MaterialSkin.Controls.MaterialLabel p1StatusLabel;
        private MaterialSkin.Controls.MaterialLabel categoryRoomLabel;
        private Label welcomeNamedLabel;
        private MaterialSkin.Controls.MaterialButton exit;
        private GroupBox groupBox_Key;
        private Button btnQ;
        private Button btnV;
        private Button btnP;
        private Button btnW;
        private Button btnO;
        private Button btnS;
        private Button btnZ;
        private Button btnT;
        private Button btnR;
        private Button btnM;
        private Button btnY;
        private Button btnL;
        private Button btnN;
        private Button btnK;
        private Button btnX;
        private Button btnJ;
        private Button btnU;
        private Button btnH;
        private Button btnI;
        private Button btnF;
        private Button btnG;
        private Button btnE;
        private Button btnD;
        private Button btnC;
        private Button btnB;
        private Button btnA;
        private GroupBox groupBox_word;
        private Label lbl_word;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
    }
}