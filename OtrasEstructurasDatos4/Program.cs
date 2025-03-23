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
            Dictionary<string, string> diccionario = new Dictionary<string, string>
            {
                { "Euro", "€" },
                { "Dollar", "$" },
                { "Yen", "¥" }
            };

            Console.WriteLine("Introduce el nombre de una divisa:");
            Console.WriteLine("Euro");
            Console.WriteLine("Dollar");
            Console.WriteLine("Yen");
            string divisa = Console.ReadLine();

            if (diccionario.ContainsKey(divisa))
            {
                Console.WriteLine("El símbolo de " + divisa + " es: " + diccionario[divisa]);
            }
            else
            {
                Console.WriteLine("La divisa ingresada no esta en el diccionario.");
            }
        }
    }
}