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

        private void smsToOwner_Clicked(object sender, EventArgs e)
        {

            var sms = CrossMessaging.Current.SmsMessenger;
            if (sms.CanSendSms)
                sms.SendSms(tel_num.Text, "");
        }
    }
}