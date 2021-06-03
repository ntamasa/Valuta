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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Valuta
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

        private void eur_Click(object sender, RoutedEventArgs e)
        {
            
            label.Content = ft.Text;
            penznem.Content = "Euró";
            double euro = 345.78;
            double osszeg = 0;
            int szam = Convert.ToInt32(ft.Text);
            if (szam >= 1)
            {
                osszeg = (szam * euro);
            }
            label.Content = osszeg;
            lista.Items.Add(osszeg);
        }

        private void usd_Click(object sender, RoutedEventArgs e)
        {
            label.Content = ft.Text;
            penznem.Content = "USA dollár";
            double dollar = 284.47;
            double osszeg = 0;
            int szam = Convert.ToInt32(ft.Text);
            if (szam >= 1)
            {
                osszeg = (szam * dollar);
            }
            label.Content = osszeg;
            lista.Items.Add(osszeg);
        }

        private void chf_Click(object sender, RoutedEventArgs e)
        {
            label.Content = ft.Text;
            penznem.Content = "Svájci frank";
            double frank = 315.43;
            double osszeg = 0;
            int szam = Convert.ToInt32(ft.Text);
            if (szam >= 1)
            {
                osszeg = (szam * frank);
            }
            label.Content = osszeg;
            lista.Items.Add(osszeg);
        }

        private void gbp_Click(object sender, RoutedEventArgs e)
        {
            label.Content = ft.Text;
            penznem.Content = "Angol font";
            double font = 402.27;
            double osszeg = 0;
            int szam = Convert.ToInt32(ft.Text);
            if (szam >= 1)
            {
                osszeg = (szam * font);
            }
            label.Content = osszeg;
            lista.Items.Add(osszeg);
        }

        private void ron_Click(object sender, RoutedEventArgs e)
        {
            label.Content = ft.Text;
            penznem.Content = "Román lej";
            double lej = 70.25;
            double osszeg = 0;
            int szam = Convert.ToInt32(ft.Text);
            if (szam >= 1)
            {
                osszeg = (szam * lej);
            }
            label.Content = osszeg;
            lista.Items.Add(osszeg);
        }

        private void ft_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                int szam = Convert.ToInt32(ft.Text);
                if (szam >= 1)
                {
                    eur.IsEnabled = true;
                    usd.IsEnabled = true;
                    chf.IsEnabled = true;
                    gbp.IsEnabled = true;
                    ron.IsEnabled = true;
                }
                else
                {
                    eur.IsEnabled = false;
                    usd.IsEnabled = false;
                    chf.IsEnabled = false;
                    gbp.IsEnabled = false;
                    ron.IsEnabled = false;
                }
            }
            catch (Exception)
            {
                eur.IsEnabled = false;
                usd.IsEnabled = false;
                chf.IsEnabled = false;
                gbp.IsEnabled = false;
                ron.IsEnabled = false;
            }
        }

        private void reset_Click(object sender, RoutedEventArgs e)
        {
            penznem.Content = " ";
            lista.Items.Clear();
            ft.Text = " ";
            label.Content = " ";
        }
    }
}
