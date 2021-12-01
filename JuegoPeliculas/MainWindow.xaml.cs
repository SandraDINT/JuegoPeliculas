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

namespace JuegoPeliculas
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        PeliculaMVVM vm = new PeliculaMVVM();
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = vm;
        }

        private void Image_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            vm.Avanzar();

        }

        private void imageAtras_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            vm.Retroceder();
        }
    }
}
