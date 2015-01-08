using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLayer
{
    public class Genre : EntityObject
    {

        public static readonly Genre BandeDessinee = new Genre("Bande Dessinee", "Des trucs avec des bulles et des vignettes");
        public static readonly Genre Biographie = new Genre("Biographie", "Truc ennuyant a propos de gens qui sont morts");
        public static readonly Genre Conte = new Genre("Conte", "Once upon a time...");
        public static readonly Genre Fantastique = new Genre("Fantastique", "Avec des dragons et des elfes");
        public static readonly Genre Horreur = new Genre("Horreur", "Brrr, ça fait trop peur pour qu'on en parle");

        private String _name;
        private String _description;

        public Genre(String name, String desc)
        {
            _name = name;
            _description = desc;
        }

        public String Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public String Description
        {
            get { return _description; }
            set { _description = value; }
        }
    }
}
