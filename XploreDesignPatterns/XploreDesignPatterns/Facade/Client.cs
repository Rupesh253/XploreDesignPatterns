using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XploreDesignPatterns.Facade {
    internal class Client {
        public void Main(string[] args) {
            Customer customer = new Customer("Rupesh Kumar Somala");
            CustomerFacade.Register(customer);
        }
        public static class CustomerFacade {
            public static void Register(Customer customer) {
                bool isValidated, isStoredInDB, isNotified = false;
                isValidated = Validator.IsValidated(customer);
                isStoredInDB = DBStorage.IsStoredInDB(customer, isValidated);
                isNotified = Notifier.IsNotified(customer, isStoredInDB);
                if (isNotified) {
                    Console.WriteLine("All done");
                } else {
                    Console.WriteLine("Oops! Something went wrong...");
                }
            }
        }
        public class Customer {
            public string? Name { get; set; }
            public string? Address { get; set; }
            public string? Email { get; set; }
            public string? MobileNumber { get; set; }
            public Customer(string name, string address = "Earth", string email = "default@gmail.com", string mobileNumber = "112") {
                this.Name = name;
                this.Address = address;
                this.Email = email;
                this.MobileNumber = mobileNumber;
            }
        }
        public static class Validator {
            public static bool IsValidated(Customer customer) {
                if (!string.IsNullOrEmpty(customer.Name)) {
                    Console.WriteLine("CustomerDto Validated...");
                    Console.WriteLine($"\tName:{customer.Name}");
                    Console.WriteLine($"\tEmail:{customer.Email}");
                    Console.WriteLine($"\tMobile:{customer.MobileNumber}");
                    Console.WriteLine($"\tAddress:{customer.Address}");
                    return true;
                } else {
                    Console.WriteLine("Validation failed");
                    return false;
                }
            }
        }
        public static class DBStorage {
            public static bool IsStoredInDB(Customer customer, bool isValidated) {
                if (isValidated) {
                    Console.WriteLine("Customer stored in db");
                    return true;
                } else {
                    Console.WriteLine("Unable to store in db due to validation failed");
                    return false;
                }
            }
        }
        public static class Notifier {
            public static bool IsNotified(Customer customer, bool isStoredInDB) {
                if (isStoredInDB) {
                    Console.WriteLine("Notified customer via Mail");
                    return true;
                } else {
                    Console.WriteLine("Unable to notify user due to storing into db failed");
                    return false;
                }
            }
        }

    }
}
