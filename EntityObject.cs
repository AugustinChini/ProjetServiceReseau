using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLayer
{
    public abstract class EntityObject
    {
        protected int _ID;

        public EntityObject()
        {
            _ID = 0;
        }

        public EntityObject(int ID)
        {
            _ID = ID;
        }

        public int ID
        {
            get { return _ID; }
            set { _ID = value; }
        }

        public bool Equals(EntityObject obj1)
        {
            return (obj1._ID == this._ID);
        }

        public String ToString()
        {
            return "ID : " + _ID;
        }
    }
}
