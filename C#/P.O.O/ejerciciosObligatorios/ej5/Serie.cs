﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej5
{
    internal class Serie : IEntregable
    {
        string titulo = "";
        int numTemps = 3;
        bool entregado = false;
        string genero = "";
        string creador = "";
        
        public string Titulo { get { return titulo; } set { titulo = value; } }
        public int NumTemps { get {return numTemps;} set {numTemps = value;} }
        public bool Entregado { get {return entregado;} set {entregado = value;} }
        public string Genero {  get {return genero;} set {genero = value;} }
        public string Creador { get { return creador; } set { creador = value; } }

        public Serie()
        {

        }
        public Serie(string T, string C)
        {
            Titulo = T;
            Creador = C;
        }
        public Serie(string T, int N, string G, string C)
        {
            Titulo = T;
            NumTemps = N;
            Genero = G;
            Creador = C;
        }

        public void Entregar()
        {
            Entregado = true;
        }
        public void Devolver()
        {
            Entregado = false;
        }
        public bool IsEntregado()
        {
            return Entregado;
        }
        /*public void CompareTo(Object a)
        {
            NumTemps = int.Parse(string.Format("{0}", a));
        } Help, portero lo sacó de star overflow */
        public void SetTitulo(string T)
        {
            Titulo = T;
        }
        public void SetNumTemps(int N)
        {
            NumTemps = N;
        }
        public void SetGenero(string G)
        {
            Genero = G;
        }
        public void SetCreador(string C)
        {
            Creador = C;
        }
        public string GetTitulo()
        {
            return Titulo;
        }
        public int GetNumTemps()
        {
            return NumTemps;
        }
        public string GetGenero()
        {
            return Genero;
        }
        public string GetCreador()
        {
            return Creador;
        }
    }
}