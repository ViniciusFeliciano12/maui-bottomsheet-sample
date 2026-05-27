using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MauiApp3.Views;
using Plugin.Maui.BottomSheet.Navigation;
using System.Xml.Linq;

namespace MauiApp3.ViewModel
{
    public partial class MainViewModel : ObservableObject
    {
        private readonly IBottomSheetNavigationService _bottomSheetService;

        [ObservableProperty]
        private string _radioValue = "";

        public MainViewModel(IBottomSheetNavigationService bottomSheet)
        {
            _bottomSheetService = bottomSheet;
        }

        [RelayCommand]
        async Task OpenBottomSheet()
        {
            await _bottomSheetService.NavigateToAsync(nameof(TestBottomSheet), null, null);
        }
    }
}
