using SpeelKaarten;

List <Speelkaart> dek = new List<Speelkaart> ();

foreach(Speelkaart.Suite kleur in Enum.GetValues<Speelkaart.Suite>())
{
    for (int i = 1; i <= 13; i++)
    {
        dek.Add(new Speelkaart(i, kleur));
    }

}

Random random = new Random ();
int teller = 0;
while (teller < 52)
{
    int kaartje = random.Next (0, 52 - teller);
    teller++;
    Speelkaart getrokkenkaart = dek[kaartje];

    Console.WriteLine($"{getrokkenkaart.Getal}  {getrokkenkaart.Soort.ToString()}");
    dek.Remove(getrokkenkaart);
}