using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;

namespace KanaPractice2
{
  public class JapaneseViewModel : INotifyPropertyChanged
  {
    private JapaneseType _currentType;
    private LetterGroup _currentGroup;
    private JapaneseType[] _types;

    public JapaneseViewModel()
    {
      Types = JapanseXmlParser.Load( @"..\..\Data.xml" ).ToArray();
      CurrentType = Types[0];
    }

    public JapaneseType[] Types
    {
      get { return _types; }
      set {
        _types = value;
        OnPropertyChanged();
      }
    }

    public JapaneseType CurrentType
    {
      get { return _currentType; }
      set {
        _currentType = value;
        CurrentGroup = _currentType.LetterGroups[0];
        OnPropertyChanged();
      }
    }

    public LetterGroup CurrentGroup
    {
      get { return _currentGroup; }
      set {
        _currentGroup = value;
        OnPropertyChanged();
      }
    }


    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void OnPropertyChanged( [CallerMemberName] string propertyName = null )
    {
      PropertyChanged?.Invoke( this, new PropertyChangedEventArgs( propertyName ) );
    }
  }
}