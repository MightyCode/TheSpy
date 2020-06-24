using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace theSpyCardEditor
{
    class FileMethods
    {
        public static void GeneralCheck()
        {
            string[] paths = {
                "data/",
            };

            CheckPaths(paths);
        }

        public static void CheckPaths(string[] path)
        {
            for (int i = 0; i < path.Length; ++i)
            {
                CheckAPath(path[i]);
            }
        }


        public static bool CheckAPath(string path)
        {
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
                return false;
            }

            return true;
        }


        #region paths
        public static void CheckAndLoadPreferences()
        {
            string file = "data/preferences.xml";
            if (!File.Exists(file))
            {
                SavePreferences();
            }
            else
            {
                LoadPreferences();
            }
        }

        public static void SavePreferences()
        {
            string file = "data/preferences.xml";

            StreamWriter stream = new StreamWriter(file);
            XmlWriter writer = XmlWriter.Create(stream);
            writer.WriteStartDocument();

            writer.WriteStartElement("preferences"); 

            writer.WriteStartElement("editor");
            writer.WriteAttributeString("language", UserPreferences.LANGUAGE_USED+"");
            writer.WriteEndElement();

            writer.WriteStartElement("lastWork");
            writer.WriteAttributeString("filePath", UserPreferences.LASTWORK);
            writer.WriteEndElement();
            writer.WriteEndElement();
            writer.WriteEndDocument();

            writer.Close();
            writer.Dispose();
            stream.Close();
            stream.Dispose();
        }

        public static void LoadPreferences()
        {
            string file = "data/preferences.xml";

            StreamReader stream = new StreamReader(file);
            XmlReader reader = XmlReader.Create(stream);

            reader.ReadToFollowing("preferences");
            reader.ReadToFollowing("editor");
            reader.MoveToAttribute("language");
            UserPreferences.LANGUAGE_USED = Convert.ToInt32(reader.ReadContentAsString());

            reader.ReadToFollowing("lastWork");
            reader.MoveToAttribute("filePath");
            UserPreferences.LASTWORK = reader.ReadContentAsString();

            reader.Close();
            reader.Dispose();
            stream.Close();
            stream.Dispose();
        }

        #endregion

        public static bool IsGoodExtension(string path, string extension)
        {
            string file = String.Copy(path);
            // Remove the previous path, just the final file

            string[] part = file.Split('/');
            file = part[part.Length - 1];
            part = file.Split('\\');
            file = part[part.Length - 1];

            // Remove the point of the file extension
            int lastIndexPoint = file.LastIndexOf('.');
            string fileExtension = file.Substring(lastIndexPoint);
            if (extension.IndexOf('.') == -1)
            {
                extension = "." + extension;
            }

            return fileExtension.Equals(extension);
        }

        public static string ReturnFileName(string path)
        {
            string file = String.Copy(path);
            // Remove the previous path, just the final file

            string[] part = file.Split('/');
            file = part[part.Length - 1];
            part = file.Split('\\');
            file = part[part.Length - 1];

            // Remove the point of the file extension
            int lastIndexPoint = file.LastIndexOf('.');
            return file.Substring(0, lastIndexPoint);
        }
    }
}
