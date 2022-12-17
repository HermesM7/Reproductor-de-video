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

namespace ReproductorVideo
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

        private void RadioButton_Trailer1_Checked(object sender, RoutedEventArgs e)
        {
            MediaElement_Reproductor.Source = new Uri(@"C:\2DAM - B\DIN\Layout\ReproductorVideo\ReproductorVideo\bin\Debug\trailer1.mp4");
            MediaElement_Reproductor.Play();
        }
    }
}
