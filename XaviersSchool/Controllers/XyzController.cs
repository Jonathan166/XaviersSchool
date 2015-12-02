using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using XaviersSchool.Models;
using XaviersSchool.ViewModels;

namespace XaviersSchool.Controllers
{
    public class XyzController : Controller
    {
        private SchoolContext db = new SchoolContext();

        public ActionResult Abc()
        {
            var mutants = db.Mutants.ToList();
            return View(mutants);
        }

        public ActionResult Index()
        {
            return View();
        }
    }
}