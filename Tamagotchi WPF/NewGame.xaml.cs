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
        private NewGameViewModel VM => DataContext as NewGameViewModel;
        private int _counter = 0;

        public NewGame()
        {
            InitializeComponent();
        }

        private void btn_Next_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button)
            {
                _counter++;
                Notification.Text = VM.GetNotificationText(_counter);
                if (_counter >= 3)
                {
                    Box_Naming.Visibility = Visibility.Visible;
                    if (!string.IsNullOrEmpty(VM.TamaName)) //Checks if user has typed a name - If so; The name is sent to the ViewModel, into tamaName. Then Displays Game (GAME STARTS)
                    {
                        VM.StartGame();                        
                    }
                }                
            }
        }
    }
}
