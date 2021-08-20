using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;


namespace LogIn
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "Admin" && txtContraseña.Text == "123")
            {
                DisplayAlert("Saludos!", "Vienvenido: Admin", "Ok");
            }
            else
            {
                DisplayAlert("Alerta", "No pueden existir campos vacíos", "Ok");
            }
        }

        
    }

}
