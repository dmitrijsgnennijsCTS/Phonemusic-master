using System;
using Xamarin.Forms;

namespace Phonemusic
{
    public partial class AddSong : ContentPage
    {
        System.Timers.Timer timer;
        public AddSong()
        {
            InitializeComponent();
        }

        void OnAdd(object sender, EventArgs e)
        {
            if (true)
            {
                songAdd.IsEnabled = true;
                songAdd.Text = "Added!";
            }
        }
    }
}