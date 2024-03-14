using MoneyMoneyMoney;

BankRekening bankrekening = new BankRekening();
SpaarRekening spaarrekening = new SpaarRekening();
ProRekening prorekening = new ProRekening();

bankrekening.VoegGeldToe(200);
Console.WriteLine($"[BankRekening] Saldo: {bankrekening.Saldo} - Rente: {bankrekening.BerekenRente()}");
bankrekening.HaalGeldAf(150);
Console.WriteLine($"[BankRekening] Saldo: {bankrekening.Saldo} - Rente: {bankrekening.BerekenRente()}");

spaarrekening.VoegGeldToe(500);
Console.WriteLine($"[SpaarRekening] Saldo: {spaarrekening.Saldo} - Rente: {spaarrekening.BerekenRente()}");
spaarrekening.VoegGeldToe(15000);
Console.WriteLine($"[SpaarRekening] Saldo: {spaarrekening.Saldo} - Rente: {spaarrekening.BerekenRente()}");

prorekening.VoegGeldToe(500);
Console.WriteLine($"[ProRekening] Saldo: {prorekening.Saldo} - Rente: {prorekening.BerekenRente()}");
prorekening.VoegGeldToe(15000);
Console.WriteLine($"[ProRekening] Saldo: {prorekening.Saldo} - Rente: {prorekening.BerekenRente()}");