namespace exercici12;

/* Fes un programa que a partir de dos números imprimeixi per pantalla la seva suma, la seva resta, 
la seva multiplicació i la seva divisió

Entra el primer número: 3
Entra el segon número: 4

4 + 3 = 7
4 - 3 = 1
4 * 5 = 12
4 / 3 = 1  i en sobra 1

Entra el primer número: 25
Entra el segon número: 5

25 + 5 = 30
25 - 5 = 20
25 * 5 = 125
25 / 5 = 5  i en sobra 0
*/

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Entra el primer numero ");
        string numero1_car = Console.ReadLine();
        int numero1 = Convert.ToInt16(numero1_car);

        Console.Write("Entra el segon numero ");
        string numero2_car = Console.ReadLine();
        int numero2 = Convert.ToInt16(numero2_car);

        int suma = numero1 + numero2;
        int resta = numero1 - numero2;
        int multi = numero1 * numero2;
        int div = numero1 / numero2;
        int porcentaje = numero1 % numero2;


        Console.WriteLine($"{numero1} + {numero2} = {suma}");
        Console.WriteLine($"{numero1} - {numero2} = {resta}");
        Console.WriteLine($"{numero1} * {numero2} = {multi}");
        Console.WriteLine($"{numero1} / {numero2} = {multi} i en sobra {porcentaje}");

    }
}
