using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ClassAndObject
{
    #region Student
    enum StudentLevel
    {
        top,
        medium,
        low
    }
    /// <summary>
    /// Student类
    /// </summary>
    class Student
    {
        private string name;
        private int age;
        private string id;
        public StudentLevel studentLevel;
        private bool hasStudied = false;
        private string[] Subject = { "Chinese", "Math", "English" };

        public string Name { get => name; set => name = value; }
        public int Age 
        {   
            get => age; 
            set 
            { 
                if (value < 0) return;
                else age = value;
            } 
        }
        public string Id
        {
            get => id; 
            set
            {
                if (value.Length != 4)
                {
                    Console.WriteLine("学号格式不符合要求。");
                    return;
                }
                else id = value;
            }
        }

        public Student(string name, int age, string id, StudentLevel studentLevel)
        {
            this.Name = name;
            this.Age = age;
            this.Id = id;
            this.studentLevel = studentLevel;
        }

        //行为
        public void Study()
        {
            hasStudied = true;
            Console.WriteLine($"{Name} is studying.");
        }
        public void Exam()
        {
            switch (studentLevel)
            {
                case StudentLevel.top:
                    Console.WriteLine($"{Name} gets {(new Random().Next(85, 95)) + (hasStudied ? 5 : 0)}");
                    break;
                case StudentLevel.medium:
                    Console.WriteLine($"{Name} gets {(new Random().Next(75, 85)) + (hasStudied ? 5 : 0)}");
                    break;
                case StudentLevel.low:
                    Console.WriteLine($"{Name} gets {(new Random().Next(50, 75) + (hasStudied ? 5 : 0))}");
                    break;
                default:
                    break;
            }
        }
        public void IntroduceMyself()
        {
            int num = new Random().Next(0, Subject.Length);
            Console.WriteLine($"My name is {Name},and I'm {Age} years old.My best subject is {Subject[num]}.");
        }
    }
    #endregion
    #region Player
    ///// <summary>
    ///// Player类
    ///// </summary>
    //enum Equipment
    //{
    //    Dagger=10,
    //    Rifle20,
    //    MachineGun=30,
    //    SniperRifle=100,
    //}
    //class Player
    //{
    //    public string name;
    //    public string sex;
    //    public int hp = 100;
    //    public Equipment equipment;

    //    public void Introduce()
    //    {
    //        Console.WriteLine($"Your name is {name},your sex is {sex},your HP is {hp},and you equiped {equipment}.");
    //    }
    //    public void ChangeEquipment(Equipment equipment)
    //    {
    //        this.equipment = equipment;
    //    }
    //    public void Struck(int damage)
    //    {
    //        hp -= damage;
    //        if(hp<=0)
    //        {
    //            Console.WriteLine("You  have dead");
    //        }
    //    }
    //    public void Attack(Player other)
    //    {
    //        other.hp -= (int)equipment;
    //    }
    //}
    #endregion
    class Program
    {
        static void Main(string[] args)
        {
            #region Student
            Student jay = new Student("Jay", 18, "2025", StudentLevel.top);//实例化//引用类型
            jay.Study();
            jay.Exam();
            jay.IntroduceMyself();
            #endregion
            #region Player

            #endregion
        }
    }
}
