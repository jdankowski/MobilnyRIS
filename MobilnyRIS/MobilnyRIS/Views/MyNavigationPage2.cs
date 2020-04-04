using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace MobilnyRIS.Views
{
	public class MyNavigationPage2 : ContentPage
	{
		public MyNavigationPage2 ()
		{
            this.Title = "My navigation Page 2";

			Content = new StackLayout {
				Children = {
					new Label { Text = "My Navigation Page 2" }
				}
			};
		}
	}
}