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
            //Ability physical = new Ability();
            //physical.AbilityName = "Super Strength";

            //Mutant charles = new Mutant();
            //charles.FirstName = "Charles";
            //charles.LastName = "Xavier";

            //Mutant scott = new Mutant();
            //scott.FirstName = "Scott";
            //scott.LastName = "Summers";

            //Mutant bobby = new Mutant();
            //bobby.FirstName = "Bobby";
            //bobby.LastName = "Drake";

            //List<Mutant> mutants = new List<Mutant>();
            //mutants.Add(charles);
            //mutants.Add(scott);
            //mutants.Add(bobby);

            //Ability_Mutants obj = new Ability_Mutants();
            //obj.ability = physical;
            //obj.mutants = mutants;

            //return View(obj);
        }

        public ActionResult Index()
        {
            return View();
        }
    }
}