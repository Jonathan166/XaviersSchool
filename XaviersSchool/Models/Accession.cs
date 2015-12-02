using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using XaviersSchool.ViewModels;

namespace XaviersSchool.Models
{
    public class Accession
    {
        public int AccessionId { get; set; }
        public int AbilityId { get; set; }
        public int MutantId { get; set; }
        public decimal? Level { get; set; }
        public virtual Mutant mutant { get; set; }
        public virtual Ability ability { get; set; }
    }
}