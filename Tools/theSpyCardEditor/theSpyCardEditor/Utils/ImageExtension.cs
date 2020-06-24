using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace theSpyCardEditor
{
    class ImageExtension
    {
        public static string[] Extensions = new string[]
        {
            "png", "PNG", "jpg", "JPG", "jpeg", "JPEG", "bmp"
        };

        public static string GetPathWithoutExtension(string path)
        {
            foreach(string extension in Extensions)
            {
                if (File.Exists(path + "." + extension))
                {
                    return path + "." + extension;
                }
            }

            return "";
        }
    }
}
