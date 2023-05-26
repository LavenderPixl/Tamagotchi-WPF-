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
using Tamagotchi_WPF.Objects;
using Tamagotchi_WPF.ViewModels;

namespace Tamagotchi_WPF
{
    /// <summary>
    /// Interaction logic for SaveInformation.xaml
    /// </summary>
    public partial class SaveInformation : UserControl
    {
        public SaveInformation()
        {
            InitializeComponent();
        }
        private void Btn_GoBack_Click(object sender, RoutedEventArgs e)
        {
            EventAggregator.Broadcast(typeof(SavesViewModel));
        }
        private void Btn_Load_Save_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button b)
            {
                EventAggregator.Broadcast(typeof(GameViewModel));

            }
        }
    }
}
