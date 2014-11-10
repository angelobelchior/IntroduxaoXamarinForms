using System;
using Xamarin.Forms;
using System.ComponentModel;

namespace MyFormsApp
{
	public class App
	{
		public static Page GetMainPage ()
		{
			/*var stacklayout = new StackLayout { Padding = 20, Spacing = 20} ;
			var user = new Entry { Placeholder = "User" };
			var search = new Button { Text = "Search" };
			var list = new ListView();

			stacklayout.Children.Add(user);
			stacklayout.Children.Add(search);
			stacklayout.Children.Add(list);

			search.Clicked += async (object sender, EventArgs e) => {
				var github = new Shared.GitHubApi();
				var items = await github.GetAsync(user.Text);
				list.ItemsSource = items;
			};

			return new ContentPage { 
				Content = stacklayout
			};*/

			return new UIXaml();
		}
	}
}