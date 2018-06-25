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
    public partial class Kapitel1 : TabbedPage
    {
        public Kapitel1()
        {
            InitializeComponent();
            menuitem.Clicked += Menuitem_Clicked;
            
            

        }

        private async void Menuitem_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Exercises1());
        }

       
    }
}