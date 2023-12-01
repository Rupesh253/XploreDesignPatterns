using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XploreDesignPatterns.Singleton {
    internal class Client2 {
        public void Main(string[] args) {
            Singleton s1 = Singleton.Instance;
            Singleton s2 = Singleton.Instance;

            Console.WriteLine($"S1:{s1.GetHashCode()}, Type {s1.GetType()}");
            Console.WriteLine($"S2:{s2.GetHashCode()},Type {s2.GetType()}");
            Console.WriteLine(s1 == s2);
        }

        public class Singleton {
            private Singleton() { }
            private static readonly object _lock = new object();
            private static Singleton? instance = null;
            public static Singleton Instance {
                get {
                    lock (_lock) {
                        if (instance == null) {
                            instance = new Singleton();
                        }
                    }
                    return instance;
                }

            }

        }


    }
}
