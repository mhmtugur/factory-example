using System;
using System.Collections.Generic;

namespace CicekSepeti
{
  public enum BuketBoyut
  {
    Kucuk,
    Orta,
    Buyuk
  }

  public abstract class Buket
  {
    public BuketBoyut Boyut { get; set; }
    public List<MalzemeAdet> Icerik { get; set; }
    public decimal Fiyat { get; set; }
    public abstract Buket CreateBuket(BuketBoyut boyut);
    public Buket(BuketBoyut boyut)
    {
      CreateBuket(boyut);
    }
  }

  public class MalzemeAdet
  {
    public Malzeme MalzemeTipi { get; set; }
    public int Adet { get; set; }
  }
}