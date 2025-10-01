namespace exercici9;

/* Demana un valor en metres. Converteix el valor a peus (1 metre = 3,28084 metres) 
i imprimeix el resultat. */

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Dime cuantors metros quieres? ");
        string metre_car = Console.ReadLine();
        int metres = Convert.ToInt16(metre_car);

        double peus = (double)metres * 3.28084;
        Console.WriteLine($"LLavors sera uns {peus} en peus");
    }
}
