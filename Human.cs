using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_03_2023_Code_first
{
   public class Human
    {
        public int Id { get; set; }
        public string Name { get; set; }    
        public string Fname { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }

        public Human (string name, string fname, string gender, int age ) 
        {
        this.Name = name;
          this.Fname = fname;
            this.Gender = gender;
            this.Age = age;
        }
        public override string ToString()
        {
            return "Имя "+this.Name+" Фамилия "+ Fname + " Пол " + Gender + " Возраст " + Age;
        }

    }
}
