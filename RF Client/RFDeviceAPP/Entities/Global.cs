using System;

using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace RFDeviceAPP.Entities
{
    public static class Global
    {
        private static Hashtable _parameters;
        public static Hashtable Parameters {
            get {
                if (_parameters == null)
                    _parameters = new Hashtable();
                return _parameters;
            }
            set {
                _parameters = value;
            }
        
        }
    }
}
