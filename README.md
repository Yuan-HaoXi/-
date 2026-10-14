# C# + WPF + MVVM 问候程序

输入姓名后点击“打个招呼”（或按 Enter），界面会显示问候语。姓名为空时使用“世界”。

## 运行

需要 Windows 和 .NET 8 SDK。也可使用支持 .NET 8 的 Visual Studio 2022，安装“.NET 桌面开发”工作负载后打开 `HelloWpf/HelloWpf.csproj`。

```powershell
dotnet run --project HelloWpf/HelloWpf.csproj
```

## 结构

- `MainWindow.xaml`：View，通过绑定显示数据并调用命令。
- `ViewModels/MainViewModel.cs`：ViewModel，使用 `INotifyPropertyChanged` 通知界面更新。
- `Commands/RelayCommand.cs`：实现 `ICommand`，将按钮操作连接到 ViewModel。

这个简单示例不涉及独立的业务数据，因此无需额外的 Model 类。窗口的代码后台仅初始化界面。

## 构建

```powershell
dotnet build HelloWpf/HelloWpf.csproj --configuration Release
```

项目开启 `EnableWindowsTargeting`，允许在 Linux 上交叉编译；WPF 窗口的运行和交互验证仍需 Windows。
