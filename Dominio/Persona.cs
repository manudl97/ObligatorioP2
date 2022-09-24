using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    public abstract class Persona
    {
        int id;
        string nombre;
        string apellido;

        public virtual void ValidarDatos()
        { 
        }

    }
}
