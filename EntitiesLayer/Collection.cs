using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLayer
{
    public class Collection : EntityObject
    {
        private String _description;
        private List<Livre> _livres;
        private String _nom;

        public Collection(String desc, String nom)
        {
            _description = desc;
            _nom = nom;
        }

        public String Description
        {
            get { return _description; }
            set { _description = value; }
        }

        public List<Livre> Livres
        {
            get { return _livres; }
            set { _livres = value; }
        }

        public String Nom
        {
            get { return _nom; }
            set { _nom = value; }
        }
    }
}
