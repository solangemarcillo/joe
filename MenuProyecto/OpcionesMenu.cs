using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuProyecto
{
    public class OpcionesMenu
    {
        public void LisOpciones()
        {
            Console.Clear();

            int opcion;

            do{
                Console.WriteLine("MENU DE OPCIONES" +
                    "\n [1] Perfil" +
                    "\n [2] Amigos" +
                    "\n [3] Buscar Amigos" +
                    "\n [4] Solicitud" +
                    "\n [0] Salir");
                Console.Write("\nIngrese opcion: ");
				opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Perfil perfil = new Perfil();
                        perfil.llamar();
                        break;
                    case 2:
						Amistad amistad = new Amistad();
						amistad.llamaramigo();
						break;
                    case 3:
						BusquedaDeAmigos busquedaDeAmigos = new BusquedaDeAmigos();
						busquedaDeAmigos.Buscar();
                        break;
                    case 4:
                        break;
                    case 0:
                        Console.WriteLine("\nSesión cerrada exitosamente");
                        break;

                    default:
                        Console.WriteLine("Caracter incorrecto, intentalo de nuevo");
                        break;
                        
                }
            } while (opcion !=0);
        }
    }
}
