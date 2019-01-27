using System;
using System.Collections.Generic;

namespace CicekSepeti
{
  public class OrkideBuketi : Buket
  {
    public OrkideBuketi(BuketBoyut boyut) : base(boyut) { }
    public override Buket CreateBuket(BuketBoyut boyut)
    {
      Boyut = boyut;
      Icerik = new List<MalzemeAdet>();
      if (boyut == BuketBoyut.Kucuk)
      {
        Icerik.Add(new MalzemeAdet { MalzemeTipi = new Orkide(), Adet = 1 });
        Fiyat = 20;
      }
      if (boyut == BuketBoyut.Orta)
      {
        Icerik.Add(new MalzemeAdet { MalzemeTipi = new Orkide(), Adet = 2 });
        Fiyat = 25;
      }
      if (boyut == BuketBoyut.Buyuk)
      {
        Icerik.Add(new MalzemeAdet { MalzemeTipi = new Orkide(), Adet = 5 });
        Fiyat = 30;
      }
      return this;
    }
  }
}