using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Desarrollador
    {

        protected string nombre;

        public List<Software> Softwares = new List<Software>();

        public Desarrollador(string nombreDes, int numeroCodigo, string nombreProducto, string numeroLicencia, string numeroVersion)
        {

            this.nombre = nombreDes;

            Softwares.Add(new Software( numeroCodigo, nombreProducto, numeroLicencia,numeroVersion));

        }

        public void AgreagarSoftware(int numeroCodigo, string nombreProducto, string numeroLicencia, string numeroVersion) {

            Softwares.Add(new Software(numeroCodigo, nombreProducto, numeroLicencia, numeroVersion));
        }
    }
}
