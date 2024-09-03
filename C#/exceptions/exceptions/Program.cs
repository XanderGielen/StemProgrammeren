
Exception uitzondering = new Exception();

onzeException blablabla = new onzeException();


int[] rij = new int[20];
string[] fruit = { "appel", "banaan" };
try
{
    IetsMoeilijks();
}
catch (onzeException e)
{
    Console.WriteLine(e.Message);
}


void IetsMoeilijks()
{
    
}


class onzeException : Exception
{
    public override string Message { get { return "onze uitzondering"; } }
}