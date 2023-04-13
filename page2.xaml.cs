using Microsoft.Maui.Controls;

namespace Flyout;

public partial class page2 : ContentPage
{
	public page2()
    {
        InitializeComponent();

        tone.Text = Preferences.Get("One", "FIRST");
    }
}