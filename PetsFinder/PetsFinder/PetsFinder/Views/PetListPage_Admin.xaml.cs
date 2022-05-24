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
    public partial class PetListPage_Admin : ContentPage
    {
        public PetListPage_Admin()
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
            PetDetailsPage_Admin petPageAdmin = new PetDetailsPage_Admin();
            petPageAdmin.BindingContext = selectedPet;
            await Navigation.PushAsync(petPageAdmin);
        }
    }
}