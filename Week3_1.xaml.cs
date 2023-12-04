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
	public partial class Week3_1 : ContentPage
	{
		public Week3_1 ()
		{
			InitializeComponent ();

            oldSlider.ValueChanged += OldSlider_ValueChanged;
            carStepper.ValueChanged += CarStepper_ValueChanged;
            genderPicker.SelectedIndexChanged += GenderPicker_SelectedIndexChanged;
		}

        private void GenderPicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            hiShowLabel.Text = genderPicker.SelectedItem.ToString();
        }

        private void CarStepper_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            hiShowLabel.Text = e.NewValue.ToString();
        }

        private void OldSlider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
			hiShowLabel.Text = e.NewValue.ToString("N0"); // N0 ไม่เอาทศนิยม
        }
    }
}