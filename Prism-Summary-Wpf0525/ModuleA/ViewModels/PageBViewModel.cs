using Prism.Mvvm;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ModuleA.ViewModels
{
    public class PageBViewModel : BindableBase, IConfirmNavigationRequest
    {
        private string? _title;
        public string Title
        {
            get { return _title; }
            private set { _title = value; RaisePropertyChanged(); }
        }
        public void ConfirmNavigationRequest(NavigationContext navigationContext, Action<bool> continuationCallback)
        {
            bool result = true;
            if(MessageBox.Show("是否继续","提示",MessageBoxButton.YesNo) == MessageBoxResult.No)
            {
                result = false;
            }
            continuationCallback(result);
        }

        public bool IsNavigationTarget(NavigationContext navigationContext)
        {
            return true;
        }

        public void OnNavigatedFrom(NavigationContext navigationContext)
        {
        }

        public void OnNavigatedTo(NavigationContext navigationContext)
        {
            string s = navigationContext.Parameters["Name"] as string;
            if (s != null)
            {
                Title = s;
            }
        }
    }
}
