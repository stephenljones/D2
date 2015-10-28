using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace D2.Models
{
    //Once you inherit DCDBIMC the class has a virtual menthod called 'Seed' that you can override.
    public class IncidentReportInitializer : DropCreateDatabaseIfModelChanges<IncidentReportContext>
    {
        //Create a list of IR and add it to IncidentReportContext
        protected override void Seed(IncidentReportContext context)
        {
            //This is seed data for the database
            var incidentReports = new List<IncidentReport>
            {
                new IncidentReport {Id = "100", Name = "John", Incident = "Theft" },
                new IncidentReport {Id = "101", Name = "Sam", Incident = "AMA" },
                new IncidentReport {Id = "102", Name = "Will", Incident = "Property Damage" }

            };
            //Loop through each incidentReport
            foreach(var temp in incidentReports)
            {
                //Add each incidentReport to IncidentReportsContext
                //context.Students is here because the IncidentReportContext has the entry IncidentReports
                context.IncidentReports.Add(temp);
            }
            context.SaveChanges();
        }
    }
}