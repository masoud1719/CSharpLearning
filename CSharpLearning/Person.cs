using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearning
{
    public class Person
    {
        public int _age;
        public string _name;
        public int _height;

        public Person() { }

        public Person(int age, string name, int height)
        {
            _age = age;
            _name = name;
            _height = height;

        }
        public void CalcSalary()
        {
            Console.WriteLine("2000");
        }
    }
}
