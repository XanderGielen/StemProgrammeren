using examenVraag;
using System.Diagnostics.Metrics;
using System.Reflection.PortableExecutable;

List<string> waardes = new List<string>();
List<Student> studenten = new List<Student>();

using (StreamReader sr = new StreamReader("OpmaakB.csv"))
{
    try
    {
        sr.ReadLine();
        while (!sr.EndOfStream)
        {

            var line = sr.ReadLine();

            var values = line.Split(';');

            foreach (string item in values)
            {
                waardes.Add(item);
            }
            Student nieuwStudent = new Student(waardes[0], waardes[1], waardes[2]);
            waardes.Clear();
            studenten.Add(nieuwStudent);
        }
    }
    catch (Exception e)
    {
        Console.WriteLine(e.ToString());
    }
}

double totaal = 0;

foreach (var student in studenten)
{
    totaal += student.Score;
}
double gem = totaal / studenten.Count;

Console.WriteLine("Deze studenten scoorde boven het gemmidelde:");
foreach (var student in studenten)
{
    if (gem < student.Score)
    {
        Console.WriteLine(student.Naam + "(" + student.Id + ")" + " - " + student.Score);
    }
}
