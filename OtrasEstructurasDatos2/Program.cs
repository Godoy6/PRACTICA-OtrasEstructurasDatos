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
            List<string> tareas = new List<string>();

            tareas.Add("LEVANTARSE");
            tareas.Add("DUCHARSE");
            tareas.Add("DESAYUNAR");
            tareas.Add("JUGAR");
            tareas.Add("DORMIR");

            Console.WriteLine("Estado inicial de las tareas:");
            MostrarTareas(tareas);

            while (true)
            {
                Console.WriteLine("----------------------------------------");
                Console.WriteLine("Escriba el numero de la acción correspondiente de lo que quiere hacer:");
                Console.WriteLine("1 = Añadir una tarea");
                Console.WriteLine("2 = Eliminar una tarea");
                Console.WriteLine("3 = Intercambiar dos tareas de orden");
                Console.WriteLine("4 = Cumplir una tarea de su lista de forma aleatoria");
                Console.WriteLine("5 = Salir");

                int respuestaUsuario = int.Parse(Console.ReadLine());

                switch (respuestaUsuario)
                {
                    case 1:
                        AñadirTarea(tareas);
                        break;

                    case 2:
                        EliminarTarea(tareas);
                        break;

                    case 3:
                        IntercambiarTareas(tareas);
                        break;

                    case 4:
                        CumplirTarea(tareas);
                        break;

                    case 5:
                        return;

                    default:
                        Console.WriteLine("<<<<<< OPCIÓN NO VÁLIDA, APRENDE A LEER >>>>>>");
                        break;
                }
            }
        }

        static void AñadirTarea(List<string> tareas)
        {
            Console.WriteLine("Escriba la tarea que quiere agregar:");
            string tareaUsuario = Console.ReadLine();
            tareas.Add(tareaUsuario);

            Console.WriteLine("----------------------------------------");
            MostrarTareas(tareas);
        }

        static void EliminarTarea(List<string> tareas)
        {
            Console.WriteLine("Escribe el numero de la tarea que quiere eliminar");

            // Recorre la lista de tareas y muestra el índice y el nombre de cada tarea
            for (int i = 0; i < tareas.Count; i++) // Este es un bucle for que se ejecuta desde i = 0 hasta i < tareas.Count.
                                                   // El valor i es el índice de cada tarea en la lista.
                                                   // La condición i < tareas.Count garantiza que el bucle se detenga una vez que haya recorrido todos los elementos de la lista.
            {
                Console.WriteLine(i + " = " + tareas[i]); // Aquí i es el índice de la tarea, y tareas[i] es la tarea en esa posición de la lista.
            }

            int posicionTarea = int.Parse(Console.ReadLine());

            // Verifica si el índice es válido y elimina la tarea en esa posición, si no, muestra un mensaje de error
            if (posicionTarea >= 0 && posicionTarea < tareas.Count) // posicionTarea >= 0: El índice no puede ser negativo.
                                                                    // posicionTarea < tareas.Count: El índice no puede ser mayor o igual al número total de tareas en la lista.
            {
                tareas.RemoveAt(posicionTarea);
                Console.WriteLine("Tarea eliminada");
            }
            else
            {
                Console.WriteLine("Índice no válido.");
            }

            Console.WriteLine("----------------------------------------");
            MostrarTareas(tareas);
        }

        static void IntercambiarTareas(List<string> tareas)
        {
            Console.WriteLine("Que dos tareas quieres intercambiar");

            // Recorre la lista de tareas y muestra el índice y el nombre de cada tarea
            for (int i = 0; i < tareas.Count; i++) // Este es un bucle for que se ejecuta desde i = 0 hasta i < tareas.Count.
                                                   // El valor i es el índice de cada tarea en la lista.
                                                   // La condición i < tareas.Count garantiza que el bucle se detenga una vez que haya recorrido todos los elementos de la lista.
            {
                Console.WriteLine(i + " = " + tareas[i]); // Aquí i es el índice de la tarea, y tareas[i] es la tarea en esa posición de la lista.
            }

            Console.WriteLine("Escribe la posicion de la primera tarea a intercambiar:");
            int posicionTarea1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Escribe la posicion de la segunda tarea a intercambiar:");
            int posicionTarea2 = int.Parse(Console.ReadLine());

            if (posicionTarea1 >= 0 && posicionTarea1 < tareas.Count && posicionTarea2 >= 0 && posicionTarea2 < tareas.Count)
            {
                string temp = tareas[posicionTarea1]; // Guardamos en una variable temporal el valor de la tarea que está en la posición posicionTarea1
                tareas[posicionTarea1] = tareas[posicionTarea2];
                tareas[posicionTarea2] = temp;
                Console.WriteLine("Tareas intercambiadas con exito");
            }
            else
            {
                Console.WriteLine("Posiciones invalidas (como tu jiji)");
            }

            Console.WriteLine("----------------------------------------");
            MostrarTareas(tareas);
        }

        static void CumplirTarea(List<string> tareas)
        {
            Random random = new Random();
            if (tareas.Count > 0)
            {
                int tareaAleatoria = random.Next(tareas.Count);
                Console.WriteLine("¡Tarea cumplida! La tarea cumplida HA SIDO: " + tareas[tareaAleatoria]);
                tareas.RemoveAt(tareaAleatoria); 
            }
            else
            {
                Console.WriteLine("No hay mas tareas disponibles");
            }

            Console.WriteLine("----------------------------------------");
            MostrarTareas(tareas);
        }

        static void MostrarTareas(List<string> tareas)
        {
            if (tareas.Count > 0)
            {
                for (int i = 0; i < tareas.Count; i++)
                {
                    Console.WriteLine(i + " = " + tareas[i]);
                }
            }
            else
            {
                Console.WriteLine("No hay mas tareas en la lista");
            }
        }
    }
}