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

namespace Tamagotchi_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
        }


        private void btn_New_Game_Click(object sender, RoutedEventArgs e)
        {
            Game G = new Game();
            NewGame NG = new NewGame();
            G.Show();
            this.Close();
        }

        private void btn_Saves_Click(object sender, RoutedEventArgs e)
        {
            Saves S = new Saves();
            S.Show();
            this.Close();
        }

        private void btn_Help_Click(object sender, RoutedEventArgs e)
        {
            Help H = new Help();
            H.Show();
        }

        private void btn_Exit_Game_Click(object sender, RoutedEventArgs e)
        {

        }
        private void Window_Closed(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Hyperlink_RequestNavigate(object sender, RequestNavigateEventArgs e)
        {
            Process.Start(new ProcessStartInfo(e.Uri.AbsoluteUri) { UseShellExecute = true });
        }
    }
}
