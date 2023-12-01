using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static XploreDesignPatterns.Builder.Client;

namespace XploreDesignPatterns.Builder {
    internal class Client {
        public void Main(String[] args) {
            Beverage beverage;
            BeverageDirector beverageDirector = new BeverageDirector();
            TeaBuilder tea = new TeaBuilder();
            beverage = beverageDirector.MakeBeverage(tea);
            Console.WriteLine(beverage.ShowBeverage());

        }
        public class BeverageDirector {
            public Beverage MakeBeverage(BeverageBuilder beverageBuilder) {
                beverageBuilder.CreateBeverage();
                beverageBuilder.SetBeverageType();
                beverageBuilder.SetWater();
                beverageBuilder.SetMilk();
                beverageBuilder.SetSugar();
                beverageBuilder.SetPowderQuantity();

                return beverageBuilder.GetBeverage();
            }
        }
        public class Beverage {
            public int Water { get; set; }
            public int Milk { get; set; }
            public int Sugar { get; set; }
            public int PowderQuantity { get; set; }
            public string BeverageName { get; set; }
            public string ShowBeverage() {
                return "Hot " + BeverageName + " [" + Water + " ml of water, " + Milk + "ml of milk, " + Sugar + " gm of sugar, " + PowderQuantity + " gm of " + BeverageName + "]\n";
            }
        }

        public abstract class BeverageBuilder {
            protected Beverage beverage;
            public void CreateBeverage() {
                beverage = new Beverage();
            }
            public Beverage GetBeverage() {
                return beverage;
            }
            public abstract void SetBeverageType();
            public abstract void SetWater();
            public abstract void SetMilk();
            public abstract void SetPowderQuantity();
            public abstract void SetSugar();

        }

        public class CoffeeBuilder : BeverageBuilder {
            public override void SetWater() {
                Console.WriteLine("Step 1 : Boiling water");
                GetBeverage().Water = 40;
            }
            public override void SetMilk() {
                Console.WriteLine("Step 2 : Adding milk");
                GetBeverage().Milk = 50;
            }
            public override void SetSugar() {
                Console.WriteLine("Step 3 : Adding Sugar");
                GetBeverage().Sugar = 10;
            }
            public override void SetPowderQuantity() {
                Console.WriteLine("Step 4 : Adding 15 Grams of coffee powder");
                GetBeverage().PowderQuantity = 15;
            }
            public override void SetBeverageType() {
                Console.WriteLine("Coffee");
                GetBeverage().BeverageName = "Coffee";
            }
        }

        public class TeaBuilder : BeverageBuilder {
            public override void SetWater() {
                Console.WriteLine("Step 1 : Boiling water");
                GetBeverage().Water = 40;
            }
            public override void SetMilk() {
                Console.WriteLine("Step 2 : Adding milk");
                GetBeverage().Milk = 50;
            }
            public override void SetSugar() {
                Console.WriteLine("Step 3 : Adding Sugar");
                GetBeverage().Sugar = 10;
            }
            public override void SetPowderQuantity() {
                Console.WriteLine("Step 4 : Adding 15 Grams of tea powder");
                GetBeverage().PowderQuantity = 15;
            }
            public override void SetBeverageType() {
                Console.WriteLine("Tea");
                GetBeverage().BeverageName = "Tea";
            }
        }

    }
}
