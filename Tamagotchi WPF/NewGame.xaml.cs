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
using System.Diagnostics;
using Tamagotchi_WPF.ViewModels;

namespace Tamagotchi_WPF
{
    /// <summary>
    /// Interaction logic for NewGame.xaml
    /// </summary>
    public partial class NewGame : UserControl
    {
        DAL dal;
        NewGameViewModel VM = new();
        public NewGame()
        {
            InitializeComponent();
            this.DataContext= VM;


        }

        private void Notification_PreviewKeyDown(object sender, KeyEventArgs e)
        {

        }

        private void btn_Next_Click(object sender, RoutedEventArgs e)
        {
            int Counter = 0;
            if (sender is Button b)
            {
                Counter++;
                Notification.Text = "Your Egg is starting to shake! Is it hatching?";
                if (Counter >= 2)
                {
                    Notification.Text = $"Congratulations, it's a ";

                }
            }
        }
    }
}
//