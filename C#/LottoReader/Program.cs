using LottoReader;

List<LottoTrekking> lottoTrekkingen = new List<LottoTrekking>();

using (StreamReader financialReader = new StreamReader("lotto-financialdata-NL-2023.csv"))
using (StreamReader gameReader = new StreamReader("lotto-gamedata-NL-2023.csv"))
{
    string financialDataLine;
    string gameDataLine;

    financialReader.ReadLine();
    gameReader.ReadLine();

    while(((financialDataLine = financialReader.ReadLine()) != null) && ((gameDataLine = gameReader.ReadLine()) != null))
    {
        lottoTrekkingen.Add(new LottoTrekking(financialDataLine, gameDataLine));

    }
}

Console.WriteLine($"Er werden {lottoTrekkingen.Count} Lottotrekkingen ingelezen.");

int[] aantalNummers = new int[45];

foreach(var item in lottoTrekkingen)
{
    foreach(var nummer in item.Nummers)
    {
        aantalNummers[nummer -1]++;
    }
}

for (int i = 0; i < aantalNummers.Length; i++)
    Console.WriteLine($"Het nummer {i+1} werd {aantalNummers[i]} keer getrokken.");
