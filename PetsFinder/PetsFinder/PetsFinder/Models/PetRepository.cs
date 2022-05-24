using SQLite;
using System.Collections.Generic;

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

        public IEnumerable<Pet> GetItems()
        {
            return database.Table<Pet>().ToList();
        }

        public Pet GetItem(int id)
        {
            return database.Get<Pet>(id);
        }

        public int DeleteItem(int id)
        {
            return database.Delete<Pet>(id);
        }
    }
}
