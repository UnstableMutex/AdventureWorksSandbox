using AjaxService.Mappers;
using AjaxService.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.ServiceModel.Web;
using System.Text;

namespace AjaxService
{
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени класса "Service1" в коде, SVC-файле и файле конфигурации.
    // ПРИМЕЧАНИЕ. Чтобы запустить клиент проверки WCF для тестирования службы, выберите элементы Service1.svc или Service1.svc.cs в обозревателе решений и начните отладку.
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class Service1 : IService1
    {


        public IEnumerable<Department> GetDataUsingDataContract()
        {
            using (var c = new SqlConnection(Constants.CS))
            {
                var m = new DepartmentMapper();
                c.Open();
                using (var cmd = c.CreateCommand())
                {
                    cmd.CommandText = "GetDepartments";
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    using (var r = cmd.ExecuteReader())
                    {
                        return m.Map(r);
                    }
                };

            }
        }
    }
}
