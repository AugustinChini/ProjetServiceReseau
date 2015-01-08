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

        public Emprunteur(int inID, String inDateDeNaissance, 
            String inNom, String inPrenom, ESexe inSexe, String ad, String email, String tel)
        {
            _ID = inID;
            _dateDeNaissance = inDateDeNaissance;
            _nom = inNom;
            _prenom = inPrenom;
            _sexe = inSexe;
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

        public new String ToString()
        {
            return base.ToString()+", Nom : "+_nom+", Prenom : "+_prenom+", Date de naissance : "+_dateDeNaissance+", Sexe : "+_sexe+", Adresse : "+_adresse+", Email : "+_email+", Tel : "+_telephone+".";
        }

    }
}
