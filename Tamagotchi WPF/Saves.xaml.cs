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
using Tamagotchi_WPF.Objects;

namespace Tamagotchi_WPF
{
    /// <summary>
    /// Interaction logic for Saves.xaml
    /// </summary>
    public partial class Saves : UserControl
    {
        public string? Navn { get; set; }

        public Saves()
        {
            InitializeComponent();
        }
        private void Window_Closed(object sender, EventArgs e)
        {
            Application.Current.Shutdown();
        }
        private void Button_1_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button b)
            {
                if (b.DataContext is Tama tama)
                {
                    //Tama tt = new Tama(tama.Name, tama.Level,);
                    Tama tt = tama;
                    EventAggregator.Broadcast(typeof(GameViewModel));
                    EventAggregator.CreateNewGame(tt);
                    GameState.PlayerTama = tt;
                }
            }
        }

        private void Btn_Home_Menu_Click(object sender, RoutedEventArgs e)
        {
            EventAggregator.Broadcast(typeof(MenuWindowViewModel));
        }


    }
}
