namespace DiabetesAssistant;

public partial class App : Application
{
	public static FoodRepository FoodRepo { get; private set; }

	public App(FoodRepository repo)
	{
		InitializeComponent();

		MainPage = new AppShell();

		FoodRepo = repo;
	}
}
