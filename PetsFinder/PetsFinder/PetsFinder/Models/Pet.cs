using SQLite;

namespace PetsFinder.Models
{
    [Table("Pets")]
    public class Pet
    {
        [PrimaryKey, AutoIncrement, Column("_id")]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string City { get; set; }
        public string Sex { get; set; }
        public string Image { get; set; }
    }
}
