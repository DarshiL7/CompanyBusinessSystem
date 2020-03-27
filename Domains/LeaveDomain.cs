using CompanyBusinessApplication.Context;
using CompanyBusinessApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompanyBusinessApplication.Domains
{
    public class LeaveDomain : BaseContext
    {
        public void AddLeaveInformation()
        {
            Leave leave = new Leave();
            Employee employee1 = new Employee();
            EmployeeDomain employeeDomain = new EmployeeDomain();

            Console.WriteLine("Leave Start Date:");
            leave.StartDate = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Leave End Date:");
            leave.EndDate = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Enter Leave Reasone:");
            leave.LeaveReason = Console.ReadLine();

            Console.WriteLine("Enter Employee Id form given below");
            Console.WriteLine("Id\tName\tAddress\tMobile Number\tStatus\tProjectId");
            foreach (Employee employee in employeeDomain.GetAllEmployeeInformation())
            {
                if (employee.Status==true)
                {
                    Console.WriteLine($"{employee.EmpId}\t{employee.EmpName}\t{employee.EmpAddress}\t{employee.EmpMobile}\t{employee.Status}\t{employee.ProjectId}");
                }
                
            }
            Console.WriteLine("Enter Id:");
            leave.EmpId= Int32.Parse(Console.ReadLine()) ;
            try
            {
                Leaves.Add(leave);
                SaveChanges();
                /*employee1.Status == false;
                employeeDomain.UpdateEmployeeInformation(employee1.Status==false);*/
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }
        }

        public List<Leave> GetAllLeaveInformation()
        {
            return Leaves.ToList();
        }
    }
}
