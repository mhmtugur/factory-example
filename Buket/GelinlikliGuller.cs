using System;
using System.Collections.Generic;

namespace CicekSepeti
{
  public class GelinlikliGuller : Buket
  {
    public GelinlikliGuller(BuketBoyut boyut) : base(boyut) { }
    public override Buket CreateBuket(BuketBoyut boyut)
    {
      Boyut = boyut;
      Icerik = new List<MalzemeAdet>();
      if (boyut == BuketBoyut.Kucuk)
      {
        Icerik.Add(new MalzemeAdet { MalzemeTipi = new Gul(), Adet = 5 });
        Icerik.Add(new MalzemeAdet { MalzemeTipi = new Papatya(), Adet = 20 });
        Icerik.Add(new MalzemeAdet { MalzemeTipi = new Suslemeler(), Adet = 5 });
        Fiyat = 12;
      }
      if (boyut == BuketBoyut.Orta)
      {
        Icerik.Add(new MalzemeAdet { MalzemeTipi = new Gul(), Adet = 7 });
        Icerik.Add(new MalzemeAdet { MalzemeTipi = new Papatya(), Adet = 20 });
        Icerik.Add(new MalzemeAdet { MalzemeTipi = new Suslemeler(), Adet = 10 });
        Fiyat = 16;
      }
      if (boyut == BuketBoyut.Buyuk)
      {
        Icerik.Add(new MalzemeAdet { MalzemeTipi = new Gul(), Adet = 10 });
        Icerik.Add(new MalzemeAdet { MalzemeTipi = new Papatya(), Adet = 20 });
        Icerik.Add(new MalzemeAdet { MalzemeTipi = new Suslemeler(), Adet = 15 });
        Fiyat = 20;
      }
      return this;
    }
  }
}