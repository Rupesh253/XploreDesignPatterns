using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XploreDesignPatterns.Factory {
    internal class ColoredConsole {
        public void Print() {
            string NL = Environment.NewLine; // shortcut
            string NORMAL = Console.IsOutputRedirected ? "" : "\x1b[39m";
            string RED = Console.IsOutputRedirected ? "" : "\x1b[91m";
            string GREEN = Console.IsOutputRedirected ? "" : "\x1b[92m";
            string YELLOW = Console.IsOutputRedirected ? "" : "\x1b[93m";
            string BLUE = Console.IsOutputRedirected ? "" : "\x1b[94m";
            string MAGENTA = Console.IsOutputRedirected ? "" : "\x1b[95m";
            string CYAN = Console.IsOutputRedirected ? "" : "\x1b[96m";
            string GREY = Console.IsOutputRedirected ? "" : "\x1b[97m";
            string BOLD = Console.IsOutputRedirected ? "" : "\x1b[1m";
            string NOBOLD = Console.IsOutputRedirected ? "" : "\x1b[22m";
            string UNDERLINE = Console.IsOutputRedirected ? "" : "\x1b[4m";
            string NOUNDERLINE = Console.IsOutputRedirected ? "" : "\x1b[24m";
            string REVERSE = Console.IsOutputRedirected ? "" : "\x1b[7m";
            string NOREVERSE = Console.IsOutputRedirected ? "" : "\x1b[27m";

            Console.WriteLine($"This is {RED}Red{NORMAL}, {GREEN}Green{NORMAL}, {YELLOW}Yellow{NORMAL}, {BLUE}Blue{NORMAL}, {MAGENTA}Magenta{NORMAL}, {CYAN}Cyan{NORMAL}, {GREY}Grey{NORMAL}! ");
            Console.WriteLine($"This is {BOLD}Bold{NOBOLD}, {UNDERLINE}Underline{NOUNDERLINE}, {REVERSE}Reverse{NOREVERSE}! ");
        }
    }
}
