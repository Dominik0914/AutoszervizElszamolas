using AutoszervizElszamolas;
List<Szerelo> jelenlegi = new List<Szerelo>();
List<int> oszeg = new List<int>();
foreach (string valami in File.ReadAllLines("szerviz.txt"))
{
    string[] vagot = valami.Split(";");
    Szerelo aktualis = new Szerelo();
    aktualis.Nev = vagot[0];
    aktualis.JavitottAutok = int.Parse(vagot[1]);
    aktualis.Munkaora = int.Parse(vagot[2]);
    aktualis.Garancialisjavitasok = int.Parse(vagot[3]);
    jelenlegi.Add(aktualis);

}
int telj = 0;
int gara = 0;
for (int i = 0; i < jelenlegi.Count; i++)
{
    int oraber = jelenlegi[i].Munkaora * 4000;
    int darabber = jelenlegi[i].JavitottAutok * 5000;
    if (jelenlegi[i].JavitottAutok <= 6 && jelenlegi[i].Garancialisjavitasok >= 1)
    {
        telj = 15000;
    }
    else
        telj = 0;

    if (jelenlegi[i].Garancialisjavitasok >=2)
    {
        gara = 10000;
    }
    else
    {
        gara = 0;
    }
    int napi = oraber + darabber + telj - gara;
    oszeg.Add(napi);
}

Console.WriteLine("Szerelők napi elszámolása:");
for (int i = 0;i < jelenlegi.Count();i++)
{
    Console.WriteLine($"{jelenlegi[i].Nev}: {jelenlegi[i].JavitottAutok} auto, {jelenlegi[i].Munkaora} óra (Garanciális {jelenlegi[i].Garancialisjavitasok}) - Munkabér:{oszeg[i]} Ft");
}
Console.WriteLine("Összesített statisztika:");
Console.WriteLine($"Szervíz által kifizetett teljes munkabér: {oszeg.Sum()} Ft");
Console.WriteLine($"általános napi munkaóra szerelőként: {jelenlegi.Average(a => a.Munkaora)} óra");
