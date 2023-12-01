using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using XploreDesignPatterns.RefactoringGuru.DesignPatterns.FactoryMethod.Conceptual;

namespace XploreDesignPatterns.Factory {


    class ConcreteProductB : IProduct {
        public string DoSomething() {
            return "{Result of ConcreteProduct2}";
        }
    }

    class ConcreteCreatorB : Creator {
        public override IProduct FactoryMethod() {
            return new ConcreteProductB();
        }
    }

}
