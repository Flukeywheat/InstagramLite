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
    public partial class UserProfile : ContentPage
    {
        private readonly User dummyUserData;
        private readonly HardCodedData users = new HardCodedData();

        public UserProfile()
        {
            InitializeComponent();

            dummyUserData = users.GetUser(1);
            BindingContext = dummyUserData;
        }
    }
}