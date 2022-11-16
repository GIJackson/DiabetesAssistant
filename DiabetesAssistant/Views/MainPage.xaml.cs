using DiabetesAssistant.Models;
using DiabetesAssistant.Services;
using DiabetesAssistant.ViewModel;
using System;
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

    private void SearchButton_Clicked(object sender, EventArgs e)
    {
        SearchButton.Text = "Search APPLES";
    }

    public async void OnNewButtonClicked(object sender, EventArgs args)
    {
        statusMessage.Text = "";

        await App.FoodRepo.AddNewFood(newFood.Text);
        statusMessage.Text = App.FoodRepo.StatusMessage;
    }

    public async void OnGetButtonClicked(object sender, EventArgs args)
    {
        statusMessage.Text = "";

        List<FoodTable> food = await App.FoodRepo.GetAllFood();
        foodList.ItemsSource = food;
    }
}

