namespace exercici20;

/* Ens cal un programa que quan li entrem un número de tres xifres i ens retorni 
el número amb els dígits invertits. 

Ex. 245 -> 542
Entra el número a invertir: 347
El número invertit és: 743
*/

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Entra el número a invertir: ");
        string input = Console.ReadLine();

        // Comprovem que el número té exactament 3 xifres
        if (input.Length == 3 && int.TryParse(input, out int number))
        {
            // Invertim els dígits
            char[] digits = input.ToCharArray();
            Array.Reverse(digits);
            string reversed = new string(digits);

            Console.WriteLine("El número invertit és: " + reversed);
        }
        else
        {
            Console.WriteLine("Si us plau, entra un número de tres xifres.");
        }
    }
}
