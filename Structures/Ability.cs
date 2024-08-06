using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDSheets.Structures
{
    class Ability
    {
        string Name { get; }
        int Level { get; } //0 - Заговор; 1-9 - Уровни;
        int Ability_Scool { get; } //0 - Приём; 1 - Воплощение; 2 - Вызов; 3 - Иллюзия; 4 - Некромантия; 5 - Ограждение; 6 - Очарование; 7 - Преоброзование; 8 - Прорицание;
        int SP_consumption { get; }
        int MP_consumption { get; }

        string UseTime { get; }
        string Distance { get; }
        string Duration { get; }
        string Recharge { get; }


        List<string> Classes = new List<string>();
        List<string> Archetypes = new List<string>();

        bool Component_Verbal = false;
        bool Component_Somantic = false;
        bool Component_Material = false;
        List<Item> Component_Material_Composition = new List<Item>();
    }
}
