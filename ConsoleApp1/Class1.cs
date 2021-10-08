using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Class1 : Interface1
    {
        private Interface1 _Interface1;
        public Class1(Interface1 _interface1)
        {
          this._Interface1 = _interface1;
        }
        public void send(string a)
        {
          _Interface1.send(a);
        }
    }
}
