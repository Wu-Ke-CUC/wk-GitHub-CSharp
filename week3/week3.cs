// using System;
// namespace Week3
// {
//     class Student
//     {
//         public string id;
//         public string name;
//         public int Chinese;
//         public int Mathematics;
//         public int Physical;
//         public Student(string id,string name,int Chinese,int Mathematics,int Physical)
//         {
//             this.id=id;
//             this.name=name;
//             this.Chinese=Chinese;
//             this.Mathematics=Mathematics;
//             this.Physical=Physical;
//         }
//     }
//     class Work1
//     {
//         static void Main()
//         {
//             Student[] con=new Student[5];
//             int[] sum=new int[5];
//             for(int i=0;i<5;i++)
//             {
//                 string[] input=Console.ReadLine().Split();
//                 con[i]=new Student(input[0],input[1],int.Parse(input[2]),int.Parse(input[3]),int.Parse(input[4]));
//                 sum[i]=con[i].Chinese+con[i].Mathematics+con[i].Physical;
//             }
//             for(int i=0;i<5;i++)
//             {
//                 Console.WriteLine($"{con[i].id} {con[i].name} {sum[i]} {(float)sum[i]/3:F2}");
//             }
//         }
//     }
// }
// using System;
// namespace Week3
// {
//     public class Student
//     {
//         private string name;
//         private string sex;
//         private int age;
//         public string Name
//         {
//             get{return name;}
//             set{name=value;}
//         }
//         public string Sex
//         {
//             get{return sex;}
//             set{sex=value;}        
//         }
//         public int Age
//         {
//             get{return age;}
//             set{age=value;}
//         }
//         public Student(string name,int age,string sex)
//         {
//             this.name=name;
//             this.age=age;
//             this.sex=sex;
//         }
//         public override string ToString()
//         {
//             return $"Student [name={name}, sex={sex}, age={age}]";
//         }
//     }
//     class Work3
//     {
//         static void Main()
//         {
//             string[] input=Console.ReadLine().Split();
//             Student stu=new Student(input[0],int.Parse(input[1]),input[2]);
//             Console.WriteLine(stu.ToString());
//         }
//     }
// }
// using System;
// using System.Globalization;

