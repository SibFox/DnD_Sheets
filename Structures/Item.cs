using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDSheets.Structures
{
    class Item
    {
        string Name { get; }
        string Description { get; }
        int Weight { get; } //в фунтах (1фнт -> 0.454)

        DamageType damageType { get; }
        string damage = "";

        int SP_consumption = 0;

        int type = 0; //0 - обычный предмет; 1 - ближ. оружие; 2 - дальн. оружие; 3 - боеприпас; 4 - метательный предмет; 5 - снаряжение: 6 - магический предмет

        public Item(int itemType, string itemName, string itemDescription, int itemWeight, DamageType itemDamageType, string itemDamage, int itemSP)
        {
            type = itemType;
            Name = itemName;
            Description = itemDescription;
            Weight = itemWeight;
            damage = itemDamage;
            damageType = itemDamageType;
            SP_consumption = itemSP;
        }
    }
}
