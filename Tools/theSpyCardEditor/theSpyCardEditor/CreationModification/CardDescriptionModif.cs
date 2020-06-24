using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace theSpyCardEditor
{
    public partial class CardDescriptionModif : Form
    {
        Card card;
        TextBox[] textBoxes;
        string[] properties;

        string path ="";

        public CardDescriptionModif(Card card)
        {
            InitializeComponent();
            this.card = card;

            textBoxes = new TextBox[]
            { textBoxId, textBoxHeader, textBoxBackground, textBoxText, textBoxEffect, textBoxCondition };

            properties = new String[]
            { "Id", "Header", "Background", "Text", "Effect", "Conditions"};

            Initialize();
        }

        private void Initialize()
        {
            for (int i = 0; i < textBoxes.Count(); ++i)
            {
                textBoxes[i].Text = card.Properties[properties[i]].Value;
            }

            if (!textBoxBackground.Text.Equals(""))
            {
                pictureImage.Image = Image.FromFile(
                    ImageExtension.GetPathWithoutExtension(Utils.RESOURCES_PATH + card.Properties["Background"].Value)
                    );
            }
        }

        private void textBoxBackground_Click(object sender, EventArgs e)
        {
            openFileDialog.InitialDirectory = AppDomain.CurrentDomain.BaseDirectory + "resources";

            DialogResult result = openFileDialog.ShowDialog();

            if (result == DialogResult.OK || result == DialogResult.Yes)
            {
                path = openFileDialog.FileName;
                pictureImage.Image = Image.FromFile(path);

                textBoxBackground.Text = openFileDialog.SafeFileName.Substring(0, openFileDialog.SafeFileName.LastIndexOf("."));
            }

            textBoxHeader.Focus();
        }

        private void CardStandardModif_FormClosed(object sender, FormClosedEventArgs e)
        {
            for (int i = 0; i < textBoxes.Count(); ++i)
            {
                card.Properties[properties[i]].Value = textBoxes[i].Text;
            }
        }

        private void BeforeChangelanguage(object sender, EventArgs e)
        {
            CardStandardModif_FormClosed(sender, null);
        }

        private void AfterChangeLanguage(object sender, EventArgs e)
        {
            Initialize();
        }

        private void EventMouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                SpecialMenuStip cm = new SpecialMenuStip(BeforeChangelanguage, AfterChangeLanguage);

                cm.Show(this, e.Location);
            }
        }

        private void CardDescriptionModif_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control)
            {
                if (e.Shift)
                {
                    if (e.KeyCode == Keys.Q)
                    {
                        SpecialMenuStip cm = new SpecialMenuStip(BeforeChangelanguage, AfterChangeLanguage);
                        cm.ElementClick(cm.Items[cm.ToolsPlace["Langage"]], null);
                    }
                }
            }
        }
    }
}
