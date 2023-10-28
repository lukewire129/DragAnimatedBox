using DragAnimatedBox.Example.ViewModels;
using System.Windows;

namespace DragAnimatedBox.Example2
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
