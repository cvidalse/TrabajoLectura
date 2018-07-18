using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1{

    public abstract class Producto{

        protected int codigo;

        protected string nombre;

        public Producto(int numeroCodigo, string nombreProducto){

            this.codigo = numeroCodigo;

            this.nombre = nombreProducto;

        }


        //implementacion de los getters y setters
        public string Nombre {

            get { return nombre; }
            set { nombre = value; }
        }

        public int Codigo{

            get { return codigo; }
            set { codigo = value; }
        }
    }
}
