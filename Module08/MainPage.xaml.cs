﻿namespace Module08
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private async void ClickedViewUser(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//UserPage");
        }
    }

}
