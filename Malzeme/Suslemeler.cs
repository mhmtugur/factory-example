using System;
using System.Collections.Generic;

namespace CicekSepeti
{
  public class Suslemeler : Malzeme
  {
    public override Malzeme CreateMalzeme()
    {
      Cicekli = false;
      Dikenli = false;
      Yaprakli = true;
      return this;
    }
  }
}