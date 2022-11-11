using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SampleCodeQA.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
            var connc = @"DATA SOURCE=localhost:1521/xe;SELF TUNING=True;USER ID=system;password=p#11@STC;";
            OracleConnection c = new OracleConnection(connc);
            c.Open();
            c.ClientInfo = "Sample Application";
            c.ModuleName = "Chandrasekar";
            c.ActionName = "Kafka";
            OracleCommand cmd = new OracleCommand("select *from perf where id="+3, c);
            OracleDataAdapter adp = new OracleDataAdapter(cmd);
            Console.WriteLine(cmd.ExecuteNonQuery());
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}