using DiabetesAssistant.Models;
using DiabetesAssistant.Services;
using DiabetesAssistant.ViewModel;
using Xunit.Sdk;

namespace DiabetesAssistantUnitTest
{
    public class UnitTest1
    {
        [Fact]
        public async void GetLabelNutrientsAsyncException()
        {
            var food = new Food();
            var nfs = new NutritionFactsService();
            var vm = new MainViewModel(nfs);

            var labelNutrients = await nfs.GetNutritionFacts();

            var labelNutrientsException = new Exception();

            Assert.Same(labelNutrientsException, labelNutrients);


        }
    }
}