namespace exercici7;

/* Defineix tres variables amb tres notes numèriques. 
Calcula la mitjana i mostra el resultat per pantalla. */ 

class Program
{
    static void Main()
    {
        Console.WriteLine("Diges 3 numeros per fer mitjana");

        Console.Write("Numero 1: ");
        string numer_1 = Console.ReadLine();
        double numer1 = Convert.ToInt16(numer_1);

        Console.Write("Numero 2: ");
        string numer_2 = Console.ReadLine();
        double numer2 = Convert.ToInt16(numer_2);

        Console.Write("Numero 3: ");
        string numer_3 = Console.ReadLine();
        double numer3 = Convert.ToInt16(numer_3);

        double total = numer1 + numer2 + numer3;

        double mitjana = total/3;

        Console.WriteLine($"La suma de {numer1},{numer2},{numer3} es {total} i la seva mitjana es {mitjana:F2}");
    }
}