using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace EU
{
  class Program
  {
    static List<Csatlakozas> lista = new List<Csatlakozas>();
    static void Main(string[] args)
    {
      MasodikFeladat();
      HarmadikFeladat();
      NegyedikFeladat();
      ÖtödikFeladat();
      HatodikFeladat();
      HetedikFeladat();
      NyolcadikFeladat();

      Console.ReadKey();
    }

    private static void NyolcadikFeladat()
    {
      Console.WriteLine("8. feladat: Statisztika");
      Dictionary<int, int> statisztika= new Dictionary<int, int>()
      {
        { 1995 , 3 },
        { 1958 , 6 },
        { 2007 , 2 },
        { 2004 , 10},
        { 1973 , 3 },
        { 1981 , 1 },
        { 2013 , 1 },
        { 1986 , 2 }
      };
      foreach (var s in statisztika)
      {
        Console.WriteLine($"{s.Value.ToString().PadRight(3)} - {s.Value.ToString().PadLeft(3)} ország");
      }

    }
    private static void HetedikFeladat()
    {

      Console.WriteLine("7. feladat: Legutoljára csatlakozott ország: {0}");
    }

    private static void HatodikFeladat()
    {
      Console.WriteLine("6. feladat: ");
      int datum = 0;
      if (datum == 5)
      {
        Console.WriteLine("Májusban volt csatlakozás");
      }
      else
      {
        Console.WriteLine("Májusban nem volt csatlakozás");
      }
      
    }

    private static void ÖtödikFeladat()
    {
      Console.WriteLine("5. feladat: Magyarország csatlakozásának dátuma: ");
    }

    private static void NegyedikFeladat()
    {
      int datum = 0;
      for (int i = 0; i == datum ; i++)
      {

      }
      Console.WriteLine($"4. feladat: 2007-ben {datum} ország csatlakozott");
    }

    private static void HarmadikFeladat()
    {
      Console.WriteLine("3. feladat: EU tagállamainak száma: {0}",lista.Count());
    }

    private static void MasodikFeladat()
    {
      Console.WriteLine("2. feladat: adatok beolvasása");
      StreamReader be = new StreamReader("EUcsatlakozas.txt");
      be.ReadLine();
      while (!be.EndOfStream)
      {
        string[] olvas = be.ReadLine().Split(';');
        lista.Add(new Csatlakozas(olvas[0], Convert.ToString(olvas)[1]));
      }
      be.Close();
    }
  }
}
