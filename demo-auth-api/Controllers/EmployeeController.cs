using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace demo_auth_api.Controllers
{
    [Authorize]
    public class EmployeeController : ApiController
    {
        APIDBEntities entities = new APIDBEntities();
        public IEnumerable<Employee> Get()
        {
            return entities.Employees.ToList();
        }
    }
}
