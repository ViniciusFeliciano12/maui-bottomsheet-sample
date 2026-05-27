using CommunityToolkit.Mvvm.ComponentModel;

namespace MauiApp3.ViewModel
{
    public partial class TestBottomSheetViewModel : ObservableObject
    {
        [ObservableProperty]
        private string _radioValue = "";
    }
}
