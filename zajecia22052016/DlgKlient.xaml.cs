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
    /// Interaction logic for DlgKlient.xaml
    /// </summary>
    public partial class DlgKlient : Window
    {
        public DlgKlient()
        {
            InitializeComponent();
        }

        private void OKbutton_Click(object sender, RoutedEventArgs e)
        {
            if (textBoxNazwisko.Text=="")
            {
                MessageBox.Show("Wpisz nazwisko");
            }
            else
            {
                DialogResult = true;
            }
        
        }
    }
}
