using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace LearnModalNavigation
{
    public partial class Modal2 : ContentPage
    {
        public Modal2()
        {
            InitializeComponent();
        }

        async void Handle_Clicked(object sender, System.EventArgs e)
        {
            await this.Navigation.PopModalAsync(true);
        }

    }
}
