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

namespace kelompok_1
{
    /// <summary>
    /// Interaction logic for Audio.xaml
    /// </summary>
    public partial class Audio : Window
    {
        public Audio()
        {
            InitializeComponent();
        }

        private void Playbtn_Click(object sender, RoutedEventArgs e)
        {
            media.Play();
        }

        private void Pausebtn_Click(object sender, RoutedEventArgs e)
        {
            media.Pause();
        }

        private void realtime_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            media.Position = TimeSpan.FromSeconds(realtime.Value);
        }
    }
}
