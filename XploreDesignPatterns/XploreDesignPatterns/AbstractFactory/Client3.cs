namespace XploreDesignPatterns.AbstractFactory {
    internal class Client3 {
        public void Main(String[] args) {
            Console.WriteLine("Enter your order type: \n [1]. DineIn [2]. Curbside [3]. Delivery");
            IOrder order = OrderFactory.Create(Convert.ToInt16(Console.ReadLine()));
            Console.WriteLine("Enter your cuisine type: \n [1]. Chinese [2]. Mediterranean [3]. Mexican [4]. Thai [5].Indian");
            CuisineFactory.Choose(order, Convert.ToInt16(Console.ReadLine()));
        }

        public interface IOrder {
            void PrepareChineseCuisine();
            void PrepareMexicanCuisine();
            void PrepareMediterraneanCuisine();
            void PrepareIndianCuisine();
            void PrepareThaiCuisine();
        }
        public class DineIn : IOrder {
            public void PrepareChineseCuisine() {
                Console.WriteLine("1.Order Type: DineIn & Cuisine: Chinese");
                Console.WriteLine("2.Accepted your order");
                Console.WriteLine("3.Preparing your order");
                Console.WriteLine("4.Serving your order at your table");
            }

            public void PrepareIndianCuisine() {
                Console.WriteLine("1.Order Type: DineIn & Cuisine: Indian");
                Console.WriteLine("2.Accepted your order");
                Console.WriteLine("3.Preparing your order");
                Console.WriteLine("4.Serving your order at your table");
            }

            public void PrepareMediterraneanCuisine() {
                Console.WriteLine("1.Order Type: DineIn & Cuisine: Mediterranean");
                Console.WriteLine("2.Accepted your order");
                Console.WriteLine("3.Preparing your order");
                Console.WriteLine("4.Serving your order at your table");
            }

            public void PrepareMexicanCuisine() {
                Console.WriteLine("1.Order Type: DineIn & Cuisine: Mexican");
                Console.WriteLine("2.Accepted your order");
                Console.WriteLine("3.Preparing your order");
                Console.WriteLine("4.Serving your order at your table");
            }

            public void PrepareThaiCuisine() {
                Console.WriteLine("1.Order Type: DineIn & Cuisine: Thai");
                Console.WriteLine("2.Accepted your order");
                Console.WriteLine("3.Preparing your order");
                Console.WriteLine("4.Serving your order at your table");
            }
        }
        public class Curbside : IOrder {
            public void PrepareChineseCuisine() {
                Console.WriteLine("1.Order Type: Curbside & Cuisine: Chinese");
                Console.WriteLine("2.Accepted your order");
                Console.WriteLine("3.Preparing your order");
                Console.WriteLine("4.Ready for pickup");
                Console.WriteLine("5.Delivered your order at takeaway counter");
            }

            public void PrepareIndianCuisine() {
                Console.WriteLine("1.Order Type: Curbside & Cuisine: Indian");
                Console.WriteLine("2.Accepted your order");
                Console.WriteLine("3.Preparing your order");
                Console.WriteLine("4.Ready for pickup");
                Console.WriteLine("5.Delivered your order at takeaway counter");
            }

            public void PrepareMediterraneanCuisine() {
                Console.WriteLine("1.Order Type: Curbside & Cuisine: Mediterranean");
                Console.WriteLine("2.Accepted your order");
                Console.WriteLine("3.Preparing your order");
                Console.WriteLine("4.Ready for pickup");
                Console.WriteLine("5.Delivered your order at takeaway counter");
            }

            public void PrepareMexicanCuisine() {
                Console.WriteLine("1.Order Type: Curbside & Cuisine: Mexican");
                Console.WriteLine("2.Accepted your order");
                Console.WriteLine("3.Preparing your order");
                Console.WriteLine("4.Ready for pickup");
                Console.WriteLine("5.Delivered your order at takeaway counter");
            }

            public void PrepareThaiCuisine() {
                Console.WriteLine("1.Order Type: Curbside & Cuisine: Thai");
                Console.WriteLine("2.Accepted your order");
                Console.WriteLine("3.Preparing your order");
                Console.WriteLine("4.Ready for pickup");
                Console.WriteLine("5.Delivered your order at takeaway counter");
            }
        }
        public class Delivery : IOrder {
            public void PrepareChineseCuisine() {
                Console.WriteLine("1.Order Type: Delivery & Cuisine: Chinese");
                Console.WriteLine("2.Accepted your order");
                Console.WriteLine("3.Preparing your order");
                Console.WriteLine("4.Dispatched your order");
                Console.WriteLine("5.Delivered your order at takeaway counter");
            }

            public void PrepareIndianCuisine() {
                Console.WriteLine("1.Order Type: Delivery & Cuisine: Indian");
                Console.WriteLine("2.Accepted your order");
                Console.WriteLine("3.Preparing your order");
                Console.WriteLine("4.Dispatched your order");
                Console.WriteLine("5.Delivered your order at takeaway counter");
            }

            public void PrepareMediterraneanCuisine() {
                Console.WriteLine("1.Order Type: Delivery & Cuisine: Mediterranean");
                Console.WriteLine("2.Accepted your order");
                Console.WriteLine("3.Preparing your order");
                Console.WriteLine("4.Dispatched your order");
                Console.WriteLine("5.Delivered your order at takeaway counter");
            }

            public void PrepareMexicanCuisine() {
                Console.WriteLine("1.Order Type: Delivery & Cuisine: Mexican");
                Console.WriteLine("2.Accepted your order");
                Console.WriteLine("3.Preparing your order");
                Console.WriteLine("4.Dispatched your order");
                Console.WriteLine("5.Delivered your order at takeaway counter");
            }

            public void PrepareThaiCuisine() {
                Console.WriteLine("1.Order Type: Delivery & Cuisine: Thai");
                Console.WriteLine("2.Accepted your order");
                Console.WriteLine("3.Preparing your order");
                Console.WriteLine("4.Dispatched your order");
                Console.WriteLine("5.Delivered your order at takeaway counter");
            }
        }

        public enum OrderType {
            DINEIN,
            CURBSIDE,
            DELIVERY
        }
        public static class OrderFactory {
            public static IOrder Create(int type) {

                return type switch {
                    1 => new DineIn(),
                    2 => new Curbside(),
                    _ => new Delivery()
                };
            }
        }
        public enum CuisineType {
            CHINESE,
            THAI,
            INDIAN
        }
        public static class CuisineFactory {
            public static void Choose(IOrder order, int cuisine) {
                switch (cuisine) {
                    case 1: order.PrepareChineseCuisine(); break;
                    case 2: order.PrepareMediterraneanCuisine(); break;
                    case 3: order.PrepareMexicanCuisine(); break;
                    case 4: order.PrepareThaiCuisine(); break;
                    default: order.PrepareIndianCuisine(); break;
                }
            }
        }
    }
}


