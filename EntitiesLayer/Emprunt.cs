using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLayer
{
    public class Emprunt : EntityObject
    {
        private String _dateDebut;
        private String _dateFin;
        private Emprunteur _emprunteur;
        private Livre _livre;

        public Emprunt(String dd, String df, Emprunteur emprunteur, Livre l)
        {
            _dateDebut = dd;
            _dateFin = df;
            _emprunteur = emprunteur;
            _livre = l;
        }

        public String DateDebut
        {
            get { return _dateDebut; }
            set { _dateDebut = value; }
        }

        public String DateFin
        {
            get { return _dateFin; }
            set { _dateFin = value; }
        }

        public Emprunteur Emprunteur
        {
            get { return _emprunteur; }
            set { _emprunteur = value; }
        }

        public Livre Livre
        {
            get { return _livre; }
            set { _livre = value; }
        }

        public String ToString()
        {
            return "Le livre "+_livre+" a ete emprunte par "+_emprunteur+" du "+_dateDebut+" au "+_dateFin+".";
        }
    }
}
