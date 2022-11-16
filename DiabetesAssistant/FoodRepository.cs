using SQLite;
using DiabetesAssistant.Models;

namespace DiabetesAssistant
{

    /*SOLID Principle S: Single-responsibility, FoodRepository and FoodTable are separated to ensure that should there be any changes to the class
     the methods within and properties within do not change. FoodTable holds the properties and FoodRepository holds the methods*/
    public class FoodRepository
    {
        string _dbPath;

        public string StatusMessage { get; set; }

        private SQLiteAsyncConnection conn;

        private async Task Init()
        {
            if (conn != null)
                return;

            conn = new SQLiteAsyncConnection(_dbPath);
            await conn.CreateTableAsync<FoodTable>();
        }

        public FoodRepository(string dbPath)
        {
            _dbPath = dbPath;
        }

        public async Task AddNewFood(string name)
        {
            int result = 0;
            try
            {
                await Init();


                if (string.IsNullOrEmpty(name))
                    throw new Exception("Valid name required");

                result = await conn.InsertAsync(new FoodTable { Name = name });

                StatusMessage = string.Format("{0} record(s) added (Name: {1})", result, name);
            }
            catch (Exception ex)
            {
                StatusMessage = string.Format("Failed to add {0}. Error: {1}", name, ex.Message);
            }

        }

        public async Task<List<FoodTable>> GetAllFood()
        {
            try
            {
                await Init();
                return await conn.Table<FoodTable>().ToListAsync();
            }
            catch (Exception ex)
            {
                StatusMessage = string.Format("Failed to retrieve data. {0}", ex.Message);
            }

            return new List<FoodTable>();
        }
    }
}
