using System;
using System.Collections.Generic;
using System.Linq;

namespace KanaPractice2.Models
{
  public class LetterGroup
  {
    public LetterGroup( string name )
    {
      Name = name;
    }

    public string Name { get; private set; }
    public Conversion[] Conversions { get; set; } 
  }
}