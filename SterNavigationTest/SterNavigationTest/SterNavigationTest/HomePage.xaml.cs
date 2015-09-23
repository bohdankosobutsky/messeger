using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace SterNavigationTest
{
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Navigation.PushAsync(new TeamPage(this));
        }
    }
}
