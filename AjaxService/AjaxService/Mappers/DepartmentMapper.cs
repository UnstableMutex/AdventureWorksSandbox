using AjaxService.Model;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace AjaxService.Mappers
{
    public class DepartmentMapper
    {
        public IEnumerable<Department> Map(SqlDataReader r)
        {
            List<Department> l = new List<Department>();
            while (r.Read())
            {
                Department dep = new Department();
                dep.ID = r.GetInt16(0);
                dep.Name = r.GetString(1);
                l.Add(dep);

            }
            return l;
        }
    }
}