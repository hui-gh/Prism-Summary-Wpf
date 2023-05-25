1. Dialog使用步驟：
	1）主窗体构造方法添加形参：IDialogService dialogService。此参数将用于开启容器中的窗口
	2）新窗口的ViewModel中激活RequestClose事件，关闭窗口。可以传递ButtonResult，可以传递自定义的参数