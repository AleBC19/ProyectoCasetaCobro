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

namespace Proyecto_Residencias_Caseta.View
{
    /// <summary>
    /// Lógica de interacción para W_OficinaCaseta.xaml
    /// </summary>
    public partial class W_OficinaCaseta : Window
    {
        public W_OficinaCaseta()
        {
            InitializeComponent();
        }
        private void Window_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }
        private void btnOficinas_Click(object sender, RoutedEventArgs e)
        {
            Hide();
            W_Oficina nuevaVentana = new W_Oficina();
            nuevaVentana.Show();
        }

        private void btnCaseta_Click(object sender, RoutedEventArgs e)
        {
            Hide();
            W_Caseta nuevaVentana = new W_Caseta();
            nuevaVentana.Show();
        }
    }
}
