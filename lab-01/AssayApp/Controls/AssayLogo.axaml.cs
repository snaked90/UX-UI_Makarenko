using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace AssayApp.Controls;

public partial class AssayLogo : UserControl
{
    public AssayLogo()
    {
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }
}
