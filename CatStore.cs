using System.Collections.Generic;
using asp_webapp.Models;

namespace asp_webapp
{
  public class CatStore
  {
    public static CatStore Current { get; } = new CatStore();

    public List<Cat> Cats { get; set; }

    public CatStore()
    {
      Cats = new List<Cat>()
      {
       new Cat()
       {
         Id = 1,
         Name = "Stella",
         Breed = "Russian Blue",
         Age = 5,
         Traits = new List<Trait>()
         {
           new Trait() {
           Id = 1,
           Skill = "Bitch Face",
           Description = "Pierces the soul."
           },
           new Trait() {
             Id = 2,
             Skill = "Clingyness",
             Description = "Hangs onto Mommy."
           }
         }
       },
       new Cat()
       {
         Id = 2,
         Name = "Nala",
         Breed = "Tabby Mix",
         Age = 5,
         Traits = new List<Trait>() {
           new Trait() {
             Id = 3,
             Skill = "Total Calm",
             Description = "Can sleep forever."
           },
           new Trait() {
             Id = 4,
             Skill = "Stealth",
             Description = "Can hide and be forgotten about."
           }
         }
       },
       new Cat()
       {
         Id = 3,
         Name = "Cayde",
         Breed = "Siberian Cat",
         Age = 2,
         Traits = new List<Trait>() {
           new Trait() {
             Id = 5,
             Skill = "Gluttony",
             Description = "Endless hunger."
           },
           new Trait() {
             Id = 6,
             Skill = "Super Speed",
             Description = "I'M FAST AS FUCK BOII."
           },
           new Trait() {
             Id = 7,
             Skill = "Absolute Cuteness",
             Description = "The cutest boy."
           }
         }
       }
     };
    }
  }
}