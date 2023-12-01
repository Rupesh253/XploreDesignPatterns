namespace XploreDesignPatterns.AbstractFactory {
    internal class Client {

        void Main(String[] ars) {
            IVehicleFactory vehicleFactory = new RegularVehicleFactory();
            ICar car = vehicleFactory.CreateCar();
            car.GetDetails();
            Category categoryFactory = new Category();
            categoryFactory.CreateRegular().CreateBike();
            categoryFactory.CreateSports().CreateCar();
        }

    }

    public interface IVehicleFactory {
        IBike CreateBike();
        ICar CreateCar();
    }
    public class RegularVehicleFactory : IVehicleFactory {
        public IBike CreateBike() {
            return new RegularBike();
        }

        public ICar CreateCar() {
            return new RegularCar();
        }
    }
    public class SportsVehicleFactory : IVehicleFactory {
        public IBike CreateBike() {
            return new SportsBike();
        }

        public ICar CreateCar() {
            return new SportsCar();
        }
    }
    public interface IBike { void GetDetails(); }

    public class RegularBike : IBike {
        public void GetDetails() {
            Console.WriteLine("Fetching RegularBike");
        }
    }
    public class SportsBike : IBike {
        public void GetDetails() {
            Console.WriteLine("Fetching SportsBike");
        }
    }
    public interface ICar { void GetDetails(); }
    public class RegularCar : ICar {
        public void GetDetails() {
            Console.WriteLine("Fetching RegularCar");
        }
    }
    public class SportsCar : ICar {
        public void GetDetails() {
            Console.WriteLine("Fetching SportsCar");
        }
    }
    public class Category : ICategory {
        public IRegular CreateRegular() {
            return new Regular();
        }

        public ISports CreateSports() {
            return new Sports();
        }
    }

    public interface ICategory {
        IRegular CreateRegular();
        ISports CreateSports();
    }
    public interface IRegular {
        void CreateBike();
        void CreateCar();
    }
    public interface ISports {
        void CreateBike();
        void CreateCar();
    }

    public class Regular : IRegular {
        public void CreateBike() {
            Console.WriteLine("Fetching RegularBike");
        }

        public void CreateCar() {
            Console.WriteLine("Fetching RegularCar");
        }
    }
    public class Sports : ISports {
        public void CreateBike() {
            Console.WriteLine("Fetching SportsBike");
        }

        public void CreateCar() {
            Console.WriteLine("Fetching SportsCar");
        }
    }



}
