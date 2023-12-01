using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace XploreDesignPatterns.Prototype {
    internal class Client {

        public void Main(String[] args) {

            Employee emp1 = new Employee();
            emp1.Name = "Rupesh";
            emp1.Id = 1;
            emp1.Role = "SDET";
            Employee.Org = "XYZ";
            emp1.Address = new Address() {
                Address1 = "Flat No.Rupesh"
            };
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Emp1: name: {emp1.Name}, Id: {emp1.Id}, role: {emp1.Role}, org:{Employee.Org}, Address:{emp1.Address.Address1}");
            Employee emp2 = Employee.DeepCopy(emp1);
            emp2.Name = "Somala";
            emp2.Id = 2;
            Employee.Org = "XYZ1";
            emp2.Address.Address1 = "Flat No.Somala";
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Deep copy");
            Console.WriteLine($"Emp1: name: {emp1.Name}, Id: {emp1.Id}, role: {emp1.Role}, org:{Employee.Org}, Address:{emp1.Address.Address1}");
            Console.WriteLine($"Emp2: name: {emp2.Name}, Id: {emp2.Id}, role: {emp2.Role}, org:{Employee.Org}, Address:{emp2.Address.Address1}");
            Employee emp3 = Employee.ShallowCopy(emp2);
            emp3.Name = "Kumar";
            emp3.Id = 3;
            emp3.Address.Address1 = "Flat No.Kumar";
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Shallow copy");
            Console.WriteLine($"Emp1: name: {emp1.Name}, Id: {emp1.Id}, role: {emp1.Role}, org:{Employee.Org}, Address:{emp1.Address.Address1}");
            Console.WriteLine($"Emp2: name: {emp2.Name}, Id: {emp2.Id}, role: {emp2.Role}, org:{Employee.Org}, Address:{emp2.Address.Address1}");
            Console.WriteLine($"Emp3: name: {emp3.Name}, Id: {emp3.Id}, role: {emp3.Role}, org:{Employee.Org}, Address:{emp3.Address.Address1}");
            Console.ForegroundColor = ConsoleColor.White;
        }

        public class Employee {
            public string? Name { get; set; }
            public int Id { get; set; }
            public string? Role { get; set; }
            public static string? Org { get; set; }
            public Address Address { get; set; }
            public static Employee DeepCopy(Employee employee) {
                Employee deepEmployee = (Employee)employee.MemberwiseClone();
                deepEmployee.Address = Address.ShallowCopy(employee.Address);
                return deepEmployee;
            }
            public static Employee ShallowCopy(Employee employee) {
                Employee shallowEmployee = (Employee)employee.MemberwiseClone();
                return shallowEmployee;
            }
        }
    }
    public class Address {
        public string? Address1 { get; set; }
        public string? Addresss2 { get; set; }
        public string? City { get; set; }
        public string? ZipCode { get; set; }
        public static Address ShallowCopy(Address address) {
            return (Address)address.MemberwiseClone();
        }
    }
}
