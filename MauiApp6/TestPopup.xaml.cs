using CommunityToolkit.Maui.Views;

namespace MauiApp6;

public partial class TestPopup : Popup
{
	public TestPopup(PopupViewModel vm)
    {
        BindingContext = vm;
        InitializeComponent();
	}
}