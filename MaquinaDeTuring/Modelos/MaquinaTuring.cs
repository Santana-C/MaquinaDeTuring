using System;
using System.Collections.Generic;
using System.Linq;

namespace MaquinaDeTuring.Modelos
{
    public class MaquinaTuring
    {
        private char[] _cinta;
        public char[] Cinta
        {
            get { return _cinta; }
            set {
                if (value.Length <= 10)
                {
                    char[] tempCinta1 = { 'Δ', 'Δ', 'Δ', 'Δ', 'Δ', 'Δ' };
                    char[] tempCinta2 = value.Concat(tempCinta1).ToArray();
                    _cinta = tempCinta2;
                }
                else
                    _cinta = value;
            }
        }

        private int _cabezal;
        public int Cabezal
        {
            get { return _cabezal; }
            set { _cabezal = value; }
        }

        private bool _terminacionAnormal;
        public bool TerminacionAnormal
        {
            get { return _terminacionAnormal; }
            set { 
                _terminacionAnormal = value; 
            }
        }
        public bool CalculosTerminados;

        private char[] _alfabeto;
        public char[] Alfabeto
        {
            get { return _alfabeto; }
            set { _alfabeto = value; }
        }

        private char[] _simbolos;
        public char[] Simbolos
        {
            get { return _simbolos; }
            set {
                bool tieneBlanco = false;
                foreach(char c in value)
                {
                    if (c == 'Δ')
                        tieneBlanco = true;
                }
                if (!tieneBlanco)
                    _simbolos = value.Concat("Δ").ToArray();
                else
                    _simbolos = value;
                
            }
        }

        public Estado EstadoActual;

        public Estado EstadoInicial;

        public Estado EstadoFinal;

        public List<Estado> Estados;

        public MaquinaTuring()
        {
            Estados = new List<Estado>();
            CalculosTerminados = false;
        }
        public void Escribir(char caracter)
        {
            Cinta[_cabezal] = caracter;
        }

        public char Leer()
        {
            return Cinta[_cabezal];
        }

        public void Derecha()
        {
            Cabezal++;
        }

        public void Izquierda()
        {
            if(Cabezal == 0)
                throw new Exception("Se ha producido una terminación anormal en la máquina.");
            Cabezal--;
        }
        public string AlfabetoToString()
        {
            string alfabeto = "";
            foreach (char c in Alfabeto)
                alfabeto += $"{c}, ";
            return alfabeto.Substring(0, alfabeto.Length - 2);
        }

        public string SimbolosToString()
        {
            string simbolos = "";
            foreach (char c in Simbolos)
                simbolos += $"{c}, ";
            return simbolos.Substring(0, simbolos.Length - 2);
        }
        public void AgregarSimbolo(char simbolo)
        {
            Simbolos = Simbolos.Concat(simbolo.ToString()).ToArray();
        }

        public List<Transicion> ObtenerTransiciones()
        {
            List<Transicion> transiciones = new List<Transicion>();
            foreach (Estado estado in Estados)
            {
                foreach (Transicion transicion in estado.Transiciones)
                {
                    transiciones.Add(transicion);
                }
            }
            return transiciones;
        }
        public List<Transicion> ObtenerTransiciones(string id_estado)
        {
            foreach (Estado estado in Estados)
            {
                if (estado.Id == id_estado)
                    return estado.Transiciones;
            }
            return new List<Transicion>();
        }
        public List<string> ObtenerAristas()
        {
            List<string> aristas = new List<string>();
            foreach(Estado estado in Estados)
            {
                foreach (Transicion transicion in estado.Transiciones)
                {
                    aristas.Add(transicion.ToStringDOT());
                }
            }
            return aristas;
        }
        public Estado ObtenerEstado(string id)
        {
            foreach(Estado estado in Estados)
            {
                if (estado.Id == id)
                    return estado;
            }
            throw new Exception("No se encontró el estado que se buscaba");
        }

        public void EliminarEstado(string id)
        {
            try
            {
                Estado estadoAEliminar = new Estado();
                estadoAEliminar.Id = id;
                this.Estados.Remove(estadoAEliminar);
            }
            catch (Exception)
            {
                throw new Exception("No se encontró el estado que se buscaba");
            }
        }
        public Transicion ObtenerTransicion(Transicion transicion)
        {
            foreach(Estado estado in Estados)
            {
                foreach (Transicion tempTransicion in estado.Transiciones)
                    if (tempTransicion.Equals(transicion))
                        return tempTransicion;
            }
            throw new Exception("No se encontró la transición que busca");
        }

        public Estado SiguientePaso()
        {
            foreach(Estado estado in Estados)
            {
                if(estado.Equals(EstadoActual))
                {
                    foreach(Transicion transicion in EstadoActual.Transiciones)
                    {
                        if(Cinta[Cabezal] == transicion.Lectura)
                        {
                            Cinta[Cabezal] = transicion.Escritura;
                            if (transicion.Direccion == -1)
                                this.Izquierda();
                            if (transicion.Direccion == 1)
                                this.Derecha();
                            if (EstadoActual.Equals(EstadoFinal))
                            {
                                CalculosTerminados = true;
                                return EstadoFinal;
                            }
                            return transicion.Destino;
                        }
                    }
                }
            }
            if (EstadoActual.Equals(EstadoFinal))
            {
                CalculosTerminados = true;
                return EstadoFinal;
            }
            else
                throw new Exception("Se detectó problema de parada.");
        }
    }
}
