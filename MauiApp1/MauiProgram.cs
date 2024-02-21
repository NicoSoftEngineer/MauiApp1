using System.Reflection;
using MauiApp1.ViewModels;
using MauiApp1.Views;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace MauiApp1
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

            var config = new ConfigurationBuilder()
                .Build();

            builder.Services.AddDbContext<AppDbContext>();

            var context = new AppDbContext();
            context.Database.EnsureCreated();
            context.Dispose();

            builder.Services.AddTransient<MainPage>();
            builder.Services.AddTransient<MainPageViewModel>();


            builder.Configuration.AddConfiguration(config);
#if DEBUG
            builder.Logging.AddDebug();
#endif
            return builder.Build();
        }
    }
}
