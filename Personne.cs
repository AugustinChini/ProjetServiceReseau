using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLayer
{
    public abstract class Personne : EntityObject
    {
        protected String _dateDeNaissance;
        protected String _nom;
        protected String _prenom;
        protected ESexe _sexe;

        public Personne()
        {
            _dateDeNaissance = "00/00/0000";
            _nom = "Inconnu";
            _prenom = "Inconnu";
            _sexe = ESexe.Indetermine;

        }

        public String DateDeNaissance
        {
            get { return _dateDeNaissance; }
            set { _dateDeNaissance = value; }
        }

        public String Nom
        {
            get { return _nom; }
            set { _nom = value; }
        }

        public String Prenom
        {
            get { return _prenom; }
            set { _prenom = value; }
        }

        public ESexe Sexe
        {
            get { return _sexe; }
            set { _sexe = value; }
        }
    }
}
