namespace exercici6;

/* Declara una variable per al costat d'un quadrat. Calcula el seu perímetre (suma dels quatre costats) 
i imprimeix-lo. */

class Program
{
    static void Main(string[] args)
    {
        Console.Write("que tan grande es un lado del cuadrado?");
        string lado = Console.ReadLine();

        if (double.TryParse(lado, out double cara))
        {
            double area = cara * 4;
            Console.WriteLine($"El perimeto del quadrado es {area}");
        }
        else
        {
             Console.WriteLine($"Valor incorrecto no se puee calcular el perimetro");
        }
    }
}
