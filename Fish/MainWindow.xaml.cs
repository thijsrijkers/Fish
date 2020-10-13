using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.Win32;
using System;

namespace Fish
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        private void add_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.AddExtension = true;
            ofd.DefaultExt = "*.*";
            ofd.Filter = "Media(*.*)|*.*";
            ofd.ShowDialog();
            mediaElement1.MediaOpened += new RoutedEventHandler(mediaElement1_MediaOpened);
            mediaElement1.Source = new Uri(ofd.FileName);
        }

        void mediaElement1_MediaOpened(object sender, RoutedEventArgs e)
        {
            label1.Content = mediaElement1.Source.ToString();
        }

        private void play_Click(object sender, RoutedEventArgs e)
        {
            mediaElement1.Play();
        }

        private void pause_Click(object sender, RoutedEventArgs e)
        {
            mediaElement1.Pause();
        }

        private void stop_Click(object sender, RoutedEventArgs e)
        {
            mediaElement1.Stop();
        }
    }
}