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
    /// Interaction logic for DisplaySavesAfterQuit.xaml
    /// </summary>
    public partial class DisplaySavesAfterQuit : UserControl
    {
        public DisplaySavesAfterQuit()
        {
            InitializeComponent();
        }

        private void btn_SaveFile_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button b)
            {
                if (b.DataContext is Tama tama)
                {
                    FileHandling.SaveTama(tama);    
                }
                else
                {
                    throw new Exception("Button is not a Tama object");
                }
            }
        }

        private void btn_CreateNewSave_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
