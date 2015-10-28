using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace D2.Models
{
    //Adding 'Context' to class name and using DbContext lets VS know which class files you want to create a table out of. 
    //All class files added to this class will be used to create tables.
    //IncidentReportContext represents the database.
    public class IncidentReportContext : DbContext
    {
        //Putting class file here enables CRUD functionality
        public DbSet<IncidentReport> IncidentReports { get; set; }
    }
}