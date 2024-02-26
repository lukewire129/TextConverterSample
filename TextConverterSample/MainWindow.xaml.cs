using System.Windows;
using TextConverterSample.ViewModels;

namespace TextConverterSample
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