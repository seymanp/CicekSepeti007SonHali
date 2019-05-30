using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CicekSepeti007
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();




        }



        private void Menu_Clicked(object sender, EventArgs e)
        {
            MainMenu menuuu = new MainMenu();
            this.Navigation.PushModalAsync(menuuu);

        }

        private void Cicekler_Clicked(object sender, EventArgs e)
        {

        }
    }
}
