using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace LearnModalNavigation
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            //  Use Control + Space (Mac) to auto complete the copde
            option_1_button.Clicked+=Option_1_Button_Clicked;
            option_2_button.Clicked+=Option_2_Button_Clicked;
        }

        async void Option_1_Button_Clicked(object sender, EventArgs e)
        {
            Modal1 modalPage = new Modal1(this);

            await this.Navigation.PushModalAsync(modalPage,true);
        }


        async void Option_2_Button_Clicked(object sender, EventArgs e)
        {
            Modal2 modalPage = new Modal2();

            Model.Contact c = new Model.Contact();
            c.Name = "Satinder Sidhu";
            c.Address = "New Jersey";
            c.Profession = "Failed Businessman";

            modalPage.BindingContext = c;

            await this.Navigation.PushModalAsync(modalPage, true);
        }



    }
}
