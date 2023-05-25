using DryIoc;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ModulesAndRegion.ViewModels
{
    public class MainPageViewModel:BindableBase
    {
        private readonly IRegionManager _regionManager;

        public DelegateCommand<string> MyCommand { get;private set; }

        public MainPageViewModel(IRegionManager regionManager) {
            _regionManager = regionManager;
            MyCommand = new DelegateCommand<string>(execute);
        }

        private void execute(string ModuleName)
        {
            
            _regionManager.RequestNavigate("MyRegion", ModuleName);
        }
    }
}
