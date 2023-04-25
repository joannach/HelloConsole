using System;
using System.Windows;

namespace HelloWPF
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

        private void button_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new HelloWindow(textBox_username.Text);
            dialog.ShowDialog();
        }

        private void button_close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
