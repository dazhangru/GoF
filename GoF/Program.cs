using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoF
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 简单工厂
            //SimpleFactory factory = new SimpleFactory();
            //Console.WriteLine(factory.GetPizza("apple"));
            //Console.Read(); 
            #endregion
            #region 工厂方法
            //ApplePizzaFactory factory = new ApplePizzaFactory();
            //factory.GetPizza();
            //BuffPizzaFactory buffPizzaFactory = new BuffPizzaFactory();
            //buffPizzaFactory.GetPizza();
            //Console.ReadKey();
            #endregion
            #region 抽象工厂
            //Apple_PizzaFactory factory = new Apple_PizzaFactory();
            //Buff_PizzaFactory buff_PizzaFactory = new Buff_PizzaFactory();
            //factory.GetPizza();
            //factory.GetPrice();
            //buff_PizzaFactory.GetPizza();
            //buff_PizzaFactory.GetPrice();
            //Console.ReadKey(); 
            #endregion
            List<Teacher> teachers = new List<Teacher> { new Teacher { TeacherId = 1, Name = "王老师" }, new Teacher { TeacherId = 2, Name = "李老师" }, new Teacher { TeacherId = 3, Name = "吴老师" } };
            List<Student> students = new List<Student> { new Student { StudentId = 101, Name = "小明同学", TeacherId = 1 }, new Student { StudentId = 102, Name = "小红同学", TeacherId = 2 }, new Student { StudentId = 103, Name = "阿水同学", TeacherId = 3 } };
            List<Class> classes = new List<Class> { new Class { ClassId = 10001, Name = "三年一班", TeacherName = "王老师" }, new Class { ClassId = 10002, Name = "三年二班", TeacherName = "李老师" }, new Class { ClassId = 10003, Name = "三年三班", TeacherName = "吴老师" } };
            foreach (var e in students)
            {
                e.TeacherName = teachers.FirstOrDefault(o => o.TeacherId == e.TeacherId)?.Name;
                e.ClassName = classes.FirstOrDefault(o => o.TeacherName == e.TeacherName)?.Name;
                Console.WriteLine($"学生姓名:{e.Name}");
                Console.WriteLine($"学生的老师姓名:{e.TeacherName}");
                Console.WriteLine($"学生的班级姓名:{e.ClassName}");
            }
            Console.Read();
        }
    }
    public class Teacher
    {
        public int TeacherId { get; set; }
        public string Name { get; set; }
    }
    public class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public int TeacherId { get; set; }
        public int ClassId { get; set; }
        public string TeacherName { get; set; }
        public string ClassName { get; set; }
    }
    public class Class
    {
        public string TeacherName { get; set; }
        public int ClassId { get; set; }
        public string Name { get; set; }
    }
}
