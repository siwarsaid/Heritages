using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heritage
{
    internal class Bipedes: Animal
    {
        public Bipedes(string name) : base(name, 2)
        { }
        public override string Move()
        {
            return $" et je marche sur {_nbPattes} pattes.";
        }

    }
}
