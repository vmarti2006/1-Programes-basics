namespace exercici2;

/* Declara variables per emmagatzemar l’adreça d’una persona: 
carrer, número, codi postal i població. Imprimeix el resultat 
en una sola línia */

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Carrer:");
        string carrer = Console.ReadLine();
        Console.WriteLine("Numero:");
        string numero = Console.ReadLine();
        Console.WriteLine("codi postal:");
        string codi_postal = Console.ReadLine();
        Console.WriteLine("poblacio:");
        string poblacio = Console.ReadLine();

        Console.WriteLine($"Carrer:{carrer}, numero {numero}, {poblacio}  {codi_postal}");
    }      
}
