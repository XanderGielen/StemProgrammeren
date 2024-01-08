Console.WriteLine("geef getal: ");
int n = Convert.ToInt32(Console.ReadLine());

///<summary>
///Bereken de faculteit van een getal
/// </summary>
/// <param name="n">Het getal waarvan we de faculteit berekenen</param>
/// <returns>De faculteit</returns>
static int Faculteit(int n)
{
    if (n == 0)
        return 1;

    return n * Faculteit(n - 1);
}


int facN = Faculteit(n);
Console.WriteLine(facN);
