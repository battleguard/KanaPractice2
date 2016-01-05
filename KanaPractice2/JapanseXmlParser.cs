using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using KanaPractice2.Models;

namespace KanaPractice2
{
  public static class JapanseXmlParser
  {
    public static IEnumerable<JapaneseType> Load(string file)
    {
      var data = XDocument.Load( @"..\..\Data.xml" );
      var elements = data.Elements().First().Elements();
      foreach ( var element in elements )
      {
        var japaneseType = new JapaneseType(element.Name.LocalName);
        japaneseType.LetterGroups = GetGroups( element ).ToArray();
        yield return japaneseType;
      }
    } 

    private static IEnumerable<LetterGroup> GetGroups( XElement element )
    {
      // skipping comboelement since this will require a lot more extra logic for now
      foreach ( var groupElement in element.Elements().TakeWhile( g => g.Name.LocalName != "comboSounds" ) )
      {
        var curGroup = new LetterGroup( groupElement.Name.LocalName );
        curGroup.Conversions = GetConversions( groupElement ).ToArray();
        yield return curGroup;
      }
    }


    private static IEnumerable<Conversion> GetConversions( XElement element )
    {
      foreach ( var conversion in element.Elements() )
      {
        var japanese = conversion.Attribute( "romanji" ).Value;
        var english = conversion.Attribute( "kana" ).Value;
        yield return new Conversion( japanese, english );
      }
    }
  }
}