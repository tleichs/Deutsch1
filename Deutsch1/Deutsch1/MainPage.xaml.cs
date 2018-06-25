using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;


namespace Deutsch1
{
	public partial class MainPage : ContentPage
	{

		public MainPage()
		{
			InitializeComponent();
            btnlogin.Clicked += Btnlogin_Clicked;
		}

        private async void Btnlogin_Clicked(object sender, EventArgs e)
        {
            
            var Pass = pass.Text;
            var Password = "1234";
            if (Pass == Password)
            {
               await Navigation.PushAsync(new Kapitel1());
            }
            else
            {
                await DisplayAlert("Falsch", "", "ok");

            }
        }
    }
}
