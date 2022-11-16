using SQLite;

namespace DiabetesAssistant.Models
{
    [Table("foodTable")]
    public class FoodTable
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        [MaxLength(250), Unique]
        public string Name { get; set; }

    }
}
