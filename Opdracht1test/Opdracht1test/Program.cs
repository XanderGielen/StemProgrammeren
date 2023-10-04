using System;
using System.IO;

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




            Console.WriteLine("Kies een figuur uit de volgende lijst:");
        Console.WriteLine("1. Cirkel");
        Console.WriteLine("2. Vierkant");
        Console.WriteLine("3. Rechthoek");
        Console.WriteLine("4. Willekeurige driehoek");
        Console.WriteLine("5. Gelijkzijdige driehoek");

        int keuzeVorm = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Wil je de omtrek of oppervlakte berekenen?");
        string keuzeSoort = Console.ReadLine();

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
                double zijde;

                while (true)
                {
                    Console.WriteLine("Voer de zijde van het vierkant in:");

                    if (double.TryParse(Console.ReadLine(), out zijde))
                    {
                        break; // Valid input, exit the loop
                    }
                    else
                    {
                        Console.WriteLine("Ongeldige invoer. Voer een geldig getal in.");
                    }
                }

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
                double lengte;
                double breedte;

                while (true)
                {
                    Console.WriteLine("Voer de lengte van de rechthoek in:");

                    if (double.TryParse(Console.ReadLine(), out lengte))
                    {
                        break; // Valid input, exit the loop
                    }
                    else
                    {
                        Console.WriteLine("Ongeldige invoer. Voer een geldig getal in.");
                    }
                }

                while (true)
                {
                    Console.WriteLine("Voer de breedte van de rechthoek in:");

                    if (double.TryParse(Console.ReadLine(), out breedte))
                    {
                        break; // Valid input, exit the loop
                    }
                    else
                    {
                        Console.WriteLine("Ongeldige invoer. Voer een geldig getal in.");
                    }
                }
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
                    double a = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Voer de lengte van zijde b in: ");
                    double b = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Voer de lengte van zijde c in: ");
                    double c = Convert.ToDouble(Console.ReadLine());

                    double omtrek = a + b + c;
                    Console.WriteLine($"De omtrek van de driehoek is {omtrek}.");
                }
                else if (keuzeSoort == "oppervlakte")
                {
                    Console.WriteLine("Voer de lengte van de basis van de driehoek in: ");
                    double basis = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Voer de hoogte van de driehoek in: ");
                    double hoogte = Convert.ToDouble(Console.ReadLine());

                    double oppervlakte = 0.5 * basis * hoogte;
                    Console.WriteLine($"De oppervlakte van de driehoek is {oppervlakte}.");
                }
                break;


            case 5:
                Console.WriteLine("Je hebt gekozen voor de gelijkzijdige driehoek.");
                Console.WriteLine("Voer de lengte van een zijde van de gelijkzijdige driehoek in:");
                double zijdeGelijkZijdig = Convert.ToDouble(Console.ReadLine());


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


