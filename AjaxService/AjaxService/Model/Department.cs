using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace AjaxService.Model
{
    [DataContract]
    public class Department
    {
        [DataMember]
        public short ID { get; set; }
        [DataMember]
        public string Name { get; set; }
    }
}