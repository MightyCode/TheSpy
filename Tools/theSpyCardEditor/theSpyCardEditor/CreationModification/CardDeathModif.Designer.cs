namespace theSpyCardEditor
{
    partial class CardDeathModif
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CardDeathModif));
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
            this.textBoxText = new System.Windows.Forms.TextBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
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
            this.labelHeader.Location = new System.Drawing.Point(386, 24);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(83, 13);
            this.labelHeader.TabIndex = 20;
            this.labelHeader.Text = "Titre de la mort :";
            // 
            // labelBackground
            // 
            this.labelBackground.AutoSize = true;
            this.labelBackground.Location = new System.Drawing.Point(23, 79);
            this.labelBackground.Name = "labelBackground";
            this.labelBackground.Size = new System.Drawing.Size(90, 13);
            this.labelBackground.TabIndex = 20;
            this.labelBackground.Text = "Fond de la carte :";
            // 
            // labelTextDes
            // 
            this.labelTextDes.AutoSize = true;
            this.labelTextDes.Location = new System.Drawing.Point(445, 89);
            this.labelTextDes.Name = "labelTextDes";
            this.labelTextDes.Size = new System.Drawing.Size(40, 13);
            this.labelTextDes.TabIndex = 20;
            this.labelTextDes.Text = "Texte :";
            // 
            // buttonClose
            // 
            this.buttonClose.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonClose.Location = new System.Drawing.Point(498, 387);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 4;
            this.buttonClose.Text = "Fermer ";
            this.buttonClose.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(600, 387);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 5;
            this.buttonCancel.Text = "Annuler";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // pictureImage
            // 
            this.pictureImage.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureImage.InitialImage")));
            this.pictureImage.Location = new System.Drawing.Point(24, 105);
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
            this.textBoxHeader.Location = new System.Drawing.Point(475, 22);
            this.textBoxHeader.Name = "textBoxHeader";
            this.textBoxHeader.Size = new System.Drawing.Size(297, 20);
            this.textBoxHeader.TabIndex = 2;
            // 
            // textBoxBackground
            // 
            this.textBoxBackground.Location = new System.Drawing.Point(119, 79);
            this.textBoxBackground.Name = "textBoxBackground";
            this.textBoxBackground.ReadOnly = true;
            this.textBoxBackground.Size = new System.Drawing.Size(227, 20);
            this.textBoxBackground.TabIndex = 29;
            this.textBoxBackground.Click += new System.EventHandler(this.textBoxBackground_Click);
            // 
            // textBoxText
            // 
            this.textBoxText.AcceptsReturn = true;
            this.textBoxText.AcceptsTab = true;
            this.textBoxText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.textBoxText.Location = new System.Drawing.Point(448, 105);
            this.textBoxText.Multiline = true;
            this.textBoxText.Name = "textBoxText";
            this.textBoxText.Size = new System.Drawing.Size(324, 235);
            this.textBoxText.TabIndex = 3;
            // 
            // CardDeathModif
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonClose;
            this.ClientSize = new System.Drawing.Size(790, 440);
            this.Controls.Add(this.textBoxText);
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
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "CardDeathModif";
            this.Text = "Modification d\'une carte de mort";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CardStandardModif_FormClosed);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CardDeathModif_KeyDown);
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
        private System.Windows.Forms.TextBox textBoxText;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}