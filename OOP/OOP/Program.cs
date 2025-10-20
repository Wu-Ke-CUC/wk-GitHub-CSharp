using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    /// <summary>
    /// Equipment
    /// </summary>
    enum EquipmentType
    {
        Attack,
        Defend,
        Magic,
        Move,
        Jungle
    }
    class Equipment
    {
        public string name;
        public int hpBuff;
        public int atBuff;
        public int deBuff;
        public int spBuff;
        public EquipmentType equipmentType;

        public Equipment(string name, int hpBuff, int atBuff, int deBuff, int spBuff, EquipmentType equipmentType)
        {
            this.name = name;
            this.hpBuff = hpBuff;
            this.atBuff = atBuff;
            this.deBuff = deBuff;
            this.spBuff = spBuff;
            this.equipmentType = equipmentType;
        }
    }
    /// <summary>
    /// Hero
    /// </summary>
    class Hero
    {
        public string name;
        public int baseHP=100;
        public int baseDamage = 10;
        public int baseDefense = 10;
        public int baseMoveSpeed = 10;

        public int hp;
        public int damage;
        public int defense;
        public int moveSpeed;

        private int grade = 1;
        public List<Equipment> equipments = new List<Equipment>();
        private int maxEquipmentCount = 6;
        
        public Hero(string name, int baseHP, int baseDamage, int baseDefense, int baseMoveSpeed)
        {
            this.name = name;
            this.baseHP = baseHP;
            this.baseDamage = baseDamage;
            this.baseDefense = baseDefense;
            this.baseMoveSpeed = baseMoveSpeed;
            InitPlayerPorperties();
        }

        public void InitPlayerPorperties()
        {
            hp = baseHP;
            damage = baseDamage;
            defense = baseDefense;
            moveSpeed = baseMoveSpeed;
        }
        public void UpdatePlayerProperties()
        {
            InitPlayerPorperties();
            foreach (var item in equipments)
            {
                hp += item.hpBuff;
                damage += item.atBuff;
                defense += item.deBuff;
                moveSpeed += item.spBuff;
            }
        }

        //加载装备
        public void LoadEquipment(Equipment equipment)
        {
            if(equipments.Count()<=maxEquipmentCount&&equipment!=null)
            {
                equipments.Add(equipment);
                UpdatePlayerProperties();
                Console.WriteLine($"{name}加载{equipment.name}成功");
            }
            else
            {
                Console.WriteLine("装备失效,装备栏已满");
                return;
            }
        }
        //卸载装备
        public void UploadEquipment(Equipment equipment)
        {
            if(equipment!=null)
            {
                Console.WriteLine($"{name}卸载{equipment.name}成功");
                equipments.Remove(equipment);
                UpdatePlayerProperties();
            }
            else
            {
                Console.WriteLine("卸载失败");
            }
        }
        public void Attack(Hero sufferer)
        {
            sufferer.Struck(this);
        }
        public void Struck(Hero injurer)
        {
            int damage = injurer.damage - defense;
            damage = damage > 0 ? damage : 0;
            hp -= damage;
            if(hp<=0)
            {
                Console.WriteLine($"{name}被{injurer.name}击杀了");
                injurer.KillAward();
            }
            else
            {
                Console.WriteLine($"{name}受到{injurer.name}{damage}点伤害了,剩余{hp}点血量");
            }
        }
        public void KillAward()
        {
            grade++;
            Console.WriteLine($"{name}等级提升至{grade}");
            baseDamage += 200;
            UpdatePlayerProperties();
            Console.WriteLine($"{name}基础攻击力提升至{baseDamage}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Equipment Gun = new Equipment("Gun", 5, 15, 5, 0, EquipmentType.Attack);
            Hero jay = new Hero("Jay", 100, 20, 10, 10);
            Hero ljj = new Hero("LJJ", 100, 15, 15, 15);
            jay.LoadEquipment(Gun);
            jay.Attack(ljj);
        }
    }
}
