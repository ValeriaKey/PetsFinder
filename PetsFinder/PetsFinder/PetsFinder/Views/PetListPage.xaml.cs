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
    public partial class PetListPage : ContentPage
    {
        public PetListPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            petsList.ItemsSource = App.Database.GetItems();
            base.OnAppearing();
        }
        private async void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Pet selectedPet = (Pet)e.SelectedItem;
            PetDetailsPage petPage = new PetDetailsPage();
            petPage.BindingContext = selectedPet;
            await Navigation.PushAsync(petPage);
        }

        private async void CreatePet(object sender, EventArgs e)
        {
            Pet pet = new Pet();
            PetAddPage petAddPage = new PetAddPage();
            petAddPage.BindingContext = pet;
            await Navigation.PushAsync(petAddPage);
        }
    }
}