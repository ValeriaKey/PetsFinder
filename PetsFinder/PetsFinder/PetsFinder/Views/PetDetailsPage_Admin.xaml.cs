using PetsFinder.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PetsFinder.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PetDetailsPage_Admin : ContentPage
    {
        public PetDetailsPage_Admin()
        {
            InitializeComponent();
        }

        private void DeletePet(object sender, EventArgs e)
        {
            var pet = (Pet)BindingContext;
            App.Database.DeleteItem(pet.Id);
            this.Navigation.PopAsync();
        }

        private void SavePet(object sender, EventArgs e)
        {
            var pet = (Pet)BindingContext;
            if (!String.IsNullOrEmpty(pet.Name))
            {
                App.Database.SaveItem(pet);
            }
            this.Navigation.PopAsync();
        }
    }
}