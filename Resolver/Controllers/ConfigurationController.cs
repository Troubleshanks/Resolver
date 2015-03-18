using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Resolver.App_Start;

namespace Resolver.Controllers
{
    public class ConfigurationController : Controller
    {

        public DatabaseConnectionContext Context = new DatabaseConnectionContext();
        // GET: Configuration
        public ActionResult Panel()
        {
            Context.Database.GetStats();
            ViewBag.Bits = Context.Database.Server.BuildInfo.Bits;
            ViewBag.GitVersion = Context.Database.Server.BuildInfo.GitVersion;
            ViewBag.SysInfo = Context.Database.Server.BuildInfo.SysInfo;
            ViewBag.Version = Context.Database.Server.BuildInfo.Version;
            ViewBag.VersionString = Context.Database.Server.BuildInfo.VersionString;
            ViewBag.ServerAddress = Resolver.Properties.Settings.Default.Server.ToString();
            ViewBag.DatabaseName = Resolver.Properties.Settings.Default.RootDatabase.ToString();

            return View();
        }

 
    }
}
