using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace MyFormsApp
{	
	public partial class UIXaml : ContentPage
	{	
		public UIXaml ()
		{
			InitializeComponent ();

			this.BindingContext = new ViewModel();
		}
	}
}