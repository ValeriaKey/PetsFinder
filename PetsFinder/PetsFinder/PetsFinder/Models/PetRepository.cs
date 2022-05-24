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

        public int SaveItem(Pet item)
        {
            if (item.Id != 0)
            {
                database.Update(item);
                return item.Id;
            }
            else
            {
                return database.Insert(item);
            }
        }
    }
}
