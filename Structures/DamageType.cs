using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;

namespace DnDSheets.Structures
{
    class DamageType
    {
        public string Name { get; }
        public string Name_Short { get; }
        public Color Color { get; }
        public Uri uriSource { get; } //Вставляется в конце текста урона с помощью StackPanel (или нет)

        public DamageType(string name, string name_short, Uri uri)
        {
            Name = name;
            Name_Short = name_short;
            uriSource = uri;
        }
    }
}
