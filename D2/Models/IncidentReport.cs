using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace D2.Models
{
    public class IncidentReport
    {
        //Using Id declares Id as primary key.
        public string Id { get; set; }
        public string Name { get; set; }
        public string Incident { get; set; }
    }
}