using AjaxService.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.ServiceModel.Web;
using System.Text;

namespace AjaxService
{
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени интерфейса "IService1" в коде и файле конфигурации.
    [ServiceContract]

    public interface IService1
    {


        [WebGet]
        [OperationContract]
        // [System.ServiceModel.Web.WebInvoke(Method = "POST", ResponseFormat = WebMessageFormat.Json)]
        IEnumerable<Department> GetDataUsingDataContract();

        // TODO: Добавьте здесь операции служб
    }



}
