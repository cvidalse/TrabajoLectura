using System;

namespace ConsoleApp1
{
    class TestSoftware
    {
        static void Main(string[] args)
        {

            Desarrollador sujeto = new Desarrollador("Pablo", 123456789, "alguna App", "1122334455", "7.32");

            sujeto.AgreagarSoftware(987654321, "segunda App", "999999999", "5.94");

            for (int i = 0; i < sujeto.Softwares.Count; i++) {

                sujeto.Softwares[i].Mostrar();
            }

        }
    }
}
