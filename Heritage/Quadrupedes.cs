using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heritage
{
    internal class Quadrupedes :Animal
    {
        public Quadrupedes(string name) : base(name,4)
        { }
        public override string Move()
        {
            return $" et je marche sur {_nbPattes} pattes.";
        }

    }
}
