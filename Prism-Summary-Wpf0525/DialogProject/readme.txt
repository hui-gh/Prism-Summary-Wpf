1. Dialog使用步驟：
	1）主窗体构造方法添加形参：IDialogService dialogService。此参数将用于开启容器中的窗口
	2）新窗口的ViewModel中激活RequestClose事件，关闭窗口。可以传递ButtonResult，可以传递自定义的参数
2. 消息发布与发布步骤：
	1）继承PubSubEvent
	2）在ViewModel中通过IEventAggregator的方法进行发布或订阅

Tip:
	1）通过构造函数来注入，prim支持构造函数多参数注入
