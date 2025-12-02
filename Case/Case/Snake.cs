using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    internal class Snake
    {
        GameObject head;
        GameObject tail;
        List<GameObject> body = new List<GameObject>();
        public bool Active;
        private static Snake instance;
        public static Snake Instance
        {
            get
            {
                return instance;
            }
            set
            {
                if (instance == null)
                {
                    instance = value;
                    instance.Active = true;
                }
            }
        }
        public Snake(GameObject head)
        {
            this.head = head;
            tail = null;
        }
        public void Move(Vector2 dir)
        {
            Vector2 pos = head.pos;
            Remove();
            head.Move(dir);
            Vector2 oldPos;
            for (int i = 0; i < body.Count; i++)
            {
                oldPos = body[i].pos;
                body[i].pos = pos;
                pos = oldPos;
            }
        }
        public void Remove()
        {
            head.Remove();
            foreach (var item in body)
            {
                item.Remove();
            }
        }
        public void Draw()
        {
            head.Draw();
            foreach (var item in body)
            {
                item.Draw();
            }
        }
        public void EatFood()
        {
            if (body.Count == 0)
            {
                GameObject newBody = new GameObject(head.pos, "*", ConsoleColor.White);
                body.Add(newBody);
            }
            else
            {
                GameObject newBody = new GameObject(body.Last().pos, "*", ConsoleColor.White);
                body.Add(newBody);
            }
        }
        public void TriggerEvent()
        {
            if (Map.Instance.food.pos == head.pos)
            {
                EatFood();
                Map.Instance.CreateFood();
            }
            foreach (var item in Map.Instance.gameObjects)
            {
                if (item.pos == head.pos||(item.pos.x+1==head.pos.x&&item.pos.y==head.pos.y))
                {
                    Console.SetCursorPosition(30, 1);
                    Instance.Active = false;
                }
            }
            //foreach (var item in body)
            //{
            //    if (item.pos == head.pos)
            //    {
            //        Console.SetCursorPosition(30, 2);
            //        Console.WriteLine("Die");
            //    }
            //}
        }
    }
}
