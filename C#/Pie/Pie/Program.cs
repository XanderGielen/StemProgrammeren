using System;

int N;
int vakInCirkel = 0;

Console.WriteLine("Geef N: ");
N = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < N; i++) //lus voor de verticale-as
{
    for (int j = 0; j < N; j++)
    {
        double x = (i + 0.5) / N;
        double y = (j + 0.5) / N;

        double z = x * x + y * y;

        if (z < 1)
        {
            vakInCirkel++;
        }
    }
}

double pi;
pi = (double)(vakInCirkel * 4) / (N * N);
Console.WriteLine(pi);