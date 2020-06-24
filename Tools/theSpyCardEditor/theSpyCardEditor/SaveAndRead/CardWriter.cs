using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace theSpyCardEditor
{
    class CardWriter
    {
        StreamWriter sw;
        bool fileOpen;

        public CardWriter()
        {
            fileOpen = false;
        }

        ~CardWriter()
        {
            Close();
        }

        public void Open(String path)
        {
            if (!fileOpen)
            {
                sw = new StreamWriter(path);
                fileOpen = true;
            }
        }

        public void Close()
        {
            if (fileOpen)
            {
                sw.Close();
                fileOpen = false;
            }
        }

        public void WriteHeader(string version)
        {
            Check();

            sw.WriteLine("version:" + version);
        }

        public void WriteCards(Dictionary<EMode, List<Card>> cards)
        {
            Check();

            foreach (EMode mode in Enum.GetValues(typeof(EMode)).Cast<EMode>())
            {
                sw.WriteLine(mode.ToString() + " " + cards[mode].Count);
                if (cards[mode].Count > 0)    
                {
                    string line = "";
                    foreach (string key in cards[mode][0].Properties.Keys)
                    {
                        line +=  "\"" +  key + "\",";
                    }

                    sw.WriteLine(line.Substring(0, line.Length-1));

                    foreach (Card card in cards[mode])
                    {
                        sw.WriteLine(card.ToExportString());
                    }
                }
            }
        }

        public void WriteFooter()
        {
            Check();

            sw.Write("end");
        }

        private void Check()
        {
            if (!fileOpen) throw new Exception("Function Open with path not called \n Stream not initialiazed");
        }
    }
}
