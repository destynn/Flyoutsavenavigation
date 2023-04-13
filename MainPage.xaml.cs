using System.Windows.Input;

namespace Flyout;

public partial class MainPage : ContentPage
{
    public MainPage()
	{
		InitializeComponent();
		one.Text = Preferences.Get("One", "FIRST");
    }

        private void savebtnClicked(object sender, EventArgs e)
	{
        one.Text = j1.Text;

        Preferences.Set("One", one.Text);
    }
}

