using Prism.Commands;
using Prism.Mvvm;
using System.Windows;

namespace Prism_Summary_Wpf0523.ViewModels
{
    public class MainViewModel:BindableBase
    {
        
        public DelegateCommand MyCommnd { get; private set; }
        public MainViewModel()
        {
            MyCommnd = new DelegateCommand(Execute, CanExecute);
        }
        public bool CanExecute()
        {
            return true;
        }
        public void Execute()
        {
            MessageBox.Show("123");
        }
    }
}
