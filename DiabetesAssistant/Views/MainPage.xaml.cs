using DiabetesAssistant.ViewModel;
using System.Net.Http;
using System.Net.Http.Json;

namespace DiabetesAssistant;

public partial class MainPage : ContentPage
{
	
	public MainPage(MainViewModel mainViewModel)
	{
		InitializeComponent();
		BindingContext = mainViewModel;

    }
}

