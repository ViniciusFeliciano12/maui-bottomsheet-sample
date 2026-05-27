using MauiApp3.ViewModel;
using Plugin.Maui.BottomSheet;

namespace MauiApp3.Views;

public partial class TestBottomSheet : BottomSheet
{
	public TestBottomSheet(TestBottomSheetViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}