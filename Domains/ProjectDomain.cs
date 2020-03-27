using CompanyBusinessApplication.Context;
using CompanyBusinessApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompanyBusinessApplication.Domains
{
    public class ProjectDomain : BaseContext

    {
        Manager Manager = new Manager();
        readonly Project project = new Project();
        readonly ManagerDomain managerDomain = new ManagerDomain();
        public void AddProjectInformation()
        {
            Console.WriteLine("-->>Enter Project Information<<--");

            Console.WriteLine("Enter Project Name:");
            project.ProjectName = Console.ReadLine();

            Console.WriteLine("Enter Project End Date:");
            project.ProjectEndDate =DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Enter ManagerId From below options");
            Console.WriteLine("ManagerId\tManagerName\tManagerAddress\tManagerMobile\tStatus");
            foreach (Manager manager in managerDomain.GetAllManagerInformation())
            {
                if (manager.Status == true)
                {
                    Console.WriteLine($"{manager.ManagerId }\t{manager.ManagerName}\t{manager.ManagerAddress}\t{manager.ManagerMobile}\t{manager.Status}");
                }
                
            }
            
            Console.WriteLine("Enter manager Id:");
            project.ManagerId =Int32.Parse(Console.ReadLine());
            try
            {
                
                    Projects.Add(project);
                    SaveChanges();
                
                
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        public List<Project> GetAllInformationProjects()
        {
            return Projects.ToList();
        }
    }
}
