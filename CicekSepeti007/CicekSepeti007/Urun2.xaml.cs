using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CicekSepeti007
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Urun2 : ContentPage
	{
		public Urun2 ()
		{
			InitializeComponent ();
		}

        private void ImageButton_Clicked(object sender, EventArgs e)
        {
            MainMenu menu = new MainMenu();
            this.Navigation.PushModalAsync(menu);
        }
    }
}