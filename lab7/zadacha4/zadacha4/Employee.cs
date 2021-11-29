using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadacha4
{
    class Employee : IComparable<Employee>
    {
        public string Name { get; set; }
        public int Level { get; set; }
        public DateTime HiringDate {get;set;}

        public Employee()
        {

        }

        public Employee(string name, int level, DateTime hiringDate)
        {
            Name = name;
            Level = level;
            HiringDate = hiringDate;
        }

        public static void addEmployee(List<Employee> target, Employee source)
        {
            target.Add(source);
        }

        public static void deleteEmployee(List<Employee> target, Employee source) 
        {
            target.Remove(source);
        }

        public static Employee findEmployee(List<Employee> target, string name)
        {
            foreach(Employee element in target)
            {
                if (element.Name.Equals(name))
                {
        
                    return element;
                }
            }

            return null;
        }

        public static Employee findEmployeeWithMostExperience(List<Employee> source)
        {
            Employee employee = new Employee();
            foreach(Employee element in source)
            {
                if (element.HiringDate > employee.HiringDate)
                {
                    return element;
                }
            }

            return employee;
        }

        public int CompareTo(Employee other)
        {
            

            if (Level > other.Level)
            {
                return 1;
            } else if (Level < other.Level)
            {
                return -1;
            }else if (Level == other.Level)
            {
                if (HiringDate > other.HiringDate)
                {
                    return 1;
                }
            }

            return 0;
        }

        public override string ToString()
        {
            return "Name: " + Name + " Level: " + Level + " Date: " + HiringDate;
        }
    }
}
