using Plugin.Messaging;
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
    public partial class PetDetailsPage : ContentPage
    {
        public PetDetailsPage()
        {
            InitializeComponent();
        }

        private void callToOwner_Clicked(object sender, EventArgs e)
        {
            var phoneDialer = CrossMessaging.Current.PhoneDialer;
            if (phoneDialer.CanMakePhoneCall)
                phoneDialer.MakePhoneCall(tel_num.Text);
        }
    }
}