using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace IT_2113110189
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProfilePage : ContentPage
    {
        public ProfilePage()
        {
            InitializeComponent();
            homeBT.Clicked += HomeBT_Clicked;
        }

        private void HomeBT_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new MainPage());
;
        }
    }
}