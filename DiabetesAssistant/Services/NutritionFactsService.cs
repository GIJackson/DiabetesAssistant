using DiabetesAssistant.Models;
using DiabetesAssistant.ViewModel;
using System.Net.Http.Json;
using System.Text.Json;

namespace DiabetesAssistant.Services;

public class NutritionFactsService
{
    HttpClient httpClient;
    public NutritionFactsService()
    {
        httpClient = new HttpClient();
    }

    Food nutritionFacts = new();

    
    public async Task<Food> GetNutritionFacts()
    {
        var url = $"https://api.nal.usda.gov/fdc/v1/food/2117388?format=full&nutrients=203&nutrients=204&nutrients=205&api_key=0SKq6od1TOB7myfx2Yn86Rhd01NaGceadw0e20zG";
        
        var response = await httpClient.GetAsync(url);

        if (response.IsSuccessStatusCode)
        {
            var nutritionFactsObject = await response.Content.ReadFromJsonAsync<Food>();
            nutritionFacts = nutritionFactsObject;
        }

        return nutritionFacts;
    }
}
