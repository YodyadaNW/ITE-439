using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace IT_2113110189
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //NavigationPage
            /*
            int x = 16;
            string y = "ya";
            var y = "ya"; เป็นการประกาศตัวแปรแบบรวม แล้วให้เรียนรู้เองว่าเป็นตัวอักษรหรือตัวเลข (ง่ายกว่าการประกาศตัวแปรแบบเฉพาะเจาะจง)
            */

            var page1 = new NavPage1();
            var np = new NavigationPage(page1);
            //สามารถรันไปหน้าอื่นๆที่เชื่อมต่อกันได้


            //TabbedPage
            var tp = new TabbedPage();
            tp.Children.Add(new tabPage1());
            tp.Children.Add(new tabPage2());
            tp.Children.Add(new tabPage3());


            MainPage = np;
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
