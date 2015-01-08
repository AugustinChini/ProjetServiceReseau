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

        public Auteur(String mort, bool prix)
        {
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
