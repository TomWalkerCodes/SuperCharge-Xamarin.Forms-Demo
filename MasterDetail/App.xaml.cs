using MasterDetail.Helpers;
using MasterDetail.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]

namespace MasterDetail
{
    public partial class App : Application
	{

        public static int AnimationSpeed = 250;

        public App()
		{
			InitializeComponent();

			SetMainPage();
		}

		public static void SetMainPage()
		{
            if (!Settings.IsLoggedIn)
            {
                Current.MainPage = new NavigationPage(new LoginPage())
                {
                    BarBackgroundColor = (Color)Current.Resources["Primary"],
                    BarTextColor = Color.White
                };
            }
            else
            {
                GoToMainPage();
            }
		}

        public static void GoToMainPage()
        {

            Current.MainPage = new TabbedPage
            {
                Children = {
                            new NavigationPage(new ItemsPage())
                            {
                                Title = "Browse"
                            },
                            new NavigationPage(new AboutPage())
                            {
                                Title = "About"
                            },
                        }
            };
        }
	}
}
