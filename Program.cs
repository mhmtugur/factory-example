using System;
using System.Collections.Generic;

namespace CicekSepeti
{
  class Program
  {
    static void Main(string[] args)
    {
      // var malzemeList = new List<Malzeme>();

      // malzemeList.Add(new Gul());
      // malzemeList.Add(new Papatya());
      // malzemeList.Add(new Orkide());
      // malzemeList.Add(new Suslemeler());

      var buketListesi = GetBuketList();
    }
    private static List<Buket> GetBuketList()
    {
      var boyutlar = new List<BuketBoyut>();
      boyutlar.Add(BuketBoyut.Kucuk);
      boyutlar.Add(BuketBoyut.Orta);
      boyutlar.Add(BuketBoyut.Buyuk);


      var buketTipleri = new List<Type>();
      buketTipleri.Add(typeof(GulBahcesi));
      buketTipleri.Add(typeof(GelinlikliGuller));
      buketTipleri.Add(typeof(OrkideBuketi));


      var buketListesi = new List<Buket>();

      foreach (var buketTipi in buketTipleri)
      {
        foreach (var boyut in boyutlar)
        {
          buketListesi.Add(GetBuket(boyut, buketTipi));
        }
      }

      return buketListesi;
    }
    private static Buket GetBuket(BuketBoyut boyut, Type buketTipi)
    {
      return (Buket)Activator.CreateInstance(buketTipi, boyut);
    }
  }
}
