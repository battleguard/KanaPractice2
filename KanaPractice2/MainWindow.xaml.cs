using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;

namespace KanaPractice2
{
  /// <summary>
  /// Interaction logic for MainWindow.xaml
  /// </summary>
  public partial class MainWindow : Window
  {
    public MainWindow()
    {
      InitializeComponent();
      DataContext = new JapaneseViewModel();
    }
  }
}
