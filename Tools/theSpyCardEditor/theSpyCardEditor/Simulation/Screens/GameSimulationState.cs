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
    partial class GameSimulationState : Form
    {
        SimulationSystem SS;

        Dictionary<string, int> parameters;
        bool UpdateCurrentItem;

        public GameSimulationState(Dictionary<string, int> parameters, SimulationSystem SS)
        {
            InitializeComponent();
            this.parameters = parameters;

            RefleshParameters();

            if (listBoxParameters.Items.Count >= 1)
            {
                listBoxParameters.SelectedIndex = 1;
            }

            UpdateCurrentItem = false;

            this.SS = SS;

            AvailableCardsChange(SS.CardsPull);
        }

        private string CurrentValueName => ((string)listBoxParameters.SelectedItem).Split('-')[0].Trim();

        public void RefleshParameters()
        {
            listBoxParameters.Items.Clear();
            foreach (string key in parameters.Keys)
            {
                listBoxParameters.Items.Add(key + "  -  " + parameters[key]);
            }
        }

        public void AvailableCardsChange(List<CardState> cards)
        {
            listBoxCards.Items.Clear();
            foreach(CardState card in cards)
            {
                listBoxCards.Items.Add(card.Card.Properties["Id"].Value);
            }

            listBoxCards.Sorted = true;
        }

        private void numericUpDownValue_ValueChanged(object sender, EventArgs e)
        {
            int newValue = decimal.ToInt32(numericUpDownValue.Value);

            parameters[CurrentValueName]
                = newValue;

            UpdateCurrentItem = true;

            listBoxParameters.Items[listBoxParameters.SelectedIndex] =
                CurrentValueName + "  -  " + newValue;

            UpdateCurrentItem = false;
        }

        private void listBoxParameters_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!UpdateCurrentItem)
                numericUpDownValue.Value = parameters[CurrentValueName];
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void GameSimulationState_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                Hide();
            }
        }

        private void buttonUpdateCard_Click(object sender, EventArgs e)
        {
            SS.ComputeCardAvailableAndUnavailable();
            AvailableCardsChange(SS.CardsPull);
        }
    }
}
