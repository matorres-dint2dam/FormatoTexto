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

namespace FormatoTexto
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Caja_TextChanged(object sender, TextChangedEventArgs e)
        {
            resultado.Text=caja.Text;
        }

        private void Cursiva_Checked(object sender, RoutedEventArgs e)
        {
            resultado.FontStyle =FontStyles.Italic; 
        }

        private void Cursiva_Unchecked(object sender, RoutedEventArgs e)
        {
            resultado.FontStyle = FontStyles.Normal;
        }
        private void Negrita_Checked(object sender, RoutedEventArgs e)
        {
            resultado.FontWeight = FontWeights.Bold;
        }

        private void Negrita_Unchecked(object sender, RoutedEventArgs e)
        {
            resultado.FontWeight = FontWeights.Normal;
        }

        private void Azul_Checked(object sender, RoutedEventArgs e)
        {
            resultado.Foreground = Brushes.Blue;
        }

        private void Verde_Checked(object sender, RoutedEventArgs e)
        {
            resultado.Foreground = Brushes.Green;
        }
        private void Rojo_Checked(object sender, RoutedEventArgs e)
        {
            resultado.Foreground = Brushes.Red;
        }
    }
}
