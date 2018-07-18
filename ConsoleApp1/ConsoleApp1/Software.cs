using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1{

    public class Software : Producto, INterface1{

        protected string licencia;
        protected string version;

        public Software(int numeroCodigo, string nombreProducto, string numeroLicencia, string numeroVersion) : base(numeroCodigo, nombreProducto){

            this.licencia = numeroLicencia;

            this.version = numeroVersion;
        }


        //implementacion de los getters y setters faltantes
        public string Licencia{

            get { return licencia; }

            set { licencia = value; }
        }

        public string Version{

            get { return version; }

            set { version = value; }
        }

        public void Mostrar() {

            Console.WriteLine("Codigo del producto: " + this.codigo);
            Console.WriteLine("Nombre del Producto: " + this.nombre);
            Console.WriteLine("Licencia del Software: " +  this.licencia);
            Console.WriteLine("Version del Software: " + this.version);
            Console.WriteLine("  ");

        }
    }
}
