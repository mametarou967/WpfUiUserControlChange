using Prism.Regions;
using System.Windows;

namespace WpfCardReaderScreen.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow(IRegionManager regionManager)
        {
            InitializeComponent();
            // https://github.com/PrismLibrary/Prism/discussions/2586
            // this.ContentRendered += (s, e) => regionManager.RequestNavigate("ContentRegion", "ViewA");

        }
    }
}
