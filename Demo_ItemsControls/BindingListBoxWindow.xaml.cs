using System;
using System.Collections.Generic;
using System.Diagnostics;
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

        private void ButtonToonGeselecteerdeTaak_Click(object sender, RoutedEventArgs e)
        {
            foreach (object o in ListBoxTaken.SelectedItems)
            {
                Debug.WriteLine((o as Taak).Titel);
            }
        }

        private void ButtonSelecteerLaatste_Click(object sender, RoutedEventArgs e)
        {
            ListBoxTaken.SelectedIndex = ListBoxTaken.Items.Count - 1;
        }

        private void ButtonSelecteerVolgende_Click(object sender, RoutedEventArgs e)
        {
            if ((ListBoxTaken.SelectedIndex >= 0) && (ListBoxTaken.SelectedIndex < (ListBoxTaken.Items.Count - 1)))
            {
                ListBoxTaken.SelectedIndex++;
            }
        }

        private void ButtonSelecteerEerste_Click(object sender, RoutedEventArgs e)
        {
            ListBoxTaken.SelectedIndex = 0;
        }
    }
}
