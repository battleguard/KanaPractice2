using System;
using System.Collections.Generic;
using System.Linq;

namespace KanaPractice2.Models
{
  public class JapaneseType
  {
    public JapaneseType(string name)
    {
      Name = name;
    }

    public string Name { get; private set; }
    public LetterGroup[] LetterGroups { get; set; }
  }
}