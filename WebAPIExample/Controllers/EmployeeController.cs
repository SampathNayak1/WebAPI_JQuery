using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPIExample.Models;

namespace WebAPIExample.Controllers
{
    public class EmployeeController : ApiController
    {
        EmpDbContext db = new EmpDbContext();
        public List<Emp> GetEmps()
        {
            List<Emp> emps= db.Emps.ToList();
            return emps; 
        }
        public List<Emp> GetByName(string name)
        {
            List<Emp> obj = db.Emps.Where(e => e.EmpName.Contains(name)).ToList();
            return obj;
        }
        public String Post(Emp emp)
        {
            db.Emps.Add(emp);
            db.SaveChanges();
            return "Data Inserted Sucessfully";
        }
        public String Put(Emp emp)
        {
             Emp existinguser=db.Emps.Where(e=>e.EmpId == emp.EmpId).FirstOrDefault();
             existinguser.EmpName = emp.EmpName;
             existinguser.EmpSalary = emp.EmpSalary;
             db.SaveChanges();
             return "Data Updated Sucessfully"; 
        }
        public String DeleteUser(int id)
        {
            Emp obj=db.Emps.Where(e=>e.EmpId == id).FirstOrDefault();
             db.Emps.Remove(obj);
            db.SaveChanges();
             return "Deleted User";
        }

    }
}
