using System.Collections.Generic;
using XaviersSchool.Models;

namespace XaviersSchool.Models
{
    public class Mutant
    {
        public int MutantId { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public int Age { get; set; }
        public string AKA { get; set; }
        public string Interests { get; set; }
        public string Address { get; set; }
        public byte[] Picture { get; set; }
        public string ImagePath { get; set; }
        public virtual List<Accession> Accessions { get; set; }
    }
}