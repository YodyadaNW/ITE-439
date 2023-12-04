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
	public partial class EventPage1 : ContentPage
	{
		public EventPage1()
		{
			InitializeComponent();

			sendButton.Clicked += SendButton_Clicked;
            addEntry.TextChanged += AddEntry_TextChanged;
		}

        private void AddEntry_TextChanged(object sender, TextChangedEventArgs e)
        {
			showLabel.Text = "Address is " + addEntry.Text;
        }

        private void SendButton_Clicked(object sender, EventArgs e)
		{
			showLabel.Text = "Hi! " + fnameEntry.Text;
		}
	}
}