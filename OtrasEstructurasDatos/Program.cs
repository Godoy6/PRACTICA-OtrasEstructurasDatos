/* 
Crea un programa que simule una pila de acciones de un personaje. 
Este puede realizar estas acciones ESQUIVAR, SALTAR, ATACAR, y DEFENDER. 
Las acciones se pueden deshacer (eliminar de la pila) en el orden correspondiente. 
Implementa un menú en el que el usuario pueda agregar acciones a la pila o deshacer estas acciones. 
Muestra el estado de la pila después de cada acción.
*/

namespace OtrasEstructurasDatos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<string> PilaAcciones = new Stack<string>();

            Console.WriteLine("Escriba el numero de la accion correspondiente de lo que quiere hacer:");
            Console.WriteLine("1 = Agregar acción");
            Console.WriteLine("2 = Deshacer última acción");

            int RespuestaUsuario = int.Parse(Console.ReadLine());

            switch (RespuestaUsuario)
            {
                case 1:
                    AgregarAccion(PilaAcciones);
                    break;

                case 2:
                    DeshacerAccion(PilaAcciones);
                    break;

                default:
                    Console.WriteLine("<<<<<< OPCION NO VALIDA, APRENDE A LEER >>>>>>");
                    break;
            }

            MostrarPila(PilaAcciones);
        }

        static void AgregarAccion(Stack<string> PilaAgregarAccion)
        {
            Console.WriteLine("Elige una acción para agregar:");
            Console.WriteLine("1 = ESQUIVAR");
            Console.WriteLine("2 = SALTAR");
            Console.WriteLine("3 = ATACAR");
            Console.WriteLine("4 = DEFENDER");

            int accionElegida = int.Parse(Console.ReadLine());

            switch (accionElegida)
            {
                case 1:
                    PilaAgregarAccion.Push("ESQUIVAR");
                    break;
                case 2:
                    PilaAgregarAccion.Push("SALTAR");
                    break;
                case 3:
                    PilaAgregarAccion.Push("ATACAR");
                    break;
                case 4:
                    PilaAgregarAccion.Push("DEFENDER");
                    break;
                default:
                    Console.WriteLine("Opción no válida.");
                    return;
            }
            Console.WriteLine("Acción agregada.");
        }

        static void DeshacerAccion(Stack<string> PilaDeshacerAccion)
        {
            if (PilaDeshacerAccion.Count > 0)
            {
                string ultimaAccion = PilaDeshacerAccion.Pop();
                Console.WriteLine("Última acción deshecha: " + ultimaAccion);
                Console.WriteLine("");
            }
            else
            {
                Console.WriteLine("No hay acciones para deshacer.");
                Console.WriteLine("");
            }
        }

        static void MostrarPila(Stack<string> PilaMostrarPila)
        {
            if (PilaMostrarPila.Count > 0)
            {
                Console.WriteLine("Estado de la pila:");

                Stack<string> pilaTemporal = new Stack<string>(PilaMostrarPila);

                while (pilaTemporal.Count > 0)
                {
                    Console.WriteLine(pilaTemporal.Pop());
                }
            }
            else
            {
                Console.WriteLine("La pila está vacía.");
            }
        }
    }
}