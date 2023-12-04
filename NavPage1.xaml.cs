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
	public partial class NavPage1 : ContentPage
	{
		public NavPage1 ()
		{
			InitializeComponent ();

            OpenPage2.Clicked += OpenPage2_Clicked;
            OpenPage3.Clicked += OpenPage3_Clicked;
            openTabPage.Clicked += OpenTabPage_Clicked;
		}

        async private void OpenTabPage_Clicked(object sender, EventArgs e)
        {
            //TabbedPage
            var tp = new TabbedPage();
            tp.Children.Add(new tabPage1());
            tp.Children.Add(new tabPage2());
            tp.Children.Add(new tabPage3());
            await Navigation.PushAsync(tp);
        }

        async private void OpenPage3_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavPage3());
            //เปลี่ยนไปหน้า 3 แต่ไม่มีลูกศรให้ย้อนกลับมาหน้า 1 ต้องเขียนโค้ดเพิ่มคือ Navigation.PopModalAsync();
        }

        async private void OpenPage2_Clicked(object sender, EventArgs e)
        {
			await Navigation.PushAsync(new NavPage2 ()); 
            //เปลี่ยนเป็นหน้า 2 แล้วหน้า 2 จะขึ้นลูกศรให้ย้อนกลับไปหน้า 1 ได้
        }
    }
}