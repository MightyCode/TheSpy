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
    public partial class LanguageModification : Form
    {
        public Language NewLanguage { get; set; } = EditorProperties.CurrentLanguage;

        public LanguageModification()
        {
            InitializeComponent();
            foreach(Language language in EditorProperties.LANGUAGES)
            {
                listBoxLanguage.Items.Add(language.IdToListIdentifier);
            }

            listBoxLanguage.SelectedIndex = listBoxLanguage.Items.IndexOf(EditorProperties.CurrentLanguage.IdToListIdentifier);
        }

        private void listBoxLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Language language in EditorProperties.LANGUAGES)
            {
                if (language.IdToListIdentifier.Equals(listBoxLanguage.SelectedItem))
                {
                    NewLanguage = language;
                }
            }
        }

        private void LanguageModification_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }

            if (e.KeyCode == Keys.Escape)
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }
    }
}
