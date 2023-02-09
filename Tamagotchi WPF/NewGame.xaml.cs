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
        NewGameViewModel VM = new();
        int Counter = 0;


        public NewGame()
        {
            InitializeComponent();
            this.DataContext = VM;
        }

        private void btn_Next_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button b)
            {
                Counter++;
                Notification.Text = "Your Egg is starting to shake! Is it hatching?";
                if (Counter >= 2)
                {
                    Notification.Text = $"Congratulations, it's a {VM.dal.CreatureTypes[VM.tamaTypeRND]} creature!";
                    if (Counter >= 3)
                    {
                        Notification.Text = "Please name your Tama:";
                        Box_Naming.Visibility = Visibility.Visible;
                    }

                }
                if (Box_Naming.Text != "") //Checks if user has typed a name - If so; The name is sent to the Viewmodel, into tamaName. Then Displays Game (GAME STARTS)
                {
                    VM.yourTama.Name = Box_Naming.Text;
                    EventAggregator.Broadcast(typeof(GameViewModel));
                }
            }
        }

    }
}
