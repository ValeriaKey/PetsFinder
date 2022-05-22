using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace PetsFinder
{
    public class PetInfoViewModel
    {
        public ObservableCollection<PetInfo> ItemList { get; set; }

        public PetInfoViewModel()
        {
            ItemList = new ObservableCollection<PetInfo>();
            ItemList.Add(new PetInfo() { Id = 1, Name= "Omsen", City="London", Sex="Male", Image="dog.png" }) ;
            ItemList.Add(new PetInfo() { Id = 2, Name = "Aero", City = "Hamburg", Sex = "Male", Image = "dog.png" });
            ItemList.Add(new PetInfo() { Id = 3, Name = "Edward", City = "Paris", Sex = "Male", Image = "dog.png" });
            ItemList.Add(new PetInfo() { Id = 4, Name = "Xabina", City = "Tallinn", Sex = "Female", Image = "dog.png" });
            ItemList.Add(new PetInfo() { Id = 5, Name = "Haley", City = "Moscow", Sex = "Female", Image = "dog.png" });
            ItemList.Add(new PetInfo() { Id = 6, Name = "Lacy", City = "Rome", Sex = "Female", Image = "dog.png" });
        }

    }
}
