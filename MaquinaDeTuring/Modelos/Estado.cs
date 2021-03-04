using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaquinaDeTuring
{
    public class Estado : IEquatable<Estado>
    {
        private string _id;

        public string Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public List<Transicion> Transiciones;

        public Estado()
        {
            Transiciones = new List<Transicion>();
        }

        public bool Equals(Estado other)
        {
            if (other != null)
                return Id.Equals(other.Id);
            else return false;
        }

        public override string ToString()
        {
            return Id;
        }
    }
}
