using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverP
{
    public class ConcreteSubject : Subject 
    {
        private int _state = 0;
        public int State { get { return _state; } set { _state = value; Notify(); } }
    }
}
