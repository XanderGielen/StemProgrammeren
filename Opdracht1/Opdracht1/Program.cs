double SetSigFigs(double d, int digits)
{
    if (d == 0)
        return 0;

    decimal scale = (decimal)Math.Pow(10, Math.Floor(Math.Log10(Math.Abs(d))) + 1);
    return (double)(scale * Math.Round((decimal)d / scale, digits));
}

double ReadValidDoubleInput()
{
    double geg;

    while (true)
    {
        if (double.TryParse(Console.ReadLine(), out geg))
        {
            return geg; // Valid input, return the value
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
        }
    }
}

int ReadValidIntInput()
{
    int geg;

    while (true)
    {
        if (int.TryParse(Console.ReadLine(), out geg))
        {
            if ((geg >= 1) && (geg <= 5))
            {
                return geg; // Valid input, return the value
            }

            else
            {
                Console.WriteLine("Invalid input. Please enter a valid choice.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid choice.");
        }
    }
}


string ReadValidDoubleString()
{
    string geg;

    while (true)
    {

        geg = Console.ReadLine();

        if ((geg == "omtrek") || (geg == "oppervlakte"))
        {
            return geg; // Valid input, return the value
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid choice.");
        }
    }
}


Console.WriteLine("Kies een figuur uit de volgende lijst:");
Console.WriteLine("1. Cirkel");
Console.WriteLine("2. Vierkant");
Console.WriteLine("3. Rechthoek");
Console.WriteLine("4. Willekeurige driehoek");
Console.WriteLine("5. Gelijkzijdige driehoek");

int keuzeVorm = ReadValidIntInput();

Console.WriteLine("Wil je de omtrek of oppervlakte berekenen?");
string keuzeSoort = ReadValidDoubleString();

switch (keuzeVorm)
{
    

    case 1:
        Console.WriteLine("Je hebt gekozen voor de cirkel.");
        Console.WriteLine("Voer de straal van de cirkel in:");
        double straal = ReadValidDoubleInput();

        if (keuzeSoort == "omtrek")
        {
            double omtrek = 2 * Math.PI * straal;
            Console.WriteLine($"De omtrek van de cirkel is {omtrek}.");
        }

        else if (keuzeSoort == "oppervlakte")
        {
            double oppervlakte = Math.PI * Math.Pow(straal, 2);
            Console.WriteLine($"De oppervlakte van de cirkel is {oppervlakte}.");
        }
        break;

    case 2:
        Console.WriteLine("Je hebt gekozen voor het vierkant.");
        Console.WriteLine("Voer de lengte van een zijde van het vierkant in:");
        double zijde = ReadValidDoubleInput();

        if (keuzeSoort == "omtrek")
        {
            double omtrek = 4 * zijde;
            Console.WriteLine($"De omtrek van het vierkant is {omtrek}.");
        }

        else if (keuzeSoort == "oppervlakte")
        {
            double oppervlakte = 2 * zijde;
            Console.WriteLine($"De oppervlakte van het vierkant is {oppervlakte}.");
        }
        break;

    case 3:
        Console.WriteLine("Je hebt gekozen voor de rechthoek.");
        Console.WriteLine("Voer de lengte en breedte van de rechthoek in:");
        double lengte = ReadValidDoubleInput();
        double breedte = ReadValidDoubleInput();

        if (keuzeSoort == "omtrek")
        {
            double omtrek = 2 * (lengte + breedte);
            Console.WriteLine($"De omtrek van de rechthoek is {omtrek}.");
        }
        else if (keuzeSoort == "oppervlakte")
        {
            double oppervlakte = lengte * breedte;
            Console.WriteLine($"De oppervlakte van de rechthoek is {oppervlakte}.");
        }
        break;

    case 4:
        Console.WriteLine("Je hebt gekozen voor de willekeurige driehoek.");

        if (keuzeSoort == "omtrek")
        {
            Console.WriteLine("Voer de lengte van zijde a in: ");
            double a = ReadValidDoubleInput();

            Console.WriteLine("Voer de lengte van zijde b in: ");
            double b = ReadValidDoubleInput();

            Console.WriteLine("Voer de lengte van zijde c in: ");
            double c = ReadValidDoubleInput();

            double omtrek = a + b + c;
            Console.WriteLine($"De omtrek van de driehoek is {omtrek}.");
        }
        else if (keuzeSoort == "oppervlakte")
        {
            Console.WriteLine("Voer de lengte van de basis van de driehoek in: ");
            double basis = ReadValidDoubleInput();

            Console.WriteLine("Voer de hoogte van de driehoek in: ");
            double hoogte = ReadValidDoubleInput();

            double oppervlakte = 0.5 * basis * hoogte; 
            Console.WriteLine($"De oppervlakte van de driehoek is {oppervlakte}.");
        }
    break;


    case 5:
        Console.WriteLine("Je hebt gekozen voor de gelijkzijdige driehoek.");
        Console.WriteLine("Voer de lengte van een zijde van de gelijkzijdige driehoek in:");
        double zijdeGelijkZijdig = ReadValidDoubleInput();

        
        double hoogteGelijkzijdig = Math.Sqrt(3) / 2 * zijdeGelijkZijdig;
        double basisGelijkzijdig = zijdeGelijkZijdig * 3;

        if (keuzeSoort == "omtrek")
        {
            double omtrekGelijkZijdig = zijdeGelijkZijdig * 3;
            Console.WriteLine($"De omtrek van de gelijkzijdige driehoek is {omtrekGelijkZijdig}.");
        }
        else if (keuzeSoort == "oppervlakte")
        {
            double oppervlakteGelijkZijdig = (Math.Sqrt(3) / 4) * Math.Pow(zijdeGelijkZijdig, 2);
            Console.WriteLine($"De oppervlakte van de gelijkzijdige driehoek is {oppervlakteGelijkZijdig}.");
        }

        break;

    default:
        Console.WriteLine("Ongeldige keuze. Probeer opnieuw.");
        break;
}


