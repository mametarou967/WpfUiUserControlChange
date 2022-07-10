using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;

namespace WpfCardReaderScreen.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        public IRegionManager RegionManager { get; }
        public DelegateCommand<string> ShowViewCommand { get; }
        public DelegateCommand ContentRenderedCommand { get; }

        public MainWindowViewModel(IRegionManager regionManager)
        {
            this.RegionManager = regionManager;
            this.ShowViewCommand = new DelegateCommand<string>(this.ShowView);
            this.ContentRenderedCommand = new DelegateCommand(this.ContentRendered);
        }

        public void ShowView(string viewName)
        {
            this.RegionManager.RequestNavigate("ContentRegion", viewName);
        }

        public void ContentRendered()
        {
            this.RegionManager.RequestNavigate("ContentRegion", "ViewA");
        }
    }
}
