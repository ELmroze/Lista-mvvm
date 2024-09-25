using Lista.mvvm;
using Microsoft.Extensions.Logging;

namespace Lista
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

#if DEBUG
    		builder.Logging.AddDebug();
#endif
            //--start
            builder.Services.AddSingleton<MainPage>();
            builder.Services.AddSingleton<CheckListViewModel>();
            //--koniec
            //od starktu i końca macie coś co trzeba kożystać w Api
            //inaczej singielton jedno razowe wywołanie jest to poto by w pliku MainPage.xaml.cs
            //nie rozpisywać sie i zrobić to w taki sposób jaki zrobiliśmy
            return builder.Build();
        }
    }
}
