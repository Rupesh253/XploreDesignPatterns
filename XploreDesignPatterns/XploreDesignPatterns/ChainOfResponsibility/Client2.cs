using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static XploreDesignPatterns.ChainOfResponsibility.Client2;

namespace XploreDesignPatterns.ChainOfResponsibility {
    internal class Client2 {

        public static void TypingConsole(string message) {
            string MAGENTA = Console.IsOutputRedirected ? "" : "\x1b[95m";
            string NORMAL = Console.IsOutputRedirected ? "" : "\x1b[39m";
            string GREEN = Console.IsOutputRedirected ? "" : "\x1b[92m";
            string CYAN = Console.IsOutputRedirected ? "" : "\x1b[96m";
            Console.Write($"{MAGENTA}[Print]{NORMAL} {CYAN}{DateTime.Now.ToUniversalTime().ToString("u")}{NORMAL} ");
            foreach (char x in message.ToCharArray()) {
                Console.Write($"{GREEN}{x}{NORMAL}");
                Thread.Sleep(10);
            }
            Console.WriteLine();
        }

        public static void Main(string[] args) {
            Console.ForegroundColor = ConsoleColor.Green;
            Employee employee = new Employee();
            employee.ProcessRequest("SpiderMan", 2);
            employee.ProcessRequest("Ironman", 9);
            employee.ProcessRequest("Thor", 25);
            employee.ProcessRequest("Dr.Strange", 53);
            employee.ProcessRequest("Captain America", 75);
            Console.ForegroundColor = ConsoleColor.White;
        }
        public interface ILeaveHandler {
            void ProcessRequest(string employeeName, float numberOfLeavesRequested);
        }

        public class Employee : ILeaveHandler {
            private readonly float MAX_LEAVE_CAN_APPROVE = 2;
            public void ProcessRequest(string employeeName, float numberOfLeavesRequested) {
                if (numberOfLeavesRequested <= MAX_LEAVE_CAN_APPROVE) {
                    Client2.TypingConsole($"Self-Approved by {employeeName} for {numberOfLeavesRequested} days");
                } else {
                    ILeaveHandler projectManager = new ProjectManager();
                    projectManager.ProcessRequest(employeeName, numberOfLeavesRequested);
                }
            }
        }
    }
    public class ProjectManager : ILeaveHandler {
        private readonly float MAX_LEAVE_CAN_APPROVE = 10;
        public void ProcessRequest(string employeeName, float numberOfLeavesRequested) {
            if (numberOfLeavesRequested <= MAX_LEAVE_CAN_APPROVE) {
                Client2.TypingConsole($"Project Manager Approved  {numberOfLeavesRequested} days for {employeeName}");
            } else {
                ILeaveHandler director = new Director();
                director.ProcessRequest(employeeName, numberOfLeavesRequested);
            }
        }
    }
    public class Director : ILeaveHandler {
        private readonly float MAX_LEAVE_CAN_APPROVE = 30;
        public void ProcessRequest(string employeeName, float numberOfLeavesRequested) {
            if (numberOfLeavesRequested <= MAX_LEAVE_CAN_APPROVE) {
                Client2.TypingConsole($"Director Approved  {numberOfLeavesRequested} days for {employeeName}");
            } else {
                ILeaveHandler hr = new HR();
                hr.ProcessRequest(employeeName, numberOfLeavesRequested);
            }
        }
    }
    public class HR : ILeaveHandler {
        private readonly float MAX_LEAVE_CAN_APPROVE = 60;
        public void ProcessRequest(string employeeName, float numberOfLeavesRequested) {
            if (numberOfLeavesRequested <= MAX_LEAVE_CAN_APPROVE) {
                Client2.TypingConsole($"HR Approved  {numberOfLeavesRequested} days for {employeeName}");
            } else {
                Client2.TypingConsole($"{employeeName}. Please contact HR");
            }
        }
    }

}

