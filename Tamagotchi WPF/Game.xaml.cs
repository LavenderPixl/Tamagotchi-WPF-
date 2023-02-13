using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
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
using Tamagotchi_WPF.NeedsOptions;
using Tamagotchi_WPF.ViewModels;

namespace Tamagotchi_WPF
{
    /// <summary>
    /// Interaction logic for Game.xaml
    /// </summary>
    public partial class Game : UserControl
    {
        private GameViewModel VM => DataContext as GameViewModel;
        public Game()
        {
            InitializeComponent();
        }
        private void Btn_FoodDrinks_Click(object sender, RoutedEventArgs e)
        {
            FoodOptions FO = new FoodOptions();
            FO.GM = this;
            FO.Owner = Application.Current.MainWindow;
            Overlay.Visibility = Visibility.Visible;
            Overlay.IsHitTestVisible = true;
            FO.Show();
        }

        private void Btn_Amusement_Click(object sender, RoutedEventArgs e)
        {
            AmusementOptions AO = new AmusementOptions();
            AO.GM = this;
            AO.Owner = Application.Current.MainWindow;
            Overlay.Visibility = Visibility.Visible;
            Overlay.IsHitTestVisible = true;
            AO.Show();
        }

        private void Btn_Care_Click(object sender, RoutedEventArgs e)
        {
            CareOptions CO = new CareOptions();
            CO.GM = this;
            CO.Owner = Application.Current.MainWindow;
            Overlay.Visibility = Visibility.Visible;
            Overlay.IsHitTestVisible = true;
            CO.Show();
        }

        private void Btn_Menu_Click(object sender, RoutedEventArgs e)
        {
            QuitWindow QW = new QuitWindow();
            QW.GM = this;
            QW.Owner= Application.Current.MainWindow;
            Overlay.Visibility = Visibility.Visible;
            Overlay.IsHitTestVisible = true;
            QW.Show();
        }
    }
}
