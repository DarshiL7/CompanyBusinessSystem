using CompanyBusinessApplication.Context;
using CompanyBusinessApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompanyBusinessApplication.Domains
{
    public class BusinessUnitDomain : BaseContext
    {
        BusinessUnit businessUnit = new BusinessUnit();
        ProjectDomain projectDomain = new ProjectDomain();
        public void AddUnitInformation()
        {

            Console.WriteLine("Enter Business Unit Name:");
            businessUnit.UnitName = Console.ReadLine();

            Console.WriteLine("Enter Business Unit Address:");
            businessUnit.UnitAddress = Console.ReadLine();

            Console.WriteLine("Enter ProjectId From given options");
            Console.WriteLine("Id\tProjectName\tEndDate\tManagerId");
            foreach (Project project in projectDomain.GetAllInformationProjects())
            {
                Console.WriteLine($"{project.ProjectId}\t{project.ProjectName}\t{project.ProjectEndDate}\t{project.ManagerId}");
            }
            Console.WriteLine("Enter Id:");
            businessUnit.ProjectId = Int32.Parse(Console.ReadLine());

            try
            {
                BusinessUnits.Add(businessUnit);
                SaveChanges();
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }
        }

        public List<BusinessUnit> GetBusinessUnitsInformation()
        {
            return BusinessUnits.ToList();
        }
    }
}
