using DragAnimatedBox.Example.ViewModels;
using System.Windows;

namespace DragAnimatedBox.Example
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
