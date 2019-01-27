using System;
using System.Collections.Generic;

namespace CicekSepeti
{
  public class GulBahcesi : Buket
  {
    public GulBahcesi(BuketBoyut boyut) : base(boyut) { }
    public override Buket CreateBuket(BuketBoyut boyut)
    {
      Boyut = boyut;
      Icerik = new List<MalzemeAdet>();
      if (boyut == BuketBoyut.Kucuk)
      {
        Icerik.Add(new MalzemeAdet { MalzemeTipi = new Gul(), Adet = 10 });
        Icerik.Add(new MalzemeAdet { MalzemeTipi = new Suslemeler(), Adet = 5 });
        Fiyat = 10;
      }
      if (boyut == BuketBoyut.Orta)
      {
        Icerik.Add(new MalzemeAdet { MalzemeTipi = new Gul(), Adet = 25 });
        Icerik.Add(new MalzemeAdet { MalzemeTipi = new Suslemeler(), Adet = 10 });
        Fiyat = 15;
      }
      if (boyut == BuketBoyut.Buyuk)
      {
        Icerik.Add(new MalzemeAdet { MalzemeTipi = new Gul(), Adet = 50 });
        Icerik.Add(new MalzemeAdet { MalzemeTipi = new Suslemeler(), Adet = 15 });
        Fiyat = 20;
      }
      return this;
    }
  }
}