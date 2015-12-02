using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using XaviersSchool.ViewModels;

namespace XaviersSchool.Models
{
    public class SchoolContext : DbContext
    {
        public DbSet<Mutant> Mutants { get; set; }
        public DbSet<Ability> Abilities { get; set; }
        public DbSet<Accession> Accessions { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}