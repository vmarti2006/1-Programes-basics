namespace exercici15;

// Assigna un nom i un cognom en variables. Imprimeix el nom complet, 
// assegurant-te que la primera lletra de cada paraula estigui en majúscula

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Nom: ");
        string nom = Console.ReadLine();

        Console.Write("Primer cognom: ");
        string cognom1 = Console.ReadLine();
        Console.Write("Sego cognoms: ");
        string cognom2 = Console.ReadLine();

        nom = char.ToUpper(nom[0]) + nom.Substring(1).ToLower();
        cognom1 = char.ToUpper(cognom1[0]) + cognom1.Substring(1).ToLower();
        cognom2 = char.ToUpper(cognom2[0]) + cognom2.Substring(1).ToLower();


        // Concatenem els cognoms
        string cognoms = string.Concat(cognom1, " ", cognom2);
        // Nom + primer cognom
        string nom_cognom1 = string.Concat(nom, " ", cognom1);
        // Nom + cognoms complets
        string nom_cognoms = string.Concat(nom, " ", cognoms);

        Console.WriteLine($"El teu nom es {nom} i els teus congoms son {cognoms}");
        Console.WriteLine($"El teu nom amb el primer cognom es {nom_cognom1} i el nom senser es {nom_cognoms}");
    }
}
