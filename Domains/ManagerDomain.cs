using CompanyBusinessApplication.Context;
using CompanyBusinessApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompanyBusinessApplication.Domains
{
    public class ManagerDomain : BaseContext
    {
        Manager manager = new Manager();
        public void AddManagerInformation()
        {
            Console.WriteLine("Enter Manager Name:");
            manager.ManagerName = Console.ReadLine();
            Console.WriteLine("Enter Manager Address");
            manager.ManagerAddress = Console.ReadLine();
            Console.WriteLine("Enter Manager Mobile Number:");
            manager.ManagerMobile = Console.ReadLine();
            Console.WriteLine("Enter Manager available status:");
            Console.WriteLine("{!!this is a boolean value so please enter false for not available or true for available!!}");
            manager.Status =bool.Parse(Console.ReadLine());

            if (manager.ManagerName!=null&&manager.ManagerAddress!=null&&manager.ManagerMobile!=null&&(manager.Status==true||manager.Status==false))
            {
                Managers.Add(manager);
                SaveChanges();
            }
            else
            {
                Console.WriteLine("!!Enter All Requierd fields!!");
            }

            

        }

        public List<Manager> GetAllManagerInformation()
        {
            return Managers.ToList();
        }

        public void DeleteManagerInformation(Manager manager)
        {
            Managers.Remove(manager);
        }
    }
}
