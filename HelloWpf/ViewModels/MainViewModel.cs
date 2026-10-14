using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using HelloWpf.Commands;

namespace HelloWpf.ViewModels;

public sealed class MainViewModel : INotifyPropertyChanged
{
    private string _name = string.Empty;
    private string _greeting = "你好，世界！";

    public MainViewModel()
    {
        GreetCommand = new RelayCommand(Greet);
    }

    public string Name
    {
        get => _name;
        set => SetProperty(ref _name, value);
    }

    public string Greeting
    {
        get => _greeting;
        private set => SetProperty(ref _greeting, value);
    }

    public ICommand GreetCommand { get; }

    public event PropertyChangedEventHandler? PropertyChanged;

    private void Greet()
    {
        var name = string.IsNullOrWhiteSpace(Name) ? "世界" : Name.Trim();
        Greeting = $"你好，{name}！";
    }

    private void SetProperty(ref string field, string value,
        [CallerMemberName] string? propertyName = null)
    {
        if (field == value)
        {
            return;
        }

        field = value;
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
