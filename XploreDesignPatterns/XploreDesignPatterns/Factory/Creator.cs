using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XploreDesignPatterns.Factory {
    public interface IProduct {
        string DoSomething();
    }
    abstract class Creator {
        public abstract IProduct FactoryMethod();
        public string SomeOperation() {
            var product = FactoryMethod();
            var result = "Creator: The same creator's code has just worked with "
                + product.DoSomething();

            return result;
        }
    }
    class Program {
        void Main(string[] args) {
            new Client().Main();
        }
    }
}
