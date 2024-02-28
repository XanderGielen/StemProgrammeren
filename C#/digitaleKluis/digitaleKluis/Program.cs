using digitaleKluis;

DigitaleKluis mijnkluis = new DigitaleKluis(1234);
Console.WriteLine($"CanShow=false -> code: {mijnkluis.Code}");
mijnkluis.CanShowCode = true;
Console.WriteLine($"CanShow=true -> code: {mijnkluis.Code}");

Random random = new Random();
for (int i = 0; i < 20; i++)
{
    //int poging = random.Next(0, 9999);

    // Let's increase the odds
    int poging = random.Next(1230, 1240);
    Console.Write($"proberen {poging}....");

    if (mijnkluis.TryCode(poging)) break;
}