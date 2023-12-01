using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XploreDesignPatterns.Builder {
    internal class Client2 {
        public void Main(string[] args) {
            Console.ForegroundColor = ConsoleColor.Green;
            House house1 = new House();
            Console.WriteLine($"_foundation:{house1.Foundation}, _walls:{house1.Walls}");
            house1 = house1.BuildFoundation();
            Console.WriteLine($"_foundation:{house1.Foundation}, _walls:{house1.Walls}");
            house1 = house1.BuildWalls();
            Console.WriteLine($"_foundation:{house1.Foundation}, _walls:{house1.Walls}");
            Console.WriteLine("\n ### Constructing via Builder Pattern");
            _ = new House().BuildFoundation().BuildWalls().BuildRoof().Build();
            Console.ForegroundColor = ConsoleColor.White;
        }

        public class House {
            private bool _foundation = false;
            private bool _walls = false;
            private bool _roof = false;
            public bool Foundation {
                get {
                    return _foundation;
                }
            }
            public bool Walls {
                get {
                    return _walls;
                }
            }
            public void TypingConsole(string message) {
                foreach (char x in message.ToCharArray()) {
                    Console.Write(x);
                    Thread.Sleep(25);
                }
                Console.WriteLine();
            }
            public House BuildFoundation(bool foundation = true) {
                TypingConsole("1.BuildFoundation");
                this._foundation = foundation;
                return this;
            }
            public House BuildWalls(bool walls = true) {
                TypingConsole("2.BuildWalls");
                this._walls = walls;
                return this;
            }
            public House BuildRoof(bool roof = true) {
                TypingConsole("3.BuildRoof");
                this._roof = roof;
                return this;
            }
            public House Build() {
                TypingConsole("4.Build");
                return this;
            }

        }
    }
}
