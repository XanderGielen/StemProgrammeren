decimal eenheidsPrijs, totaal, korting, teBetalenIncl, teBetalenExcl, btwBedrag;

int aantal, kortingsPercentage = 0;

string aard;

const int btwPerc = 21;

bool valid = false; // declare a boolean variable to store the validity of the input
while (!valid) // repeat the loop until valid is true
{
    Console.WriteLine("Particulier (P) of winkerlier (W)? ");
    aard = Console.ReadLine();

    if (aard == "W" || aard == "w") // check if it is W or w
    {
        kortingsPercentage = 15; // assign the value
        valid = true; // set valid to true to exit the loop
    }
    else if (aard == "P" || aard == "p") // check if it is P or p
    {
        kortingsPercentage = 0; // assign the value
        valid = true; // set valid to true to exit the loop
    }
    else // otherwise
    {
        Console.WriteLine("Error: invalid input."); // display an error message
    }
}

Console.WriteLine("Geef de eenheidsprijs: ");
eenheidsPrijs = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Geef het aantal stuks: ");
aantal = Convert.ToInt32(Console.ReadLine());

totaal = eenheidsPrijs * aantal;


korting = totaal * kortingsPercentage / 100;
teBetalenIncl = totaal - korting;
btwBedrag = teBetalenIncl * btwPerc / (100 + btwPerc);
teBetalenExcl = teBetalenIncl - btwBedrag;

Console.WriteLine("Totaal inclusief BTW: " + totaal);
Console.WriteLine("kortingspercentage: " + kortingsPercentage);
Console.WriteLine("Korting: " + korting);
Console.WriteLine("Te betalen inclusief BTW: " + teBetalenIncl);
Console.WriteLine("Te betalen exclusief BTW: " + teBetalenExcl);
Console.WriteLine("BTW-bedrag: " + btwBedrag);
Console.ReadLine();



