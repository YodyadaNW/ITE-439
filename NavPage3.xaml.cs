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
	public partial class NavPage3 : ContentPage
	{
		public NavPage3 ()
		{
			InitializeComponent ();

            closePage3.Clicked += ClosePage3_Clicked;
		}

        async private void ClosePage3_Clicked(object sender, EventArgs e)
        {
			await Navigation.PopModalAsync();
        }
    }
}