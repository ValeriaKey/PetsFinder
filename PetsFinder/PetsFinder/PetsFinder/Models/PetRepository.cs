using SQLite;

namespace PetsFinder.Models
{
    public class PetRepository
    {
        SQLiteConnection database;
        public PetRepository(string databasePath)
        {
            database = new SQLiteConnection(databasePath);
            database.CreateTable<Pet>();
        }
    }
}
