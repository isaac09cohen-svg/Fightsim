
string svar = "";

string name1 = "";

string name2 = "";

int HP1 = 100;

int HP2 = 100;

int Runda = 0;

int skada;




while (svar != "Y" && svar != "y")
{
    Console.WriteLine("Välj namn för spelare 1");

    name1 = Console.ReadLine();

    Console.WriteLine("Är du säker att du vill heta detta?");
    Console.WriteLine("Y/N?");
    svar = Console.ReadLine();
}
string svar2 = "";
while (svar2 != "Y" && svar2 != "y")
{
    Console.WriteLine("Välj namn för spelare 2");

    name2 = Console.ReadLine();
    Console.WriteLine("Är du säker att du vill heta detta?");
    Console.WriteLine("Y/N?");
    svar2 = Console.ReadLine();
}

Console.WriteLine("Spelare 1  är " + name1 + " och spelare 2 är " + name2);
Thread.Sleep(1000);
while (HP1 > 0 || HP2 > 100)
{
Runda = Runda + 1; 
Console.WriteLine("<---+Runda " + Runda +"+--->");
Thread.Sleep(1000);
Console.WriteLine(name1 + " har " + HP1 + " HP och " + name2 +  " har " + HP2 + " HP");
Thread.Sleep(1000);
skada = Random.Shared.Next(10,30);
Console.WriteLine(name1 +" gör " + skada + " skada");
HP2 = HP2 - skada;
Thread.Sleep(1000);
    if (HP1 < 1)
    {
        Console.WriteLine("<---+Match Över+--->");
        Console.WriteLine(name2 + " Vinner");
        break;
    }
    if (HP2 < 1)
    {
        Console.WriteLine("<---+Match Över+--->");
        Console.WriteLine(name1 + " Vinner");
        break;
    }

skada = Random.Shared.Next(10,30);
Console.WriteLine(name2 + " gör " + skada + " skada");
HP1 = HP1 - skada;
Thread.Sleep(1000);
    if (HP1 < 1)
    {
        Console.WriteLine("<---+Match Över+--->");
        Console.WriteLine(name2 + " Vinner");
        break;
    }
    if (HP2 < 1)
    {
        Console.WriteLine("<---+Match Över+--->");
        Console.WriteLine(name1 + " Vinner");
        break;
    }
}
Console.ReadLine();




























Console.ReadLine();


