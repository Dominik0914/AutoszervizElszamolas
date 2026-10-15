using AutoszervizElszamolas;

List<Szerelo> jelenlegi = new List<Szerelo>();
foreach (string valami in File.ReadAllLines("szerviz.txt"))
{
    Szerelo aktualis = new Szerelo();
    string[] vagot = valami.Split(";");
    aktualis.Nev = vagot[0];
    aktualis.JavitottAutok = int.Parse(vagot[0]);
    aktualis.Munkaora = int.Parse(vagot[0]);
    aktualis.Garancialisjavitasok = int.Parse(vagot[0]);
    jelenlegi.Add(aktualis);

}