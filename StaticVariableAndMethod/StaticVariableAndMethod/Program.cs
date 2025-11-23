using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticVariableAndMethod
{
    enum AddType
    {
        atk=0,
        def=1,
        hp=2
    }
    class Equip
    {
        public string name;
        public AddType type;
        public int point;
        public int price;
        public Equip(string name,AddType type,int point,int price)
        {
            this.name = name;
            this.type = type;
            this.point = point;
            this.price = price;
        }
    }
    class Hero
    {
        public string name;
        public int atk = 10;
        public int def = 5;
        public int hp = 100;
        public int money = 100;

        public Hero(string name,int atk,int def,int hp,int money)
        {
            this.name = name;
            this.atk = atk;
            this.def = def;
            this.hp = hp;
            this.money = money;
        }
        public void AddEquip(Equip equip)
        {
            if(money>=equip.price)
            {
                if(equip.type==AddType.hp)
                {
                    money -= equip.price;
                    AddEffect(equip);
                    return;
                }
                else if(Bag.Instance.AddEquip(equip))
                {
                    money -= equip.price;
                    AddEffect(equip);
                    return;
                }
            }
            Console.WriteLine("钱不够");
        }
        public void AddEffect(Equip equip)
        {
            switch((int)(equip.type))
            {
                case 0:
                    atk += equip.point;
                    break;
                case 1:
                    def += equip.point;
                    break;
                case 2:
                    hp += equip.point;
                    break;
            }
        }
    }
    class Bag
    {
        private static Bag instance;
        public static Bag Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Bag();
                }
                return instance;
            }
        }
        public int contain = 4;
        private List<Equip> equips = new List<Equip>();
        public bool AddEquip(Equip equip)
        {
            if(equips.Count<contain)
            {
                equips.Add(equip);
                return true;
            }
            Console.WriteLine("装备数量达到上限，无法购买");
            return false;
        }
        public void ShowEquip()
        {
            foreach(var equip in equips)
            {
                Console.Write(equip.name + " ");
            }
            Console.WriteLine();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //Bag.Instance.contain = 10;
            //Console.WriteLine(Bag.Instance.contain);
            Hero lvbu = new Hero("吕布", 20, 5, 100, 100);
            while(true)
            {
                Console.WriteLine("Could you want to buy an equipment? Yes:y  No:n");
                string input = Console.ReadLine();
                if(input=="y")
                {
                    Equip equip = null;
                    Console.WriteLine("1，青缸剑 add 10 atk ;2,仁王盾 add 10 def ;3,白银狮子头 add 20 hp");
                    input = Console.ReadLine();
                    switch (int.Parse(input))
                    {
                        case 1:
                            equip = new Equip("青缸剑", AddType.atk, 10, 30);
                            lvbu.AddEquip(equip);
                            break;
                        case 2:
                            equip = new Equip("仁王盾", AddType.def, 10, 10);
                            lvbu.AddEquip(equip);
                            break;
                        case 3:
                            equip = new Equip("白银狮子头", AddType.hp, 30, 20);
                            lvbu.AddEquip(equip);
                            break;
                        default:
                            break;
                    }
                    Bag.Instance.ShowEquip();
                }
                else if(input=="n")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("default");
                }
            }
            Console.WriteLine($"atk:{lvbu.atk} def:{lvbu.def} hp:{lvbu.hp}");
        }
    }
}
