using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Page
{
	public partial class LoginPage : ContentPage
	{
		public LoginPage()
		{
			InitializeComponent();
			LoginButton.Clicked += (sender, e) =>
			{
				var mp = new MasterDetailPage();
				mp.Master = new MenuPage();
				mp.Detail = new NavigationPage(new MainPage());
				App.Current.MainPage = mp;
				Navigation.PushModalAsync(mp);
			};

			SingUpButton.Clicked += (sender, e) =>
			{
				App.Current.MainPage = new SingUpPage();
			};
		}
	}
}
