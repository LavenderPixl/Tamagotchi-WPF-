using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Tamagotchi_WPF.NeedsOptions;
using Tamagotchi_WPF.ViewModels;

namespace Tamagotchi_WPF
{
    /// <summary>
    /// Interaction logic for Game.xaml
    /// </summary>
    public partial class Game : UserControl
    {
        private GameViewModel VM => DataContext as GameViewModel;
        public Game()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Opens Food options and starts a BackgroundWorker to change the FoodNeed ProgressBar.
        /// </summary>
        private void Btn_FoodDrinks_Click(object sender, RoutedEventArgs e)
        {
            FoodOptions FO = new FoodOptions();
            FO.GM = this;
            FO.Owner = Application.Current.MainWindow;
            Overlay.Visibility = Visibility.Visible;
            Overlay.IsHitTestVisible = true;
            FO.Show();
            BackgroundWorker worker = new BackgroundWorker();
            worker.WorkerReportsProgress = true;
            worker.DoWork += worker_DoWork;
            worker.ProgressChanged += worker_ProgressChanged;

            worker.RunWorkerAsync();
        }
        /// <summary>
        /// Opens Amusement options and starts a BackgroundWorker to change the AmusementNeed ProgressBar.
        /// </summary>
        private void Btn_Amusement_Click(object sender, RoutedEventArgs e)
        {
            AmusementOptions AO = new AmusementOptions();
            AO.GM = this;
            AO.Owner = Application.Current.MainWindow;
            Overlay.Visibility = Visibility.Visible;
            Overlay.IsHitTestVisible = true;
            AO.Show();
        }
        /// <summary>
        /// Opens Care options and starts a BackgroundWorker to change the CareNeed ProgressBar.
        /// </summary>
        private void Btn_Care_Click(object sender, RoutedEventArgs e)
        {
            CareOptions CO = new CareOptions();
            CO.GM = this;
            CO.Owner = Application.Current.MainWindow;
            Overlay.Visibility = Visibility.Visible;
            Overlay.IsHitTestVisible = true;
            CO.Show();
        }

        private void Btn_Menu_Click(object sender, RoutedEventArgs e)
        {
            QuitWindow QW = new QuitWindow();
            QW.GM = this;
            QW.Owner= Application.Current.MainWindow;
            Overlay.Visibility = Visibility.Visible;
            Overlay.IsHitTestVisible = true;
            QW.Show();
        }

        void worker_DoWork(object sender, DoWorkEventArgs e)
        {
            for (int i = 0; i < 100; i++)
            {
                (sender as BackgroundWorker).ReportProgress(i);
                Thread.Sleep(100);
            }
        }
        void worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            Bar_Food.Value = e.ProgressPercentage;
            GameState.Instance.PlayerTama.Hunger = e.ProgressPercentage;
        }
        private void Window_ContentRendered(object sender, EventArgs e)
        {
            BackgroundWorker worker = new BackgroundWorker();
            worker.WorkerReportsProgress = true;
            worker.DoWork += worker_DoWork;
            worker.ProgressChanged += worker_ProgressChanged;

            worker.RunWorkerAsync();
        }
    }
}
