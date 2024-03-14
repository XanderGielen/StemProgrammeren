using Boek;
klasseBoek boek1 = new klasseBoek();
klasseBoek boek2 = new klasseBoek();
boek1.Title = "De Kleine Prins";
boek1.Prijs = 10;
boek2.Title = "De avonturen van WafelMan";
boek2.Prijs = 20;
klasseBoek boek3 = klasseBoek.TelOp(boek1, boek2);
Console.WriteLine(boek1.Title + " " + boek1.Prijs);
Console.WriteLine(boek2.Title + " " + boek2.Prijs);
Console.WriteLine(boek3.Title + boek3.Prijs);

