using berek2020;
using System.Text;


//9:05 - 9:24 19 perc alatt lett kész

List<Ber> berek = new();
using(StreamReader sr = new StreamReader(@"..\..\..\src\berek2020.txt", Encoding.UTF8))
{
    while (!sr.EndOfStream)
    {
        berek.Add(new Ber(sr.ReadLine()));
    }
}

Console.WriteLine($"3. feladat: A forrásállományban {berek.Count} db dolgozó adatait tároljuk.");



var f4 = berek.Average(x => x.Fizetes);

Console.WriteLine($"4. feladat: Az éves átlag fizetés 2020-ban {f4} Ft");

Console.Write("Adjon meg egy részleget: ");
var beker = Console.ReadLine();
var f6 = berek.Where(x => x.Reszleg == beker);

if(f6.Count() == 0) Console.WriteLine("6. feladat: A megadott részleg nem létezik a cégnél!");
if(f6.Count() > 0) Console.WriteLine($"6. feladat: A megadott részleg legmagasabb fizetése: {f6.Max(x => x.Fizetes)} Ft");


var f7 = berek.GroupBy(x => x.Reszleg);
foreach (var item in f7)
{
    Console.WriteLine($"{item.Key} - {item.Count()} fő");
}

