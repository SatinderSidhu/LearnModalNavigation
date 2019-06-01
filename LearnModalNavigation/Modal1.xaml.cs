using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace LearnModalNavigation
{


    public partial class Modal1 : ContentPage
    {
        private Page _rootPage;

        public Modal1(Page rootPage)
        {
            _rootPage = rootPage;
            InitializeComponent();

            lblNavigationCount.Text = " Modal Page # " + _rootPage.Navigation.ModalStack.Count.ToString();

            pageNames.ItemsSource = _rootPage.Navigation.ModalStack;

        }

        async void Handle_Clicked(object sender, System.EventArgs e)
        {
            await this.Navigation.PopModalAsync(true);
        }


        async void Push_Clicked(object sender, EventArgs e)
        {
            Modal1 modalPage = new Modal1(_rootPage);
            modalPage.Title = "Page # " + _rootPage.Navigation.ModalStack.Count.ToString();

            await this.Navigation.PushModalAsync(modalPage, true);
        }
    }
}
