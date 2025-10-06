namespace exercici19;

// Assigna una paraula a una variable de text. Utilitza una funció per a obtenir la seva longitud i 
// imprimeix la paraula i el seu nombre de caràcters.
class Program
{
    static void Main(string[] args)
    {

        Console.Write("La paraula de havui es: ");

        string paraula = Console.ReadLine();
        int longitudn = paraula.Length;

        Console.WriteLine($"la paraula es {paraula} i te {longitudn} lletre");
    }
}
