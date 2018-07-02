using System;
using Xamarin.Forms;

namespace Phonemusic
{
    public partial class MyPage : ContentPage
    {
        public MyPage()
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
            else
            {
                songAdd.IsEnabled = false;
                songAdd.Text = "Call";
            }
        }
    }
}
