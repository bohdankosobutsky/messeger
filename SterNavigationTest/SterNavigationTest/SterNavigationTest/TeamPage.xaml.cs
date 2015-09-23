using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace SterNavigationTest
{
    public partial class TeamPage
    {
        public TeamPage(HomePage mainPage)
        {
            InitializeComponent();
            Parent = mainPage;
        }

        public new HomePage Parent { get; set; }

       
    }
}
