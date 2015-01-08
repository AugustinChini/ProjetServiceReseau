using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLayer
{
    public class Auteur : Personne
    {
        private String _dateMort;
        private bool _prixGoncourt;

        public Auteur(int inID, String inDateDeNaissance, 
            String inNom, String inPrenom, ESexe inSexe, String mort, bool prix)
        {
            _ID = inID;
            _dateDeNaissance = inDateDeNaissance;
            _nom = inNom;
            _prenom = inPrenom;
            _sexe = inSexe;
            _dateMort = mort;
            _prixGoncourt = prix;
        }

        public String DateMort
        {
            get { return _dateMort; }
            set { _dateMort = value; }
        }

        public bool PrixGoncourt
        {
            get { return _prixGoncourt; }
            set { _prixGoncourt = value; }
        }
    }
}
