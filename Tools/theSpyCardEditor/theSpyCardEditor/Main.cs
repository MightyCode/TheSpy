using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace theSpyCardEditor
{
    public enum EMode
    {
        Standard, Description, Death, Fight, Equipment, Quest
    }

    public partial class Main : Form
    {

        EMode currentMode;

        Dictionary<EMode, List<Card>> allCards;

        Button[] buttonsMode;

        CardWriter cardWriter;
        CardReader cardReader;

        public Main()
        {
            InitializeComponent();

            Construct();

            buttonRemoveElement.Enabled = false;
            buttonUpElement.Enabled = false;
            buttonDownElement.Enabled = false;

            buttonsMode = new Button[] { buttonModeStandard, buttonModeDescription, buttonModeDeath, buttonModeFight, 
                buttonModeEquipment, buttonModeQuest};

            cardWriter = new CardWriter();
            cardReader = new CardReader();

            SwitchMode(EMode.Standard);
        }

        #region load and close form
        private void Construct()
        {
            allCards = new Dictionary<EMode, List<Card>>();

            foreach (EMode mode in Enum.GetValues(typeof(EMode)).Cast<EMode>())
            {
                allCards.Add(mode, new List<Card>());
            }
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            UserPreferences.LANGUAGE_USED = (int)EditorProperties.CurrentIdLanguage;

            bool empty = true;
            foreach (EMode mode in Enum.GetValues(typeof(EMode)).Cast<EMode>())
            {
                empty &= allCards[mode].Count <= 0;
            }

            if (!empty)
            {
                if (new WantSave().ShowDialog() == DialogResult.Yes)
                {
                    if (File.Exists(UserPreferences.LASTWORK))
                    {
                        SaveCards(UserPreferences.LASTWORK);
                    }
                    else
                    {
                        SaveCardsDialog();
                    }
                }
            }

            FileMethods.SavePreferences();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            if (File.Exists(UserPreferences.LASTWORK))
            {
                OpenFile(UserPreferences.LASTWORK);
            }
        }

        #endregion

        private void SwitchMode(EMode newMode)
        {
            currentMode = newMode;

            ConstructList();

            for (int i = 0; i < buttonsMode.Length; ++i)
            {
                buttonsMode[i].Enabled = (i != (int)currentMode);
            }

            switch (currentMode)
            {
                case EMode.Standard:
                    //SwitchToStandard();
                    break;
                case EMode.Description:
                    //SwitchToDescription();
                    break;
                case EMode.Death:
                    //SwitchToDeath();
                    break;
                case EMode.Fight:
                    //SwitchToFight();
                    break;
            }

            listCard_SelectedIndexChanged(this, null);
        }


        #region cardList
        public Card CurrentCard
        {
            get => (listCard.SelectedIndex >= 0 && listCard.SelectedIndex < allCards[currentMode].Count)
            ? allCards[currentMode][listCard.SelectedIndex] : null;
            set
            {
                if (listCard.SelectedIndex >= 0 && listCard.SelectedIndex < allCards[currentMode].Count)
                {
                    allCards[currentMode][listCard.SelectedIndex] = value;
                }
            }
        }

        private void ConstructList()
        {
            listCard.Items.Clear();

            foreach (Card card in allCards[currentMode])
            {
                listCard.Items.Add(card.IdList);
            }
        }

        private void listCard_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listCard.SelectedIndex >= 0 && listCard.SelectedIndex < allCards[currentMode].Count)
            {
                buttonRemoveElement.Enabled = true;
                buttonUpElement.Enabled = true;
                buttonDownElement.Enabled = true;

                groupBoxDescription.Visible = true;
                groupBoxDescription.Enabled = true;

                Card card = CurrentCard;

                labelId.Text = card.Properties["Id"].Value;
                labelHeader.Text = card.Properties["Header"].Value;
                labelBackground.Text = card.Properties["Background"].Value;
                labelText.Text = card.Properties["Text"].Value;

                List<Tuple<Color, string>> parts = Utils.StringToColoredString(labelText.Text, textBox.ForeColor);
                textBox.Text = "";
                for (int i = 0; i < parts.Count; ++i)
                {
                    textBox.SelectionColor = parts[i].Item1;
                    textBox.AppendText(parts[i].Item2);
                }
            }
            else
            {
                groupBoxDescription.Visible = false;
                groupBoxDescription.Enabled = false;
            }
        }

        public void RemoveSelectedCard()
        {
            allCards[currentMode].RemoveAt(listCard.SelectedIndex);

            int selected = listCard.SelectedIndex;
            listCard.Items.RemoveAt(listCard.SelectedIndex);

            if (selected >= 1) listCard.SelectedIndex = selected - 1;
            else if (selected == 0 & listCard.Items.Count >= 1) listCard.SelectedIndex = selected;
            else
            {
                buttonRemoveElement.Enabled = false;
                buttonUpElement.Enabled = false;
                buttonDownElement.Enabled = false;
            }
        }

        private void ElementUp()
        {
            if (listCard.SelectedIndex >= 1 && listCard.SelectedIndex < listCard.Items.Count)
            {
                int selectedIndex = listCard.SelectedIndex;
                Card current = CurrentCard;
                CurrentCard = allCards[currentMode][selectedIndex -1];
                allCards[currentMode][selectedIndex -1] = current;

                string temp = (string)listCard.Items[selectedIndex];
                listCard.Items[selectedIndex] = listCard.Items[selectedIndex -1];
                listCard.Items[selectedIndex -1] = temp;
                listCard.SelectedIndex = selectedIndex - 1;
            }
        }

        private void ElementDown()
        {
            if(listCard.SelectedIndex >= 0 && listCard.SelectedIndex < listCard.Items.Count - 1)
            {
                int selectedIndex = listCard.SelectedIndex;
                Card current = CurrentCard;
                CurrentCard = allCards[currentMode][selectedIndex+1];
                allCards[currentMode][selectedIndex + 1] = current;

                string temp = (string)listCard.Items[selectedIndex];
                listCard.Items[selectedIndex] = listCard.Items[selectedIndex + 1];
                listCard.Items[selectedIndex + 1] = temp;
                listCard.SelectedIndex = selectedIndex + 1;
            }
        }
        #endregion

        private void EventMouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                SpecialMenuStip cm = new SpecialMenuStip(null, AfterChangeLanguage);
                cm.Show(this, e.Location);
            }
        }

        private void AfterChangeLanguage(object sender, EventArgs e)
        {
            ConstructList();
            listCard_SelectedIndexChanged(this, e);
        }

        #region save and load
        public void SaveCardsDialog()
        {
            saveFileDialog.InitialDirectory = AppDomain.CurrentDomain.BaseDirectory;
            DialogResult result = saveFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                SaveCards(saveFileDialog.FileName);
            }
        }

        public void SaveCards(string path)
        {
            cardWriter.Open(path);
            cardWriter.WriteHeader("1.2.0");
            cardWriter.WriteCards(allCards);
            cardWriter.WriteFooter();
            cardWriter.Close();

            UserPreferences.LASTWORK = path;
        }
        public void OpenFileDialog()
        {
            openFileDialog.InitialDirectory = AppDomain.CurrentDomain.BaseDirectory;
            DialogResult result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                OpenFile(openFileDialog.FileName);
            }
        }

        public void OpenFile(string path)
        {
            cardReader.Open(path);
            cardReader.Read();
            cardReader.Close();
            allCards = cardReader.Cards;
            SwitchMode(currentMode);
        }

        #endregion

        #region instant effect button
        private void buttonModeStandard_Click(object sender, EventArgs e)
        {
            SwitchMode(EMode.Standard);
        }

        private void buttonModeDescription_Click(object sender, EventArgs e)
        {
            SwitchMode(EMode.Description);
        }

        private void buttonModeDeath_Click(object sender, EventArgs e)
        {
            SwitchMode(EMode.Death);
        }

        private void buttonModeFight_Click(object sender, EventArgs e)
        {
            SwitchMode(EMode.Fight);
        }

        private void buttonModeEquipment_Click(object sender, EventArgs e)
        {
            SwitchMode(EMode.Equipment);
        }

        private void buttonModeQuest_Click(object sender, EventArgs e)
        {
            SwitchMode(EMode.Quest);
        }

        private void buttonRemoveElement_Click(object sender, EventArgs e)
        {
            RemoveSelectedCard();
        }

        private void buttonNewCard_Click(object sender, EventArgs e)
        {
            allCards[currentMode].Add(new Card(currentMode));
            listCard.Items.Add(allCards[currentMode][listCard.Items.Count].IdList);

            listCard.SelectedIndex = listCard.Items.Count - 1;

            buttonEdit_Click(null, null);
        }


        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (CurrentCard == null) return;

            Card card = (Card)CurrentCard.Clone();
            Form modification = null;

            switch (card.Type)
            {
                case EMode.Standard:
                    modification = new CardStandardModif(card);
                    break;
                case EMode.Description:
                    modification = new CardDescriptionModif(card);
                    break;
                case EMode.Death:
                    modification = new CardDeathModif(card);
                    break;
                    /*case EMode.Fight:
                        //SwitchToFight();
                        break;*/
            }

            if (modification != null)
            {
                DialogResult result = modification.ShowDialog();
                if (result != DialogResult.Cancel)
                {
                    CurrentCard = card;
                    listCard.Items[listCard.SelectedIndex] = card.IdList;
                }


                listCard_SelectedIndexChanged(null, null);
            }

            listCard.Focus();
        }

        private void buttonLauchGame_Click(object sender, EventArgs e)
        {
            Dictionary<string, int> parameters = SimulationComputations.ComputeParametersAvailable(allCards);
            if (parameters != null)
            {
                GameSimulationPreChoose gmpc = new GameSimulationPreChoose(parameters);
                DialogResult result = gmpc.ShowDialog();
                if (result == DialogResult.OK)
                {
                    parameters = gmpc.Parameters;
                    GameSimulation game = new GameSimulation(allCards, parameters);
                    game.ShowDialog();
                }
            }
        }

        private void ouvrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog();
        }

        private void enregistrerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveCardsDialog();
        }

        private void nouveauToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Construct();
            SwitchMode(EMode.Standard);
            UserPreferences.LASTWORK = "null";
        }


        private void buttonUp_Click(object sender, EventArgs e)
        {
            ElementUp();
        }

        private void buttonDown_Click(object sender, EventArgs e)
        {
            ElementDown();
        }

        #endregion

        #region shortcut
        private void Main_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control)
            {
                if (e.Shift)
                {
                    if (e.KeyCode == Keys.Q)
                    {
                        SpecialMenuStip cm = new SpecialMenuStip(null, AfterChangeLanguage);
                        cm.ElementClick(cm.Items[cm.ToolsPlace["Langage"]], e);
                    }

                    if (e.KeyCode == Keys.W)
                    {
                        if (groupBoxDescription.Visible)buttonEdit_Click(this, e);
                    }

                    if (e.KeyCode == Keys.N)buttonNewCard_Click(this, e);

                    if (e.KeyCode == Keys.S)SaveCardsDialog();

                } else
                {
                    if (e.KeyCode == Keys.S)
                    {
                        if (File.Exists(UserPreferences.LASTWORK))SaveCards(UserPreferences.LASTWORK);
                        else SaveCardsDialog();
                    }
                }

                if (e.KeyCode == Keys.Left)
                {
                    int next = (int)currentMode - 1;
                    if (next < 0) next = Enum.GetValues(typeof(EMode)).Length - 1;
                    SwitchMode((EMode)next);

                }
                else if (e.KeyCode == Keys.Right)
                {
                    int next = (int)currentMode + 1;

                    if (next >= Enum.GetValues(typeof(EMode)).Length) next = 0;
                    SwitchMode((EMode)next);
                }
            }

            if (e.KeyCode == Keys.P)
            {
                if (CurrentCard == null && listCard.Items.Count > 0)
                {
                    listCard.Focus();
                    listCard.SelectedIndex = 0;
                }
                else buttonEdit_Click(this, null);
            }
        }

        #endregion
    }
}
