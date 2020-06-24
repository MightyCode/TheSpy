using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace theSpyCardEditor
{
    public class Card : ICloneable
    {
        public EMode Type { get; set; }

        public string IdList => Properties["Id"].Value + " - " + Properties["Header"].Value;

        public Dictionary<string, CardField> Properties { get; set; }

        public Card(EMode type)
        {
            Properties = new Dictionary<string, CardField>();

            this.Type = type;

            InitProperties();
        }

        public void InitProperties()
        {

            Properties.Add("Id", new CardField(false) { Value = "cardID" });
            Properties.Add("Header", new CardField(true));
            Properties.Add("Background", new CardField(false));
            Properties.Add("Text", new CardField(true));

            switch (Type)
            {
                case EMode.Standard:
                    Properties.Add("TextLeft", new CardField(true));
                    Properties.Add("TextRight", new CardField(true));
                    Properties.Add("EffectLeft", new CardField(false));
                    Properties.Add("EffectRight", new CardField(false));
                    Properties.Add("BackTextLeft", new CardField(true));
                    Properties.Add("BackTextRight", new CardField(true));
                    Properties.Add("ConditionsLeft", new CardField(false));
                    Properties.Add("ConditionsRight", new CardField(false));
                    Properties.Add("NecessaryConditions", new CardField(false));
                    Properties.Add("Weight", new CardField(false));
                    break;
                case EMode.Description:
                    Properties.Add("Effect", new CardField(false));
                    Properties.Add("Conditions", new CardField(false));
                    break;
                case EMode.Death:
                    break;
                case EMode.Fight:
                    Properties.Add("Damage", new CardField(false));
                    Properties.Add("Life", new CardField(false));
                    Properties.Add("Defence", new CardField(false));
                    Properties.Add("Dodge", new CardField(false));
                    Properties.Add("EffectLoose", new CardField(false));
                    Properties.Add("EffectWin", new CardField(false));
                    Properties.Add("ConditionsLoose", new CardField(false));
                    Properties.Add("ConditionsWin", new CardField(false));
                    break;
            }
        }

        public bool IdEquals(string otherId)
        {
            return Properties["Id"].Value.Equals(otherId);
        }

        public void PrintProperties()
        {
            Console.WriteLine("A faire");
        }

        public object Clone()
        {
            Card card = new Card(Type);

            card.Properties = new Dictionary<string, CardField>(Properties);

            return card;
        }

        public string ToExportString()
        {
            string line = "";

            foreach(string key in Properties.Keys)
            {
                line += "\"" + Properties[key].ToExportString().Replace("\"", "\\\"") + "\",";
            }

            return line.Substring(0, line.Count() - 1);
        }
    }
}
