using System.Runtime.CompilerServices;

System.Globalization.CultureInfo cultureInfo = System.Globalization.CultureInfo.CurrentCulture;
string characterseperator = cultureInfo.TextInfo.ListSeparator;

using(StreamReader tekstlezer = new StreamReader("teksst.csv"))
{
    string line = tekstlezer.ReadLine();
    string[] ding = [];
    while (line != null)
    {
        ding = line.Split(characterseperator);
        line = tekstlezer.ReadLine();
        foreach (string s in ding)
        {
            Console.WriteLine(s);
        }
    }
    tekstlezer.Close();
}
