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
    public partial class PetAddPage : ContentPage
    {
        public PetAddPage()
        {
            InitializeComponent();
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