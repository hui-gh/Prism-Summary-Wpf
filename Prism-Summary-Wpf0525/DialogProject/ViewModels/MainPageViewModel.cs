using Prism.Commands;
using Prism.Mvvm;
using Prism.Services.Dialogs;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DialogProject.ViewModels
{
    public class MainPageViewModel:BindableBase
    {
        private string _title;
        public string Title { get { return _title; } set { _title = value; RaisePropertyChanged(); } }

        private string btnText = "打开Dialog";
        public string BtnText { get { return btnText; } private set { btnText = value; RaisePropertyChanged(); } }

        public DelegateCommand OpenDialogCmd { get;private set; }

        private IDialogService _dialogService;

        public MainPageViewModel(IDialogService dialogService)
        {
            _dialogService = dialogService;
            OpenDialogCmd = new DelegateCommand(OpenDialogFun);
        }

        private void OpenDialogFun()
        {
            string message = "Dialog测试文本";
            DialogParameters dialogParameters = new DialogParameters();
            dialogParameters.Add("message", message);
            _dialogService.ShowDialog("NotificationDialog", dialogParameters,r =>
            {
                if(r.Result == ButtonResult.Yes)
                {
                    BtnText = "点击了窗口确认";
                }else if(r.Result == ButtonResult.No)
                {
                    BtnText = "点击了窗口取消";
                }
                else if(r.Result == ButtonResult.None)
                {
                    BtnText = "ButtonResult.None";
                }else {
                    BtnText = "未知的关闭方式";
                }

                Title = r.Parameters.GetValue<string>("checked");
            });
        }
    }
}
