using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace theSpyCardEditor
{
    class EditorProperties
    {
        public static Language[] LANGUAGES = new Language[]{
            new Language("fr", "Français", ELanguage.FR),
            new Language("en", "English", ELanguage.EN)
        };

        public static Language CurrentLanguage => LANGUAGES[(int)CurrentIdLanguage];

        public static ELanguage CurrentIdLanguage { get; set; }
    }
}
