namespace theSpyCardEditor
{
    partial class GameSimulation
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
            this.pictureCard = new System.Windows.Forms.PictureBox();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.textBoxLeftText = new System.Windows.Forms.TextBox();
            this.textBoxRightText = new System.Windows.Forms.TextBox();
            this.labelHorizontalbar = new System.Windows.Forms.Label();
            this.buttonLeft = new System.Windows.Forms.Button();
            this.buttonRight = new System.Windows.Forms.Button();
            this.textBoxBack = new System.Windows.Forms.TextBox();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonGameState = new System.Windows.Forms.Button();
            this.labelPopulation = new System.Windows.Forms.Label();
            this.labelMoney = new System.Windows.Forms.Label();
            this.labelCover = new System.Windows.Forms.Label();
            this.labelWorship = new System.Windows.Forms.Label();
            this.labelMoneyValue = new System.Windows.Forms.Label();
            this.labelPopulationValue = new System.Windows.Forms.Label();
            this.labelCoverValue = new System.Windows.Forms.Label();
            this.labelWorshipValue = new System.Windows.Forms.Label();
            this.textBoxText = new System.Windows.Forms.RichTextBox();
            this.buttonOpenInventory = new System.Windows.Forms.Button();
            this.buttonOpenQuests = new System.Windows.Forms.Button();
            this.buttonOpenDeath = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCard)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureCard
            // 
            this.pictureCard.Location = new System.Drawing.Point(204, 161);
            this.pictureCard.Name = "pictureCard";
            this.pictureCard.Size = new System.Drawing.Size(280, 280);
            this.pictureCard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureCard.TabIndex = 1;
            this.pictureCard.TabStop = false;
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.AcceptsReturn = true;
            this.textBoxTitle.AcceptsTab = true;
            this.textBoxTitle.AllowDrop = true;
            this.textBoxTitle.Location = new System.Drawing.Point(204, 82);
            this.textBoxTitle.Multiline = true;
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.ReadOnly = true;
            this.textBoxTitle.Size = new System.Drawing.Size(280, 61);
            this.textBoxTitle.TabIndex = 2;
            this.textBoxTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxLeftText
            // 
            this.textBoxLeftText.AcceptsReturn = true;
            this.textBoxLeftText.AcceptsTab = true;
            this.textBoxLeftText.AllowDrop = true;
            this.textBoxLeftText.Location = new System.Drawing.Point(32, 161);
            this.textBoxLeftText.Multiline = true;
            this.textBoxLeftText.Name = "textBoxLeftText";
            this.textBoxLeftText.ReadOnly = true;
            this.textBoxLeftText.Size = new System.Drawing.Size(152, 203);
            this.textBoxLeftText.TabIndex = 4;
            this.textBoxLeftText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxRightText
            // 
            this.textBoxRightText.AcceptsReturn = true;
            this.textBoxRightText.AcceptsTab = true;
            this.textBoxRightText.AllowDrop = true;
            this.textBoxRightText.Location = new System.Drawing.Point(504, 161);
            this.textBoxRightText.Multiline = true;
            this.textBoxRightText.Name = "textBoxRightText";
            this.textBoxRightText.ReadOnly = true;
            this.textBoxRightText.Size = new System.Drawing.Size(152, 203);
            this.textBoxRightText.TabIndex = 5;
            this.textBoxRightText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelHorizontalbar
            // 
            this.labelHorizontalbar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelHorizontalbar.Location = new System.Drawing.Point(677, 65);
            this.labelHorizontalbar.Name = "labelHorizontalbar";
            this.labelHorizontalbar.Size = new System.Drawing.Size(10, 542);
            this.labelHorizontalbar.TabIndex = 6;
            // 
            // buttonLeft
            // 
            this.buttonLeft.Location = new System.Drawing.Point(37, 380);
            this.buttonLeft.Name = "buttonLeft";
            this.buttonLeft.Size = new System.Drawing.Size(147, 61);
            this.buttonLeft.TabIndex = 7;
            this.buttonLeft.Text = "Choix de gauche";
            this.buttonLeft.UseVisualStyleBackColor = true;
            this.buttonLeft.Click += new System.EventHandler(this.buttonLeft_Click);
            // 
            // buttonRight
            // 
            this.buttonRight.Location = new System.Drawing.Point(504, 380);
            this.buttonRight.Name = "buttonRight";
            this.buttonRight.Size = new System.Drawing.Size(147, 61);
            this.buttonRight.TabIndex = 8;
            this.buttonRight.Text = "Choix de droite";
            this.buttonRight.UseVisualStyleBackColor = true;
            this.buttonRight.Click += new System.EventHandler(this.buttonRight_Click);
            // 
            // textBoxBack
            // 
            this.textBoxBack.AcceptsReturn = true;
            this.textBoxBack.AcceptsTab = true;
            this.textBoxBack.AllowDrop = true;
            this.textBoxBack.Location = new System.Drawing.Point(232, 199);
            this.textBoxBack.Multiline = true;
            this.textBoxBack.Name = "textBoxBack";
            this.textBoxBack.ReadOnly = true;
            this.textBoxBack.Size = new System.Drawing.Size(221, 211);
            this.textBoxBack.TabIndex = 9;
            this.textBoxBack.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonClose
            // 
            this.buttonClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonClose.Location = new System.Drawing.Point(713, 550);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(105, 57);
            this.buttonClose.TabIndex = 11;
            this.buttonClose.Text = "Fermer la simulation de jeu";
            this.buttonClose.UseVisualStyleBackColor = true;
            // 
            // buttonGameState
            // 
            this.buttonGameState.Location = new System.Drawing.Point(713, 473);
            this.buttonGameState.Name = "buttonGameState";
            this.buttonGameState.Size = new System.Drawing.Size(105, 57);
            this.buttonGameState.TabIndex = 12;
            this.buttonGameState.Text = " Ouvrir fenêtre état de jeu";
            this.buttonGameState.UseVisualStyleBackColor = true;
            this.buttonGameState.Click += new System.EventHandler(this.buttonGameState_Click);
            // 
            // labelPopulation
            // 
            this.labelPopulation.AutoSize = true;
            this.labelPopulation.Location = new System.Drawing.Point(229, 13);
            this.labelPopulation.Name = "labelPopulation";
            this.labelPopulation.Size = new System.Drawing.Size(63, 13);
            this.labelPopulation.TabIndex = 13;
            this.labelPopulation.Text = "Population :";
            // 
            // labelMoney
            // 
            this.labelMoney.AutoSize = true;
            this.labelMoney.Location = new System.Drawing.Point(71, 13);
            this.labelMoney.Name = "labelMoney";
            this.labelMoney.Size = new System.Drawing.Size(44, 13);
            this.labelMoney.TabIndex = 14;
            this.labelMoney.Text = "Argent :";
            // 
            // labelCover
            // 
            this.labelCover.AutoSize = true;
            this.labelCover.Location = new System.Drawing.Point(375, 13);
            this.labelCover.Name = "labelCover";
            this.labelCover.Size = new System.Drawing.Size(68, 13);
            this.labelCover.TabIndex = 15;
            this.labelCover.Text = "Couverture : ";
            // 
            // labelWorship
            // 
            this.labelWorship.AutoSize = true;
            this.labelWorship.Location = new System.Drawing.Point(534, 13);
            this.labelWorship.Name = "labelWorship";
            this.labelWorship.Size = new System.Drawing.Size(101, 13);
            this.labelWorship.TabIndex = 16;
            this.labelWorship.Text = "Image du dictateur :";
            // 
            // labelMoneyValue
            // 
            this.labelMoneyValue.AutoSize = true;
            this.labelMoneyValue.Location = new System.Drawing.Point(122, 13);
            this.labelMoneyValue.Name = "labelMoneyValue";
            this.labelMoneyValue.Size = new System.Drawing.Size(40, 13);
            this.labelMoneyValue.TabIndex = 17;
            this.labelMoneyValue.Text = "#value";
            // 
            // labelPopulationValue
            // 
            this.labelPopulationValue.AutoSize = true;
            this.labelPopulationValue.Location = new System.Drawing.Point(289, 13);
            this.labelPopulationValue.Name = "labelPopulationValue";
            this.labelPopulationValue.Size = new System.Drawing.Size(40, 13);
            this.labelPopulationValue.TabIndex = 18;
            this.labelPopulationValue.Text = "#value";
            // 
            // labelCoverValue
            // 
            this.labelCoverValue.AutoSize = true;
            this.labelCoverValue.Location = new System.Drawing.Point(444, 13);
            this.labelCoverValue.Name = "labelCoverValue";
            this.labelCoverValue.Size = new System.Drawing.Size(40, 13);
            this.labelCoverValue.TabIndex = 19;
            this.labelCoverValue.Text = "#value";
            // 
            // labelWorshipValue
            // 
            this.labelWorshipValue.AutoSize = true;
            this.labelWorshipValue.Location = new System.Drawing.Point(641, 13);
            this.labelWorshipValue.Name = "labelWorshipValue";
            this.labelWorshipValue.Size = new System.Drawing.Size(40, 13);
            this.labelWorshipValue.TabIndex = 20;
            this.labelWorshipValue.Text = "#value";
            // 
            // textBoxText
            // 
            this.textBoxText.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxText.Location = new System.Drawing.Point(204, 473);
            this.textBoxText.Name = "textBoxText";
            this.textBoxText.ReadOnly = true;
            this.textBoxText.Size = new System.Drawing.Size(280, 134);
            this.textBoxText.TabIndex = 21;
            this.textBoxText.Text = "";
            // 
            // buttonOpenInventory
            // 
            this.buttonOpenInventory.Location = new System.Drawing.Point(713, 65);
            this.buttonOpenInventory.Name = "buttonOpenInventory";
            this.buttonOpenInventory.Size = new System.Drawing.Size(105, 57);
            this.buttonOpenInventory.TabIndex = 22;
            this.buttonOpenInventory.Text = " Ouvrir l\'inventaire";
            this.buttonOpenInventory.UseVisualStyleBackColor = true;
            this.buttonOpenInventory.Click += new System.EventHandler(this.buttonOpenInventory_Click);
            // 
            // buttonOpenQuests
            // 
            this.buttonOpenQuests.Location = new System.Drawing.Point(713, 128);
            this.buttonOpenQuests.Name = "buttonOpenQuests";
            this.buttonOpenQuests.Size = new System.Drawing.Size(105, 57);
            this.buttonOpenQuests.TabIndex = 23;
            this.buttonOpenQuests.Text = "Quêtes";
            this.buttonOpenQuests.UseVisualStyleBackColor = true;
            this.buttonOpenQuests.Click += new System.EventHandler(this.buttonOpenQuests_Click);
            // 
            // buttonOpenDeath
            // 
            this.buttonOpenDeath.Location = new System.Drawing.Point(713, 191);
            this.buttonOpenDeath.Name = "buttonOpenDeath";
            this.buttonOpenDeath.Size = new System.Drawing.Size(105, 57);
            this.buttonOpenDeath.TabIndex = 24;
            this.buttonOpenDeath.Text = "Morts";
            this.buttonOpenDeath.UseVisualStyleBackColor = true;
            this.buttonOpenDeath.Click += new System.EventHandler(this.buttonOpenDeath_Click);
            // 
            // GameSimulation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonClose;
            this.ClientSize = new System.Drawing.Size(865, 636);
            this.Controls.Add(this.buttonOpenDeath);
            this.Controls.Add(this.buttonOpenQuests);
            this.Controls.Add(this.buttonOpenInventory);
            this.Controls.Add(this.textBoxText);
            this.Controls.Add(this.labelWorshipValue);
            this.Controls.Add(this.labelCoverValue);
            this.Controls.Add(this.labelPopulationValue);
            this.Controls.Add(this.labelMoneyValue);
            this.Controls.Add(this.labelWorship);
            this.Controls.Add(this.labelCover);
            this.Controls.Add(this.labelMoney);
            this.Controls.Add(this.labelPopulation);
            this.Controls.Add(this.buttonGameState);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.textBoxBack);
            this.Controls.Add(this.buttonRight);
            this.Controls.Add(this.buttonLeft);
            this.Controls.Add(this.labelHorizontalbar);
            this.Controls.Add(this.textBoxRightText);
            this.Controls.Add(this.textBoxLeftText);
            this.Controls.Add(this.textBoxTitle);
            this.Controls.Add(this.pictureCard);
            this.Name = "GameSimulation";
            this.Text = "GameSimulation";
            ((System.ComponentModel.ISupportInitialize)(this.pictureCard)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureCard;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.TextBox textBoxLeftText;
        private System.Windows.Forms.TextBox textBoxRightText;
        private System.Windows.Forms.Label labelHorizontalbar;
        private System.Windows.Forms.Button buttonLeft;
        private System.Windows.Forms.Button buttonRight;
        private System.Windows.Forms.TextBox textBoxBack;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonGameState;
        private System.Windows.Forms.Label labelPopulation;
        private System.Windows.Forms.Label labelMoney;
        private System.Windows.Forms.Label labelCover;
        private System.Windows.Forms.Label labelWorship;
        private System.Windows.Forms.Label labelMoneyValue;
        private System.Windows.Forms.Label labelPopulationValue;
        private System.Windows.Forms.Label labelCoverValue;
        private System.Windows.Forms.Label labelWorshipValue;
        private System.Windows.Forms.RichTextBox textBoxText;
        private System.Windows.Forms.Button buttonOpenInventory;
        private System.Windows.Forms.Button buttonOpenQuests;
        private System.Windows.Forms.Button buttonOpenDeath;
    }
}