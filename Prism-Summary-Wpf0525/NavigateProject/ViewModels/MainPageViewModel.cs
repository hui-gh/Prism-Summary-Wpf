using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;

namespace NavigateProject.ViewModels
{
    public class MainPageViewModel:BindableBase
    {
        private readonly IRegionManager _regionManager;
        public DelegateCommand<string> MyCom { get;private set; }

        public MainPageViewModel(IRegionManager regionManager) {
            _regionManager = regionManager;
            MyCom = new DelegateCommand<string>(execute);
        }

        private void execute(string path)
        {
            //测试一：向模块传递参数
            NavigationParameters navigationParameters = new NavigationParameters();
            navigationParameters.Add("Name", "主窗体传来的信息：MainInFo");
            _regionManager.Regions["MyRegion"].RequestNavigate(path,navigationParameters);
        }
    }
}
