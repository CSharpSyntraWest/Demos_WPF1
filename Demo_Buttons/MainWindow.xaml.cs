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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Demo_Buttons
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void GewoneButton_Click(object sender, RoutedEventArgs e) //Event Handler = methode die wordt uitgevoerd bij Click event op Button GewoneButton
        {
           MessageBox.Show("Je hebt geklikt op de gewone button");
        }

        private void Checkbox_Click(object sender, RoutedEventArgs e)
        {
            CheckBox deCheckbox = (CheckBox)sender;
            
            Debug.WriteLine("Geklikt op checkbox control - Is aangevinkt?: {0}", deCheckbox.IsChecked);
            
        }

        private void RepeatButton_Click(object sender, RoutedEventArgs e)
        {
            Debug.WriteLine("Geklikt op Repeat button");
        }

        private void Checkbox_Checked(object sender, RoutedEventArgs e)
        {
            CheckBox deCheckbox = (CheckBox)sender;
            Debug.WriteLine("{0} is checked. Nu IsChecked={1}", deCheckbox.Name, deCheckbox.IsChecked);
        }

        private void Checkbox_Unchecked(object sender, RoutedEventArgs e)
        {
            CheckBox deCheckbox = (CheckBox)sender;
            Debug.WriteLine("{0} is unchecked. Nu IsChecked={1}", deCheckbox.Name, deCheckbox.IsChecked);
        }

        private void Checkbox_Indeterminate(object sender, RoutedEventArgs e)
        {
            CheckBox deCheckbox = (CheckBox)sender;
            Debug.WriteLine("{0} is in ongedefinieerde status. Nu IsChecked={1}", deCheckbox.Name, deCheckbox.IsChecked);
        }
    }
}
