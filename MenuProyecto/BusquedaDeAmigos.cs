using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuProyecto
{
    class BusquedaDeAmigos
    {
		public BusquedaDeAmigos()
		{
			List<BusquedaDeAmigos> busquedaDeAmigos = new List<BusquedaDeAmigos>();
		}
        public string Busqueda { get; set; }
		public int Id { get; set; }
		public String Nombre { get; set; }
		string opcion;

		public void Buscar()
		{
			Console.WriteLine("\n 1 Lista de amigos \n 2 Salir");
			Console.WriteLine("Ingrese la opcion");
			int opc = int.Parse(Console.ReadLine());

			if (opc == 1 )
			{
				List<BusquedaDeAmigos> busquedaDeAmigos = new List<BusquedaDeAmigos>
				{
				new BusquedaDeAmigos{Id=1, Nombre=" Nicole Anahi Mora Lopez"},
				new BusquedaDeAmigos{Id=2, Nombre=" Neymar Abel Sornoza Marcillo"},
				new BusquedaDeAmigos{Id=3, Nombre=" Gina Rosabel Mero Marcillo"},
				new BusquedaDeAmigos{Id=4, Nombre=" Jonathan Elias Merchan Moreira"},
				};
				Console.WriteLine("ID\t\tNombre");
				foreach (var busqueda in busquedaDeAmigos)
				{
					
					Console.WriteLine(busqueda.Id + "\t" + busqueda.Nombre);
					
				}
				Console.WriteLine("\n Elija a la persona que desee agregar\n elija el ID: ");
				
				opc = int.Parse(Console.ReadLine());
			}
			else
			{
				OpcionesMenu opcionesMenu = new OpcionesMenu();
				opcionesMenu.LisOpciones();
			}
			Console.Read();
		}
	}
}
