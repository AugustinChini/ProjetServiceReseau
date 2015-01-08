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

        public Personne(int inID, String inDateDeNaissance, String inNom, String inPrenom, ESexe inSexe)
        {
            _ID = inID;
            _dateDeNaissance = inDateDeNaissance;
            _nom = inNom;
            _prenom = inPrenom;
            _sexe = inSexe;
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

        public new String ToString()
        {
            return base.ToString() + ", Nom : " + _nom + ", Prenom : " + _prenom + ", Date de naissance : " + _dateDeNaissance + ", Sexe : " + _sexe + ".";
        }
    }
}
