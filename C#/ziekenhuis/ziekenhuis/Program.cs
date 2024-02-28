using ziekenhuis;

Patient patient1 = new Patient();
VerzekerdePatient patient2 = new VerzekerdePatient();

Console.WriteLine("Wat is zijn naam? ");
patient1.naam = Console.ReadLine();
Console.WriteLine("Hoeveel uur heeft hij in het ziekenhuis gelegen? ");
patient1.uur = Convert.ToInt16(Console.ReadLine());
Console.WriteLine(patient1.InfoFiche());

Console.WriteLine("Wat is zijn naam? ");
patient2.naam = Console.ReadLine();
Console.WriteLine("Hoeveel uur heeft hij in het ziekenhuis gelegen? ");
patient2.uur = Convert.ToInt16(Console.ReadLine());
Console.WriteLine(patient2.InfoFiche());


