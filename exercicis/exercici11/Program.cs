namespace exercici11;

// A partir de dues variables (nom d'usuari i domini), crea i imprimeix una adreça de correu electrònic completa.
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digues el teu Nom: ");
        string id = Console.ReadLine();

        Console.Write("Digues el teu Domini: ");
        string domini = Console.ReadLine();

        string correo = id +"@"+domini+".com";
        Console.WriteLine(correo);

    }
}
