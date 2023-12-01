using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XploreDesignPatterns.Adapter {
    internal class Client {
        public void Main(string[] args) {
            ITarget target = new EmployeeAdapter();
            target.ProcessCompanySalaries(HR.employees);
        }
        public class Employee {
            public int Id { get; set; }
            public string? Name { get; set; }
            public string? Designation { get; set; }
            public string? Experience { get; set; }
            public double Salary { get; set; }

            public Employee(int id, string name, string designation, string experience, double salary) {
                this.Id = id;
                this.Name = name;
                this.Designation = designation;
                this.Experience = experience;
                this.Salary = salary;
            }
        }
        public interface ITarget {
            void ProcessCompanySalaries(string[,] employeesArray);
        }
        public class EmployeeAdapter : ITarget {
            public int Id { get; set; }
            public string? Name { get; set; }
            public string? Designation { get; set; }
            public string? Experience { get; set; }
            public double Salary { get; set; }
            public void ProcessCompanySalaries(string[,] employeesArray) {
                ThirdPartyBillingSystem thirdPartyBillingSystem = new ThirdPartyBillingSystem();
                List<Employee> employeesList = new List<Employee>();
                for (int i = 0; i < employeesArray.GetLength(0); i++) {
                    for (int j = 0; j < employeesArray.GetLength(1); j++) {
                        switch (j) {
                            case 0: Id = Convert.ToInt16(employeesArray[i, j]); break;
                            case 1: Name = employeesArray[i, j]; break;
                            case 2: Designation = employeesArray[i, j]; break;
                            case 3: Experience = employeesArray[i, j]; break;
                            default: Salary = Convert.ToDouble(employeesArray[i, j]); break;
                        }
                    }
                    Employee emp = new(Id, Name, Designation, Experience, Salary);
                    employeesList.Add(emp);
                }
                thirdPartyBillingSystem.ProcessSalary(employeesList);
            }

        }
        public static class HR {
            public static string[,] employees = new string[3, 5] {
                { "1", "Rupesh", "X3", "9", "5300000" },
                { "2", "Kumar", "Y9", "5", "530000" },
                { "3", "Somala", "Z5", "3", "53000000" } };
        }

        public class ThirdPartyBillingSystem {
            public void ProcessSalary(List<Employee> employees) {
                foreach (Employee emp in employees) {
                    Console.WriteLine($"INR{emp.Salary} deposited to {emp.Name} having {emp.Experience} yoe with {emp.Designation} grade");
                }
            }

        }



    }
}
