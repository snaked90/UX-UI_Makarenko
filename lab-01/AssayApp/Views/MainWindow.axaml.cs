using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;

namespace AssayApp.Views;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }

    // The only working button on this screen, as required for lab 1:
    // everything else here is a visual stub.
    private async void OnAboutClick(object? sender, RoutedEventArgs e)
    {
        var about = new AboutWindow();
        await about.ShowDialog(this);
    }
}
