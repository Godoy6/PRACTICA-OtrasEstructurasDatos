/*
Crea un programa que reciba un listado de números separados por un espacio.
Debe almacenar esos elementos en una cola. 
Crea un método que revierta el orden de los elementos de una cola y muestra la queue por pantalla
*/

namespace OtrasEstructurasDatos3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*

            // Crear la cola para almacenar los números
            Queue<int> numeros = new Queue<int>();

            // Leer la cantidad de números que se van a ingresar
            Console.WriteLine("¿Cuántos números quieres ingresar?");
            int cantidad = int.Parse(Console.ReadLine());

            // Leer los números uno por uno
            Console.WriteLine($"Introduce {cantidad} números:");

            for (int i = 0; i < cantidad; i++)
            {
                string input = Console.ReadLine();  // Leemos la entrada del usuario

                // Intentamos convertir la entrada a un número
                if (int.TryParse(input, out int num))
                {
                    numeros.Enqueue(num);  // Añadimos el número a la cola
                }
                else
                {
                    Console.WriteLine("Por favor, ingresa un número válido.");
                    i--;  // Si la entrada no es válida, repetimos el ciclo para el mismo número
                }
            }

            // Invertir la cola
            InvertirCola(numeros);

            // Mostrar la cola invertida
            Console.WriteLine("\nCola invertida:");
            MostrarCola(numeros);
        }

        // Método para invertir la cola
        static void InvertirCola(Queue<int> cola)
        {
            // Crear una lista temporal para almacenar los números en orden invertido
            List<int> listaInvertida = new List<int>();

            // Pasar todos los elementos de la cola a la lista (invertir el orden)
            while (cola.Count > 0)
            {
                listaInvertida.Add(cola.Dequeue());  // Sacamos de la cola y añadimos a la lista
            }

            // Reinsertar los elementos en la cola en orden invertido
            for (int i = listaInvertida.Count - 1; i >= 0; i--)
            {
                cola.Enqueue(listaInvertida[i]);  // Volver a añadir los elementos en orden invertido
            }
        }

        // Método para mostrar los elementos de la cola
        static void MostrarCola(Queue<int> cola)
        {
            // Mostrar los elementos de la cola
            while (cola.Count > 0)
            {
                Console.Write(cola.Dequeue() + " ");  // Mostrar y eliminar el primer elemento
            }
            Console.WriteLine();

            */
        }
    }
}