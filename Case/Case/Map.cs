using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    internal class Map
    {
        string icon;
        public Vector2 size;
        public Vector2 startPos;
        ConsoleColor color;
        public GameObject food;
        public List<GameObject> gameObjects = new List<GameObject>();
        public static Map instance;
        public static Map Instance
        {
            get
            {
                return instance;
            }
            set
            {
                if(instance==null)
                {
                    instance = value;
                }
            }
        }
        public Map(string icon,Vector2 size,Vector2 startPos,ConsoleColor color)
        {
            this.icon = icon;
            this.size = size;
            this.startPos = startPos;
            this.color = color;
        }
        public Map(string icon,int sizeX,int sizeY,int startPosX,int startPosY,ConsoleColor color):
            this(icon,new Vector2(sizeX,sizeY),new Vector2(startPosX, startPosY), color) { }
        public void CreateWallDate()
        {
            Console.ForegroundColor = color;
            for (int i = 0; i < size.x; i++)
            {
                GameObject gameObject1 = new GameObject(new Vector2(startPos.x + i * 2, startPos.y), icon, color);
                GameObject gameObject2 = new GameObject(new Vector2(startPos.x + i * 2, startPos.y + size.y - 1), icon, color);
                gameObjects.Add(gameObject1);
                gameObjects.Add(gameObject2);
            }
            for (int i = 0; i < size.y; i++)
            {
                GameObject gameObject1 = new GameObject(new Vector2(startPos.x, startPos.y + i), icon, color);
                GameObject gameObject2 = new GameObject(new Vector2(startPos.x + (size.x - 1) * 2, startPos.y + i), icon, color);
                gameObjects.Add(gameObject1);
                gameObjects.Add(gameObject2);
            }
        }
        public void CreateFood()
        {
            int minX = startPos.x + 2;
            int maxX = startPos.x + (size.x - 2) * 2;
            int minY = startPos.y + 1;
            int maxY = startPos.y + size.y - 2;
            Random random = new Random();
            int foodX = random.Next(minX, maxX + 1);
            int foodY = random.Next(minY, maxY + 1);
            food = new GameObject(foodX, foodY, "$", ConsoleColor.Red);
            food.Draw();
        }
        public void Draw()
        {
            CreateWallDate();
            foreach (var icon in gameObjects)
            {
                icon.Draw();
            }
            CreateFood();
        }
    }
}
