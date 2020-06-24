using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace theSpyCardEditor
{
    class SpecialMenuStip : ContextMenuStrip
    {
        EventHandler beforeChangeLanguage, afterChangeLanguage;
        public Dictionary<string, int> ToolsPlace;

        public SpecialMenuStip(EventHandler beforeChangeLanguage, EventHandler afterChangeLanguage)
        {
            ToolsPlace = new Dictionary<string, int>();

            this.beforeChangeLanguage = beforeChangeLanguage;
            this.afterChangeLanguage = afterChangeLanguage;

            ToolStripMenuItem item = new ToolStripMenuItem("Langage");
            item.Click += ElementClick;
            Items.Add(item);
            ToolsPlace.Add("Langage", Items.IndexOf(item));
        }

        public void ElementClick(object sender, EventArgs e)
        {
            ToolStripMenuItem tm = (ToolStripMenuItem)sender;
            switch (tm.Text)
            {
                case "Langage":
                    LanguageModification form = new LanguageModification();

                    DialogResult result = form.ShowDialog();

                    if (result != DialogResult.Cancel)
                    {
                        if (beforeChangeLanguage != null)
                        {
                            beforeChangeLanguage(this, e);
                        }

                        EditorProperties.CurrentIdLanguage = form.NewLanguage.IdLanguage;

                        if (afterChangeLanguage != null)
                        {
                            afterChangeLanguage(this, e);
                        }
                    }
                    break;
            }
        }
    }
}
