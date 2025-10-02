namespace exercici14;

// Declara una paraula i fes que el programa imprimeixi només la primera lletra, l'última lletra i la lletra del mig 
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Paraula a escollir");
        string paraula = Console.ReadLine();

        char primera = paraula[0];
        char ultima = paraula[paraula.Length - 1];
        int indexMig = paraula.Length / 2;
        char mig = paraula[indexMig];

        Console.WriteLine($"Primera lletra: {primera}");
        Console.WriteLine($"Ultima lletra: {ultima}");
        Console.WriteLine($"Lletra del mig: {mig}");
    }
}
