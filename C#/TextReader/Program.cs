using System.Globalization;

CultureInfo cultureUS = CultureInfo.GetCultureInfo("en-US");
string characterseparator = cultureUS.TextInfo.ListSeparator;
Console.WriteLine(characterseparator);

using (StreamReader textlezer = new StreamReader("waardes.csv"))
{
    string nieuwregel = textlezer.ReadLine();
    while (nieuwregel != null)
    {
        string[] splitted = nieuwregel.Split(characterseparator);
        Console.WriteLine(splitted[0]);
        nieuwregel = textlezer.ReadLine();
    }
    textlezer.Close();
}









