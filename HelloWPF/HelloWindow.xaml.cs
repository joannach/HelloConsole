using System.Windows;
using HelloLib;

namespace HelloWPF
{
    /// <summary>
    /// Interaction logic for HelloWindow.xaml
    /// </summary>
    public partial class HelloWindow : Window
    {
        public HelloWindow(string text)
        {
            InitializeComponent();
            SetLabelContent(text);
        }

        private void SetLabelContent(string text)
        {
            label_username.Content = HelloMessage.SetHelloUsernameMessage(text);
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
