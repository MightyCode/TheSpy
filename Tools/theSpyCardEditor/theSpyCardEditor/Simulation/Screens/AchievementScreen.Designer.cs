namespace theSpyCardEditor
{
    partial class AchievementScreen
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
            this.labelTitle = new System.Windows.Forms.Label();
            this.listBoxAchivements = new System.Windows.Forms.ListBox();
            this.buttonClose = new System.Windows.Forms.Button();
            this.groupBoxDescription = new System.Windows.Forms.GroupBox();
            this.pictureBoxQuest = new System.Windows.Forms.PictureBox();
            this.pictureBoxDeath = new System.Windows.Forms.PictureBox();
            this.textBox = new System.Windows.Forms.RichTextBox();
            this.labelTextDes = new System.Windows.Forms.Label();
            this.labelHeader = new System.Windows.Forms.Label();
            this.labelHeaderDes = new System.Windows.Forms.Label();
            this.groupBoxDescription.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxQuest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDeath)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(139, 19);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(47, 20);
            this.labelTitle.TabIndex = 10;
            this.labelTitle.Text = "#Title";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listBoxAchivements
            // 
            this.listBoxAchivements.FormattingEnabled = true;
            this.listBoxAchivements.Location = new System.Drawing.Point(12, 42);
            this.listBoxAchivements.Name = "listBoxAchivements";
            this.listBoxAchivements.Size = new System.Drawing.Size(320, 329);
            this.listBoxAchivements.TabIndex = 9;
            this.listBoxAchivements.SelectedIndexChanged += new System.EventHandler(this.listBoxAchivements_SelectedIndexChanged);
            // 
            // buttonClose
            // 
            this.buttonClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonClose.Location = new System.Drawing.Point(289, 402);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(110, 47);
            this.buttonClose.TabIndex = 7;
            this.buttonClose.Text = "Fermer";
            this.buttonClose.UseVisualStyleBackColor = true;
            // 
            // groupBoxDescription
            // 
            this.groupBoxDescription.Controls.Add(this.pictureBoxQuest);
            this.groupBoxDescription.Controls.Add(this.pictureBoxDeath);
            this.groupBoxDescription.Controls.Add(this.textBox);
            this.groupBoxDescription.Controls.Add(this.labelTextDes);
            this.groupBoxDescription.Controls.Add(this.labelHeader);
            this.groupBoxDescription.Controls.Add(this.labelHeaderDes);
            this.groupBoxDescription.Location = new System.Drawing.Point(361, 42);
            this.groupBoxDescription.Name = "groupBoxDescription";
            this.groupBoxDescription.Size = new System.Drawing.Size(371, 328);
            this.groupBoxDescription.TabIndex = 14;
            this.groupBoxDescription.TabStop = false;
            this.groupBoxDescription.Text = "Résumé de la carte selectionnée";
            // 
            // pictureBoxQuest
            // 
            this.pictureBoxQuest.Location = new System.Drawing.Point(23, 170);
            this.pictureBoxQuest.Name = "pictureBoxQuest";
            this.pictureBoxQuest.Size = new System.Drawing.Size(64, 64);
            this.pictureBoxQuest.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxQuest.TabIndex = 20;
            this.pictureBoxQuest.TabStop = false;
            // 
            // pictureBoxDeath
            // 
            this.pictureBoxDeath.Location = new System.Drawing.Point(23, 170);
            this.pictureBoxDeath.Name = "pictureBoxDeath";
            this.pictureBoxDeath.Size = new System.Drawing.Size(130, 130);
            this.pictureBoxDeath.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxDeath.TabIndex = 19;
            this.pictureBoxDeath.TabStop = false;
            // 
            // textBox
            // 
            this.textBox.BackColor = System.Drawing.SystemColors.Control;
            this.textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox.DetectUrls = false;
            this.textBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.textBox.Location = new System.Drawing.Point(60, 55);
            this.textBox.Name = "textBox";
            this.textBox.ReadOnly = true;
            this.textBox.Size = new System.Drawing.Size(299, 109);
            this.textBox.TabIndex = 0;
            this.textBox.Text = "#Text";
            // 
            // labelTextDes
            // 
            this.labelTextDes.AutoSize = true;
            this.labelTextDes.Location = new System.Drawing.Point(20, 55);
            this.labelTextDes.Name = "labelTextDes";
            this.labelTextDes.Size = new System.Drawing.Size(34, 13);
            this.labelTextDes.TabIndex = 18;
            this.labelTextDes.Text = "Text :";
            // 
            // labelHeader
            // 
            this.labelHeader.AutoSize = true;
            this.labelHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.labelHeader.Location = new System.Drawing.Point(69, 30);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(47, 13);
            this.labelHeader.TabIndex = 17;
            this.labelHeader.Text = "#header";
            // 
            // labelHeaderDes
            // 
            this.labelHeaderDes.AutoSize = true;
            this.labelHeaderDes.Location = new System.Drawing.Point(20, 30);
            this.labelHeaderDes.Name = "labelHeaderDes";
            this.labelHeaderDes.Size = new System.Drawing.Size(43, 13);
            this.labelHeaderDes.TabIndex = 14;
            this.labelHeaderDes.Text = "#Title : ";
            // 
            // AchievementScreen
            // 
            this.AcceptButton = this.buttonClose;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonClose;
            this.ClientSize = new System.Drawing.Size(744, 461);
            this.Controls.Add(this.groupBoxDescription);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.listBoxAchivements);
            this.Controls.Add(this.buttonClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AchievementScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AchievementScreen";
            this.groupBoxDescription.ResumeLayout(false);
            this.groupBoxDescription.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxQuest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDeath)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.ListBox listBoxAchivements;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.GroupBox groupBoxDescription;
        private System.Windows.Forms.RichTextBox textBox;
        private System.Windows.Forms.Label labelTextDes;
        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.Label labelHeaderDes;
        private System.Windows.Forms.PictureBox pictureBoxDeath;
        private System.Windows.Forms.PictureBox pictureBoxQuest;
    }
}