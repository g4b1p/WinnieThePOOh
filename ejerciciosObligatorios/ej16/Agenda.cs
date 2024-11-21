using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej16
{
    internal class Agenda
    {
        int numContactos = 10;
        List<Contacto> contactos;
        List<Contacto> Contactos { get { return contactos; } set { contactos = value; } }
        int NumContactos { get { return numContactos; } set { numContactos = value; } }
        public Agenda(List<Contacto> c, int n)
        {
            this.contactos = c;
            this.numContactos = n;
        }
        Agenda(List<Contacto> c)
        {
            this.contactos = c;
        }

        public bool AgendaLlena()
        {
            if (contactos.Count == numContactos)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool ExisteContacto(Contacto c) 
        {
            foreach (Contacto contacto in contactos)
            {
                if (c.Nombre == contacto.Nombre)
                {
                    return true;
                }
            }
                return false;
        }
        public void AñadirContacto(Contacto c)
        {
            if (AgendaLlena() == false)
            {
                if (!ExisteContacto(c))
                {
                    contactos.Add(c);
                }
            }
            else 
            {
                Console.WriteLine("La agenda está llena.");
            }
        }
        public void ListarContactos()
        {
            for (int i = 0; i < contactos.Count; i++)
            {
                Console.WriteLine("--------------------");
                Console.WriteLine($"{i} - Nombre: {contactos[i].Nombre} | Teléfono: {contactos[i].Telefono}");
                Console.WriteLine("--------------------");
            }
        }
        public void BuscarContacto(string Nombre)
        {
                Console.WriteLine($"Telefono: {contactos.Find(contacto => contacto.Nombre == Nombre).Telefono}");
        }
        public void EliminarContacto(string nombre)
        {
            foreach (Contacto c in contactos)
                { 
                    if (c.Nombre == nombre)
                    contactos.Remove(c);
                }
        }
        public int EspacioAgenda()
        {
            return numContactos - contactos.Count;
        }
        public int TamañoAgenda()
        {
            return NumContactos;
        }
        public int ContactosOcupados()
        {
            return contactos.Count;
        }
    }
}
