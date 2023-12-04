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
	public partial class EventPage2 : ContentPage
	{
		public EventPage2 ()
		{
			InitializeComponent ();
            loginButton.Clicked += LoginButton_Clicked;
		}

        private void LoginButton_Clicked(object sender, EventArgs e)
        {
			showLabel.Text = "Hi! " + userEntry.Text + " " + passEntry.Text;
        }
    }
}