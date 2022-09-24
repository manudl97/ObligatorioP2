using System;

namespace Dominio
{
    public class Pais
    {

        //int id;
        string nombre;
        string codigoAlpha;

        //public int Id
        //{
        //    get { return id; }
        //    set { id = value; }
        //}

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string CodigoAlpha
        {
            get { return codigoAlpha; }
            set { codigoAlpha = value; }
        }

        public Pais ( string nombre, string codigoAlpha)
        {
            this.nombre = Nombre;
            this.codigoAlpha = CodigoAlpha;
        }


        public void ValidarNombre(string nombre)
        {

        }

        public void ValidarCodigo(string codigoAlpha)
        {

        }


    }
}
