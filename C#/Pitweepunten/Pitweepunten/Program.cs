using System;

double x;
double y;
double pi = 0;
int vakInCirkel = 0;
int N;
int aantalKeer = 100;
Console.WriteLine("Geef hoeveel punten je wilt: ");
N = Convert.ToInt32(Console.ReadLine());

for (int j = 0; j < aantalKeer; j++)
{
    vakInCirkel = 0;
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


    
    pi = (double)(vakInCirkel * 4) / N;
    Console.WriteLine(pi);
}


