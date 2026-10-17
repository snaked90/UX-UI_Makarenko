using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using AssayApp.Views;

namespace AssayApp;

public partial class App : Application
{
    public override void Initialize()
    {
        AvaloniaXamlLoader.Load(this);
    }

    public override void OnFrameworkInitializationCompleted()
    {
        if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
        {
            // The app always starts on the splash screen; it hands off to the
            // main window itself once initialization finishes (see SplashWindow).
            desktop.MainWindow = new SplashWindow();
        }

        base.OnFrameworkInitializationCompleted();
    }
}
