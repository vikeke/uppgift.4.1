using uppgift._4._1;

void Djur()
{
    //denna funktion användet get och set
    Djur.katt katt = new Djur.katt();
    katt.settassStorlek(12);
    katt.setNamn("lilly");
    Console.WriteLine("name: " + katt.getNamn());
    Console.WriteLine("Tass Storlek: " + katt.gettassStorlek());
    katt.jama();
}

Djur();