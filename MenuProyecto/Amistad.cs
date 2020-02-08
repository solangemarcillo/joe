using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuProyecto
{
    public class Amistad
    {
		public int id { get; set; }
		public string nombre { get; set; }

        public Amistad()
        {
            List<Amistad> amistads = new List<Amistad>();		

		}

		public void llamaramigo()
		{
			Console.WriteLine("Amigos\n");
			List<Amistad> amistads = new List<Amistad>
			{
				
				new Amistad{id=1, nombre=" Nicole Anahi Mora Lopez"},
				new Amistad{id=2, nombre=" Neymar Abel Sornoza Marcillo"},
				new Amistad{id=3, nombre=" Gina Rosabel Mero Marcillo"},
				new Amistad{id=4, nombre=" Jonathan Elias Merchan Moreira"},
			};

			Console.WriteLine("ID\t\tNombre");
			foreach (var resultado in amistads)
			{
				Console.WriteLine(resultado.id + "\t" + resultado.nombre);
			}
			Console.Read();

		}
       
    }
}
