namespace theSpyCardEditor
{
    partial class CardDescriptionModif
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CardDescriptionModif));
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
            this.labelEffectLeft = new System.Windows.Forms.Label();
            this.textBoxText = new System.Windows.Forms.TextBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.textBoxEffect = new System.Windows.Forms.TextBox();
            this.labelCondition = new System.Windows.Forms.Label();
            this.textBoxCondition = new System.Windows.Forms.TextBox();
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
            this.labelHeader.Location = new System.Drawing.Point(445, 24);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(106, 13);
            this.labelHeader.TabIndex = 20;
            this.labelHeader.Text = "Titre de description  :";
            // 
            // labelBackground
            // 
            this.labelBackground.AutoSize = true;
            this.labelBackground.Location = new System.Drawing.Point(23, 222);
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
            this.buttonClose.Location = new System.Drawing.Point(503, 538);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 6;
            this.buttonClose.Text = "Fermer ";
            this.buttonClose.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(605, 538);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 7;
            this.buttonCancel.Text = "Annuler";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // pictureImage
            // 
            this.pictureImage.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureImage.InitialImage")));
            this.pictureImage.Location = new System.Drawing.Point(24, 248);
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
            this.textBoxId.TabIndex = 1;
            // 
            // textBoxHeader
            // 
            this.textBoxHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.textBoxHeader.Location = new System.Drawing.Point(557, 21);
            this.textBoxHeader.Name = "textBoxHeader";
            this.textBoxHeader.Size = new System.Drawing.Size(215, 20);
            this.textBoxHeader.TabIndex = 2;
            // 
            // textBoxBackground
            // 
            this.textBoxBackground.Location = new System.Drawing.Point(119, 222);
            this.textBoxBackground.Name = "textBoxBackground";
            this.textBoxBackground.ReadOnly = true;
            this.textBoxBackground.Size = new System.Drawing.Size(227, 20);
            this.textBoxBackground.TabIndex = 29;
            this.textBoxBackground.Click += new System.EventHandler(this.textBoxBackground_Click);
            // 
            // labelEffectLeft
            // 
            this.labelEffectLeft.AutoSize = true;
            this.labelEffectLeft.Location = new System.Drawing.Point(445, 57);
            this.labelEffectLeft.Name = "labelEffectLeft";
            this.labelEffectLeft.Size = new System.Drawing.Size(35, 13);
            this.labelEffectLeft.TabIndex = 38;
            this.labelEffectLeft.Text = "Effet :";
            // 
            // textBoxText
            // 
            this.textBoxText.AcceptsReturn = true;
            this.textBoxText.AcceptsTab = true;
            this.textBoxText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.textBoxText.Location = new System.Drawing.Point(24, 73);
            this.textBoxText.Multiline = true;
            this.textBoxText.Name = "textBoxText";
            this.textBoxText.Size = new System.Drawing.Size(322, 137);
            this.textBoxText.TabIndex = 3;
            // 
            // textBoxEffect
            // 
            this.textBoxEffect.AcceptsReturn = true;
            this.textBoxEffect.AcceptsTab = true;
            this.textBoxEffect.Location = new System.Drawing.Point(448, 73);
            this.textBoxEffect.Multiline = true;
            this.textBoxEffect.Name = "textBoxEffect";
            this.textBoxEffect.Size = new System.Drawing.Size(324, 193);
            this.textBoxEffect.TabIndex = 4;
            // 
            // labelCondition
            // 
            this.labelCondition.AutoSize = true;
            this.labelCondition.Location = new System.Drawing.Point(445, 285);
            this.labelCondition.Name = "labelCondition";
            this.labelCondition.Size = new System.Drawing.Size(114, 13);
            this.labelCondition.TabIndex = 39;
            this.labelCondition.Text = "Conditions d\'étiquette :";
            // 
            // textBoxCondition
            // 
            this.textBoxCondition.AcceptsReturn = true;
            this.textBoxCondition.AcceptsTab = true;
            this.textBoxCondition.Location = new System.Drawing.Point(448, 301);
            this.textBoxCondition.Multiline = true;
            this.textBoxCondition.Name = "textBoxCondition";
            this.textBoxCondition.Size = new System.Drawing.Size(324, 213);
            this.textBoxCondition.TabIndex = 5;
            // 
            // CardDescriptionModif
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonClose;
            this.ClientSize = new System.Drawing.Size(790, 581);
            this.Controls.Add(this.textBoxText);
            this.Controls.Add(this.labelCondition);
            this.Controls.Add(this.labelEffectLeft);
            this.Controls.Add(this.textBoxCondition);
            this.Controls.Add(this.textBoxEffect);
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
            this.Name = "CardDescriptionModif";
            this.Text = "Modification d\'une carte de decription";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CardStandardModif_FormClosed);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CardDescriptionModif_KeyDown);
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
        private System.Windows.Forms.Label labelEffectLeft;
        private System.Windows.Forms.TextBox textBoxText;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.TextBox textBoxEffect;
        private System.Windows.Forms.Label labelCondition;
        private System.Windows.Forms.TextBox textBoxCondition;
    }
}