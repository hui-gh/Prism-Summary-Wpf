using Prism.Mvvm;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleA.ViewModels
{
    public class PageAViewModel : BindableBase,INavigationAware
    {
        private string _title;
        public string Title { 
            get { return _title; }
            private set { _title = value; RaisePropertyChanged(); }
        }

        /// <summary>
        /// 是否重用实例
        /// </summary>
        /// <param name="navigationContext"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public bool IsNavigationTarget(NavigationContext navigationContext)
        {
            return true;
        }

        public void OnNavigatedFrom(NavigationContext navigationContext)
        {
        }

        public void OnNavigatedTo(NavigationContext navigationContext)
        {
            string t = navigationContext.Parameters["Name"] as string;
            if (t != null) {
                Title = t;
            }
             
        }
    }
}
