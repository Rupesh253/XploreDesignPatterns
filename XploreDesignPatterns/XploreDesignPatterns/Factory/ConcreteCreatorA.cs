using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using XploreDesignPatterns.RefactoringGuru.DesignPatterns.FactoryMethod.Conceptual;

namespace XploreDesignPatterns.Factory {

    class ConcreteProductA : IProduct {
        public string DoSomething() {
            return "{Result of ConcreteProduct1}";
        }
    }
    class ConcreteCreatorA : Creator {
        public override IProduct FactoryMethod() {
            return new ConcreteProductA();
        }
    }


}
