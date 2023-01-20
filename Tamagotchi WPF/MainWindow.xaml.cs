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

namespace Tamagotchi_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        NewGame NG = new NewGame();
        Game G = new Game();
        Saves S = new Saves();

        public MainWindow()
        {
            InitializeComponent();
        }


        private void btn_New_Game_Click(object sender, RoutedEventArgs e)
        {
            S.Show();
            this.Close();
        }

        private void btn_Saves_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_Help_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_Exit_Game_Click(object sender, RoutedEventArgs e)
        {

        }
        private void Window_Closed(object sender, EventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
