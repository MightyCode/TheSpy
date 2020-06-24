namespace theSpyCardEditor
{
    partial class CardStandardModif
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
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CardStandardModif));
            this.labelId = new System.Windows.Forms.Label();
            this.labelHeader = new System.Windows.Forms.Label();
            this.labelBackground = new System.Windows.Forms.Label();
            this.labelTextDes = new System.Windows.Forms.Label();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.pictureImage = new System.Windows.Forms.PictureBox();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.textBoxHeader = new System.Windows.Forms.TextBox();
            this.textBoxBackground = new System.Windows.Forms.TextBox();
            this.textBoxTextLeft = new System.Windows.Forms.TextBox();
            this.labelTextLeft = new System.Windows.Forms.Label();
            this.textBoxTextRight = new System.Windows.Forms.TextBox();
            this.textBoxEffectLeft = new System.Windows.Forms.TextBox();
            this.textBoxEffectRight = new System.Windows.Forms.TextBox();
            this.textBoxConditionLeft = new System.Windows.Forms.TextBox();
            this.textBoxConditionRight = new System.Windows.Forms.TextBox();
            this.labelEffectLeft = new System.Windows.Forms.Label();
            this.labelConditionLeft = new System.Windows.Forms.Label();
            this.labelTextRight = new System.Windows.Forms.Label();
            this.labelEffectRight = new System.Windows.Forms.Label();
            this.labelWeight = new System.Windows.Forms.Label();
            this.textBoxWeight = new System.Windows.Forms.TextBox();
            this.textBoxCondition = new System.Windows.Forms.TextBox();
            this.labelCondition = new System.Windows.Forms.Label();
            this.textBoxText = new System.Windows.Forms.TextBox();
            this.labelConditionRight = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.textBoxBackTextLeft = new System.Windows.Forms.TextBox();
            this.textBoxBackTextRight = new System.Windows.Forms.TextBox();
            this.labelBeckTextLeft = new System.Windows.Forms.Label();
            this.labelBackTextRight = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureImage)).BeginInit();
            this.SuspendLayout();
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(21, 25);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(25, 13);
            this.labelId.TabIndex = 20;
            this.labelId.Text = "Id : ";
            // 
            // labelHeader
            // 
            this.labelHeader.AutoSize = true;
            this.labelHeader.Location = new System.Drawing.Point(409, 25);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(106, 13);
            this.labelHeader.TabIndex = 20;
            this.labelHeader.Text = "Nom de pesonnage :";
            // 
            // labelBackground
            // 
            this.labelBackground.AutoSize = true;
            this.labelBackground.Location = new System.Drawing.Point(23, 360);
            this.labelBackground.Name = "labelBackground";
            this.labelBackground.Size = new System.Drawing.Size(90, 13);
            this.labelBackground.TabIndex = 20;
            this.labelBackground.Text = "Fond de la carte :";
            // 
            // labelTextDes
            // 
            this.labelTextDes.AutoSize = true;
            this.labelTextDes.Location = new System.Drawing.Point(21, 57);
            this.labelTextDes.Name = "labelTextDes";
            this.labelTextDes.Size = new System.Drawing.Size(40, 13);
            this.labelTextDes.TabIndex = 20;
            this.labelTextDes.Text = "Texte :";
            // 
            // buttonClose
            // 
            this.buttonClose.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonClose.Location = new System.Drawing.Point(595, 720);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 13;
            this.buttonClose.Text = "Fermer ";
            this.buttonClose.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(697, 720);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 14;
            this.buttonCancel.Text = "Annuler";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // pictureImage
            // 
            this.pictureImage.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureImage.InitialImage")));
            this.pictureImage.Location = new System.Drawing.Point(26, 383);
            this.pictureImage.Name = "pictureImage";
            this.pictureImage.Size = new System.Drawing.Size(322, 322);
            this.pictureImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureImage.TabIndex = 26;
            this.pictureImage.TabStop = false;
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(52, 21);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(205, 20);
            this.textBoxId.TabIndex = 0;
            // 
            // textBoxHeader
            // 
            this.textBoxHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.textBoxHeader.Location = new System.Drawing.Point(521, 21);
            this.textBoxHeader.Name = "textBoxHeader";
            this.textBoxHeader.Size = new System.Drawing.Size(251, 20);
            this.textBoxHeader.TabIndex = 1;
            // 
            // textBoxBackground
            // 
            this.textBoxBackground.Location = new System.Drawing.Point(119, 357);
            this.textBoxBackground.Name = "textBoxBackground";
            this.textBoxBackground.ReadOnly = true;
            this.textBoxBackground.Size = new System.Drawing.Size(229, 20);
            this.textBoxBackground.TabIndex = 29;
            this.textBoxBackground.Click += new System.EventHandler(this.textBoxBackground_Click);
            // 
            // textBoxTextLeft
            // 
            this.textBoxTextLeft.AcceptsReturn = true;
            this.textBoxTextLeft.AcceptsTab = true;
            this.textBoxTextLeft.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.textBoxTextLeft.Location = new System.Drawing.Point(448, 73);
            this.textBoxTextLeft.Multiline = true;
            this.textBoxTextLeft.Name = "textBoxTextLeft";
            this.textBoxTextLeft.Size = new System.Drawing.Size(324, 66);
            this.textBoxTextLeft.TabIndex = 4;
            // 
            // labelTextLeft
            // 
            this.labelTextLeft.AutoSize = true;
            this.labelTextLeft.Location = new System.Drawing.Point(445, 57);
            this.labelTextLeft.Name = "labelTextLeft";
            this.labelTextLeft.Size = new System.Drawing.Size(128, 13);
            this.labelTextLeft.TabIndex = 32;
            this.labelTextLeft.Text = "Texte du choix gauche :  ";
            // 
            // textBoxTextRight
            // 
            this.textBoxTextRight.AcceptsReturn = true;
            this.textBoxTextRight.AcceptsTab = true;
            this.textBoxTextRight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.textBoxTextRight.Location = new System.Drawing.Point(882, 73);
            this.textBoxTextRight.Multiline = true;
            this.textBoxTextRight.Name = "textBoxTextRight";
            this.textBoxTextRight.Size = new System.Drawing.Size(334, 66);
            this.textBoxTextRight.TabIndex = 5;
            // 
            // textBoxEffectLeft
            // 
            this.textBoxEffectLeft.AcceptsReturn = true;
            this.textBoxEffectLeft.AcceptsTab = true;
            this.textBoxEffectLeft.Location = new System.Drawing.Point(448, 360);
            this.textBoxEffectLeft.Multiline = true;
            this.textBoxEffectLeft.Name = "textBoxEffectLeft";
            this.textBoxEffectLeft.Size = new System.Drawing.Size(324, 159);
            this.textBoxEffectLeft.TabIndex = 9;
            // 
            // textBoxEffectRight
            // 
            this.textBoxEffectRight.AcceptsReturn = true;
            this.textBoxEffectRight.AcceptsTab = true;
            this.textBoxEffectRight.Location = new System.Drawing.Point(882, 365);
            this.textBoxEffectRight.Multiline = true;
            this.textBoxEffectRight.Name = "textBoxEffectRight";
            this.textBoxEffectRight.Size = new System.Drawing.Size(334, 154);
            this.textBoxEffectRight.TabIndex = 10;
            // 
            // textBoxConditionLeft
            // 
            this.textBoxConditionLeft.AcceptsReturn = true;
            this.textBoxConditionLeft.AcceptsTab = true;
            this.textBoxConditionLeft.Location = new System.Drawing.Point(448, 551);
            this.textBoxConditionLeft.Multiline = true;
            this.textBoxConditionLeft.Name = "textBoxConditionLeft";
            this.textBoxConditionLeft.Size = new System.Drawing.Size(324, 154);
            this.textBoxConditionLeft.TabIndex = 11;
            // 
            // textBoxConditionRight
            // 
            this.textBoxConditionRight.AcceptsReturn = true;
            this.textBoxConditionRight.AcceptsTab = true;
            this.textBoxConditionRight.Location = new System.Drawing.Point(882, 551);
            this.textBoxConditionRight.Multiline = true;
            this.textBoxConditionRight.Name = "textBoxConditionRight";
            this.textBoxConditionRight.Size = new System.Drawing.Size(334, 154);
            this.textBoxConditionRight.TabIndex = 12;
            // 
            // labelEffectLeft
            // 
            this.labelEffectLeft.AutoSize = true;
            this.labelEffectLeft.Location = new System.Drawing.Point(445, 344);
            this.labelEffectLeft.Name = "labelEffectLeft";
            this.labelEffectLeft.Size = new System.Drawing.Size(117, 13);
            this.labelEffectLeft.TabIndex = 38;
            this.labelEffectLeft.Text = "Effet du choix gauche :";
            // 
            // labelConditionLeft
            // 
            this.labelConditionLeft.AutoSize = true;
            this.labelConditionLeft.Location = new System.Drawing.Point(445, 535);
            this.labelConditionLeft.Name = "labelConditionLeft";
            this.labelConditionLeft.Size = new System.Drawing.Size(153, 13);
            this.labelConditionLeft.TabIndex = 39;
            this.labelConditionLeft.Text = "Conditions d\'étiquette gauche ;";
            // 
            // labelTextRight
            // 
            this.labelTextRight.AutoSize = true;
            this.labelTextRight.Location = new System.Drawing.Point(879, 57);
            this.labelTextRight.Name = "labelTextRight";
            this.labelTextRight.Size = new System.Drawing.Size(118, 13);
            this.labelTextRight.TabIndex = 40;
            this.labelTextRight.Text = "Texte du choix droite :  ";
            // 
            // labelEffectRight
            // 
            this.labelEffectRight.AutoSize = true;
            this.labelEffectRight.Location = new System.Drawing.Point(879, 349);
            this.labelEffectRight.Name = "labelEffectRight";
            this.labelEffectRight.Size = new System.Drawing.Size(101, 13);
            this.labelEffectRight.TabIndex = 41;
            this.labelEffectRight.Text = "Effet du choix droit :";
            // 
            // labelWeight
            // 
            this.labelWeight.AutoSize = true;
            this.labelWeight.Location = new System.Drawing.Point(879, 24);
            this.labelWeight.Name = "labelWeight";
            this.labelWeight.Size = new System.Drawing.Size(39, 13);
            this.labelWeight.TabIndex = 42;
            this.labelWeight.Text = "Poids :";
            // 
            // textBoxWeight
            // 
            this.textBoxWeight.Location = new System.Drawing.Point(924, 22);
            this.textBoxWeight.Name = "textBoxWeight";
            this.textBoxWeight.Size = new System.Drawing.Size(140, 20);
            this.textBoxWeight.TabIndex = 2;
            // 
            // textBoxCondition
            // 
            this.textBoxCondition.Location = new System.Drawing.Point(26, 253);
            this.textBoxCondition.Multiline = true;
            this.textBoxCondition.Name = "textBoxCondition";
            this.textBoxCondition.Size = new System.Drawing.Size(322, 79);
            this.textBoxCondition.TabIndex = 6;
            // 
            // labelCondition
            // 
            this.labelCondition.AutoSize = true;
            this.labelCondition.Location = new System.Drawing.Point(21, 232);
            this.labelCondition.Name = "labelCondition";
            this.labelCondition.Size = new System.Drawing.Size(119, 13);
            this.labelCondition.TabIndex = 45;
            this.labelCondition.Text = "Conditions d\'apparition :";
            // 
            // textBoxText
            // 
            this.textBoxText.AcceptsReturn = true;
            this.textBoxText.AcceptsTab = true;
            this.textBoxText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.textBoxText.Location = new System.Drawing.Point(24, 73);
            this.textBoxText.Multiline = true;
            this.textBoxText.Name = "textBoxText";
            this.textBoxText.Size = new System.Drawing.Size(324, 137);
            this.textBoxText.TabIndex = 3;
            // 
            // labelConditionRight
            // 
            this.labelConditionRight.AutoSize = true;
            this.labelConditionRight.Location = new System.Drawing.Point(879, 535);
            this.labelConditionRight.Name = "labelConditionRight";
            this.labelConditionRight.Size = new System.Drawing.Size(143, 13);
            this.labelConditionRight.TabIndex = 47;
            this.labelConditionRight.Text = "Conditions d\'étiquette droite ;";
            // 
            // textBoxBackTextLeft
            // 
            this.textBoxBackTextLeft.AcceptsReturn = true;
            this.textBoxBackTextLeft.AcceptsTab = true;
            this.textBoxBackTextLeft.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.textBoxBackTextLeft.Location = new System.Drawing.Point(448, 169);
            this.textBoxBackTextLeft.Multiline = true;
            this.textBoxBackTextLeft.Name = "textBoxBackTextLeft";
            this.textBoxBackTextLeft.Size = new System.Drawing.Size(324, 159);
            this.textBoxBackTextLeft.TabIndex = 7;
            // 
            // textBoxBackTextRight
            // 
            this.textBoxBackTextRight.AcceptsReturn = true;
            this.textBoxBackTextRight.AcceptsTab = true;
            this.textBoxBackTextRight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.textBoxBackTextRight.Location = new System.Drawing.Point(882, 169);
            this.textBoxBackTextRight.Multiline = true;
            this.textBoxBackTextRight.Name = "textBoxBackTextRight";
            this.textBoxBackTextRight.Size = new System.Drawing.Size(334, 159);
            this.textBoxBackTextRight.TabIndex = 8;
            // 
            // labelBeckTextLeft
            // 
            this.labelBeckTextLeft.AutoSize = true;
            this.labelBeckTextLeft.Location = new System.Drawing.Point(445, 153);
            this.labelBeckTextLeft.Name = "labelBeckTextLeft";
            this.labelBeckTextLeft.Size = new System.Drawing.Size(132, 13);
            this.labelBeckTextLeft.TabIndex = 50;
            this.labelBeckTextLeft.Text = "Text d\'après choix gauche";
            // 
            // labelBackTextRight
            // 
            this.labelBackTextRight.AutoSize = true;
            this.labelBackTextRight.Location = new System.Drawing.Point(879, 153);
            this.labelBackTextRight.Name = "labelBackTextRight";
            this.labelBackTextRight.Size = new System.Drawing.Size(122, 13);
            this.labelBackTextRight.TabIndex = 51;
            this.labelBackTextRight.Text = "Text d\'après choix droite";
            // 
            // CardStandardModif
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonClose;
            this.ClientSize = new System.Drawing.Size(1293, 755);
            this.Controls.Add(this.labelBackTextRight);
            this.Controls.Add(this.labelBeckTextLeft);
            this.Controls.Add(this.textBoxBackTextRight);
            this.Controls.Add(this.textBoxBackTextLeft);
            this.Controls.Add(this.labelConditionRight);
            this.Controls.Add(this.textBoxText);
            this.Controls.Add(this.labelCondition);
            this.Controls.Add(this.textBoxCondition);
            this.Controls.Add(this.textBoxWeight);
            this.Controls.Add(this.labelWeight);
            this.Controls.Add(this.labelEffectRight);
            this.Controls.Add(this.labelTextRight);
            this.Controls.Add(this.labelConditionLeft);
            this.Controls.Add(this.labelEffectLeft);
            this.Controls.Add(this.textBoxConditionRight);
            this.Controls.Add(this.textBoxConditionLeft);
            this.Controls.Add(this.textBoxEffectRight);
            this.Controls.Add(this.textBoxEffectLeft);
            this.Controls.Add(this.textBoxTextRight);
            this.Controls.Add(this.labelTextLeft);
            this.Controls.Add(this.textBoxTextLeft);
            this.Controls.Add(this.textBoxBackground);
            this.Controls.Add(this.textBoxHeader);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.pictureImage);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.labelTextDes);
            this.Controls.Add(this.labelBackground);
            this.Controls.Add(this.labelHeader);
            this.Controls.Add(this.labelId);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "CardStandardModif";
            this.Text = "Modification d\'une carte standarde";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CardStandardModif_FormClosed);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CardStandardModif_KeyDown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.EventMouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.Label labelBackground;
        private System.Windows.Forms.Label labelTextDes;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.PictureBox pictureImage;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.TextBox textBoxHeader;
        private System.Windows.Forms.TextBox textBoxBackground;
        private System.Windows.Forms.TextBox textBoxTextLeft;
        private System.Windows.Forms.Label labelTextLeft;
        private System.Windows.Forms.TextBox textBoxTextRight;
        private System.Windows.Forms.TextBox textBoxEffectLeft;
        private System.Windows.Forms.TextBox textBoxEffectRight;
        private System.Windows.Forms.TextBox textBoxConditionLeft;
        private System.Windows.Forms.TextBox textBoxConditionRight;
        private System.Windows.Forms.Label labelEffectLeft;
        private System.Windows.Forms.Label labelConditionLeft;
        private System.Windows.Forms.Label labelTextRight;
        private System.Windows.Forms.Label labelEffectRight;
        private System.Windows.Forms.Label labelWeight;
        private System.Windows.Forms.TextBox textBoxWeight;
        private System.Windows.Forms.TextBox textBoxCondition;
        private System.Windows.Forms.Label labelCondition;
        private System.Windows.Forms.TextBox textBoxText;
        private System.Windows.Forms.Label labelConditionRight;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.TextBox textBoxBackTextLeft;
        private System.Windows.Forms.TextBox textBoxBackTextRight;
        private System.Windows.Forms.Label labelBeckTextLeft;
        private System.Windows.Forms.Label labelBackTextRight;
    }
}