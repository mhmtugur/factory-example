using System;

namespace CicekSepeti
{
  public abstract class Malzeme
  {
    public bool Cicekli { get; set; }
    public bool Dikenli { get; set; }
    public bool Yaprakli { get; set; }

    /// Factory Method
    public abstract Malzeme CreateMalzeme();

    public Malzeme()
    {
      this.CreateMalzeme();
    }
  }
}