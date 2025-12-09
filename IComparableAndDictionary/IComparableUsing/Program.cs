using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IComparableUsing
{
    enum CompareType
    {
        Hp,Atk,Def
    }

    class Hero:IComparable<Hero>
    {
        public string name;
        public int hp;
        public int atk;
        public int def;
        public Hero(string name, int hp, int atk, int def)
        {
            this.name = name;
            this.hp = hp;
            this.atk = atk;
            this.def = def;
        }
        private static CompareType type = CompareType.Hp;
        public static CompareType Type
        {
            set
            {
                type = value;
            }
        }
        public int CompareTo(Hero other)
        {
            switch (type)
            {
                case CompareType.Hp:
                    return hp - other.hp;
                case CompareType.Atk:
                    return atk - other.atk;
                case CompareType.Def:
                    return def - other.def;
                default:
                    return 0;
            }
        }
        public override string ToString()
        {
            return $"Name:{name} HP:{hp} Atk:{atk} Def:{def}";
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Hero hero1 = new Hero("zhangsan",100,20,10);
            Hero hero2 = new Hero("lisis",90,25,5);
            Hero hero3 = new Hero("wangwu", 110, 15, 15);
            List<Hero> heroes = new List<Hero>();
            heroes.Add(hero1);
            heroes.Add(hero2);
            heroes.Add(hero3);
            heroes.Sort();
            foreach (var item in heroes)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-----------------------");
            Hero.Type = CompareType.Atk;
            heroes.Sort();
            foreach (var item in heroes)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-----------------------");
            Hero.Type = CompareType.Def;
            heroes.Sort();
            foreach (var item in heroes)
            {
                Console.WriteLine(item);
            }
        }
    }
}
