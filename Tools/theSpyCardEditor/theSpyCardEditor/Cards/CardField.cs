using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace theSpyCardEditor
{
    public class CardField : ICloneable
    {
        protected Dictionary<string, string> values;
        string value = "";
        public bool MultipleLanguage;

        public CardField(bool multiple)
        {
            this.MultipleLanguage = multiple;
            if (multiple)
            {
                values = new Dictionary<string, string>();
                foreach (Language language in EditorProperties.LANGUAGES)
                {
                    values.Add(language.Id, "");
                }
            }
        }

        public string Value
        {
            get => (MultipleLanguage) ? values[EditorProperties.CurrentLanguage.Id] : value;
            set
            {
                if (MultipleLanguage) values[EditorProperties.CurrentLanguage.Id] = value;
                else this.value = value;
            }
        }

        public object Clone()
        {
            CardField cardField = new CardField(MultipleLanguage);
            cardField.value = value;
            cardField.values = new Dictionary<string, string>(values);

            return cardField;
        }

        public void SetProperty(string value, string language = "")
        {
            if (MultipleLanguage)
            {
                values[language] = value;
            } else
            {
                this.value = value;
            }
        }

        public string ToExportString()
        {
            if (MultipleLanguage)
            {
                string line = "";

                foreach (string language in values.Keys)
                {
                    line += language + "{" + values[language] + "};";
                }

                return line.Substring(0, line.Count() - 1);
            } else
            {
                return value;
            }
        }
    }
}
