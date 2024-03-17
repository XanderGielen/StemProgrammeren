using ComplexGetal;

ComplexGetalKlasse x = new ComplexGetalKlasse(5, 15);
Console.WriteLine(x.ToString());
ReeelGetalKlasse y = new ReeelGetalKlasse(10);
Console.WriteLine(y.ToString());
ComplexGetalKlasse z = new ComplexGetalKlasse(2, -4);
Console.WriteLine(z.ToString());


Console.WriteLine(x * z);
Console.WriteLine(x + z);

Console.WriteLine(x.R);
Console.WriteLine(x.Toegevoegde);

Console.WriteLine(x * y);
Console.WriteLine(x + y);


