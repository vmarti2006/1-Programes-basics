namespace exercici5;

/* Feu un programa que demani un nom i l’any de naixement i imprimeixi per pantalla 
“Hola [nom]!  Ja tens [edat] anys? 
nom i edat seran el nom introduït i l'edat la resta de l’any actual i l’any de naixement. */

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Di tu nombre: ");
        string nom = Console.ReadLine();

        Console.Write("En que año naciste: ");
        string nace = Console.ReadLine();

        if (int.TryParse(nace, out int anyNaixement))
         {
            int anyActual = DateTime.Now.Year;
            int edat = anyActual - anyNaixement;

            Console.WriteLine($"Hola {nom}! Ja tens {edat} anys?");
        }
        else
        {
            Console.WriteLine("L'any de naixement no és vàlid.");
        }
    }
}
