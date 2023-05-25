using Prism.Mvvm;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Navigation;

namespace ModuleA.ViewModels
{
    public class PageAViewModel : BindableBase,INavigationAware, IJournalAware
    {
        private string? _title;
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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="navigationContext"></param>
        public void OnNavigatedTo(NavigationContext navigationContext)
        {
            string t = navigationContext.Parameters["Name"] as string;
            if (t != null) {
                Title = t;
            }
             
        }

        public bool PersistInHistory()
        {
            return false;//禁止导航返回
        }
    }
}
