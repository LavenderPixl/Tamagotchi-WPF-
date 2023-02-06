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
using Tamagotchi_WPF.ViewModels;

namespace Tamagotchi_WPF.NeedsOptions
{
    /// <summary>
    /// Interaction logic for CareOptions.xaml
    /// </summary>
    public partial class CareOptions : Window
    {
        public Game GM { get; set; }
        readonly CareOptionsViewModel VM = new();
        public CareOptions()
        {
            InitializeComponent();
            this.DataContext = VM;
        }

        private void btn_Option_1_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_Option_2_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_Option_3_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_Option_4_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_Option_5_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_Option_6_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_Close_Click(object sender, RoutedEventArgs e)
        {
            GM.Overlay.Visibility = Visibility.Collapsed;
            GM.Overlay.IsHitTestVisible = false;
            this.Close();
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }
    }
}
