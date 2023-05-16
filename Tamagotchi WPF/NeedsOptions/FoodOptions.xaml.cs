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

namespace Tamagotchi_WPF.NeedsOptions
{
    /// <summary>
    /// Interaction logic for FoodOptions.xaml
    /// </summary>
    public partial class FoodOptions : Window
    {
        public Game GM { get; set; }
        readonly FoodOptionsViewModel VM = new();
        public FoodOptions()
        {
            InitializeComponent();
            this.DataContext = VM;
        }
        public void CloseWindow()
        {
            GM.Overlay.Visibility = Visibility.Collapsed;
            GM.Overlay.IsHitTestVisible = false;
            this.Close();
        }
        private void btn_EatFood_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button b)
            {
                if (b != null)
                {
                    Food o = (Food)b.DataContext;
                    if (o != null)
                    {
                        EventAggregator.UpdateTama(o.ExperiencePoints, "TamaXP");
                        EventAggregator.UpdateTama(o.FoodFillment, "TamaFood");
                        CloseWindow();
                    }
                }
            }
        }

        private void btn_Close_Click(object sender, RoutedEventArgs e)
        {
            CloseWindow();
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
