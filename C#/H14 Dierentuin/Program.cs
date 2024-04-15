using H14_Dierentuin;


bool programRunning = true;

while (programRunning)
{
    List<Dier> dierentuin = new List<Dier>()
    {
        new Hond(){ Gewicht = 10.0 },
        new Kat(){ Gewicht = 3.1415926535 },
        new Eend(){ Gewicht = 1.25 },
        new Koe(){ Gewicht = 825.1 }
    };

    bool inLoop = true;

    while (inLoop)
    {
        Console.WriteLine("Maak uw keuze:");
        Console.WriteLine("1 - Dier verwijderen");
        Console.WriteLine("2 - Diergewicht gemiddelde");
        Console.WriteLine("3 - Dier praten");
        Console.WriteLine("4 - Opnieuw beginnen");
        Console.WriteLine("Q - Programma stoppen");

        char keuze = Console.ReadLine().ToUpper().First();

        switch (keuze)
        {
            case '1':
                Console.Write($"Welk dier verwijderen (1-{dierentuin.Count})?");
                int index = Convert.ToInt32(Console.ReadLine()) - 1;
                dierentuin.RemoveAt(index);
                break;

            case '2':
                double totaalGewicht = 0.0;
                foreach (Dier dier in dierentuin)
                {
                    totaalGewicht += dier.Gewicht;
                }
                Console.WriteLine($"Het gemiddelde diergewicht is {totaalGewicht / dierentuin.Count}");
                break;

            case '3':
                foreach (Dier dier in dierentuin)
                {
                    Console.WriteLine(dier.Zegt());
                }
                break;

            case '4':
                inLoop = false;
                break;

            case 'Q':
                inLoop = false;
                programRunning = false;
                break;

            default:
                break;
        }

    }
}

