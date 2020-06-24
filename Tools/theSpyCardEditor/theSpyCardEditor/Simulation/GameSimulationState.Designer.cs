namespace theSpyCardEditor
{
    partial class GameSimulationState
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
            this.labelValue = new System.Windows.Forms.Label();
            this.numericUpDownValue = new System.Windows.Forms.NumericUpDown();
            this.labelVariables = new System.Windows.Forms.Label();
            this.listBoxParameters = new System.Windows.Forms.ListBox();
            this.buttonClose = new System.Windows.Forms.Button();
            this.listBoxCards = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelHorizontal = new System.Windows.Forms.Label();
            this.buttonUpdateCard = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownValue)).BeginInit();
            this.SuspendLayout();
            // 
            // labelValue
            // 
            this.labelValue.AutoSize = true;
            this.labelValue.Location = new System.Drawing.Point(394, 198);
            this.labelValue.Name = "labelValue";
            this.labelValue.Size = new System.Drawing.Size(42, 13);
            this.labelValue.TabIndex = 12;
            this.labelValue.Text = "Valeurs";
            // 
            // numericUpDownValue
            // 
            this.numericUpDownValue.Location = new System.Drawing.Point(360, 214);
            this.numericUpDownValue.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.numericUpDownValue.Name = "numericUpDownValue";
            this.numericUpDownValue.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownValue.TabIndex = 11;
            this.numericUpDownValue.ValueChanged += new System.EventHandler(this.numericUpDownValue_ValueChanged);
            // 
            // labelVariables
            // 
            this.labelVariables.AutoSize = true;
            this.labelVariables.Location = new System.Drawing.Point(132, 78);
            this.labelVariables.Name = "labelVariables";
            this.labelVariables.Size = new System.Drawing.Size(82, 13);
            this.labelVariables.TabIndex = 10;
            this.labelVariables.Text = "Variables de jeu";
            // 
            // listBoxParameters
            // 
            this.listBoxParameters.FormattingEnabled = true;
            this.listBoxParameters.Location = new System.Drawing.Point(21, 94);
            this.listBoxParameters.Name = "listBoxParameters";
            this.listBoxParameters.Size = new System.Drawing.Size(320, 290);
            this.listBoxParameters.Sorted = true;
            this.listBoxParameters.TabIndex = 9;
            this.listBoxParameters.SelectedIndexChanged += new System.EventHandler(this.listBoxParameters_SelectedIndexChanged);
            // 
            // buttonClose
            // 
            this.buttonClose.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonClose.Location = new System.Drawing.Point(12, 5);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(110, 40);
            this.buttonClose.TabIndex = 7;
            this.buttonClose.Text = "Fermer";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // listBoxCards
            // 
            this.listBoxCards.FormattingEnabled = true;
            this.listBoxCards.Location = new System.Drawing.Point(587, 93);
            this.listBoxCards.Name = "listBoxCards";
            this.listBoxCards.Size = new System.Drawing.Size(320, 290);
            this.listBoxCards.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(709, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Cartes disponibles";
            // 
            // labelHorizontal
            // 
            this.labelHorizontal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelHorizontal.Location = new System.Drawing.Point(512, 24);
            this.labelHorizontal.Name = "labelHorizontal";
            this.labelHorizontal.Size = new System.Drawing.Size(10, 360);
            this.labelHorizontal.TabIndex = 15;
            // 
            // buttonUpdateCard
            // 
            this.buttonUpdateCard.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonUpdateCard.Location = new System.Drawing.Point(587, 39);
            this.buttonUpdateCard.Name = "buttonUpdateCard";
            this.buttonUpdateCard.Size = new System.Drawing.Size(110, 25);
            this.buttonUpdateCard.TabIndex = 16;
            this.buttonUpdateCard.Text = "Actualiser carte disponible";
            this.buttonUpdateCard.UseVisualStyleBackColor = true;
            this.buttonUpdateCard.Click += new System.EventHandler(this.buttonUpdateCard_Click);
            // 
            // GameSimulationState
            // 
            this.AcceptButton = this.buttonClose;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 404);
            this.Controls.Add(this.buttonUpdateCard);
            this.Controls.Add(this.labelHorizontal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxCards);
            this.Controls.Add(this.labelValue);
            this.Controls.Add(this.numericUpDownValue);
            this.Controls.Add(this.labelVariables);
            this.Controls.Add(this.listBoxParameters);
            this.Controls.Add(this.buttonClose);
            this.Name = "GameSimulationState";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GameSimulationState";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GameSimulationState_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelValue;
        private System.Windows.Forms.NumericUpDown numericUpDownValue;
        private System.Windows.Forms.Label labelVariables;
        private System.Windows.Forms.ListBox listBoxParameters;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.ListBox listBoxCards;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelHorizontal;
        private System.Windows.Forms.Button buttonUpdateCard;
    }
}