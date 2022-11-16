using DiabetesAssistant.Services;
using DiabetesAssistant.ViewModel;

namespace DiabetesAssistant;

public static class MauiProgram
{

    /*SOLID principle D: Dependency inversion, singleton use of classes*/

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


        string dbPath = FileAccessHelper.GetLocalFilePath("food.db3");
        builder.Services.AddSingleton<FoodRepository>(s => ActivatorUtilities.CreateInstance<FoodRepository>(s, dbPath));

        builder.Services.AddSingleton<NutritionFactsService>();

        builder.Services.AddSingleton<MainViewModel>();

        builder.Services.AddSingleton<MainPage>();

        return builder.Build();
	}
}
