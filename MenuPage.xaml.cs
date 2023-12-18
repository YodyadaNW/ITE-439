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
    public partial class MenuPage : ContentPage
    {
        public MenuPage()
        {
            InitializeComponent();

            youtubeBT.Clicked += YoutubeBT_Clicked;
            homeBT.Clicked += HomeBT_Clicked;
            stackBT.Clicked += StackBT_Clicked;
            gridBT.Clicked += GridBT_Clicked;
            tabBT.Clicked += TabBT_Clicked;
            profileBT.Clicked += ProfileBT_Clicked;
        }

        private void ProfileBT_Clicked(object sender, EventArgs e)
        {
            var mp = Parent as FlyoutPage;
            mp.Detail = new NavigationPage(new ProfilePage());
            mp.IsPresented = false;
        }

        private void TabBT_Clicked(object sender, EventArgs e)
        {
            //TabbedPage
            var tp = new TabbedPage();
            tp.Children.Add(new tabPage1());
            tp.Children.Add(new tabPage2());
            tp.Children.Add(new tabPage3());

            var mp = Parent as FlyoutPage;
            mp.Detail = new NavigationPage(tp);
            mp.IsPresented = false;
        }

        private void GridBT_Clicked(object sender, EventArgs e)
        {
            var mp = Parent as FlyoutPage;
            mp.Detail = new NavigationPage(new Week4_B());
            mp.IsPresented = false;
        }

        private void StackBT_Clicked(object sender, EventArgs e)
        {
            var mp = Parent as FlyoutPage;
            mp.Detail = new NavigationPage(new Week3_1());
            mp.IsPresented = false;
        }

        private void HomeBT_Clicked(object sender, EventArgs e)
        {
            var mp = Parent as FlyoutPage;
            mp.Detail = new NavigationPage(new MainPage());
            mp.IsPresented = false;
        }

        private void YoutubeBT_Clicked(object sender, EventArgs e)
        {
            var mp = Parent as FlyoutPage;
            mp.Detail = new NavigationPage(new youtubePage());
            mp.IsPresented = false;
        }
    }
}