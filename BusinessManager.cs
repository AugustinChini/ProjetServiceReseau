using EntitiesLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StubDataAccessLayer;

namespace BusinessLayer
{
    public class BusinessManager
    {
        private DalManager _dm;
        private DateTime _date;

        public BusinessManager()
        {
            _dm = new DalManager();
            _date = DateTime.Now;
        }

        public List<String> getAllAuteurs()
        {
            List<String> auteurs = new List<String>();
            foreach(Auteur auteur in _dm.getAllAuteurs())
            {
                auteurs.Add(auteur.ToString());
            }
            return auteurs;
        }
        
        public List<String> empruntsEnCours()
        {
            List<String> emprunts = new List<String>();
            var empruntsEnCours =
                from emprunt in _dm.getAllEmprunts()
                where Convert.ToDateTime(emprunt.DateDebut) <= _date && Convert.ToDateTime(emprunt.DateFin) >= _date
                select emprunt;
            foreach (Emprunt emprunt in empruntsEnCours)
            {
                emprunts.Add(emprunt.ToString());
            }
            return emprunts;
        }

        public List<String> auteursPrixGoncourt()
        {
            List<String> auteurs = new List<String>();
            var auteursGoncourt =
                from auteur in _dm.getAllAuteurs()
                where auteur.PrixGoncourt == true
                select auteur;
            foreach (Auteur auteur in auteursGoncourt)
            {
                auteurs.Add(auteur.ToString());
            }
            return auteurs;
        }

        public List<String> livresNoteSup5()
        {
            List<String> livres = new List<String>();
            var livresNoteSup5 =
                from livre in _dm.getAllBooks()
                where livre.Note > 5
                select livre;
            foreach (Livre livre in livresNoteSup5)
            {
                livres.Add(livre.ToString());
            }
            return livres;
        }

        public List<String> livresPrixNoteSup5()
        {
            List<String> livres = new List<String>();
            var livresPrixNoteSup5 =
                from livre in _dm.getAllBooks()
                where livre.Note > 5 && livre.Auteur.PrixGoncourt == true
                select livre;
            foreach (Livre livre in livresPrixNoteSup5)
            {
                livres.Add(livre.ToString());
            }
            return livres;
        }

    }
}
