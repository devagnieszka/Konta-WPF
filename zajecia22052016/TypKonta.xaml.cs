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

namespace zajecia22052016
{
    /// <summary>
    /// Interaction logic for TypKonta.xaml
    /// </summary>
    public partial class TypKonta : Window
    {
        public TypKonta()
        {
            InitializeComponent();
            Random rnd = new Random();
            int losuj = rnd.Next(111111, 999999);
            NumerTextBox.Text = losuj.ToString();
                
        }

        private void Dodajkontobutton_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
        }
    }
}
