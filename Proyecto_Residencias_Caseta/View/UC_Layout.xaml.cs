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

namespace Proyecto_Residencias_Caseta.View
{
    /// <summary>
    /// Lógica de interacción para UC_Layout.xaml
    /// </summary>
    public partial class UC_Layout : UserControl
    {
        public UC_Layout()
        {
            InitializeComponent();
        }
        private void btnMinimize_Click(object sender, RoutedEventArgs e)
        {
            Window window = Window.GetWindow(this);
            window.WindowState = WindowState.Minimized;
        }
        private void btnMaximize_Click(object sender, RoutedEventArgs e)
        {
            Window window = Window.GetWindow(this);

            if (window.WindowState == WindowState.Normal)
            {
                window.WindowState = WindowState.Maximized;

            }
            else
            {
                window.WindowState = WindowState.Normal;
            }
        }
        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
