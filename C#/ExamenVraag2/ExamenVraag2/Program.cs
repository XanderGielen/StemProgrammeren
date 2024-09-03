using ExamenVraag2;

Auto auto = new Auto("Maserati", "Quattroporte", 4);
Moto moto = new Moto("Ducati", "Panigale", 240.5);
Vrachtwagen vracht = new Vrachtwagen("Iveco", "Eurocargo", 6300);

Voertuig[] voertuigen = new Voertuig[3];
voertuigen[0] = auto; voertuigen[1] = moto; voertuigen[2] = vracht;

foreach (var voertuig in voertuigen)
{
    voertuig.ToonInfo();
    Console.WriteLine("");
}