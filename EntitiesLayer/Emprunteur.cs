using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLayer
{
    public class Emprunteur : Personne
    {
        private String _adresse;
        private String _email;
        private String _telephone;

        public Emprunteur(String ad, String email, String tel)
        {
            _adresse = ad;
            _email = email;
            _telephone = tel;
        }

        public String Adresse
        {
            get { return _adresse; }
            set { _adresse = value; }
        }

        public String Email
        {
            get { return _email; }
            set { _email = value; }
        }

        public String Telephone
        {
            get { return _telephone; }
            set { _telephone = value; }
        }

        public String ToString()
        {
            return "Nom : "+_nom+", Prenom : "+_prenom+", Date de naissance : "+_dateDeNaissance+", Sexe : "+_sexe+", Adresse : "+_adresse+", Email : "+_email+", Tel : "+_telephone+".";
        }

    }
}
