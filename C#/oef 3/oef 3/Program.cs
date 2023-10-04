using static System.Math;

double korting = 0;
double kortingsBedrag;
double btw;
double totaal;

Console.WriteLine("Geef het bedrag aan goederen <netto> in:");
double bedrag = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Geef hoeveel dagen het geleden is dat u uw aankop heeft gemaakt: ");
string input = Console.ReadLine();

DateTime aankoopDatum;
if (DateTime.TryParseExact(input, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out aankoopDatum))
{
    DateTime currentDate = DateTime.Today;
    TimeSpan timeSincePurchase = currentDate - aankoopDatum;

    if (timeSincePurchase.TotalDays < 10)
    {
        korting = (bedrag * 2) / 100;
    }
}
else
{
    Console.WriteLine("Onvalide datum formaat, probeer opnieuw.");
}


kortingsBedrag = bedrag - korting;
btw = (bedrag * 21) / 100 ;
totaal =  kortingsBedrag + btw;

Console.WriteLine("Het bedrag aan goederen is " + Round(bedrag, 2) + " euro.");
Console.WriteLine("Het kortingsbedrag is " + Round(kortingsBedrag, 2) + " euro.");
Console.WriteLine("De te betalen BTW is: " + Round(btw, 2) + " euro.");
Console.WriteLine("Het totaal te betalen bedrag is " + Round(totaal, 2) + " euro.");