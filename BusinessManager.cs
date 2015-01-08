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
        private string _date;

        public BusinessManager()
        {
            _dm = new DalManager();
            _date = DateTime.Now.ToString("dd/MM/yyyy");
        }

        public List<Auteur> getAllAuteurs()
        {
            return _dm.getAllAuteurs();
        }

        public void methodeTest()
        {
            var auteursGoncourt =
                from auteur in _dm.getAllAuteurs()
                where auteur.PrixGoncourt == true
                select auteur;
            foreach (Auteur auteur in auteursGoncourt)
            {
                Console.WriteLine(auteur.Nom);
            }
        }

    }
}
