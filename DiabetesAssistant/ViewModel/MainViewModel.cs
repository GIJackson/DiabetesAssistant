using System.Collections.ObjectModel;
using System.ComponentModel;
using DiabetesAssistant.Services;
using DiabetesAssistant.Models;
using CommunityToolkit.Mvvm.Input;
using System.Diagnostics;

namespace DiabetesAssistant.ViewModel
{
    public partial class MainViewModel : BaseViewModel
    {
        NutritionFactsService nutritionFactsService;

        public ObservableCollection<Food> Food { get; } = new();

        public ObservableCollection<FoodTable> FoodTable { get; } = new();

        public MainViewModel(NutritionFactsService nutritionFactsService)
        {
            this.nutritionFactsService = nutritionFactsService;
        }

        
        [RelayCommand]
        async Task GetLabelNutrientsAsync()
        {
            if (IsBusy)
                return;

            try
            {
                IsBusy = true;
                if (Food.Count != 0)
                {
                    Food.Clear();
                }
                Food labelNutrients = await nutritionFactsService.GetNutritionFacts();
                Food.Add(labelNutrients);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
                await Shell.Current.DisplayAlert("Error!", $"Unable to get nutrition facts: {ex.Message}", "OK");
            }
            finally
            {
                IsBusy = false;

            }
            
        }
    }
}
