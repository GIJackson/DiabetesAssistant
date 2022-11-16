using Newtonsoft.Json;
using System.Text.Json;

namespace DiabetesAssistant.Models;

// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
public class Calories
{
    public int value { get; set; }
}

public class Carbohydrates
{
    public double value { get; set; }
}

public class Fat
{
    public double value { get; set; }
}

public class FoodAttribute
{
    public int id { get; set; }
    public int value { get; set; }
    public string name { get; set; }
}

public class FoodNutrient
{
    public string type { get; set; }
    public Nutrient nutrient { get; set; }
    public FoodNutrientDerivation foodNutrientDerivation { get; set; }
    public int id { get; set; }
    public double amount { get; set; }
}

public class FoodNutrientDerivation
{
    public int id { get; set; }
    public string code { get; set; }
    public string description { get; set; }
}

public class FoodUpdateLog
{
    public string discontinuedDate { get; set; }
    public List<object> foodAttributes { get; set; }
    public int fdcId { get; set; }
    public string description { get; set; }
    public string publicationDate { get; set; }
    public string dataType { get; set; }
    public string foodClass { get; set; }
    public string modifiedDate { get; set; }
    public string availableDate { get; set; }
    public string brandOwner { get; set; }
    public string brandName { get; set; }
    public string dataSource { get; set; }
    public string brandedFoodCategory { get; set; }
    public string gtinUpc { get; set; }
    public string ingredients { get; set; }
    public string marketCountry { get; set; }
    public double servingSize { get; set; }
    public string servingSizeUnit { get; set; }
    public string packageWeight { get; set; }
    public string notaSignificantSourceOf { get; set; }
    public string subbrandName { get; set; }
    public string householdServingFullText { get; set; }
}

public class LabelNutrients
{
    public Fat fat { get; set; }
    public Sodium sodium { get; set; }
    public Carbohydrates carbohydrates { get; set; }
    public Sugars sugars { get; set; }
    public Protein protein { get; set; }
    public Calories calories { get; set; }
}

public class Nutrient
{
    public int id { get; set; }
    public string number { get; set; }
    public string name { get; set; }
    public int rank { get; set; }
    public string unitName { get; set; }
}

public class Protein
{
    public double value { get; set; }
}

public class Food
{
    public string discontinuedDate { get; set; }
    public List<object> foodComponents { get; set; }
    public List<FoodAttribute> foodAttributes { get; set; }
    public List<object> foodPortions { get; set; }
    public int fdcId { get; set; }
    public string description { get; set; }
    public string publicationDate { get; set; }
    public List<FoodNutrient> foodNutrients { get; set; }
    public string dataType { get; set; }
    public string foodClass { get; set; }
    public string modifiedDate { get; set; }
    public string availableDate { get; set; }
    public string brandOwner { get; set; }
    public string brandName { get; set; }
    public string dataSource { get; set; }
    public string brandedFoodCategory { get; set; }
    public string gtinUpc { get; set; }
    public string ingredients { get; set; }
    public string marketCountry { get; set; }
    public double servingSize { get; set; }
    public string servingSizeUnit { get; set; }
    public string packageWeight { get; set; }
    public string notaSignificantSourceOf { get; set; }
    public List<FoodUpdateLog> foodUpdateLog { get; set; }
    public LabelNutrients labelNutrients { get; set; }
}

public class Sodium
{
    public double value { get; set; }
}

public class Sugars
{
    public double value { get; set; }
}




