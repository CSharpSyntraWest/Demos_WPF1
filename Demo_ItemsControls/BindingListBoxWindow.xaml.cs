using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Demo_ItemsControls
{
    /// <summary>
    /// Interaction logic for BindingListBoxWindow.xaml
    /// </summary>
    public partial class BindingListBoxWindow : Window
    {
        public class Taak
        { 
            public string Titel { get; set; }
            public int PercentAfgewerkt { get; set; }
        }
        public BindingListBoxWindow()
        {
            InitializeComponent();
            List<Taak> taken = new List<Taak>();
            taken.Add(new Taak() { Titel = "Hond uitlaten", PercentAfgewerkt = 0 });
            taken.Add(new Taak() { Titel = "Oefeningen C# maken", PercentAfgewerkt = 50 });
            taken.Add(new Taak() { Titel = "Huis kuisen", PercentAfgewerkt = 85 });
            ListBoxTaken.ItemsSource = taken;
        }
    }
}
