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
	public partial class NavPage2 : ContentPage
	{
		public NavPage2 ()
		{
			InitializeComponent ();

            OpenPage3.Clicked += OpenPage3_Clicked;
            openTabPageWeek4.Clicked += OpenTabPageWeek4_Clicked;
		}

        async private void OpenTabPageWeek4_Clicked(object sender, EventArgs e)
        {
            //TabbedPage
            var tpWeek4 = new TabbedPage();
            tpWeek4.Children.Add(new Week4_A());
            tpWeek4.Children.Add(new Week4_B());
            tpWeek4.Children.Add(new Week4_C());
            tpWeek4.Children.Add(new Week4_Event());
            await Navigation.PushAsync(tpWeek4);
        }

        async private void OpenPage3_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavPage3());
        }
    }
}