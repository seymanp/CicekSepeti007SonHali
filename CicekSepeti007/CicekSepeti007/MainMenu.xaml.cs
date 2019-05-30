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
	public partial class MainMenu : ContentPage
	{
		public MainMenu ()
		{
			InitializeComponent();
		}

        private void Click_UyeGirisi(object sender, EventArgs e)
        {

        }

        private void MainMenuUyeGirisi(object sender, EventArgs e)
        {

        }

        private void Click_DogumGunu(object sender, EventArgs e)
        {
            DogumGunuMenu dgm = new DogumGunuMenu();
            this.Navigation.PushModalAsync(dgm);
        }

        private void TumUrunlerclk(object sender, EventArgs e)
        {
            TumUrunler tum = new TumUrunler();
            this.Navigation.PushModalAsync(tum);
        }
    }
}