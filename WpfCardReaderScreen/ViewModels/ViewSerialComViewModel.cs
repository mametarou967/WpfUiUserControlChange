using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;
using System.Threading;

namespace WpfCardReaderScreen.ViewModels
{
    public class ViewSerialComViewModel : BindableBase
    {
        public IRegionManager RegionManager { get; }
        public DelegateCommand ShiyouCommand { get; }

        public ViewSerialComViewModel(IRegionManager regionManager)
        {
            this.RegionManager = regionManager;
        }

        public void Task1()
        {
            Thread.Sleep(1000);
        }
    }
}
