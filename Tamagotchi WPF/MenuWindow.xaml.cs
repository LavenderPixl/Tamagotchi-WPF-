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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Tamagotchi_WPF.ViewModels;

namespace Tamagotchi_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MenuWindow : UserControl
    {
        Game G = new Game();
        DAL dal;

        public MenuWindow()
        {
            InitializeComponent();
            dal = new DAL();
        }

        private void btn_New_Game_Click(object sender, RoutedEventArgs e)
        {
            EventAggregator.Broadcast(typeof(NewGameViewModel));
        }
        private void btn_Saves_Click(object sender, RoutedEventArgs e)
        {
            EventAggregator.Broadcast(typeof(SavesViewModel));
        }
        private void btn_Help_Click(object sender, RoutedEventArgs e)
        {
            EventAggregator.Broadcast(typeof(HelpViewModel));
        }
        private void btn_Exit_Game_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
        private void Window_Closed(object sender, EventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}