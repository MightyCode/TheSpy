using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace theSpyCardEditor
{
    public enum ELanguage
    {
        FR, EN
    }

    public class Language
    {
        public string Id { get;  }
        public string Name { get;  }

        public ELanguage IdLanguage { get; }

        public string IdToListIdentifier => Id + " : " + Name;

        public Language(string id, string name, ELanguage language)
        {
            Id = id;
            Name = name;
            IdLanguage = language;
        }
    }
}
