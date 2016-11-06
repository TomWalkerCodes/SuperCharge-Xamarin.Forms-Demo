using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MasterDetail.Views
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
            Initialize();
        }

        private async void Initialize()
        {
            await Task.Delay(300);
            await StackLayoutHeader.ScaleTo(1, (uint)App.AnimationSpeed, Easing.SinIn);
            await ButtonNowNow.ScaleTo(1, (uint)App.AnimationSpeed, Easing.SinIn);
            await ButtonSignIn.ScaleTo(1, (uint)App.AnimationSpeed, Easing.SinIn);

        }
    }
}
