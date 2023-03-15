using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_03_2023_Code_first
{
    internal class Human
    {
        public int Id { get; set; }
        public string Name { get; set; }    
        public string Fname { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }

        public Human (string _name, string _fname, string _gender, int _age ) 
        {
        Name = _name;
            Fname = _fname;
            Gender = _gender;
            Age = _age;
        }
        public override string ToString()
        {
            return "Имя "+Name+" Фамилия "+ Fname + " Пол " + Gender + " Возраст " + Age;
        }

    }
}
