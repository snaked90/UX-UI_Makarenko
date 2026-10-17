using System;
using System.Threading.Tasks;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace AssayApp.Views;

public partial class SplashWindow : Window
{
    public SplashWindow()
    {
        InitializeComponent();
        Loaded += OnLoaded;
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }
    
    private async void OnLoaded(object? sender, EventArgs e)
    {
        await InitializeAppAsync();

        var main = new MainWindow();
        main.Show();
        Close();
    }

    private static Task InitializeAppAsync() => Task.Delay(2000);
}
