using System;

double x;
double y;
int vakInCirkel = 0;
int N;
Console.WriteLine("Geef hoeveel punten je wilt: ");
N = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < N; i++)
{
    Random getalGenerator = new Random();
    x = getalGenerator.NextDouble();
    y = getalGenerator.NextDouble();

    double z = x * x + y * y;

    if (z < 1)
    {
        vakInCirkel++;
    }
}


double pi;
pi = (double)(vakInCirkel * 4) / N;
Console.WriteLine(pi);
