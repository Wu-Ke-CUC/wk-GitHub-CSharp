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
        Vector2 size;
        Vector2 startPos;
        ConsoleColor color;
        List<GameObject> gameObjects = new List<GameObject>();
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
        public void GreateWallDate()
        {
            Console.ForegroundColor = color;
            for (int i = 0; i < size.y; i++)
            {
                for (int j = 0; j < size.x; j++)
                {
                    if (i == 0||i==size.y-1) 
                    {
                        GameObject gameObject = new GameObject(new Vector2(startPos.x + j, startPos.y + i), icon, color);
                        gameObjects.Add(gameObject);
                        //gameObject.Draw();
                        //Console.SetCursorPosition(startPos.x+j, startPos.y+i);
                        //Console.Write(icon);
                    }
                    if(j==0||j==size.x-1)
                    {
                        GameObject gameObject = new GameObject(new Vector2(startPos.x + j, startPos.y + i), icon, color);
                        gameObjects.Add(gameObject);
                        //gameObject.Draw();
                        //Console.SetCursorPosition(startPos.x + j, startPos.y + i);
                        //Console.Write(icon);
                    }
                }
            }
        }
        public void Draw()
        {
            foreach (var icon in gameObjects)
            {
                icon.Draw();
            }
        }
    }
}
