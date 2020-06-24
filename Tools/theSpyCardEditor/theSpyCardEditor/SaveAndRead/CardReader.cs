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
    class CardReader
    {
        StreamReader sr;
        bool fileOpen;

        public Dictionary<EMode, List<Card>> Cards;

        public CardReader()
        {
            fileOpen = false;
        }

        ~CardReader()
        {
            Close();
        }

        public void Open(String path)
        {
            if (!fileOpen)
            {
                sr = new StreamReader(path);
                Cards = new Dictionary<EMode, List<Card>>();
                fileOpen = true;
            }
        }

        public void Close()
        {
            if (fileOpen)
            {
                sr.Close();
                fileOpen = false;
            }
        }

        public void Read()
        {
            Check();
            sr.ReadLine(); //Version

            EMode currentCategorie = EMode.Standard;
            string line, languageId, content;
            string[] parts;
            string[] parameters;
            string[] languages;
            int segmentationIndex;

            int sizeOfEnum = Enum.GetNames(typeof(EMode)).Length;

            // 4 categories 
            for (int z = 0; z < sizeOfEnum; z++)
            {
                line = sr.ReadLine();
                parts = line.Split(' ');
                int size = Convert.ToInt16(parts[1]);

                // Find current categorie
                for (int y = 0; y < sizeOfEnum; y++)
                {
                    if (((EMode)y).ToString().Equals(parts[0]))
                    {
                        currentCategorie = (EMode)y;
                    }
                }

                Cards.Add(currentCategorie, new List<Card>());

                // If there are card(s) on the categorie
                if (size > 0)
                {
                    parameters = ReadParts();
                    if (parameters == null)
                    {
                        Cards = null;
                        return;
                    }

                    // Card
                    for (int i = 0; i < size; i++)
                    {
                        Cards[currentCategorie].Add(new Card(currentCategorie));

                        parts = ReadParts();
                        if (parts == null)
                        {
                            Cards = null;
                            return;
                        }
                        else if (parts.Length != parameters.Length)
                        {
                            Cards = null;
                            return;
                        }

                        // Properties
                        for (int j = 0; j < parameters.Length; ++j)
                        {
                            // If multiple language for the value
                            if (Cards[currentCategorie][i].Properties[parameters[j]].MultipleLanguage)
                            {
                                languages = SplitLanguage(parts[j]);

                                // Language
                                for (int q = 0; q < languages.Length; ++q)
                                {
                                    segmentationIndex = languages[q].IndexOf('{');

                                    // Like fr or en
                                    languageId = languages[q].Substring(0, segmentationIndex);
                                    content = ((segmentationIndex + 1 == languages[q].Length - 1) ? "" :
                                    languages[q].Substring(segmentationIndex + 1, languages[q].Length - segmentationIndex - 2));

                                    Cards[currentCategorie][i].Properties[parameters[j]].SetProperty(
                                        content,
                                        languageId);
                                }
                            }
                            else
                            {
                                Cards[currentCategorie][i].Properties[parameters[j]].SetProperty(parts[j]);
                            }
                        }
                    }
                }
            }
        }

        private string[] ReadParts()
        {
            List<string> parameters = new List<string>();
            string parameter = "";
            string line;
            bool continu = false;
            int index = 0;
            int begin = 1;

            line = sr.ReadLine();

            if (line.ElementAt(index) == '"')
            {
                continu = true;
                ++index;
            }

            while (continu)
            {
                if (index < line.Length)
                {
                    if (line[index] == '\\')
                    {
                        
                        ++index;
                        if (index < line.Length)
                        {
                            if (line.ElementAt(index) == '"')
                            {
                                ++index;
                            }
                        }
                    }
                    else if (line[index] == '"')
                    {
                        parameter += line.Substring(begin, index - begin).Replace("\\\"", "\"");
                        parameters.Add(parameter);
                        parameter = "";

                        ++index;
                        continu = !continu;

                        if (index < line.Length)
                        {
                            if (line[index] == ',')
                            {
                                ++index;

                                if (index < line.Length)
                                {
                                    if (line[index] == '"')
                                    {
                                        ++index;
                                        begin = index;
                                        continu = true;
                                    }
                                }
                            }
                        }
                    } else
                    {
                        index++;
                    }
                }
                // New line but not finish the current value
                else
                {
                    parameter += line.Substring(begin, index - begin).Replace("\\\"", "\"") + Environment.NewLine;
                    line = sr.ReadLine();
                    begin = 0;
                    index = 0;
                }
            }

            return parameters.ToArray();
        }


        private string[] SplitLanguage(string content)
        {
            List<string> parts = new List<string>();
            bool inLanguage = false;
            int index = 0;
            int begin = 0;

            while (index < content.Length)
            {
                if (inLanguage)
                {
                    if (content.ElementAt(index) == '}')
                    {
                        if (index >= 1)
                        {
                            inLanguage = (content.ElementAt(index - 1) == '\\');
                        }
                        else
                        {
                            inLanguage = false;
                        }
                    }
                } else
                {
                    if (content.ElementAt(index) == '{')
                    {
                        if (index >= 1)
                        {
                            inLanguage = (content.ElementAt(index - 1) != '\\');
                        }
                        else
                        {
                            inLanguage = true;
                        }
                    }
                    else if (content.ElementAt(index) == ';')
                    {
                        parts.Add(content.Substring(begin, index - begin));
                        begin = index + 1;
                    }
                }

                ++index;
            }

            if (index - begin > 0) parts.Add(content.Substring(begin, index - begin));

            return parts.ToArray();
        }

        private void Check()
        {
            if (!fileOpen) throw new Exception("Function Open with path not called \n Stream not initialiazed");
        }
    }
}
