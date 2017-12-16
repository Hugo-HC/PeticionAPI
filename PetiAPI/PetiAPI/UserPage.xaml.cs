using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PetiAPI
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class UserPage : ContentPage
    {
        //public UserModel _user { get; set; }


        public UserPage(UserModel user)
        {
            InitializeComponent();
            //_user = user;
            BindingContext = user;
        }
    }
}