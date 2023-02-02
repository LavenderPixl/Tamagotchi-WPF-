using System;
using System.Collections.Generic;
using System.Diagnostics;
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
using Tamagotchi_WPF.ViewModels;

namespace Tamagotchi_WPF
{
    /// <summary>
    /// Interaction logic for Game.xaml
    /// </summary>
    public partial class Game : UserControl
    {
        public Game()   
        {
            InitializeComponent();
        }
        private void Window_Closed(object sender, EventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Btn_FoodDrinks_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Btn_Amusement_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Btn_Care_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Btn_Menu_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
