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
        public List<Emp> GetEmps()
        {
            EmpDbContext db = new EmpDbContext();
            List<Emp> emps= db.Emps.ToList();
            return emps; 
        }
    }
}
