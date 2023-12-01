using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XploreDesignPatterns.ChainOfResponsibility {
    internal class Client {
        public void Main(string[] args) {
            Employee employee = new Employee();
            ProjectManager projectManager = new ProjectManager();
            Director director = new Director();
            HR hr = new HR();
            employee.SetNextSupervisor(projectManager);
            projectManager.SetNextSupervisor(director);
            director.SetNextSupervisor(hr);
            employee.ProcessLeaveRequest("SpiderMan", 2);
            employee.ProcessLeaveRequest("Ironman", 9);
            employee.ProcessLeaveRequest("Thor", 25);
            employee.ProcessLeaveRequest("Dr.Strange", 53);
            employee.ProcessLeaveRequest("Captain America", 75);
        }

        public abstract class LeaveHandler {
            protected LeaveHandler supervisor;
            public void SetNextSupervisor(LeaveHandler supervisor) {
                this.supervisor = supervisor;
            }
            public abstract void ProcessLeaveRequest(string employeeName, float numberOfLeavesRequested);

        }
        public class Employee : LeaveHandler {
            private const float MAX_LEAVES_CAN_APPROVE = 2;
            public override void ProcessLeaveRequest(string employeeName, float numberOfLeavesRequested) {
                if (numberOfLeavesRequested <= MAX_LEAVES_CAN_APPROVE) {
                    Console.WriteLine($"Self-Approved by {employeeName} for {numberOfLeavesRequested} days");
                } else {
                    supervisor.ProcessLeaveRequest(employeeName, numberOfLeavesRequested);
                }
            }
        }
        public class ProjectManager : LeaveHandler {
            private const float MAX_LEAVES_CAN_APPROVE = 10;
            public override void ProcessLeaveRequest(string employeeName, float numberOfLeavesRequested) {
                if (numberOfLeavesRequested <= MAX_LEAVES_CAN_APPROVE) {
                    Console.WriteLine($"Project Manager Approved  {numberOfLeavesRequested} days for {employeeName}");
                } else {
                    supervisor.ProcessLeaveRequest(employeeName, numberOfLeavesRequested);
                }
            }
        }
        public class Director : LeaveHandler {
            private const float MAX_LEAVES_CAN_APPROVE = 30;
            public override void ProcessLeaveRequest(string employeeName, float numberOfLeavesRequested) {
                if (numberOfLeavesRequested <= MAX_LEAVES_CAN_APPROVE) {
                    Console.WriteLine($"Director Approved  {numberOfLeavesRequested} days for {employeeName}");
                } else {
                    supervisor.ProcessLeaveRequest(employeeName, numberOfLeavesRequested);
                }
            }
        }
        public class HR : LeaveHandler {
            private const float MAX_LEAVES_CAN_APPROVE = 60;
            public override void ProcessLeaveRequest(string employeeName, float numberOfLeavesRequested) {
                if (numberOfLeavesRequested <= MAX_LEAVES_CAN_APPROVE) {
                    Console.WriteLine($"HR Approved  {numberOfLeavesRequested} days for {employeeName}");
                } else {
                    Console.WriteLine("Please contact HR");
                }
            }
        }
    }

}
