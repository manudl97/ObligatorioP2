using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    public class Jugador
    {
        int id; // agregarlo al UML
        string nroCamiseta;
        string nombreCompleto;
        DateTime fechaNacimiento;
        double altura; // cambie el tipo de int a double de acuerdo a la precarga
        string pieHabil;
        int valorMercado; // lo cambie a int porque en la precarga esta de esta forma
        string moneda; // en la precarga pone EUR, entiendo que es la moneda aunque no esta en la letra :c
        Pais pais;
        string posicion;
        static int montoReferencia; 
      // hola dominio

        public string NroCamiseta
        {
            get { return nroCamiseta; }
            set { nroCamiseta = value; }
        }

        public DateTime FechaNacimiento
        {
            get { return fechaNacimiento; }
            set { fechaNacimiento = value; }
        }

        public double Altura
        {
            get { return altura; }
            set { altura = value; }
        }

        public string PieHabil
        {
            get { return pieHabil; }
            set { pieHabil = value; }
        }

        public int ValorMercado
        {
            get { return valorMercado; }
            set { valorMercado = value; }

        }

        public string Posicion
        {
            get { return posicion; }
            set { posicion = value; }
        }

        public int MontoReferencia
        {
            get { return montoReferencia; }
            set { montoReferencia = value; }

        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string NombreCompleto
        {
            get { return nombreCompleto; }
            set { nombreCompleto = value; }
        }

    

        public string Moneda
        {
            get { return moneda; }
            set { moneda = value; }
        }



        public Jugador(int id, string nroCamiseta, string nombreCompleto, DateTime fechaNacimiento, double altura, string pieHabil, int valorMercado, string moneda, Pais pais, string posicion)
        {
            this.id = Id;
            this.nroCamiseta = NroCamiseta;
            this.nombreCompleto = NombreCompleto;
            this.fechaNacimiento = FechaNacimiento;
            this.altura = Altura;
            this.pieHabil = PieHabil;
            this.valorMercado = ValorMercado; 
            this.pais = pais;
            this.posicion = Posicion;
            
         




        }




        public void validarDatos() // este metodo tiene un override (no se como mostrar eso je)
        { 

        }

        //public void ValorMercado(double valorMercado) // quizas podriamos cambiar el nombre del metodo a EsVip para diferenciar del atributo valorMercado
        //{

        //}

        //public void CategoriaFinanciera(double valorMercado, int montoReferencia)
        //{

        //}



    }
}
