using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    class Partido
    {
        int id;
        Seleccion seleccion1;
        Seleccion seleccion2;
        DateTime fechaHora;
        bool finalizado;
        List<Incidencia> incidencias;
        string resultado;

        public void ValidarSelecciones(Seleccion seleccion1, Seleccion seleccion2)
        {

        }

        public void ValidarFecha(DateTime fechaHora)
        {

        }

        public virtual string ResultadoPartido(bool finalizado, string resultado) 

        }


    }
}
