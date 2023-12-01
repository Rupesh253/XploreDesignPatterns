using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XploreDesignPatterns.Singleton {
    internal class Client {
        public void Main(string[] args) {

            VoterMachine vm1 = VoterMachine.Instance;
            vm1.Register();
            VoterMachine vm2 = VoterMachine.Instance;
            vm2.Register();
            Console.WriteLine($"Number of votes:{vm2.Counter}");
        }
        public sealed class VoterMachine {
            private static int counter = 0;
            public int Counter { get { return counter; } }
            private VoterMachine() {
            }
            private static VoterMachine? instance = null;
            public static VoterMachine Instance {
                get {
                    if (instance == null) {
                        instance = new VoterMachine();
                    }
                    return instance;
                }
            }
            public void Register() {
                counter++;
            }
        }
    }
}