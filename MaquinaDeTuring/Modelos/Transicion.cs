using MaquinaDeTuring.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaquinaDeTuring 
{
    public class Transicion : IEquatable<Transicion>
    {
        public Estado Origen;

        public Estado Destino;

        public char Lectura;

        public char Escritura;

        public sbyte Direccion;

        public bool Equals(Transicion other)
        {
            return this.Origen.Equals(other.Origen) &&
                this.Destino.Equals(other.Destino) &&
                this.Lectura == other.Lectura;
        }

        public override string ToString()
        {
            char direcc;
            switch (Direccion)
            {
                case -1:
                    direcc = 'I';
                    break;
                case 0:
                    direcc = 'N';
                    break;
                case 1:
                    direcc = 'D';
                    break;
                default: throw new Exception("Se asignó una dirección de movimiento inválida");
            }
            return $"({this.Origen},{this.Lectura}) -> ({this.Destino},{this.Escritura},{direcc})";
        }

        public string ToStringDOT()
        {
            char direcc;
            switch (Direccion)
            {
                case -1: direcc = 'I';
                    break;
                case 0: direcc = 'N';
                    break;
                case 1: direcc = 'D';
                    break;
                default: throw new Exception("Se asignó una dirección de movimiento inválida");
            }
            return $"{this.Origen} -> {this.Destino} [label = \"{this.Lectura}/{this.Escritura},{direcc}\"]";
        }

    }
}
