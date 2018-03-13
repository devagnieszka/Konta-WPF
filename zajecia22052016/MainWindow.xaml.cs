using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace zajecia22052016
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
           InitializeComponent();
           listaKont.ItemsSource = aktualny.Konta;
  
        }
       
         
       ObservableCollection<Klient> klienci = new ObservableCollection<Klient>();
       Klient aktualny= new Klient();
       Konto aktualne = new Konto();



        public void dodajKlientaButton_Click(object sender, RoutedEventArgs e)
        {
            DlgKlient dlg = new DlgKlient();
            if (true == dlg.ShowDialog())
            {


                Klient nowy = new Klient { Nazwisko = dlg.textBoxNazwisko.Text };
                klienci.Add(nowy);

                comboBoxKlient.Items.Add(nowy.Nazwisko);
                comboBoxKlient.SelectedIndex = klienci.Count - 1;
                comboBoxKlient.IsEnabled = true;
                buttonOKNoweKonto.IsEnabled = true;
              
            }
        }



        private void comboBoxKlient_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            string name = comboBoxKlient.SelectedValue.ToString();
            foreach (Klient kl in klienci)
            {
                if (kl.Nazwisko == name)
                {
                    aktualny = kl;
                }
            }


            listaKont.ItemsSource = aktualny.Konta;

        }

        private void buttonOK_Click(object sender, RoutedEventArgs e)   //dodawanie konta
        {


            TypKonta okno = new TypKonta();
            if (true == okno.ShowDialog())

            {
                if (okno.TypComboBox.SelectedIndex == 0)
                {

                    ROR nowe = new ROR { Numer = okno.NumerTextBox.Text, Saldo = 0, Typ = "ROR" };
                    aktualny.konta.Add(nowe);
                }

                if (okno.TypComboBox.SelectedIndex == 1)
                {
                    LOKATA nowe = new LOKATA { Numer = okno.NumerTextBox.Text, Saldo = 0, Typ = "Lokata" };
                    aktualny.konta.Add(nowe);
                }

                if (okno.TypComboBox.SelectedIndex == 2)
                {
                    KK nowe = new KK { Numer = okno.NumerTextBox.Text, Saldo = 0, Typ = "Karta kredytowa" };
                    aktualny.konta.Add(nowe);
                }
                usunKontoButton.IsEnabled = true;
                wplacButton.IsEnabled = true;
                wyplacButton.IsEnabled = true;
            }

        }


        private void usunKontoButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                aktualny.konta.RemoveAt(listaKont.SelectedIndex);
                listaKont.ItemsSource = aktualny.Konta;
            }
            catch
            {
                MessageBox.Show("Zaznacz konto do usunięcia");
            }

        }





        private void wplacButton_Click(object sender, RoutedEventArgs e)
        {


            aktualne = listaKont.SelectedItem as Konto;

            decimal ile;
            try
            {
                if (!decimal.TryParse(kwota.Text, out ile))
                {
                    MessageBox.Show("zła kwota");
                    kwota.SelectAll();
                    kwota.Focus();
                }
                else
                {
                    aktualne.Wplac(ile);
                    listaKont.ItemsSource = aktualny.Konta;
                    listaKont.Items.Refresh();
                }
            }
            catch 
            {
                MessageBox.Show("Zaznacz konto, do którego chcesz wpłacać");

            }
            
        }


        private void wyplacButton_Click(object sender, RoutedEventArgs e)
        {
            aktualne = listaKont.SelectedItem as Konto;
            decimal ile;


            try
            {
                if (!decimal.TryParse(kwota.Text, out ile))
                {
                    MessageBox.Show("zła kwota");
                    kwota.SelectAll();
                    kwota.Focus();
                }
                else
                {
                    aktualne.Wyplac(ile);
                    listaKont.ItemsSource = aktualny.Konta;
                    listaKont.Items.Refresh();
                }
            }
            catch 
            {
                MessageBox.Show("Zaznacz konto, z którego chcesz wypłacać");

            }

            

        }






    }
}




