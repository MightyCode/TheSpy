namespace theSpyCardEditor
{
    partial class GameSimulationPreChoose
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
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonContinue = new System.Windows.Forms.Button();
            this.listBoxParameters = new System.Windows.Forms.ListBox();
            this.labelVariables = new System.Windows.Forms.Label();
            this.numericUpDownValue = new System.Windows.Forms.NumericUpDown();
            this.labelValue = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownValue)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonClose
            // 
            this.buttonClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonClose.Location = new System.Drawing.Point(554, 236);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(110, 64);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "Annuler et fermer";
            this.buttonClose.UseVisualStyleBackColor = true;
            // 
            // buttonContinue
            // 
            this.buttonContinue.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonContinue.Location = new System.Drawing.Point(554, 81);
            this.buttonContinue.Name = "buttonContinue";
            this.buttonContinue.Size = new System.Drawing.Size(110, 64);
            this.buttonContinue.TabIndex = 2;
            this.buttonContinue.Text = "Continuer";
            this.buttonContinue.UseVisualStyleBackColor = true;
            // 
            // listBoxParameters
            // 
            this.listBoxParameters.FormattingEnabled = true;
            this.listBoxParameters.Location = new System.Drawing.Point(24, 50);
            this.listBoxParameters.Name = "listBoxParameters";
            this.listBoxParameters.Size = new System.Drawing.Size(320, 290);
            this.listBoxParameters.Sorted = true;
            this.listBoxParameters.TabIndex = 3;
            this.listBoxParameters.SelectedIndexChanged += new System.EventHandler(this.listBoxParameters_SelectedIndexChanged);
            // 
            // labelVariables
            // 
            this.labelVariables.AutoSize = true;
            this.labelVariables.Location = new System.Drawing.Point(135, 34);
            this.labelVariables.Name = "labelVariables";
            this.labelVariables.Size = new System.Drawing.Size(82, 13);
            this.labelVariables.TabIndex = 4;
            this.labelVariables.Text = "Variables de jeu";
            // 
            // numericUpDownValue
            // 
            this.numericUpDownValue.Location = new System.Drawing.Point(363, 170);
            this.numericUpDownValue.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.numericUpDownValue.Name = "numericUpDownValue";
            this.numericUpDownValue.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownValue.TabIndex = 5;
            this.numericUpDownValue.ValueChanged += new System.EventHandler(this.numericUpDownValue_ValueChanged);
            // 
            // labelValue
            // 
            this.labelValue.AutoSize = true;
            this.labelValue.Location = new System.Drawing.Point(397, 154);
            this.labelValue.Name = "labelValue";
            this.labelValue.Size = new System.Drawing.Size(42, 13);
            this.labelValue.TabIndex = 6;
            this.labelValue.Text = "Valeurs";
            // 
            // GameSimulationPreChoose
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 356);
            this.Controls.Add(this.labelValue);
            this.Controls.Add(this.numericUpDownValue);
            this.Controls.Add(this.labelVariables);
            this.Controls.Add(this.listBoxParameters);
            this.Controls.Add(this.buttonContinue);
            this.Controls.Add(this.buttonClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "GameSimulationPreChoose";
            this.Text = "Modification des paramètres";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonContinue;
        private System.Windows.Forms.ListBox listBoxParameters;
        private System.Windows.Forms.Label labelVariables;
        private System.Windows.Forms.NumericUpDown numericUpDownValue;
        private System.Windows.Forms.Label labelValue;
    }
}