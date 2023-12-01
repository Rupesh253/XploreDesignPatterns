using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XploreDesignPatterns.AbstractFactory {
    internal class Client4 {
        public void Main(String[] args) {
            Console.WriteLine("Enter your cuisine type: \n [1]. Chinese [2]. Mediterranean [3]. Mexican [4]. Thai [5].Indian");
            ICuisine cuisine = CuisineFactory.Choose(Convert.ToInt16(Console.ReadLine()));
            Console.WriteLine("Enter your order type: \n [1]. DineIn [2]. Curbside [3]. Delivery");
            OrderFactory.Choose(cuisine, Convert.ToInt16(Console.ReadLine()));
        }

    }
    public interface ICuisine {
        void PerformDineIn();
        void PerformCurbside();
        void PerformDelivery();
    }

    public class Chinese : ICuisine {
        public void PerformCurbside() {
            Console.WriteLine("1.Cuisine: Chinese & Order Type: Curbside");
            Console.WriteLine("2.Accepted your order");
            Console.WriteLine("3.Preparing your order");
            Console.WriteLine("4.Ready for pickup");
            Console.WriteLine("5.Delivered your order at takeaway counter");
        }

        public void PerformDelivery() {
            Console.WriteLine("1.Cuisine: Chinese & Order Type: Delivery");
            Console.WriteLine("2.Accepted your order");
            Console.WriteLine("3.Preparing your order");
            Console.WriteLine("4.Dispatched your order");
            Console.WriteLine("5.Delivered your order at takeaway counter");
        }

        public void PerformDineIn() {
            Console.WriteLine("1.Cuisine: Chinese & Order Type: DineIn");
            Console.WriteLine("2.Accepted your order");
            Console.WriteLine("3.Preparing your order");
            Console.WriteLine("4.Serving your order at your table");
        }
    }
    public class Mediterranean : ICuisine {
        public void PerformCurbside() {
            Console.WriteLine("1.Cuisine: Mediterranean & Order Type: Curbside");
            Console.WriteLine("2.Accepted your order");
            Console.WriteLine("3.Preparing your order");
            Console.WriteLine("4.Ready for pickup");
            Console.WriteLine("5.Delivered your order at takeaway counter");
        }

        public void PerformDelivery() {
            Console.WriteLine("1.Cuisine: Mediterranean & Order Type: Delivery");
            Console.WriteLine("2.Accepted your order");
            Console.WriteLine("3.Preparing your order");
            Console.WriteLine("4.Dispatched your order");
            Console.WriteLine("5.Delivered your order at takeaway counter");
        }

        public void PerformDineIn() {
            Console.WriteLine("1.Cuisine: Mediterranean & Order Type: DineIn");
            Console.WriteLine("2.Accepted your order");
            Console.WriteLine("3.Preparing your order");
            Console.WriteLine("4.Serving your order at your table");
        }
    }
    public class Mexican : ICuisine {
        public void PerformCurbside() {
            Console.WriteLine("1.Cuisine: Mexican & Order Type: Curbside");
            Console.WriteLine("2.Accepted your order");
            Console.WriteLine("3.Preparing your order");
            Console.WriteLine("4.Ready for pickup");
            Console.WriteLine("5.Delivered your order at takeaway counter");
        }

        public void PerformDelivery() {
            Console.WriteLine("1.Cuisine: Mexican & Order Type: Delivery");
            Console.WriteLine("2.Accepted your order");
            Console.WriteLine("3.Preparing your order");
            Console.WriteLine("4.Dispatched your order");
            Console.WriteLine("5.Delivered your order at takeaway counter");
        }

        public void PerformDineIn() {
            Console.WriteLine("1.Cuisine: Mexican & Order Type: DineIn");
            Console.WriteLine("2.Accepted your order");
            Console.WriteLine("3.Preparing your order");
            Console.WriteLine("4.Serving your order at your table");
        }
    }
    public class Thai : ICuisine {
        public void PerformCurbside() {
            Console.WriteLine("1.Cuisine: Thai & Order Type: DineIn");
            Console.WriteLine("2.Accepted your order");
            Console.WriteLine("3.Preparing your order");
            Console.WriteLine("4.Ready for pickup");
            Console.WriteLine("5.Delivered your order at takeaway counter");
        }

        public void PerformDelivery() {
            Console.WriteLine("1.Cuisine: Thai & Order Type: Delivery");
            Console.WriteLine("2.Accepted your order");
            Console.WriteLine("3.Preparing your order");
            Console.WriteLine("4.Dispatched your order");
            Console.WriteLine("5.Delivered your order at takeaway counter");
        }

        public void PerformDineIn() {
            Console.WriteLine("1.Cuisine: Thai & Order Type: DineIn");
            Console.WriteLine("2.Accepted your order");
            Console.WriteLine("3.Preparing your order");
            Console.WriteLine("4.Serving your order at your table");
        }
    }
    public class Indian : ICuisine {
        public void PerformCurbside() {
            Console.WriteLine("1.Cuisine: Indian & Order Type: Curbside");
            Console.WriteLine("2.Accepted your order");
            Console.WriteLine("3.Preparing your order");
            Console.WriteLine("4.Ready for pickup");
            Console.WriteLine("5.Delivered your order at takeaway counter");
        }

        public void PerformDelivery() {
            Console.WriteLine("1.Cuisine: Indian & Order Type: Delivery");
            Console.WriteLine("2.Accepted your order");
            Console.WriteLine("3.Preparing your order");
            Console.WriteLine("4.Dispatched your order");
            Console.WriteLine("5.Delivered your order at takeaway counter");
        }

        public void PerformDineIn() {
            Console.WriteLine("1.Cuisine: Indian & Order Type: DineIn");
            Console.WriteLine("2.Accepted your order");
            Console.WriteLine("3.Preparing your order");
            Console.WriteLine("4.Serving your order at your table");
        }
    }
    public static class CuisineFactory {
        public static ICuisine Choose(int type) {
            return type switch {
                1 => new Chinese(),
                2 => new Mediterranean(),
                3 => new Mexican(),
                4 => new Thai(),
                _ => new Indian()
            };
        }
    }
    public static class OrderFactory {
        public static void Choose(ICuisine cuisine, int type) {
            switch (type) {
                case 1: cuisine.PerformDineIn(); break;
                case 2: cuisine.PerformCurbside(); break;
                default: cuisine.PerformDelivery(); break;
            }
        }
    }

}
