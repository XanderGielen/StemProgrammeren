using Vraag_3_Exceptions;

Bankrekening mijnrekening = new Bankrekening("Dagobert Duck");

string command = "";

while (true)
{ 
    Console.WriteLine($"Welkom bij uw bank, {mijnrekening.Naam}");
    Console.WriteLine();
    Console.WriteLine("Maak uw keuze:");
    Console.WriteLine("1 - Saldo Tonen");
    Console.WriteLine("2 - Geld afhalen");
    Console.WriteLine("3 - Geld storten");
    Console.WriteLine("QUIT - Programma stoppen");
    Console.WriteLine();
    command = Console.ReadLine();

    switch (command.ToUpper())
    {
        case "1":
            mijnrekening.ToonSaldo();
            break;

        case "2":
            Console.Write("Hoeveel afhalen? ");
            mijnrekening.Afhalen(Convert.ToDouble(Console.ReadLine()));
            mijnrekening.ToonSaldo();
            break;


        case "3":
            Console.Write("Hoeveel storten? ");
            mijnrekening.Storten(Convert.ToDouble(Console.ReadLine()));
            mijnrekening.ToonSaldo();
            break;

        case "QUIT":
            return;

        default:
            Console.WriteLine($"'{command}' is niet bekend als een intern commando. probeer opnieuw.");
            break;
    }

    Console.WriteLine();
}