using CompanyBusinessApplication.Domains;
using CompanyBusinessApplication.Models;
using System;

namespace CompanyBusinessApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            ManagerDomain managerDomain = new ManagerDomain();
            //managerDomain.AddManagerInformation();
            EmployeeDomain employeeDomain = new EmployeeDomain();
            BusinessUnitDomain businessUnitDomain = new BusinessUnitDomain();
            ProjectDomain projectDomain = new ProjectDomain();
            LeaveDomain leaveDomain = new LeaveDomain();
            //projectDomain.AddProjectInformation();
            //leaveDomain.AddLeaveInformation();
            repeate:
            Console.WriteLine("--->>>Welcome to Company Application Development<<<---");
            Console.WriteLine("Enter Choice form the Given Options");
            Console.WriteLine("1.Add BusinessUnit");
            Console.WriteLine("2.View BusinessUnits");
            Console.WriteLine("");
            Console.WriteLine("3.Add Employees");
            Console.WriteLine("4.View Employesss");
            Console.WriteLine("");
            Console.WriteLine("5.Add Leave");
            Console.WriteLine("6.View Leaves");
            Console.WriteLine("");
            Console.WriteLine("7.Add Manager");
            Console.WriteLine("8.View Managers");
            Console.WriteLine("");
            Console.WriteLine("9.Add Project");
            Console.WriteLine("10.View Projects");
            Console.WriteLine("");
            Console.WriteLine("Enter Any numeric Key To Exit:");
            Console.WriteLine("Enter From above:");
            int c = Int32.Parse(Console.ReadLine());

            switch (c)
            {
                case 1:
                    businessUnitDomain.AddUnitInformation();
                    goto repeate;

                case 2:
                    Console.WriteLine("Id\tName\tAddress\tProjectId");
                    foreach (BusinessUnit businessUnit in businessUnitDomain.GetBusinessUnitsInformation())
                    {
                        Console.WriteLine($"{businessUnit.BusinessUnitId}\t{businessUnit.UnitName}\t{businessUnit.UnitAddress}\t{businessUnit.ProjectId}");
                    }
                    goto repeate;

                case 3:
                    employeeDomain.AddEmployeeInformation();
                    goto repeate;

                case 4:
                    Console.WriteLine("Id\tName\tAddress\tMobile Number\tStatus\tProjectId");
                    foreach (Employee employee in employeeDomain.GetAllEmployeeInformation())
                    {
                       
                            Console.WriteLine($"{employee.EmpId}\t{employee.EmpName}\t{employee.EmpAddress}\t{employee.EmpMobile}\t{employee.Status}\t{employee.ProjectId}");
                        

                    }
                    goto repeate;

                case 5:
                    leaveDomain.AddLeaveInformation();
                    goto repeate;

                case 6:
                    Console.WriteLine("Id\tStartDate\tEndDate\tLeave Reason\tEmployeeId");
                    foreach (Leave leave in leaveDomain.GetAllLeaveInformation())
                    {

                        Console.WriteLine($"{leave.LeaveId}\t{leave.StartDate}\t{leave.EndDate}\t{leave.LeaveReason}\t{leave.EmpId}");
                    }
                    goto repeate;

                case 7:
                    managerDomain.AddManagerInformation();
                    goto repeate;

                case 8:
                    Console.WriteLine("ManagerId\tManagerName\tManagerAddress\tManagerMobile\tStatus");
                    foreach (Manager manager in managerDomain.GetAllManagerInformation())
                    {
                        
                            Console.WriteLine($"{manager.ManagerId }\t{manager.ManagerName}\t{manager.ManagerAddress}\t{manager.ManagerMobile}\t{manager.Status}");
                        

                    }
                    goto repeate;

                case 9:
                    projectDomain.AddProjectInformation();
                    goto repeate;

                case 10:
                    Console.WriteLine("ManagerId\tManagerName\tManagerAddress\tManagerMobile\tStatus");
                    Console.WriteLine("Id\tProjectName\tEndDate\tManagerId");
                    foreach (Project project in projectDomain.GetAllInformationProjects())
                    {
                        Console.WriteLine($"{project.ProjectId}\t{project.ProjectName}\t{project.ProjectEndDate}\t{project.ManagerId}");
                    }
                    goto repeate;

                default:
                    break;
            }

        }
    }
}
