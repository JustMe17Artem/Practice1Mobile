using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FirstMobileApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Projects_Page : ContentPage
    {
        public Projects_Page()
        {
            InitializeComponent();
        }

        private async void ProjectOne_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new InfoProjectOne());
        }

        
    }
}