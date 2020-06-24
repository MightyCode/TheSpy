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
    public partial class GameSimulationPreChoose : Form
    {
        public Dictionary<string, int> Parameters;
        bool UpdateCurrentItem;

        public GameSimulationPreChoose(Dictionary<string, int> id)
        {
            InitializeComponent();
            this.Parameters = id;

            foreach (string key in Parameters.Keys)
            {
                listBoxParameters.Items.Add(key + "  -  " + Parameters[key]);
            }

            if (listBoxParameters.Items.Count >= 1)
            {
                listBoxParameters.SelectedIndex = 1;
            }

            UpdateCurrentItem = false;
        }

        private string CurrentValueName => ((string)listBoxParameters.SelectedItem).Split('-')[0].Trim();

        private void numericUpDownValue_ValueChanged(object sender, EventArgs e)
        {
            int newValue = decimal.ToInt32(numericUpDownValue.Value);

            Parameters[CurrentValueName] 
                = newValue;

            UpdateCurrentItem = true;

            listBoxParameters.Items[listBoxParameters.SelectedIndex] =
                CurrentValueName + "  -  " + newValue;

            UpdateCurrentItem = false;
        }

        private void listBoxParameters_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!UpdateCurrentItem)
            numericUpDownValue.Value = Parameters[CurrentValueName];
        }
    }
}
