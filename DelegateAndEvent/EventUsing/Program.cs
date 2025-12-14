using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventUsing
{
    internal class Program
    {
        delegate void TestDele();
        delegate void HeroCheck();
        class Manager
        {
            private static Manager instance;
            public static Manager Instance
            {
                get
                {
                    if (instance == null)
                    {
                        instance = new Manager();
                    }
                    return instance;
                }
                set
                {
                    instance = value;
                }
            }
            public event TestDele eventTest;
            public void Test()
            {
                eventTest();
            }
            public void SetNull()
            {
                eventTest = null;
            }
        }

        #region 练习1
        class PlayerManager
        {
            private static PlayerManager instance;
            public static PlayerManager Instance
            {
                get
                {
                    if (instance == null)
                    {
                        instance = new PlayerManager();
                    }
                    return instance;
                }
                set
                {
                    instance = value;
                }
            }
            public event HeroCheck check;
            public void Test()
            {
                check();
            }
            public void SetNull()
            {
                check = null;
            }
        }

        class Hero
        {
            public string name;
            public int hp;
            public int atk;
            public Hero(string name, int hp, int atk)
            {
                this.name = name;
                this.hp = hp;
                this.atk = atk;
            }
            public void DeadCheck()
            {
                if (hp <= 0)
                {
                    Console.WriteLine($"{name} has dead");
                }
            }
            public void HitOther(Hero other)
            {
                if (other.hp > 0)
                {
                    other.BeHitted(atk);
                }
            }
            private void BeHitted(int demage)
            {
                hp -= demage;
                if (hp < 0)
                {
                    hp = 0;
                }
            }
        }
        #endregion

        static void Main(string[] args)
        {
            Manager.Instance.eventTest += Test1;
            Manager.Instance.eventTest += Test2;

            Manager.Instance.Test();

            Hero hero1 = new Hero("Player1", 100, 120);
            Hero hero2 = new Hero("Player2", 100, 20);
            PlayerManager.Instance.check += hero1.DeadCheck;
            PlayerManager.Instance.check += hero2.DeadCheck;
            hero2.HitOther(hero1);
            hero1.HitOther(hero2);
            PlayerManager.Instance.Test();
        }
        static void Test1()
        {
            Console.WriteLine("Test1");
        }
        static void Test2()
        {
            Console.WriteLine("Test2");
        }
    }
}
