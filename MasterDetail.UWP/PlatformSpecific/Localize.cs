using MasterDetail.Interfaces;
using MasterDetail.Localization;
using MasterDetail.UWP.PlatformSpecific;
using System.Globalization;
using Xamarin.Forms;

//Learn more at: https://developer.xamarin.com/guides/xamarin-forms/advanced/localization/
[assembly: Dependency(typeof(Localize))]
namespace MasterDetail.UWP.PlatformSpecific
{
    public class Localize : ILocalize
    {
        public CultureInfo GetCurrentCultureInfo()
        {
            return CultureInfo.CurrentUICulture;
        }
    }
}
