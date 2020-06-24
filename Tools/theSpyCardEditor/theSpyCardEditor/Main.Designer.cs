namespace theSpyCardEditor
{
    partial class Main
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.listCard = new System.Windows.Forms.ListBox();
            this.labelList = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonModeStandard = new System.Windows.Forms.Button();
            this.buttonModeDescription = new System.Windows.Forms.Button();
            this.buttonModeDeath = new System.Windows.Forms.Button();
            this.buttonModeFight = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.buttonNewCard = new System.Windows.Forms.Button();
            this.buttonRemoveElement = new System.Windows.Forms.Button();
            this.labelIdDes = new System.Windows.Forms.Label();
            this.groupBoxDescription = new System.Windows.Forms.GroupBox();
            this.textBox = new System.Windows.Forms.RichTextBox();
            this.labelText = new System.Windows.Forms.Label();
            this.labelTextDes = new System.Windows.Forms.Label();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.labelHeader = new System.Windows.Forms.Label();
            this.labelBackground = new System.Windows.Forms.Label();
            this.labelBackgroundDes = new System.Windows.Forms.Label();
            this.labelHeaderDes = new System.Windows.Forms.Label();
            this.labelId = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ouvrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enregistrerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nouveauToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.buttonLauchGame = new System.Windows.Forms.Button();
            this.buttonUpElement = new System.Windows.Forms.Button();
            this.buttonDownElement = new System.Windows.Forms.Button();
            this.groupBoxDescription.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listCard
            // 
            this.listCard.FormattingEnabled = true;
            this.listCard.Location = new System.Drawing.Point(12, 148);
            this.listCard.Name = "listCard";
            this.listCard.Size = new System.Drawing.Size(303, 342);
            this.listCard.TabIndex = 6;
            this.listCard.SelectedIndexChanged += new System.EventHandler(this.listCard_SelectedIndexChanged);
            // 
            // labelList
            // 
            this.labelList.AutoSize = true;
            this.labelList.Location = new System.Drawing.Point(136, 132);
            this.labelList.Name = "labelList";
            this.labelList.Size = new System.Drawing.Size(37, 13);
            this.labelList.TabIndex = 2;
            this.labelList.Text = "Cartes";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(504, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Catégories";
            // 
            // buttonModeStandard
            // 
            this.buttonModeStandard.Location = new System.Drawing.Point(334, 78);
            this.buttonModeStandard.Name = "buttonModeStandard";
            this.buttonModeStandard.Size = new System.Drawing.Size(94, 23);
            this.buttonModeStandard.TabIndex = 2;
            this.buttonModeStandard.Text = "Standards";
            this.buttonModeStandard.UseVisualStyleBackColor = true;
            this.buttonModeStandard.Click += new System.EventHandler(this.buttonModeStandard_Click);
            // 
            // buttonModeDescription
            // 
            this.buttonModeDescription.Location = new System.Drawing.Point(434, 78);
            this.buttonModeDescription.Name = "buttonModeDescription";
            this.buttonModeDescription.Size = new System.Drawing.Size(94, 23);
            this.buttonModeDescription.TabIndex = 3;
            this.buttonModeDescription.Text = "Descriptions";
            this.buttonModeDescription.UseVisualStyleBackColor = true;
            this.buttonModeDescription.Click += new System.EventHandler(this.buttonModeDescription_Click);
            // 
            // buttonModeDeath
            // 
            this.buttonModeDeath.Location = new System.Drawing.Point(534, 78);
            this.buttonModeDeath.Name = "buttonModeDeath";
            this.buttonModeDeath.Size = new System.Drawing.Size(94, 23);
            this.buttonModeDeath.TabIndex = 4;
            this.buttonModeDeath.Text = "Morts";
            this.buttonModeDeath.UseVisualStyleBackColor = true;
            this.buttonModeDeath.Click += new System.EventHandler(this.buttonModeDeath_Click);
            // 
            // buttonModeFight
            // 
            this.buttonModeFight.Location = new System.Drawing.Point(634, 78);
            this.buttonModeFight.Name = "buttonModeFight";
            this.buttonModeFight.Size = new System.Drawing.Size(94, 23);
            this.buttonModeFight.TabIndex = 5;
            this.buttonModeFight.Text = "Combats";
            this.buttonModeFight.UseVisualStyleBackColor = true;
            this.buttonModeFight.Click += new System.EventHandler(this.buttonModeFight_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(85, 49);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(160, 23);
            this.button5.TabIndex = 1;
            this.button5.Text = "Charger la visualisation";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // buttonNewCard
            // 
            this.buttonNewCard.Location = new System.Drawing.Point(12, 505);
            this.buttonNewCard.Name = "buttonNewCard";
            this.buttonNewCard.Size = new System.Drawing.Size(94, 23);
            this.buttonNewCard.TabIndex = 8;
            this.buttonNewCard.Text = "Nouvelle carte";
            this.buttonNewCard.UseVisualStyleBackColor = true;
            this.buttonNewCard.Click += new System.EventHandler(this.buttonNewCard_Click);
            // 
            // buttonRemoveCard
            // 
            this.buttonRemoveElement.Location = new System.Drawing.Point(221, 505);
            this.buttonRemoveElement.Name = "buttonRemoveCard";
            this.buttonRemoveElement.Size = new System.Drawing.Size(94, 23);
            this.buttonRemoveElement.TabIndex = 9;
            this.buttonRemoveElement.Text = "Retirer carte";
            this.buttonRemoveElement.UseVisualStyleBackColor = true;
            this.buttonRemoveElement.Click += new System.EventHandler(this.buttonRemoveCard_Click);
            // 
            // labelIdDes
            // 
            this.labelIdDes.AutoSize = true;
            this.labelIdDes.Location = new System.Drawing.Point(20, 40);
            this.labelIdDes.Name = "labelIdDes";
            this.labelIdDes.Size = new System.Drawing.Size(25, 13);
            this.labelIdDes.TabIndex = 12;
            this.labelIdDes.Text = "Id : ";
            // 
            // groupBoxDescription
            // 
            this.groupBoxDescription.Controls.Add(this.textBox);
            this.groupBoxDescription.Controls.Add(this.labelText);
            this.groupBoxDescription.Controls.Add(this.labelTextDes);
            this.groupBoxDescription.Controls.Add(this.buttonEdit);
            this.groupBoxDescription.Controls.Add(this.labelHeader);
            this.groupBoxDescription.Controls.Add(this.labelBackground);
            this.groupBoxDescription.Controls.Add(this.labelBackgroundDes);
            this.groupBoxDescription.Controls.Add(this.labelHeaderDes);
            this.groupBoxDescription.Controls.Add(this.labelId);
            this.groupBoxDescription.Controls.Add(this.labelIdDes);
            this.groupBoxDescription.Location = new System.Drawing.Point(334, 163);
            this.groupBoxDescription.Name = "groupBoxDescription";
            this.groupBoxDescription.Size = new System.Drawing.Size(469, 327);
            this.groupBoxDescription.TabIndex = 13;
            this.groupBoxDescription.TabStop = false;
            this.groupBoxDescription.Text = "Résumé de la carte selectionnée";
            // 
            // textBox
            // 
            this.textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox.DetectUrls = false;
            this.textBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.textBox.Location = new System.Drawing.Point(66, 122);
            this.textBox.Name = "textBox";
            this.textBox.ReadOnly = true;
            this.textBox.Size = new System.Drawing.Size(397, 118);
            this.textBox.TabIndex = 0;
            this.textBox.Text = "";
            // 
            // labelText
            // 
            this.labelText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.labelText.Location = new System.Drawing.Point(63, 122);
            this.labelText.Name = "labelText";
            this.labelText.Size = new System.Drawing.Size(400, 140);
            this.labelText.TabIndex = 19;
            this.labelText.Text = "#Text";
            // 
            // labelTextDes
            // 
            this.labelTextDes.AutoSize = true;
            this.labelTextDes.Location = new System.Drawing.Point(20, 122);
            this.labelTextDes.Name = "labelTextDes";
            this.labelTextDes.Size = new System.Drawing.Size(34, 13);
            this.labelTextDes.TabIndex = 18;
            this.labelTextDes.Text = "Text :";
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(194, 281);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(103, 23);
            this.buttonEdit.TabIndex = 7;
            this.buttonEdit.Text = "Modifier la carte";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // labelHeader
            // 
            this.labelHeader.AutoSize = true;
            this.labelHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.labelHeader.Location = new System.Drawing.Point(104, 70);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(47, 13);
            this.labelHeader.TabIndex = 17;
            this.labelHeader.Text = "#header";
            // 
            // labelBackground
            // 
            this.labelBackground.AutoSize = true;
            this.labelBackground.Location = new System.Drawing.Point(116, 95);
            this.labelBackground.Name = "labelBackground";
            this.labelBackground.Size = new System.Drawing.Size(71, 13);
            this.labelBackground.TabIndex = 16;
            this.labelBackground.Text = "#background";
            // 
            // labelBackgroundDes
            // 
            this.labelBackgroundDes.AutoSize = true;
            this.labelBackgroundDes.Location = new System.Drawing.Point(20, 95);
            this.labelBackgroundDes.Name = "labelBackgroundDes";
            this.labelBackgroundDes.Size = new System.Drawing.Size(90, 13);
            this.labelBackgroundDes.TabIndex = 15;
            this.labelBackgroundDes.Text = "Fond de la carte :";
            // 
            // labelHeaderDes
            // 
            this.labelHeaderDes.AutoSize = true;
            this.labelHeaderDes.Location = new System.Drawing.Point(20, 70);
            this.labelHeaderDes.Name = "labelHeaderDes";
            this.labelHeaderDes.Size = new System.Drawing.Size(78, 13);
            this.labelHeaderDes.TabIndex = 14;
            this.labelHeaderDes.Text = "Haut de carte :";
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(51, 40);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(26, 13);
            this.labelId.TabIndex = 13;
            this.labelId.Text = "#Id ";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(843, 24);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ouvrirToolStripMenuItem,
            this.enregistrerToolStripMenuItem,
            this.nouveauToolStripMenuItem});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.fichierToolStripMenuItem.Text = "Fichier";
            // 
            // ouvrirToolStripMenuItem
            // 
            this.ouvrirToolStripMenuItem.Name = "ouvrirToolStripMenuItem";
            this.ouvrirToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.ouvrirToolStripMenuItem.Text = "Ouvrir";
            this.ouvrirToolStripMenuItem.Click += new System.EventHandler(this.ouvrirToolStripMenuItem_Click);
            // 
            // enregistrerToolStripMenuItem
            // 
            this.enregistrerToolStripMenuItem.Name = "enregistrerToolStripMenuItem";
            this.enregistrerToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.enregistrerToolStripMenuItem.Text = "Enregistrer";
            this.enregistrerToolStripMenuItem.Click += new System.EventHandler(this.enregistrerToolStripMenuItem_Click);
            // 
            // nouveauToolStripMenuItem
            // 
            this.nouveauToolStripMenuItem.Name = "nouveauToolStripMenuItem";
            this.nouveauToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.nouveauToolStripMenuItem.Text = "Nouveau";
            this.nouveauToolStripMenuItem.Click += new System.EventHandler(this.nouveauToolStripMenuItem_Click);
            // 
            // buttonLauchGame
            // 
            this.buttonLauchGame.Location = new System.Drawing.Point(85, 78);
            this.buttonLauchGame.Name = "buttonLauchGame";
            this.buttonLauchGame.Size = new System.Drawing.Size(160, 23);
            this.buttonLauchGame.TabIndex = 15;
            this.buttonLauchGame.Text = "Tester le jeu";
            this.buttonLauchGame.UseVisualStyleBackColor = true;
            this.buttonLauchGame.Click += new System.EventHandler(this.buttonLauchGame_Click);
            // 
            // buttonUp
            // 
            this.buttonUpElement.Location = new System.Drawing.Point(127, 505);
            this.buttonUpElement.Name = "buttonUp";
            this.buttonUpElement.Size = new System.Drawing.Size(28, 23);
            this.buttonUpElement.TabIndex = 16;
            this.buttonUpElement.Text = "↑";
            this.buttonUpElement.UseVisualStyleBackColor = true;
            this.buttonUpElement.Click += new System.EventHandler(this.buttonUp_Click);
            // 
            // buttonDown
            // 
            this.buttonDownElement.Location = new System.Drawing.Point(161, 505);
            this.buttonDownElement.Name = "buttonDown";
            this.buttonDownElement.Size = new System.Drawing.Size(28, 23);
            this.buttonDownElement.TabIndex = 17;
            this.buttonDownElement.Text = "↓";
            this.buttonDownElement.UseVisualStyleBackColor = true;
            this.buttonDownElement.Click += new System.EventHandler(this.buttonDown_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 559);
            this.Controls.Add(this.buttonDownElement);
            this.Controls.Add(this.buttonUpElement);
            this.Controls.Add(this.buttonLauchGame);
            this.Controls.Add(this.groupBoxDescription);
            this.Controls.Add(this.buttonRemoveElement);
            this.Controls.Add(this.buttonNewCard);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.buttonModeFight);
            this.Controls.Add(this.buttonModeDeath);
            this.Controls.Add(this.buttonModeDescription);
            this.Controls.Add(this.buttonModeStandard);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelList);
            this.Controls.Add(this.listCard);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "Editeur de cartes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Main_KeyDown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.EventMouseDown);
            this.groupBoxDescription.ResumeLayout(false);
            this.groupBoxDescription.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox listCard;
        private System.Windows.Forms.Label labelList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonModeStandard;
        private System.Windows.Forms.Button buttonModeDescription;
        private System.Windows.Forms.Button buttonModeDeath;
        private System.Windows.Forms.Button buttonModeFight;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button buttonNewCard;
        private System.Windows.Forms.Button buttonRemoveElement;
        private System.Windows.Forms.Label labelIdDes;
        private System.Windows.Forms.GroupBox groupBoxDescription;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.Label labelHeaderDes;
        private System.Windows.Forms.Label labelBackgroundDes;
        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.Label labelBackground;
        private System.Windows.Forms.Label labelTextDes;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Label labelText;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ouvrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enregistrerToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button buttonLauchGame;
        private System.Windows.Forms.ToolStripMenuItem nouveauToolStripMenuItem;
        private System.Windows.Forms.RichTextBox textBox;
        private System.Windows.Forms.Button buttonUpElement;
        private System.Windows.Forms.Button buttonDownElement;
    }
}

