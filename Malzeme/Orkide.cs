using System;
using System.Collections.Generic;

namespace CicekSepeti
{
  public class Orkide : Malzeme
  {
    public override Malzeme CreateMalzeme()
    {
      Cicekli = true;
      Dikenli = false;
      Yaprakli = false;
      return this;
    }
  }
}