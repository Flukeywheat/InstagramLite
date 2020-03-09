using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace InstagramLite
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PersonProfile : ContentPage
    {

        private HardCodedData users = new HardCodedData();

        public PersonProfile(int userID)
        {
            InitializeComponent();

            BindingContext = users.GetUser(userID);
        }
    }
}