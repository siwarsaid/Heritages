using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heritage
{
    internal abstract class Animal
    {
        protected string _name;
        protected int _nbPattes;
        public Animal(string name, int nbPattes)
        {
            _name = name;
            _nbPattes = nbPattes;
        }

        public  string Eat()
        {
            return $"Je suis un {GetName()}, je mange";
        }

        public string GetName()
        {
            return _name;
        }
        public virtual string  Move()
        {
            return "et je marche sur " + _nbPattes;
        }
    }
}