// class Program
// {
//     static void Main()
//     {
//         long inputMillis = long.Parse(Console.ReadLine());
//         GregorianCalendar calendar = new GregorianCalendar();
//         DateTime dateTime = new DateTime(1970, 1, 1).AddMilliseconds(inputMillis);
//         int year = calendar.GetYear(dateTime);
//         int month = calendar.GetMonth(dateTime);
//         int day = calendar.GetDayOfMonth(dateTime);
//         Console.WriteLine($"{year}-{month}-{day}");
//     }
// }
// using System;
// using System.Reflection.Metadata;
// namespace Week3
// {
//     public class Complex
//     {
//         private double real;
//         private double imag;
//         public double Real
//         {
//             get{return real;}
//             set{real=value;}
//         }
//         public double Imag
//         {
//             get{return imag;}
//             set{imag=value;}
//         }
//         public Complex(double real,double imag)
//         {
//             this.real=real;
//             this.imag=imag;
//         }
//         public static Complex operator +(Complex a, Complex b)
//         {
//            return new Complex(a.real+b.real,a.imag+b.imag);
//         }
//         public static Complex operator -(Complex a, Complex b)
//         {
//             return new Complex(a.real-b.real,a.imag-b.imag);
//         }
//         public static Complex operator *(Complex a, Complex b)
//         {
//             return new Complex(a.real*b.real-a.imag*b.imag,a.real*b.imag+a.imag*b.real);
//         }
//     }
//     class Work5
//     {
//       static void Main()
//       {
//         string[] inputn=Console.ReadLine().Split("  ");
//         Complex n=new Complex(double.Parse(inputn[0]),double.Parse(inputn[1]));
//         while(true)
//         {
//             string[] inputm=Console.ReadLine().Split("  ");
//             Complex m=new Complex(double.Parse(inputm[0]),double.Parse(inputm[1]));
//             if(double.Parse(inputm[0])==0&&double.Parse(inputm[1])==0&&int.Parse(inputm[2])==0)
//             {
//                 break;
//             }
//             switch(int.Parse(inputm[2]))
//             {
//                case 1:
//                {
//                     n+=m;
//                     break;
//                }
//                case 2:
//                {
//                     n-=m;
//                     break;
//                }
//                case 3:
//                {
//                     n*=m;
//                     break;
//                }
//             }
//         }
//         Console.WriteLine($"{n.Real} {n.Imag}");
//       }
//     }
// }
// using System;
// namespace Week3
// {
//     class Vector
//     {
//         public int x;
//         public int y;
//         public Vector(int x,int y)
//         {
//             this.x=x;
//             this.y=y;
//         }
//         public static Vector operator +(Vector n,Vector m)
//         {
//             return new Vector(n.x+m.x,n.y+m.y);
//         }
//     }
//     class Work6
//     {
//         static void Main()
//         {
//             List<Vector> result=new List<Vector>();
//             while(true)
//             {
//                 string inputf = Console.ReadLine();
//                 if(!string.IsNullOrEmpty(inputf))
//                 {
//                     string[] element=inputf.Split();
//                     Vector f=new Vector(int.Parse(element[0]),int.Parse(element[1]));
//                     for(int i=0;i<int.Parse(element[2]);i++)
//                     {
//                         string[] inputs=Console.ReadLine().Split();
//                         Vector s=new Vector(int.Parse(inputs[0]),int.Parse(inputs[1]));
//                         f+=s; 
//                     }
//                     result.Add(f);
//                 }
//                 else
//                 {
//                     break;
//                 }
//             }
//             foreach (Vector num in result)
//             {
//                 Console.WriteLine($"({num.x} {num.y})");
//             }
//         }
//     }
// }
// using System;
// using System.Runtime.Intrinsics.X86;
// namespace Week3
// {
//     class Circle
//     {
//         private int radius;
//         public int Radius
//         {
//             get{return radius;}
//             set { radius = value <= 0 ? 2 : value; }
//         }
//         public Circle()
//         {
//             this.radius=2;
//             Console.WriteLine("This is a constructor with no para.");
//         }
//         public Circle(int radius)
//         {
//             this.radius = radius <= 0 ? 2 : radius;
//             Console.WriteLine("This is a constructor with para.");
//         }
//         public string getAtea()
//         {
//             return $"{Math.PI*radius*radius:F2}";
//         }
//         public string toString()
//         {
//             return "Circle [radius=" + radius + "]";
//         }
//     }
//     class Work7
//     {
//         static void Main()
//         {
//             int rc2=int.Parse(Console.ReadLine());
//             int rc3=int.Parse(Console.ReadLine());
//             Circle c1=new Circle();
//             Console.WriteLine(c1.toString());
//             Console.WriteLine(c1.getAtea());
//             Circle c2=new Circle();
//             Console.WriteLine(c2.toString());
//             Console.WriteLine(c2.getAtea());
//             c2.Radius=rc2;
//             Console.WriteLine(c2.toString());
//             Console.WriteLine(c2.getAtea());
//             Circle c3=new Circle(rc3);
//             Console.WriteLine(c3.toString());
//             Console.WriteLine(c3.getAtea());
//         }
//     }
// }
// using System;
// using System.Collections.Generic;
// namespace Week3
// {
//     class Student
//     {
//         private string stuID;
//         private string stuName;
//         static int stuNum = 0;

//         public string Stuid
//         {
//             get { return stuID; }
//             set { stuID = value; }
//         }

//         public string Stuname
//         {
//             get { return stuName; }
//             set { stuName = value; }
//         }

//         public Student()
//         {
//             stuNum++;
//             Console.WriteLine("学生类无参构造方法");
//         }

//         public Student(string stuID, string stuName)
//         {
//             stuNum++;
//             this.stuID = stuID;
//             this.stuName = stuName;
//             Console.WriteLine("学生类有参构造方法");
//         }

