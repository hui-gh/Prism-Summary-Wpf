1. 使用路径加载模块时，模块的界面应使用UserControl
2. 使用模块的步骤：
	1）在主窗体定义ContentControl，并给予区域名
	2）在App.xaml.cs中重写CreateModuleCatalog()
	3）在需要响应动作的位置通过RequestNavigate导航到新区域
	4）添加新项目：此项目输出为dll，并编写配置注册界面
	5）将新项目中的dll移动到第二步中指定的文件夹