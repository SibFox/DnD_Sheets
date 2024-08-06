using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DnDSheets.Structures
{
    class Creature
    {
        public string Name { get; private set; }
        public string Race { get; private set; }
        public PlayerClass Class { get; private set; }
        public PlayerArchetype CArchetype { get; private set; }
        public int Level { get; private set; }
        private int _mastery = 0;
        public int Mastery { get => _mastery; }
        int creature_type = 0; //0 - Игрок; 1 - Существо с предметами; 2 - Существо с действиями;

        //Характеристики и модификаторы
        int Att_STR { get; }
        int Att_DEX { get; }
        int Att_CON { get; }
        int Att_INT { get; }
        int Att_WIS { get; }
        int Att_CHR { get; }

        int mod_STR = 0;
        int mod_DEX = 0;
        int mod_CON = 0;
        int mod_INT = 0;
        int mod_WIS = 0;
        int mod_CHR = 0;

        //Показатели
        int HP = 0; //Здоровье
        int SP = 0; //Выносливость
        int MP = 0; //Мана
        int speed = 0; //Скорость в фт
        /** <summary>Голова, Торс, Руки, Ноги</summary> */
        private int[] _defenceClass = new int[4] { 0, 0, 0, 0 };
        public int[] DefenceClass { get => _defenceClass; }
        public bool Have_Magic { get; private set; }

        //Навыки
        //При подсчёте навыков складывается модификатор и навык мастерства
        bool Skill_STR_Athletic = false;        //Атлетика
        bool Skill_STR_Intimidation = false;    //Запугивание
        bool Skill_DEX_Acrobatics = false;      //Акробатика
        bool Skill_DEX_SleightOfHands = false;  //Ловкость рук
        bool Skill_DEX_Stealth = false;         //Скрытность
        bool Skill_INT_Arcana = false;          //Магия
        bool Skill_INT_History = false;         //История
        bool Skill_INT_Investigation = false;   //Анализ
        bool Skill_INT_Nature = false;          //Природа
        bool Skill_INT_Religion = false;        //Религия
        bool Skill_WIS_AnimalHandling = false;  //Уход за животными
        bool Skill_WIS_Insight = false;         //Проницательность
        bool Skill_WIS_Medicine = false;        //Медицина
        bool Skill_WIS_Perception = false;      //Проницательность
        bool Skill_WIS_Survival = false;        //Выживание
        bool Skill_CHR_Deception = false;       //Обман
        bool Skill_CHR_Intimidation = false;    //Запугивание
        bool Skill_CHR_Perfomance = false;      //Выступление
        bool Skill_CHR_Persuasion = false;      //Убеждение

        //Уязвимости
        List<DamageType> vulnerabilities = new List<DamageType>();
        //Сопротивления
        List<DamageType> resistances = new List<DamageType>();

        int maxFeats = 0;
        //List<Trait> feats = new List<Trait>();
        //List<Item> items = new List<Item>();
        //List<Item> lootTab = new List<Item>();
        //List<Ability> = new List<Ability>();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="CDefenceClass">Голова, Торс, Руки, Ноги</param>
        public Creature(string CName)
        {

        }

        public Creature SetCreatureType(int t)
        {
            creature_type = t;
            return this;
        }

        public Creature SetClassAndLevel ()
    }
}
