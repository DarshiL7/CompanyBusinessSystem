using CompanyBusinessApplication.Context;
using CompanyBusinessApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompanyBusinessApplication.Domains
{
    public class EmployeeDomain : BaseContext
    {

        Employee employee = new Employee();
        ProjectDomain projectDomain = new ProjectDomain();

        public void AddEmployeeInformation()
        {
            Console.WriteLine("Enter Employee Name:");
            employee.EmpName= Console.ReadLine();

            Console.WriteLine("Enter Employee Address:");
            employee.EmpAddress = Console.ReadLine();

            Console.WriteLine("Enter Employee Mobile Number:");
            employee.EmpMobile =Console.ReadLine();

            Console.WriteLine("Enter Employee available status:");
            Console.WriteLine("{!!this is a boolean value so please enter false for not available or true for available!!}");
            employee.Status = bool.Parse(Console.ReadLine());

            Console.WriteLine("Enter ProjectId from given Options:");
            Console.WriteLine("Id\tProjectName\tEndDate\tManagerId");
            foreach (Project project in projectDomain.GetAllInformationProjects())
            {
                Console.WriteLine($"{project.ProjectId}\t{project.ProjectName}\t{project.ProjectEndDate}\t{project.ManagerId}");
            }
            Console.WriteLine("Enter Id:");
            employee.ProjectId = Int32.Parse(Console.ReadLine());

            try
            {
                Employees.Add(employee);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

        }
        public List<Employee> GetAllEmployeeInformation()
        {
            return Employees.ToList();
        }

        /*public void UpdateEmployeeInformation(Employee employee1)
        {
            Employees.Update(employee1.Status);
            SaveChanges();
        }*/
    }
}
