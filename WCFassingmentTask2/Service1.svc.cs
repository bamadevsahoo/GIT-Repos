using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WCFassingmentTask2
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public List<Employee> OpeningJobs()
        {
            List<Employee> empobj = new List<Employee>();
            empobj.Add(new Employee { Role = "Developer", Worktitle = "Programmer" });
            empobj.Add(new Employee { Role = "Developer", Worktitle = "Senior Programmer" });
            empobj.Add(new Employee { Role = "Data Science", Worktitle = "Data Analyst" });
            empobj.Add(new Employee { Role = "Support", Worktitle = "Production Support Analyst" });
            empobj.Add(new Employee { Role = "Manager", Worktitle = "Program Manager" });
            empobj.Add(new Employee { Role = "Manager", Worktitle = "IT AVP" });
            return empobj;
        }

        public List<Employee> OpeningJobsByRole(string role)
        {
            List<Employee> empobj = new List<Employee>();
            empobj.Add(new Employee { Role = "Developer", Worktitle = "Programmer" });
            empobj.Add(new Employee { Role = "Developer", Worktitle = "Senior Programmer" });
            empobj.Add(new Employee { Role = "Data Science", Worktitle = "Data Analyst" });
            empobj.Add(new Employee { Role = "Support", Worktitle = "Production Support Analyst" });
            empobj.Add(new Employee { Role = "Manager", Worktitle = "Program Manager" });
            empobj.Add(new Employee { Role = "Manager", Worktitle = "IT AVP" });

            empobj = empobj.FindAll(x => x.Role == role);

            return empobj;
        }

    }
    [DataContract]
    public class Employee
    {
        [DataMember]
        public string Role { get; set; }
        [DataMember]
        public string Worktitle { get; set; }
    }
}
