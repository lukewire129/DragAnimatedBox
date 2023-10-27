using SlideScrollBox.Example.ViewModels;
using System.Windows;

namespace SlideScrollBox.Example
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent ();

            this.DataContext = new MainViewModel ();
        }
    }
}
