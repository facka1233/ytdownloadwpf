<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
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

namespace kelompok_1
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

        private void btnVideo_Click(object sender, RoutedEventArgs e)
        {
            Progress progress = new Progress();
            progress.Show();
            this.Hide();
        }

        private void btnAudio_Click(object sender, RoutedEventArgs e)
        {
            Progress progress = new Progress();
            progress.Show();
            this.Hide();
        }
    }
}
=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
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

namespace kelompok_1
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

        private void btnVideo_Click(object sender, RoutedEventArgs e)
        {
            Progress progress = new Progress();
            progress.Show();
            this.Hide();
        }

        private void btnAudio_Click(object sender, RoutedEventArgs e)
        {
            Progress progress = new Progress();
            progress.Show();
            this.Hide();
        }
    }
}
>>>>>>> 77791fd (Perubahan icon di player)
