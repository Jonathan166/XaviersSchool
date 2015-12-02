using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using XaviersSchool.Models;

namespace XaviersSchool.Models
{
    public class Ability
    {
        public int AbilityId { get; set; }
        public string AbilityName { get; set; }
        public List<Accession> Accessions { get; set; }
    }
}