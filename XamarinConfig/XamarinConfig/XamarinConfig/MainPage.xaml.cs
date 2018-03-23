using System;
using Xamarin.Forms;

namespace XamarinConfig
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
            lbl.Text = AppConfig.config;
		}
	}
}
