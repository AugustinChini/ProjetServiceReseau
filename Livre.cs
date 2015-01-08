using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLayer
{
    public class Livre : EntityObject
    {
        private Auteur _auteur;
        private String _dateParution;
        private String _editeur;
        private Genre _genre;
        private int _ISBN;
        private int _nombrePages;
        private int _note;
        private String _titre;

        public Livre()
        {
            _auteur = null;
            _dateParution = "00/00/0000";
            _editeur = "Inconnu";
            _genre = null;
            _ISBN = 0;
            _nombrePages = 0;
            _note = 0;
            _titre = "Inconnu";
        }

        public Livre(Auteur a, String d, String e, Genre g, int i, int nb, int note, String t)
        {
            _auteur = a;
            _dateParution = d;
            _editeur = e;
            _genre = g;
            _ISBN = i;
            _nombrePages = nb;
            _note = note;
            _titre = t;
        }

        public Auteur Auteur
        {
            get { return _auteur; }
            set { _auteur = value; }
        }

        public String DateParution
        {
            get { return _dateParution; }
            set { _dateParution = value; }
        }

        public String Editeur
        {
          get { return _editeur; }
          set { _editeur = value; }
        }

        public Genre Genre
        {
            get { return _genre; }
            set { _genre = value; }
        }

        public int ISBN
        {
            get { return _ISBN; }
            set { _ISBN = value; }
        }

        public int NombrePages
        {
            get { return _nombrePages; }
            set { _nombrePages = value; }
        }
 
        public int Note
        {
            get { return _note; }
            set { _note = value; }
        }

        public String Titre
        {
            get { return _titre; }
            set { _titre = value; }
        }
    }
}
