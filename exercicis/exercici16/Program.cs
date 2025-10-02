namespace exercici16;

/* Ningú entén res del nou sistema d’avaluació. Necessitem un programa que calculi la part que és més senzilla: 
a partir de la mitjana de les notes les pràctiques i la nota de l’examen ens calculi la nota final

Nota de pràctiques: 8 (40%)
Nota de l’examen: 9   (60%)
La nota final és 8.7 o sigui un 9

*/

class Program
{
    static void Main(string[] args)
    {
        Console.Write("La nota final de practiques:");
        string practiques_car = Console.ReadLine();
        double practiques = Convert.ToInt16(practiques_car);
        double practiques_porcentaje = (double)practiques * 0.40;

        Console.Write("La nota final de examen:");
        string examen_car = Console.ReadLine();
        double examen = Convert.ToInt16(examen_car);
        double examen_porcentaje = (double)examen * 0.60;

        double resultat = examen_porcentaje + practiques_porcentaje;
        int resultat_arrodonit =(int) resultat;

        Console.WriteLine($"Has tret un {resultat}, per tan es queda en {resultat_arrodonit}");
    }
}
