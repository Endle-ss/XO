using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
namespace XO
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void PlayButton_Click(object sender, RoutedEventArgs e)
        {
            PlayField playField = new PlayField();
            playField.Show();
            this.Close(); 
        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}