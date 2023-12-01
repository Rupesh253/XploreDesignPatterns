using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XploreDesignPatterns.RefactoringGuru.DesignPatterns.FactoryMethod.Conceptual;

namespace XploreDesignPatterns.Factory {
    class Client {
        public void Main() {
            Console.WriteLine("App: Launched with the ConcreteCreator1.");
            ClientCode(new ConcreteCreatorA());
            Console.WriteLine("App: Launched with the ConcreteCreator2.");
            ClientCode(new ConcreteCreatorB());
        }
        public void ClientCode(Creator creator) {
            Console.WriteLine("Client: I'm not aware of the creator's class," + "but it still works.\n" + creator.SomeOperation());
        }
    }
}
