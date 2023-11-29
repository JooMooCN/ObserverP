using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverP
{
    public class Academy : Subject
    {
        public string Name { get; }
        private string _message = string.Empty;
        public string Message { get { return _message; } set { _message = value; Notify(); } }

        public Academy(string name)
        {
            this.Name = name;
        }


    }
}
