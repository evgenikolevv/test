using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadacha4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();
            DateTime firstDate = new DateTime(2015,12,25);
            Employee firstEmployee = new Employee("Ivan", 2, firstDate);
            DateTime secondDate = new DateTime(2016,11,21);
            Employee secondEmployee = new Employee("Martin", 1, secondDate);
            DateTime thirdDate = new DateTime(2011,01,05);
            Employee thirdEmployee = new Employee("Svetla", 1, thirdDate);

            Employee.addEmployee(employees, firstEmployee);
            Employee.addEmployee(employees, secondEmployee);
            Employee.addEmployee(employees, thirdEmployee);

            Console.WriteLine("Извеждане на списъка подреден по level.");
            employees.Sort();
            foreach(Employee element in employees)
            {
                Console.WriteLine(element);
            }

            DateTime fourthDate = new DateTime(2021, 11, 07);
            Employee fourthEmployee = new Employee("Svetoslav", 3, fourthDate);

            Employee.addEmployee(employees, fourthEmployee);
            Console.WriteLine("Извеждане на списъка след като е добавен новия служител.");
            employees.Sort();
            foreach (Employee element in employees)
            {
                Console.WriteLine(element);
            }

            Console.WriteLine("Извеждане на списъка след като е изтрит новия служител.");
            Employee.deleteEmployee(employees, fourthEmployee);
            foreach (Employee element in employees)
            {
                Console.WriteLine(element);
            }

            Employee employee = Employee.findEmployee(employees, "Ivan");
            Console.WriteLine("Извеждане на служител. ");
            Console.WriteLine(employee);

            Employee employeeWithMostExperience = Employee.findEmployeeWithMostExperience(employees);
            Console.WriteLine("Извеждане на служителя с най-много стаж. ");
            Console.WriteLine(employeeWithMostExperience);

            Console.ReadLine();
        }
    }
}
