1. 构建prism项目的步骤：
	1）NuGet下载prism Unity
	2）修改App.xaml：标签；修改App.xaml.cs：继承PrismAppalication，重写方法
	3）创建Views、ViewModels文件夹（文件夹必须同名）
	4）创建视图：xxView，并在xxView.xaml中引用prism，设置自动扫描
	5）创建视图对应Model：xxViewModel
2. Delegate使用步骤：
	1）创建命令
	2）在页面中绑定命令
