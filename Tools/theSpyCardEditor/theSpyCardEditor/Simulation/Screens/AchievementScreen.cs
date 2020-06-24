using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace theSpyCardEditor
{
    public partial class AchievementScreen : Form
    {
        List<Card> achievements;
        bool isDeath;


        public AchievementScreen(Dictionary<Card, bool> achievements, bool isDeath)
        {
            InitializeComponent();

            this.achievements = new List<Card>();
            this.isDeath = isDeath;

            SetDisplay(isDeath);
            groupBoxDescription.Visible = false;

            foreach (KeyValuePair<Card, bool> value in achievements)
            {
                if ((value.Value))
                {
                    listBoxAchivements.Items.Add(value.Key.Properties["Header"].Value);
                    this.achievements.Add(value.Key);
                } else
                {
                    this.achievements.Add(null);
                    listBoxAchivements.Items.Add("???");
                }
            }
        }

        public void SetDisplay(bool isDeath)
        {
            if (isDeath)
            {
                labelTitle.Text = "Morts obtenus";
                labelHeaderDes.Text = "Mort : ";
                pictureBoxQuest.Visible = false;
            } else
            {
                labelTitle.Text = "Quêtes finis";
                labelHeaderDes.Text = "Quête : ";
                pictureBoxDeath.Visible = false;
            }
        }

        private void listBoxAchivements_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxAchivements.SelectedIndex >= 0 && listBoxAchivements.SelectedIndex < achievements.Count)
            {
                groupBoxDescription.Visible = true;
                Card card = achievements[listBoxAchivements.SelectedIndex];

                if (card == null)
                {
                    pictureBoxDeath.Image = null;
                    pictureBoxDeath.Image = null;
                    labelHeader.Text = "/";
                    SetText("/");
                } else
                {
                    labelHeader.Text = card.Properties["Header"].Value;
                    SetText(card.Properties["Text"].Value);
                    LoadCardImage(card.Properties["Background"].Value);
                }
            } else
            {
                groupBoxDescription.Visible = false;
            }
        }

        private void SetText(string text)
        {
            List<Tuple<Color, string>> parts = Utils.StringToColoredString(text);
            textBox.Text = "";
            for (int i = 0; i < parts.Count; ++i)
            {
                textBox.SelectionColor = parts[i].Item1;
                textBox.AppendText(parts[i].Item2);
            }
        }

        private void LoadCardImage(string name)
        {
            string path = ImageExtension.GetPathWithoutExtension(Utils.RESOURCES_PATH + name);

            if (File.Exists(path)) return;

            if (isDeath)
                pictureBoxDeath.Image = Image.FromFile(path);
            else
                pictureBoxQuest.Image = Image.FromFile(path);
        }
    }
}
