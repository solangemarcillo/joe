using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuProyecto
{
    class Perfil
    {
		public string Nombre { get; set; }
		public string Apellido { get; set; }
		public string Ciudad { get; set; }
		public string Edad { get; set; }
		public string Sexo { get; set; }
		public int Telefono { get; set; }

		public  Perfil()
        {
            ListCaracteristicas = new List<Caracteristica>();
            ListAmistads = new List<Amistad>();
            ListSolicitudes = new List<Solicitud>();
          
        }

        public void llamar()
        {
            Console.WriteLine("DATOS USUARIO\n");

			Console.WriteLine("Nombres");
			Console.WriteLine(Nombre = "Rodrigo Andree\n");
			Console.WriteLine("Apellidos");
			Console.WriteLine(Apellido = "Velez Carbo\n");
			Console.WriteLine("Ciudad");
			Console.WriteLine(Ciudad = "Manta\n");
			Console.WriteLine("Edad");
			Console.WriteLine(Edad = "21\n");
			Console.WriteLine("Sexo");
			Console.WriteLine(Sexo = "Masculino\n");

		}
       

        public List<Caracteristica> ListCaracteristicas { get; set; }
        public List<Solicitud> ListSolicitudes { get; set; }
        public List<Amistad> ListAmistads { get; set; }
    }
}
