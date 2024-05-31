using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio
{
    [Serializable]
    public class Employee
    {
        private string name;
        private string surname;
        private string rank;
        private int age;
        private double salary;
        private readonly int id;
        private static int AllEmployee = 0;

        public Employee(string name, string surname, string rank, int age, double salary)
        {
            this.name = name;
            this.surname = surname;
            this.rank = rank;
            this.age = age;
            this.salary = salary;

            id = AllEmployee;
            AllEmployee++;
        }

        public Employee()
        {
            this.name = "";
            this.surname = "";
            this.rank = "";
            this.age = 0;
            this.salary = 0;

            id = AllEmployee;
            AllEmployee++;
        }

        public int ID
        {
            get { return id; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }

        public string Rank
        {
            get { return rank; }
            set { rank = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public double Salary
        {
            get { return salary; }
            set { salary = value; }
        }

        public override string ToString()
        {
            return string.Format($"id: {id}, Name = {name}, Surname = {surname}");
        }
    }
}
