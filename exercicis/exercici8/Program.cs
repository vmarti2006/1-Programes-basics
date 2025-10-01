namespace exercici8;

/* Assigna un nombre total de minuts a una variable. 
Calcula quantes hores senceres i minuts restants són i imprimeix el resultat. */

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Un total de ");
        string minuts_car = Console.ReadLine();
        int minuts = Convert.ToInt16(minuts_car);

        int hores = minuts / 60;
        int h_m = minuts % 60;

        Console.WriteLine($"{minuts}m es igual a {hores}h i {h_m}");
    }
}
