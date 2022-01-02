using System;
using System.Collections.Generic;
using System.Linq;
namespace company
{
    class Program
    {
        static void Main(string[] args)
        {

            infoR infoRf = new infoR();
            infoRf.Add();
            infoRf.INFO1();
            infoRf.info2();
            infoRf.info3();
            infoRf.info4();
            infoRf.info5();
            infoRf.info6();
        }

    }
    public class infoR
    {
        public string name;
        public int age;
        public string gender;
        public int salary;
        public string position;
        static List<infoR> info = new List<infoR>();


        public void Add()
        {

            infoR f1 = new infoR();
            f1.name = "elnaz";
            f1.age = 21;
            f1.gender = "female";
            f1.salary = 20000000;
            f1.position = "manager";
            info.Add(f1);

            infoR f2 = new infoR();
            f2.name = "reza";
            f2.age = 49;
            f2.gender = "male";
            f2.salary = 10000000;
            f2.position = "computer programming";
            info.Add(f2);

            infoR f3 = new infoR();
            f3.name = "yasamin";
            f3.age = 100;
            f3.gender = "female";
            f3.salary = 1500000;
            f3.position = "computer programming";
            info.Add(f3);

            infoR f4 = new infoR();
            f4.name = "yasin";
            f4.age = 21;
            f4.gender = "male";
            f4.salary = 12000000;
            f4.position = "computer programming";
            info.Add(f4);

            infoR f5 = new infoR();
            f5.name = "fateme";
            f5.age = 78;
            f5.gender = "female";
            f5.salary = 2000000;
            f5.position = "abdarchi";
            info.Add(f5);

        }
        public void INFO1()
        {

            var Al = info.Where(a => a.age > 40).OrderBy(a => a.age).ToList();
            Al.ForEach(b => System.Console.WriteLine(b.name + "  " + b.age + b.position + "  "));
        }
        public void info2()
        {
            var Dl = info.Where(p => p.salary > 10000000 && p.salary < 13000000).OrderBy(p => p.salary).ToList();
            Dl.ForEach(k => System.Console.WriteLine(k.name +" "+ k.gender +" "+ k.salary + k.position+" "));

        }
        public void info3()
        {
            var yl = info.Where(w => w.gender == "female" && w.salary < 3000000).ToList();
            yl.ForEach(l => System.Console.WriteLine(l.name+" " + l.gender +" "+ l.salary));

        }
        public void info4()
        {
            var el = info.Sum(j => j.salary);
            System.Console.WriteLine(el);

        }
        public void info5()
        {
            var avgl = info.Where(H => H.gender == "male").Average(H => H.salary);
            System.Console.WriteLine(avgl);

        }
        public void info6()
        {
           var sa=info.Where( b=>b.gender=="male").Average(b=>b.age);
           System.Console.WriteLine(sa);

        }
       
    }
}
