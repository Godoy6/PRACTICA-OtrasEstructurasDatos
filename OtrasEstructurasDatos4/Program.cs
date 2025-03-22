/*
Escribe un programa que guarde en una variable el diccionario {'Euro':'€', 'Dollar':'$', 'Yen':'¥'}. 
El usuario debe introducir el nombre de una divisa por el editor y, en el Start, el programa mostrará su símbolo o un mensaje de aviso si la divisa no está en el diccionario
*/

namespace OtrasEstructurasDatos4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Crear un diccionario con las divisas y sus símbolos
            Dictionary<string, string> divisas = new Dictionary<string, string>
            {
                { "Euro", "€" },
                { "Dollar", "$" },
                { "Yen", "¥" }
            };

            // Solicitar al usuario que ingrese el nombre de una divisa
            Console.WriteLine("Introduce el nombre de una divisa (Euro, Dollar, Yen):");
            string divisa = Console.ReadLine();

            // Comprobar si la divisa existe en el diccionario
            if (divisas.ContainsKey(divisa))
            {
                // Mostrar el símbolo de la divisa
                Console.WriteLine($"El símbolo de {divisa} es: {divisas[divisa]}");
            }
            else
            {
                // Mostrar un mensaje si la divisa no se encuentra en el diccionario
                Console.WriteLine("La divisa ingresada no está en el diccionario.");
            }
        }
    }
}