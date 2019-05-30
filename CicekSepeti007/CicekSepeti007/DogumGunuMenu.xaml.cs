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
    public partial class DogumGunuMenu : ContentPage
    {
        public DogumGunuMenu()
        {
            InitializeComponent();
        }

        private void MainMenu(object sender, EventArgs e)
        {
            MainMenu main = new MainMenu();
            this.Navigation.PushModalAsync(main);
        }

        private void TumUrunler(object sender, EventArgs e)
        {
            TumUrunler tum = new TumUrunler();
            this.Navigation.PushModalAsync(tum);
        }
    }
}