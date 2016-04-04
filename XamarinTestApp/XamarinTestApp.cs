using System;

using Xamarin.Forms;

namespace XamarinTestApp
{
	public class App : Application
	{
		public App ()
		{
			int count = 0;

			Button btn = new Button ();
			btn.Text = "This is a button";

			Label label = new Label ();
			label.HorizontalTextAlignment = TextAlignment.Center;

			// The root page of your application
			MainPage = new ContentPage {
				Content = new StackLayout {
					VerticalOptions = LayoutOptions.StartAndExpand,
					Children = {
						new Label {
							HorizontalTextAlignment = TextAlignment.Center,
							Text = "Eamonn Xamarin Learning"
						},
						btn,
						label
					}
				}
			};
			btn.Clicked += (sender, e) => {
				count++;
				btn.Text = "You have clicked " + count.ToString()+" times";
				if (count == 5){
					label.Text += "Wow!";
				}
				if (count == 10){
					label.Text += " Keep it up!";
				}
				if (count == 15){
					label.Text += " You are doing great!";
				}
			};
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}

