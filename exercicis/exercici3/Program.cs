namespace exercici3;

/* Defineix quatre variables per al nom d’un producte, el seu preu 
i si està en estoc o no. Imprimeix la informació de forma clara. */
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Producto:");
        string prducte = Console.ReadLine();

        Console.Write("El seu preu es:");
        var preu = Console.ReadLine();

        Console.Write("Hay estoc del producto si/no:");
        bool enEstoc = true;
        Console.WriteLine($"Tenemos estoc? {enEstoc}");
    }
}
