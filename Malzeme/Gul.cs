using System;


namespace CicekSepeti
{
  public class Gul : Malzeme
  {
    public override Malzeme CreateMalzeme()
    {
      Cicekli = true;
      Dikenli = true;
      Yaprakli = true;
      return this;
    }
  }
}