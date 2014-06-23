using System;
using Xamarin.Forms;

namespace FormsExample
{
	public class App
	{
		public static Page GetMainPage ()
		{	

			var stacker = new StackLayout ();
			Label hiLabel = new Label ();
			hiLabel.Text = "Hail Satan";
			stacker.Children.Add (hiLabel);
			Entry textBox = new Entry ();
			textBox.Text = "stuff";
			stacker.Children.Add (textBox);
						Button btnHi = new Button();
			btnHi.Text = "Click Me";
			btnHi.Clicked += (object sender, EventArgs e) => {

				hiLabel.Text  = "Event Fired for button press, " + textBox.Text;

			};
			stacker.Children.Add(btnHi);
			return new NavigationPage( new ContentPage { 
				Content = stacker
			});
		}

	}
}

