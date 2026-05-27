using CommunityToolkit.Maui;
using MauiApp3.ViewModel;
using MauiApp3.Views;
using Microsoft.Extensions.Logging;
using Microsoft.Maui.Controls.Shapes;
using Plugin.Maui.BottomSheet.Hosting;

namespace MauiApp3
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .UseMauiCommunityToolkit(static options => options.SetPopupOptionsDefaults(DefaultPopupOptions))
                .UseBottomSheet(config =>
                {
                    config.CopyPagePropertiesToBottomSheet = true;
                })
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

            builder.Services.AddTransient<MainViewModel>();
            builder.Services.AddBottomSheet<TestBottomSheet, TestBottomSheetViewModel>(nameof(TestBottomSheet));

#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }

        private static DefaultPopupOptionsSettings DefaultPopupOptions => new()
        {
            Shadow = null,
            CanBeDismissedByTappingOutsideOfPopup = true,
            Shape = new RoundRectangle() { CornerRadius = 16, Stroke = Colors.Transparent }
        };
    }
}
