using ProjDierenTuin;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq.Expressions;
using System.Reflection.Emit;

List<Dier> dieren = new List<Dier>();

Dodovogel dodo1 = new Dodovogel() { gewicht = 10.0 };
dieren.Add(dodo1);
KuikenPiep kuiken1 = new KuikenPiep() { gewicht = 1.0 };
dieren.Add(kuiken1);
Kip kip1 = new Kip() { gewicht = 5.0 };
dieren.Add(kip1);
Casbeest casvankurkel = new Casbeest() { gewicht = 4000000000 };
dieren.Add(casvankurkel);

string input = "";
while (true)
{
    double totGewicht = 0;
    int teller = 0;

    Console.WriteLine("1.Dier verwijderen:\r\n2.Diergewicht gemiddelde:\r\n3.Dier praten: \r\n4.Opnieuw beginnen: ");
    input = Console.ReadLine();
    if (input == "q") { break; }
    if(input == "1") { int welkDier = Convert.ToInt32(Console.ReadLine()); dieren.Remove(dieren[welkDier]); }
    else if (input == "2")
    {
        foreach (var dier in dieren)
        {
            totGewicht += dier.gewicht;
            teller++;
        }
        double gemGewicht = totGewicht / teller;
        Console.WriteLine("Het gemiddelde gewiht is: " + gemGewicht);
    }
    else if (input == "3")
    {
        foreach (var dier in dieren)
        {
            Console.WriteLine(dier.Zegt());
        }
    }
    else if(input == "4")
    {
        dieren.Clear();
        dieren.Add(dodo1);
        dieren.Add(kuiken1);
        dieren.Add(kip1);
        dieren.Add(kip1);
        dieren.Add(casvankurkel);
        totGewicht = 0;
        teller = 0;
    }
}





