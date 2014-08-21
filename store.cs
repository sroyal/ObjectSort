using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectSort 
{
    class Store : IComparable
    {
        public int CompareTo(object obj)
        {
            if (obj is Store)
            {
                return this.poNumber.CompareTo((obj as Store).poNumber);  // compare numbers
            }
            throw new ArgumentException("Object is not a User");
        }
        int _storeNumber; 
        int _pONumber;

        public int storeNumber
        {
            get
            {
                return _storeNumber;
            }
            set
            {
                _storeNumber = value;
            }
        }

        public int poNumber
        {
            get
            {
                return _pONumber;
            }
            set
            {
                _pONumber = value;
            }
        }


        
    }
}
