1. 模块传参步骤：
	1）通过RequestNavigate第二个参数进行传参
	2）继承INavigationAware，在实现的OnNavigatedTo方法捕获参数
2. 离开页面前的确认弹窗实现步骤：
	1）在ViewModel类中继承IConfirmNavigationRequest
	2）实现ConfirmNavigationRequest，在此方法中进行操作
3. 导航日志实现步骤：
	1）继承了INavigationAware接口的类都可以通过日志进行导航
	2）在方法OnNavigatedTo中通过navigationContext获得NavigationService
	3）利用NavigationService.Journal进行日志导航
注意：
	模块类的配置文件，可以在注册时，绑定指定的ViewModel，也可以通过prism的自动扫描功能自动绑定。
	但是通过测试，两者似乎不能兼容。同时出现的时候会导致无法通过日志返回