using ComputerWinkel;

List<ComputerOnderdeel> computerOnderdelen = new List<ComputerOnderdeel>();

for (int i = 0; i < 100; i++)
{
    computerOnderdelen.Add(new ComputerOnderdeel());
    computerOnderdelen[i].ToonInfo();
}

Console.WriteLine("\n\nNu degene duurder dan 400 \n");
for (int i = 0; i < 100; i++)
{
    if (computerOnderdelen[i].Prijs > 400)
    {
        computerOnderdelen[i].ToonInfo();
    }
}

Console.WriteLine("\n\nNu degene die in de doos zitte \n");
for (int i = 0;i < 100; i++)
{
    if (computerOnderdelen[i].InDoos == true)
    {
        computerOnderdelen[i].ToonInfo();
    }
}

Console.WriteLine("\n\nNu degene met een ID lager dan 200 \n");
for (int i = 0; i < 100; i++)
{
    if (computerOnderdelen[i].ID <= 200)
    {
        computerOnderdelen[i].ToonInfo();
    }
}
