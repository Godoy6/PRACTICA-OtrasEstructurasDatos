/*
Crea un programa que simule el comportamiento de un NPC.
Tendrá una lista de tareas que debe cumplir. 
Implementa un menú en el que se pueda añadir una tarea al NPC (nombre de la tarea), eliminar una tarea según su índice de posición, intercambiar dos tareas de orden y 
cumplir una tarea de su lista (de forma aleatoria). 
Muestra el estado de la lista tras cada acción.
*/

namespace OtrasEstructurasDatos2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> cola = new Queue<string>();

            cola.Enqueue("LEVANTARSE");
            cola.Enqueue("DUCHARSE");
            cola.Enqueue("DESAYUNAR");
            cola.Enqueue("JUGAR");
            cola.Enqueue("DORMIR");

            Console.WriteLine("Estado de la cola:");
            Console.WriteLine("LEVANTARSE");
            Console.WriteLine("DUCHARSE");
            Console.WriteLine("DESAYUNAR");
            Console.WriteLine("JUGAR");
            Console.WriteLine("DORMIR");

            Console.WriteLine("--------");

            Console.WriteLine("Escriba el numero de la accion correspondiente de lo que quiere hacer:");
            Console.WriteLine("1 = Añadir una tarea");
            Console.WriteLine("2 = Eliminar una tarea");
            Console.WriteLine("3 = Intercambiar dos tareas de orden");
            Console.WriteLine("4 = Cumplir una tarea de su lista de forma aleatoria");

            int RespuestaUsuario = int.Parse(Console.ReadLine());

            switch (RespuestaUsuario)
            {
                case 1:
                    AñadirCola(cola);
                    break;

                case 2:
                    EliminarCola(cola);
                    break;

                case 3:
                    IntercambiarCola(cola);
                    break;

                case 4:
                    break;

                default:
                    Console.WriteLine("<<<<<< OPCION NO VALIDA, APRENDE A LEER >>>>>>");
                    break;
            }

            static void AñadirCola(Queue<string> colaAñadir)
            {
                Console.WriteLine("Escriba la acción que quiere agregar:");

                string RespuestaUsuario = Console.ReadLine(); // Leemos la entrada del usuario

                colaAñadir.Enqueue(RespuestaUsuario); // Añadimos el elemento a la cola

                Console.WriteLine("--------");
                MostrarCola(colaAñadir);
                Console.WriteLine("--------");
            }

            static void EliminarCola(Queue<string> colaAñadir)
            {

            }

            static void IntercambiarCola(Queue<string> colaIntercambiar)
            {

            }

            static void MostrarCola(Queue<string> colaMostrar)
            {
                if (colaMostrar.Count > 0) // "Count" es una propiedad que devuelve el número de elementos que contiene en ese momento
                {
                    Console.WriteLine("Estado de la cola:");

                    Queue<string> colaTemporal = new Queue<string>(colaMostrar); // Copiar la cola para no modificar la original

                    while (colaTemporal.Count > 0) // Mostrar los elementos en orden (FIFO)
                    {
                        Console.WriteLine(colaTemporal.Dequeue());
                    }
                }
                else
                {
                    Console.WriteLine("La cola está vacía.");
                }
            }
        }
    }
}