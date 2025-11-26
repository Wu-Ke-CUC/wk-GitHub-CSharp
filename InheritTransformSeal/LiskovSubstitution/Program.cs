using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitution
{
    #region 练习一
    class Monster
    {
        public string name;
        public int hp;
        public int atk;
        public Monster(int hp,int atk, string name)
        {
            this.hp = hp;
            this.atk = atk;
            this.name = name;
        }
        public void Attack()
        {
            Console.WriteLine($"{name} 攻击了你 {atk} 点血量");
        }
    }
    class Boss:Monster
    {
        public double rate;
        public Boss(int hp,int atk, string name,double rate) : base(hp,atk,name)
        {
            this.rate = rate;
        }
        public new void Attack()
        {
            Console.WriteLine($"{name} 使用了技能攻击了你 {atk * 2} 点血量");
        }
    }
    class Goblin:Monster
    {
        public Goblin(int hp, int atk, string name) : base(hp, atk, name)
        {
        }
    }
    #endregion
    #region 练习二
    class Graphic
    {
        public int x;
        public int y;
        public ConsoleColor consoleColor;
        public string icon;
        public Graphic(int x,int y,ConsoleColor consoleColor,string icon)
        {
            this.x = x;
            this.y = y;
            this.consoleColor = consoleColor;
            this.icon = icon;
        }
        public void Move(int x,int y)
        {
            this.x += x;
            this.y += y;
        }
        public void ClearConsole()
        {
            Console.Clear();
        }
    }
    class Rect : Graphic
    {
        int weight,height;
        public Rect(int x, int y, ConsoleColor consoleColor, string icon,int weight,int height) : base(x, y, consoleColor, icon)
        {
            this.weight = weight;
            this.height = height;
        }
        public void Draw()
        {
            Console.ForegroundColor = consoleColor;
            for(int i=0;i<height;i++)
            {
                for(int j=0;j<weight;j++)
                {
                    Console.SetCursorPosition(x + j, y + i);
                    Console.Write(icon);
                }
            }
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
    #endregion
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 练习一
            //List<Monster> monsters = new List<Monster>();
            //var random = new Random();
            //for (int i=0;i<10;i++)
            //{
            //    int num = random.Next(2);
            //    Monster monster = null;
            //    if(num==0)
            //    {
            //        monster = new Boss(100, 10, "Boss" + i, 0.5d);
            //    }
            //    else
            //    {
            //        monster = new Goblin(50, 5, "Goblin" + i);
            //    }
            //    monsters.Add(monster);
            //}
            //for(int i=0;i<10;i++)
            //{
            //    if(monsters[i] is Boss)
            //    {
            //        (monsters[i] as Boss).Attack();
            //    }
            //    else if (monsters[i] is Goblin)
            //    {
            //        (monsters[i] as Goblin).Attack();
            //    }
            //}
            #endregion
            #region 练习二
            Rect rect = new Rect(5, 5, ConsoleColor.Magenta, "$", 5, 5);
            rect.Draw();
            while(true)
            {
                char input = Console.ReadKey(true).KeyChar;
                if(input=='d')
                {
                    rect.ClearConsole();
                    rect.Move(1, 0);
                    rect.Draw();
                }
                else if(input=='a')
                {
                    rect.ClearConsole();
                    rect.Move(-1, 0);
                    rect.Draw();
                }
                else if(input=='w')
                {
                    rect.ClearConsole();
                    rect.Move(0, -1);
                    rect.Draw();
                }
                else if(input=='s')
                {
                    rect.ClearConsole();
                    rect.Move(0, 1);
                    rect.Draw();
                }
            }
            #endregion
        }
    }
}
