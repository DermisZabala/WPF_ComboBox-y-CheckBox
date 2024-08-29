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

namespace WPF_CHECKBOX_COMBOBOX_1
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            List<Ciudades> misCiudades = new List<Ciudades>();

            misCiudades.Add(new Ciudades { NombreCiudades = "Seleccione una ciudad" });
            misCiudades.Add(new Ciudades { NombreCiudades= "Santo Domingo"});
            misCiudades.Add(new Ciudades { NombreCiudades = "Santiago" });
            misCiudades.Add(new Ciudades { NombreCiudades = "San Cristobal" });
            misCiudades.Add(new Ciudades { NombreCiudades = "La Vega" });
            misCiudades.Add(new Ciudades { NombreCiudades = "Puerto Plata" });

            miCombo.ItemsSource = misCiudades;

        }

        private void miCombo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (miCombo.SelectedIndex == 0)
            {
                miCombo.Background = Brushes.Black;

                // No seleccionar nada                
                miCombo.SelectedIndex = -1;
            }

        }

        private void miCheck_Checked(object sender, RoutedEventArgs e)
        {
            SantoDomingo.IsChecked = true;
            SanCristobal.IsChecked = true;
            SanPedro.IsChecked = true;
            SanJuan.IsChecked = true;
            Peravia.IsChecked = true;
        }

        private void miCheck_Unchecked(object sender, RoutedEventArgs e)
        {

            SantoDomingo.IsChecked = false;
            SanCristobal.IsChecked = false;
            SanPedro.IsChecked = false;
            SanJuan.IsChecked = false;
            Peravia.IsChecked = false;
        }
        private void CheckedIndividual_Unchecked(object sender, RoutedEventArgs e)
        {
            if(SantoDomingo.IsChecked == false &&
            SanCristobal.IsChecked == false &&
            SanPedro.IsChecked == false &&
            SanJuan.IsChecked == false &&
            Peravia.IsChecked == false)
            {
                miCheck.IsChecked = false;
            }
            else
            {
                miCheck.IsChecked = null;
            }
        }

        private void CheckedIndividual_checked(object sender, RoutedEventArgs e)
        {
            if (SantoDomingo.IsChecked == true &&
            SanCristobal.IsChecked == true &&
            SanPedro.IsChecked == true &&
            SanJuan.IsChecked == true &&
            Peravia.IsChecked == true)
            {
                miCheck.IsChecked = true;
            }
            else
            {
                miCheck.IsChecked = null;
            }
        }

    }
    class Ciudades
    {
        public string NombreCiudades
        {
            get;
            set;
        }
    }
}
