﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace InstagramLite
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class People : ContentPage
    {
        public People()
        {
            InitializeComponent();

            PeopleList.ItemsSource = new List<Activity>
            {
                new Activity { UserId = 1, Description = "Your Facebook friend Jenny Dalby is on Instagram." },
                new Activity { UserId = 2, Description = "Jonv started following you" },
                new Activity { UserId = 3, Description = "RachelMartin liked your photo." },
                new Activity { UserId = 4, Description = "Your Facebook friend Nivan Jay is on Instagram." },
                new Activity { UserId = 5, Description = "SanazZ sent a photo posted by @brookeisep." },
                new Activity { UserId = 6, Description = "NextLab started following you." },
                new Activity { UserId = 7, Description = "Your Facebook friend Alex B is on Instagram." },
                new Activity { UserId = 8, Description = "Your Facebook friend Tara Chang is on Instagram." },
                new Activity { UserId = 9, Description = "Your Facebook friend Tom K is on Instagram." },
            };
        }

        async private void PeopleList_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if ( e.SelectedItem != null)
            {
                var activity = e.SelectedItem as Activity;               
                await Navigation.PushAsync( new PersonProfile(activity.UserId));
                PeopleList.SelectedItem = null;
            }
        }
    }
}