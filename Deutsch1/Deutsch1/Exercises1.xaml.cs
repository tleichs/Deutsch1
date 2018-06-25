using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Deutsch1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Exercises1 : TabbedPage
    {
        

        public Exercises1 ()
        {
            InitializeComponent();
            btnoption1.Clicked += Btnoption1_Clicked;
            btnoption2.Clicked += Btnoption2_Clicked;
            btnoption3.Clicked += Btnoption3_Clicked;
            btnoption4.Clicked += Btnoption4_Clicked;

            var tapGestureRecognizer = new TapGestureRecognizer();
            tapGestureRecognizer.Tapped += (s, e) => {
                DisplayAlert("A Conversation can not begin with", "", "ok");
               
            };
            tran.GestureRecognizers.Add(tapGestureRecognizer);

            btnantwort.Clicked += Btnantort_Clicked;
        }

        private async void Btnantort_Clicked(object sender, EventArgs e)
        {
            var ex1 = new Switch();
            var ex2 = new Switch();

            if (ex1 & ex2 == true)
            {
                await DisplayAlert("Korrekt", "", "Nächste Übung");

            }
            else
            {
                await DisplayAlert("falsch", "", "Versuch noch Mal");
            }
        }

        private async void Btnoption4_Clicked(object sender, EventArgs e)
        {
           await DisplayAlert("Korrekt", "Gute Nacht ist zu schlafen", "Nächste Übung");
           
                stk.IsVisible = true;
           
           
        }

        private async void Btnoption3_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Falsch", "Versuch noch Mal", "Schließen");
        }

        private async void Btnoption2_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Falsch", "Versuch noch Mal", "Schließen");
        }

        private async void Btnoption1_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Falsch", "Versuch noch Mal", "Schließen");
        }
    }
}