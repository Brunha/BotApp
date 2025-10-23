using CommunityToolkit.Maui;
using CommunityToolkit.Maui.Core;
using DalluiApp.MVVM.ViewModels;
using DalluiApp.MVVM.Views;
using Microsoft.Extensions.Logging;
using PanCardView;
using Sharpnado.MaterialFrame;
using SkiaSharp.Views.Maui.Controls.Hosting;

namespace DalluiApp
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .UseCardsView()
                .UseMauiCommunityToolkit()
                .UseMauiCommunityToolkitCore()
                .UseSkiaSharp()
                .UseSharpnadoMaterialFrame(loggerEnable: false)
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                    fonts.AddFont("Nexa - ExtraLight.ttf", "NexaExtraLight");
                    fonts.AddFont("Nexa-Heavy.ttf", "NexaHeavy");
                });

#if DEBUG
            builder.Logging.AddDebug();

            builder.Services.AddTransient<ImageGeneratorView>(); // Make It Transient, since will always show the view from the scrath
            builder.Services.AddTransient<ImageGeneratorViewModel>(); // Make It Transient, since will always show the view from the scrath

            builder.Services.AddSingleton<DashboardViewPage>();
            builder.Services.AddSingleton<DashboardViewPageViewModel>();

            builder.Services.AddSingleton<GenerationOptionsView>();
            builder.Services.AddSingleton<GenerationOptionsViewModel>();
#endif

            return builder.Build();
        }
    }
}