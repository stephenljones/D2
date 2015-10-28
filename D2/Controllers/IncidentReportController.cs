using D2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace D2.Controllers
{
    public class IncidentReportController : Controller
    {
        private IncidentReportContext db = new IncidentReportContext();

        // GET: IncidentReport

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult IncidentReport()
        {
            //IncidentReports is from the IncidentReportsContext class.
            //db.IncidentReports.ToList() means fetch everything from the IncidentReport(?) class and convert to a list.

            var incidentReports = db.IncidentReports.ToList();
            return View(incidentReports);
            
        }

        
    }
}