using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace Phonemusic
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        async void OnAddPage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AddSong());
        }
        async void OnTextPage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Creator());
        }
    }
}