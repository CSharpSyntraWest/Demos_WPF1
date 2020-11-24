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
    /// Interaction logic for ComboBoxWindow.xaml
    /// </summary>
    public partial class ComboBoxWindow : Window
    {
        public ComboBoxWindow()
        {
            InitializeComponent();
            ComboBoxColors.ItemsSource = typeof(Colors).GetProperties();
        }

        private void ButtonBlauw_Click(object sender, RoutedEventArgs e)
        {
            ComboBoxColors.SelectedItem = typeof(Colors).GetProperty("Blue");
        }

        private void ComboBoxColors_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Debug.WriteLine("Geselecteerde index=" + ComboBoxColors.SelectedIndex);
          //  Debug.WriteLine(((Color)ComboBoxColors.SelectedItem).ToString());
        }

        private void ButtonVorige_Click(object sender, RoutedEventArgs e)
        {
            //als SelectedIndex ==-1 dan is er geen item in de Combobox geselecteerd
           if (ComboBoxColors.SelectedIndex > 0)
            {
                ComboBoxColors.SelectedIndex--;
            }
        }

        private void ButtonVolgende_Click(object sender, RoutedEventArgs e)
        {
            if (ComboBoxColors.SelectedIndex > -1)
            {
                ComboBoxColors.SelectedIndex++;
            }
        }
    }
}
