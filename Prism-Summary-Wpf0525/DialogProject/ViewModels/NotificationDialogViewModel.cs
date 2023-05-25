using DialogProject.Events;
using Prism.Commands;
using Prism.Events;
using Prism.Mvvm;
using Prism.Services.Dialogs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Ink;

namespace DialogProject.ViewModels
{
    public class NotificationDialogViewModel : BindableBase, IDialogAware
    {
        public string message;
        public string Message { get { return message; } private set { message = value; RaisePropertyChanged(); } }

        public DelegateCommand<string> CloseBtnCmd { get; private set; }

        public NotificationDialogViewModel(IEventAggregator eventAggregator) {
            eventAggregator.GetEvent<MessageEvent>().Subscribe(eventFun);
            CloseBtnCmd = new DelegateCommand<string>(CloseDialogFun);
            /*eventAggregator.GetEvent<MessageEvent>().Unsubscribe(eventFun);*/
        }

        private void eventFun(string obj)
        {
            MessageBox.Show($"接收到了: {obj}");
        }

        private void CloseDialogFun(string parameter)
        {
            ButtonResult buttonResult = ButtonResult.None;
            if(parameter.ToLower() == "true")
            {
                buttonResult = ButtonResult.Yes;
            }
            else if(parameter.ToLower() == "false")
            {
                buttonResult = ButtonResult.No;
            }
            DialogParameters dialogParameters = new DialogParameters();
            dialogParameters.Add("checked", buttonResult.ToString());
            RaiseRequestClose(new DialogResult(buttonResult, dialogParameters));
        }

        public string Title { get; set; }

        public event Action<IDialogResult> RequestClose;

        public virtual void RaiseRequestClose(IDialogResult result) {
            RequestClose?.Invoke(result);
        }

        public bool CanCloseDialog()
        {
            return true;
        }

        public void OnDialogClosed()
        {
        }

        public void OnDialogOpened(IDialogParameters parameters)
        {
            Message = parameters.GetValue<string>("message");
        }
    }
}
