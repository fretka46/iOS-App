using Microsoft.Maui;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Graphics;

//
namespace First_iOSApp
{
    public partial class App : Application
    {
        public App()
        {
            MainPage = new ContentPage
            {
                Content = new StackLayout
                {
                    Children = { new Label { Text = "Hello World", HorizontalOptions = LayoutOptions.Center, VerticalOptions = LayoutOptions.Center } }
                }
            };
        }
    }
}