using System;
using System.Collections.Generic;
using System.Linq;

namespace KanaPractice2.Models
{
  public class Conversion
  {
    public Conversion( string japanese, string english )
    {
      Japanese = japanese;
      English = english;
    }

    public string Japanese { get; private set; }
    public string English { get; private set; }
  }
}