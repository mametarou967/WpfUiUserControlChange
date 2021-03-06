using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;
using System.Threading;

namespace WpfCardReaderScreen.ViewModels
{
    public class ViewAViewModel : BindableBase
    {
        public IRegionManager RegionManager { get; }
        public DelegateCommand ShiyouCommand { get; }

        public ViewAViewModel(IRegionManager regionManager)
        {
            this.RegionManager = regionManager;
            this.ShiyouCommand = new DelegateCommand(this.Shiyou);
        }

        public void Shiyou()
        {
            this.RegionManager.RequestNavigate("ContentRegion", "ViewSerialCom");
        }

        public void Task1()
        {
            Thread.Sleep(1000);
        }
    }
}
