using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppTravel
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void LoginButton_Clicked(object sender, System.EventArgs e)
        {
            bool isEmail = string.IsNullOrEmpty(email.Text);
            bool isPassword = string.IsNullOrEmpty(password.Text);

            if(isEmail || isPassword)
            {

            }
            else
            {
                
            }

            Navigation.PushAsync(new HomePage());
           

        }

    }
}
