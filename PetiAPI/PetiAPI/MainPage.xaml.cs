using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PetiAPI
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        /*
        int count = 0;
        protected override void OnAppearing()
        {
            base.OnAppearing();

            btnSumar.Clicked += BtnSumar_Clicked;

        }

        private void BtnSumar_Clicked(object sender, EventArgs e)
        {
            count++;
            btnSumar.Text = count.ToString();
        }
        */
        /*
        private void BtnSave_Clicked(object sender, EventArgs e)
        {
            var nombre = boxName.Text;
            if (!string.IsNullOrEmpty(nombre))
            {
                //2DisplayAlert("Xamarin Forms", nombre, "Aceptar");


                var user = new UserModel { Name = nombre };
                this.Navigation.PushModalAsync(new UserPage(user));
            }
        }
        */
        private void BtnVerChocolates_Clicked(object sender, EventArgs e)
        {
            this.Navigation.PushModalAsync(new ChocolatesPage());
        }
        private void BtnVerGomitas_Clicked(object sender, EventArgs e)
        {
            this.Navigation.PushModalAsync(new GomitasPage());
        }
        private void BtnVerPaletas_Clicked(object sender, EventArgs e)
        {
            this.Navigation.PushModalAsync(new PaletasPage());
        }
        private void BtnVerSemillas_Clicked(object sender, EventArgs e)
        {
            this.Navigation.PushModalAsync(new SemillasPage());
        }
    }
}