//         public static int GetStuNum()
//         {
//             return stuNum;
//         }
//     }

//     class Course
//     {
//         private string cID;
//         private string cName;
//         static int cNum = 0;

//         public string Cid
//         {
//             get { return cID; }
//             set { cID = value; }
//         }

//         public string Cname
//         {
//             get { return cName; }
//             set { cName = value; }
//         }

//         public Course()
//         {
//             cNum++;
//             Console.WriteLine("课程类无参构造方法");
//         }

//         public Course(string cID, string cName)
//         {
//             cNum++;
//             this.cID = cID;
//             this.cName = cName;
//             Console.WriteLine("课程类有参构造方法");
//         }

//         public static int GetCourseNum()
//         {
//             return cNum;
//         }
//     }

//     class Schedule
//     {
//         static List<Student> stuList = new List<Student>();
//         static List<Course> cList = new List<Course>();
//         static int schNum = 0;

//         public Schedule() { }

//         public void addCourse(Student stu, Course course)
//         {
//             stuList.Add(stu);
//             cList.Add(course);
//             schNum++;
//         }

//         public void displayCourse()
//         {
//             Console.WriteLine("学生选课情况如下：");
//             for (int i = 0; i < schNum; i++)
//             {
//                 Console.WriteLine($"{stuList[i].Stuid}    {stuList[i].Stuname}    {cList[i].Cid}    {cList[i].Cname}");
//             }
//         }

//         public static int GetSchNum()
//         {
//             return schNum;
//         }
//     }

//     class Work8
//     {
//         static void Main()
//         {
//             int Choose = int.Parse(Console.ReadLine());
//             switch (Choose)
//             {
//                 case 1:
//                     test1();
//                     break;
//                 case 2:
//                     test2();
//                     break;
//                 case 3:
//                     test3();
//                     break;
//                 case 4:
//                     test4();
//                     break;
//             }
//         }

//         public static void test1()
//         {
//             Student s1 = new Student();
//             Student s2 = new Student();
//             Console.WriteLine($"学生总数为：{Student.GetStuNum()}");
//         }

//         public static void test2()
//         {
//             Course c1 = new Course();
//             Course c2 = new Course();
//             Course c3 = new Course();
//             Console.WriteLine($"课程总数为：{Course.GetCourseNum()}");
//         }

//         public static void test3()
//         {
//             string[] studentInput = Console.ReadLine().Split();
//             Student student = new Student(studentInput[0], studentInput[1]);

//             string[] courseInput1 = Console.ReadLine().Split();
//             Course course1 = new Course();
//             course1.Cid=courseInput1[0];
//             course1.Cname=courseInput1[1];
//             string[] courseInput2 = Console.ReadLine().Split();
//             Course course2 = new Course();
//             course2.Cid=courseInput2[0];
//             course2.Cname=courseInput2[1];
//             Schedule schedule = new Schedule();
//             schedule.addCourse(student, course1);
//             schedule.addCourse(student, course2);

//             Console.WriteLine($"学生选课的总数为：{Schedule.GetSchNum()}");
//             schedule.displayCourse();
//         }

//         public static void test4()
//         {
//             string[] studentInput1 = Console.ReadLine().Split();
//             Student student1 = new Student(studentInput1[0], studentInput1[1]);

//             string[] studentInput2 = Console.ReadLine().Split();
//             Student student2 = new Student(studentInput2[0], studentInput2[1]);

//             string[] studentInput3 = Console.ReadLine().Split();
//             Student student3 = new Student(studentInput3[0], studentInput3[1]);

//             string[] courseInput1 = Console.ReadLine().Split();
//             Course course1 = new Course(courseInput1[0], courseInput1[1]);

//             string[] courseInput2 = Console.ReadLine().Split();
//             Course course2 = new Course(courseInput2[0], courseInput2[1]);

//             string[] courseInput3 = Console.ReadLine().Split();
//             Course course3 = new Course(courseInput3[0], courseInput3[1]);

//             string[] courseInput4 = Console.ReadLine().Split();
//             Course course4 = new Course(courseInput4[0], courseInput4[1]);

