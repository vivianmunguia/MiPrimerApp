﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MiPrimerApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MyContentPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
