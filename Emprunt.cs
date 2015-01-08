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

        public Emprunt(int inID, String inDd, String inDf, Emprunteur inEmprunteur, Livre inL)
        {
            _ID = inID;
            _dateDebut = inDd;
            _dateFin = inDf;
            _emprunteur = inEmprunteur;
            _livre = inL;
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

        public new String ToString()
        {
            return base.ToString()+", Le livre {"+_livre.ToString()+"} a ete emprunte par {"+_emprunteur.ToString()+"} du "+_dateDebut+" au "+_dateFin+".";
        }
    }
}
