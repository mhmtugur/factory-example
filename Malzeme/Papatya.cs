using System;


namespace CicekSepeti
{
    public class Papatya : Malzeme
  {
    public override Malzeme CreateMalzeme()
    {
      Cicekli = true;
      Dikenli = false;
      Yaprakli = true;
      return this;
    }
  }
}