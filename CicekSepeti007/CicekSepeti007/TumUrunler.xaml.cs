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
	public partial class TumUrunler : ContentPage
	{
		public TumUrunler ()
		{
			InitializeComponent ();
		}

      
        private void Menu(object sender, EventArgs e)
        {
            MainMenu menu = new MainMenu();
            this.Navigation.PushModalAsync(menu);
        }

        private void ClkOrkide(object sender, EventArgs e)
        {
            Urun1 urunA = new Urun1();
            this.Navigation.PushModalAsync(urunA);
        }


        private void ClkPapatya(object sender, EventArgs e)
        {
            Urun2 urunB = new Urun2();
            this.Navigation.PushModalAsync(urunB);
        }

        
    }
}