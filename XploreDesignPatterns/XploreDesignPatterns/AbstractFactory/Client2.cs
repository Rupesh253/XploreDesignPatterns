using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XploreDesignPatterns.AbstractFactory {
    internal class Client2 {
        public void Main(String[] args) {
            Console.WriteLine("Please enter your ordertype:");
            IOrder order = OrderFactory.Create(Console.ReadLine());
            order?.Prepare();
        }
        public interface IOrder { void Prepare(); }
        public class DineIn : IOrder {
            public void Prepare() {
                Console.WriteLine("1.Order Type is: DineIn");
                Console.WriteLine("2.Accepted your order");
                Console.WriteLine("3.Preparing your order");
                Console.WriteLine("4.Serving your order at your table");
            }
        }
        public class Curbside : IOrder {
            public void Prepare() {
                Console.WriteLine("1.Order Type is: Curbside");
                Console.WriteLine("2.Accepted your order");
                Console.WriteLine("3.Preparing your order");
                Console.WriteLine("4.Ready for pickup");
                Console.WriteLine("5.Delivered your order at takeaway counter");
            }
        }
        public class Delivery : IOrder {
            public void Prepare() {
                Console.WriteLine("1.Order Type is: Delivery");
                Console.WriteLine("2.Accepted your order");
                Console.WriteLine("3.Preparing your order");
                Console.WriteLine("4.Dispatched your order");
                Console.WriteLine("5.Delivered your order at takeaway counter");
            }
        }
        public static class OrderFactory {
            public static IOrder Create(string type) {
                return type.ToLower() switch {
                    "dinein" => new DineIn(),
                    "curbside" => new Curbside(),
                    _ => new Delivery()
                };
            }
        }

    }


}
