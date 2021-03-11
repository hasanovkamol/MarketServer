using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MarketServer.Views
{
    /// <summary>
    /// Interaction logic for SystemServers.xaml
    /// </summary>
    public partial class SystemServers : Window
    {
        public SystemServers()
        {
            InitializeComponent();
        }

        private void Border_MouseUp(object sender, MouseButtonEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void Border_MouseUp_1(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {

        }
    }
}