//             Schedule schedule = new Schedule();
//             schedule.addCourse(student1, course2);
//             schedule.addCourse(student1, course3);
//             schedule.addCourse(student2, course1);
//             schedule.addCourse(student3, course1);
//             schedule.addCourse(student3, course2);
//             schedule.addCourse(student3, course4);

//             Console.WriteLine($"学生总数为：{Student.GetStuNum()}");
//             Console.WriteLine($"课程总数为：{Course.GetCourseNum()}");
//             Console.WriteLine($"学生选课的总数为：{Schedule.GetSchNum()}");
//             schedule.displayCourse();
//         }
//     }
// }
// using System;
// namespace Week3
// {
//     class Coe
//     {
//         private double a;
//         private double b;
//         private double c;
//         public double A
//         {
//             get{return a;}
//             set{a=value;}
//         }
//         public double B
//         {
//             get{return b;}
//             set{b=value;}
//         }
//         public double C
//         {
//             get{return C;}
//             set{c=value;}
//         }
//         public Coe(double a,double b,double c)
//         {
//             this.a=a;
//             this.b=b;
//             this.c=c;
//         }
//         public double getD(double a,double b,double c)
//         {
//             return b*b-4*a*c;
//         }
//         public double getRoo1(double b,double D,double a)
//         {
//             if(D<0)
//             return 0;
//             else 
//             return (-b+Math.Sqrt(D))/(2*a);
//         }
//         public double getRoo2(double b,double D,double a)
//         {
//             if(D<0)
//             return 0;
//             else 
//             return (-b-Math.Sqrt(D))/(2*a);
//         }
//     }
//     class Work10
//     {
//         static void Main()
//         {
//             double a=double.Parse(Console.ReadLine());
//             double b=double.Parse(Console.ReadLine());
//             double c=double.Parse(Console.ReadLine());
//             Coe equation1=new Coe(a,b,c);
//             double D=equation1.getD(a,b,c);
//             if(D>0)
//             {
//                 Console.WriteLine($"{equation1.getRoo1(b,D,a)} {equation1.getRoo2(b,D,a)}");
//             }
//             else if(D==0)
//             {
//                 Console.WriteLine($"{equation1.getRoo1(b,D,a):F2}");
//             }
//             else
//             {
//                 Console.WriteLine("no Root");
//             }
//         }
//     }
// }
using System;
namespace Week3
{
    class Sentence
    {
        private string s;
        public string S
        {
            get{return s;}
            set{s=value;}
        }
        public Sentence(string s)
        {
            this.s=s;
        }
        public string getSentence
        {
            get{return s;}
        }
        public List<string> getWord(string s)
        {
            List<string> ret=new List<string>();
            string[] depart=s.Split();
            for(int i=0;i<depart.Length;i++)
            {
                ret.Add(depart[i]);
            }
            return ret;
        }
        public int getLength(string s)
        {
            string ret=S.Trim();
            return ret.Length;
        }
        public int getNumWords(string s)
        {
            string[] depart=S.Split();
            return depart.Length;
        }
        public string setSentence(string s)
        {
            return S.ToUpper();
        }
    }
    class Work11
    {
        static void Main()
        {
            string? input = Console.ReadLine();
            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("输入不能为空。");
                return;
            }
            Sentence ex=new Sentence(input);
            Console.WriteLine($"输入的字符串是：{ex.S}，共有{ex.getLength(ex.S)}个字符。");
            var words = ex.getWord(ex.S);
            var wordsString = string.Join(", ", words);
            Console.WriteLine($"其中有单词：[{wordsString}]，共有{ex.getNumWords(ex.S)}个单词。");
            Console.WriteLine($"输入的字符串是：{ex.setSentence(ex.S)}，共有{ex.getLength(ex.S)}个字符。");
            var words2 = ex.getWord(ex.setSentence(ex.S));
            var wordsString2 = string.Join(", ", words);
            Console.WriteLine($"其中有单词：[{wordsString2.ToUpper()}]，共有{ex.getNumWords(ex.S)}个单词。");
        }
    }
}