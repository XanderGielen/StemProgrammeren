//digits of pi

using System.Diagnostics.Metrics;
using System.Reflection.PortableExecutable;

Console.Write("Hoeveel cijfers van Pi moet ik inlezen? ");
int N = Convert.ToInt32(Console.ReadLine());

if (N < 0) return;

// TODO:
// Maak een array aan waarin je het aantal keer dat een cijfer voorkomt
// kan bijhouden. Deze array heeft een lengte van 10, de index van de array
// staat voor het cijfer
int[] telnummers = new int[10];
char[] arrayvanCijfers = new char[N];

using (StreamReader sr = new StreamReader("pidigits.txt"))
{
    int count = 0;
    while (count < N && !sr.EndOfStream)
    {
        char c = (char)sr.Read();
        arrayvanCijfers[count] = c;
        if (c == '.') { count--; }
        else
        {
            telnummers[c - '0']++;
        }
        count++;
    }
}
foreach (int i in telnummers) { Console.WriteLine(Convert.ToString(i)); }
foreach(char j in arrayvanCijfers) {  Console.Write(j); }


// TODO:
// Maak een array waarin je alle cijfers als een char opslaat.
// Je maakt dus een array aan van lengte N


// TODO: Lees N cijfers van Pi in (kijk goed naar het decimaalteken)
// Moet je het hele bestand inlezen?
// Update de teller en de digits (arrays) tijdens het inlezen

// TODO: geef de uitkomst op de console als volgt:
// In de eerste 1000 cijfers van Pi komt...
// het cijfer 0 -> 99 keer voor
// het cijfer 1 -> 101 keer voor
// .......
// het cijfer 9 -> 103 keer voor
// (!!! de cijfers in de voorbeeld zijn niet de juiste uitkomst)







