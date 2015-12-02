using System.Collections.Generic;
using System.Data.Entity;
using XaviersSchool.ViewModels;

namespace XaviersSchool.Models
{
    public class SchoolInitializer :DropCreateDatabaseIfModelChanges<SchoolContext>
    {
        protected override void Seed(SchoolContext context)
        {
            var mutants = new List<Mutant>
            {
                new Mutant {FirstName = "Charles", LastName = "Xavier", AKA = "Professor X", Age = 47,
                    Interests = "Teaching, Peace with Humans, Building Relationships", Address = "New York City, New York", ImagePath = "proX.jpeg"},
                new Mutant {FirstName = "Scott", LastName = "Summers", AKA = "Cyclops", Age = 22,
                    Interests = "Jean Grey, Leading his team, Strategic warfare", Address = "Anchorage, Alaska", ImagePath = "cyclops.jpeg"},
                new Mutant {FirstName = "Bobby", LastName = "Drake", AKA = "Iceman", Age = 18,
                    Interests = "Girls, ShadowCat, Music, Snowboarding, Free-running", Address = "South Boston, Massachusetts", ImagePath = "iceman.jpeg"},
                new Mutant {FirstName = "Warren", LastName = "Worthington", AKA = "Archangel", Age = 23,
                    Interests = "Free Flying, Saving people", Address= "Hamptons, New York", ImagePath = "archangel.jpeg"},
                new Mutant {FirstName = "Hank", LastName = "McCoy", AKA = "Beast", Age = 28,
                    Interests = "Reading, Studying, Learning, Working out, Experimenting", Address = "Livermore, California", ImagePath = "beast.jpeg"},
                new Mutant {FirstName = "Jean", LastName = "Grey", AKA = "Phoenix", Age = 21,
                    Interests = "Developing Empathy, Listening to others, Helping the unfortunate", Address = "Trenton, New Jersey", ImagePath = "jeanGrey.jpeg"},
            };
            foreach (var temp in mutants){
                context.Mutants.Add(temp);
            }
            context.SaveChanges();

            var abilities = new List<Ability>
            {
                new Ability{AbilityName = "Optical Concussive Force"},
                new Ability{AbilityName = "Telekinesis"},
                new Ability{AbilityName = "Flight"},
                new Ability{AbilityName = "Strength"},
                new Ability{AbilityName = "Telepathy"},
                new Ability{AbilityName = "HyperFreeze"}
            };
            foreach(var temp in abilities)
            {
                context.Abilities.Add(temp);
            }
            context.SaveChanges();

            var accessions = new List<Accession>
            {
                new Accession{MutantId = 1, AbilityId = 5, Level = 10},
                new Accession{MutantId = 6, AbilityId = 2, Level = 10},
                new Accession{MutantId = 4, AbilityId = 3, Level = 5},
                new Accession{MutantId = 5, AbilityId = 4, Level = 6},
                new Accession{MutantId = 2, AbilityId = 1, Level = 7},
                new Accession{MutantId = 3, AbilityId = 6, Level = 5}
            };
            foreach (var temp in accessions)
            {
                context.Accessions.Add(temp);
            }
            context.SaveChanges();
        }
    }
}