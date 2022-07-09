using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;

namespace WpfCardReaderScreen.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        public IRegionManager RegionManager { get; }
        public DelegateCommand<string> ShowViewCommand { get; }

        public MainWindowViewModel(IRegionManager regionManager)
        {
            this.RegionManager = regionManager;
            this.ShowViewCommand = new DelegateCommand<string>(this.ShowView);
        }

        public void ShowView(string viewName)
        {
            this.RegionManager.RequestNavigate("ContentRegion", viewName);
        }
    }
}
