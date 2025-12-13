using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    interface Subject
    {
        void Notify();
        string SubjectState
        {
            get;
            set;
        }
    }
    delegate void Handler();
    class Teacher : Subject
    {
        public string name;
        public string subjectState;
        public string SubjectState { get => subjectState; set => subjectState = value; }
        public Handler Handler;

        public Teacher(string name)
        {
            this.name = name;
        }
        public void Notify()
        {
            Handler();
        }
    }
    class Student
    {
        public string name;
        public string action;
        Subject sub;
        public Student(string name, string action, Subject sub)
        {
            this.name = name;
            this.action = action;
            this.sub = sub;
        }
        public void StopAction()
        {
            Console.WriteLine($"{sub.SubjectState},{name}请不要{action}了");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Teacher teacher = new Teacher("zhanglaoshi");
            Student student1 = new Student("zhangsan", "sleep", teacher);
            Student student2 = new Student("lisi", "play", teacher);
            teacher.Handler += new Handler(student1.StopAction);
            teacher.Handler += new Handler(student2.StopAction);
            teacher.SubjectState = "Teacher is coming";
            teacher.Notify();
        }
    }
}
