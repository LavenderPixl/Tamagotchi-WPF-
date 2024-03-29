﻿using System;
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

namespace Tamagotchi_WPF
{
    /// <summary>
    /// Interaction logic for QuitWindow.xaml
    /// </summary>
    public partial class QuitWindow : Window
    {
        public Game GM { get; set; }
        public bool CloseProgram;
        public QuitWindow()
        {
            InitializeComponent();
        }

        private void btn_Save_Click(object sender, RoutedEventArgs e)
        {
            GM.Overlay.Visibility = Visibility.Collapsed;
            GM.Overlay.IsHitTestVisible = false;
            this.Close();
            GameState.Instance.QuitAfterSave = false;
            EventAggregator.Broadcast(typeof(DisplaySavesAfterQuitViewModel));

        }

        private void btn_SaveAndQuit_Click(object sender, RoutedEventArgs e)
        {
            GM.Overlay.Visibility = Visibility.Collapsed;
            GM.Overlay.IsHitTestVisible = false;
            this.Close();
            GameState.Instance.QuitAfterSave = true;
            EventAggregator.Broadcast(typeof(DisplaySavesAfterQuitViewModel));
        }

        private void btn_QuitGame_Click(object sender, RoutedEventArgs e)
        {
            GM.Overlay.Visibility = Visibility.Collapsed;
            GM.Overlay.IsHitTestVisible = false;
            this.Close();
            Application.Current.Shutdown();
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
