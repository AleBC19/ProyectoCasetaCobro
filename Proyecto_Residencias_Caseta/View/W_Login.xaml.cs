using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Proyecto_Residencias_Caseta.View
{
    /// <summary>
    /// Lógica de interacción para W_Login.xaml
    /// </summary>
    public partial class W_Login : Window
    {
        public W_Login()
        {
            InitializeComponent();
            this.MaxHeight = SystemParameters.MaximizedPrimaryScreenHeight;
        }
        private void Window_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }

        //boton de cambio de pestañas
        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            Hide();
            W_OficinaCaseta nuevaVentana = new W_OficinaCaseta();
            nuevaVentana.Show();
        }
    }
}
