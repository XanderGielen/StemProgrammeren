using Weerstationn;

DrukMeting druk = new DrukMeting(0.1, 1000);
druk.VoegMetingenToe(130);
druk.VoegMetingenToe(127);
druk.VoegMetingenToe(125);
druk.VoegMetingenToe(124);
druk.VoegMetingenToe(124);
druk.VoegMetingenToe(129);
Console.WriteLine(druk.Gemiddelde);
Console.WriteLine(druk.omgezetteWaardeVanGem);

Temperatuur binnenTem = new Temperatuur(0.01, -50);
binnenTem.VoegMetingenToe(12000);
Console.Write(binnenTem.omgezetteWaardeVanGem);
if (binnenTem.vriesTemp) { Console.Write("!"); }

Console.WriteLine("");

Temperatuur buitenTem = new Temperatuur(0.01, -50);
buitenTem.VoegMetingenToe(1000);
Console.Write(buitenTem.omgezetteWaardeVanGem);
if (buitenTem.vriesTemp) { Console.Write("!"); }