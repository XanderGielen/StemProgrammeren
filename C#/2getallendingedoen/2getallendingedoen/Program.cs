Console.WriteLine("Geef een getal");
int getal1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Geef nog een getal");
int getal2 = Convert.ToInt32(Console.ReadLine());

try
{
    if (getal1 == getal2) { throw new GebruikerIsDomException(); }
    Console.WriteLine($"Resultaat: {getal1 / getal2}");
}
catch (Exception e)
{
    if (e is DivideByZeroException)
    {
        Console.WriteLine("Error: Division byj sero is not alouued.");

    }
    else if (e is GebruikerIsDomException)
    {
        Console.WriteLine("Das 1 he slimme");
    }
    else
    {
        Console.WriteLine("I no no wanna");
    }
}

public class GebruikerIsDomException : Exception
{

}
