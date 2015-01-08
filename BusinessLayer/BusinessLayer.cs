using EntitiesLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    abstract class BusinessLayer : EntityObject
    {
        private int _id;

        public BusinessLayer(int inID)
        {
            _id = inID;
        }

        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }
    }
}
